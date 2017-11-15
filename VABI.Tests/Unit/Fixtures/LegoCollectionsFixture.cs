using FakeItEasy;
using Microsoft.Azure.Documents;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using VABI.Configuration;
using VABI.Controllers;
using VABI.Models;
using VABI.Repository;
using VABI.Tests.Unit.Utils;

namespace VABI.Tests.Unit.Fixtures
{
    public class LegoCollectionsFixture
    {
        public string Id { get; private set; }
        public LegoCollection ExpectedLegoCollection { get; private set; }
        public LegoCollection UpsertedLegoCollection { get; private set; }
        public List<LegoCollection> ExpectedLegoCollections { get; private set; }
        public ILegoCollectionsRepository LegoCollectionsRepository { get; private set; }
        public LegoCollectionsController LegoCollectionsController { get; private set; }
        public LegoCollectionsFixture()
        {
            Id = Guid.NewGuid().ToString();
            ExpectedLegoCollection = new LegoCollection()
            {
                Id = Id
            };
            UpsertedLegoCollection = new LegoCollection()
            {
                Id = Id
            };

            ExpectedLegoCollections = new List<LegoCollection>()
            {
                new LegoCollection()
                {
                    Id = Guid.NewGuid().ToString(),
                    LegoBlocks = new List<LegoBlockCollected>()
                    {
                        new LegoBlockCollected()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Amount = 5
                        }
                    }
                },
                new LegoCollection()
                {
                    Id = Guid.NewGuid().ToString(),
                    LegoBlocks = new List<LegoBlockCollected>()
                    {
                        new LegoBlockCollected()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Amount = 1
                        }
                    }
                }
            };

            LegoCollectorCosmosDbSettings connectionStrings = new LegoCollectorCosmosDbSettings()
            {
                DatabaseName = "Test"
            };
            IOptions<LegoCollectorCosmosDbSettings> fakeOptions = A.Fake<IOptions<LegoCollectorCosmosDbSettings>>();
            A.CallTo(() => fakeOptions.Value).Returns(connectionStrings);
            LegoCollectionsRepository = new LegoCollectionsCosmosDbRepository(new DummyLegoCollectionsDocumentClient(Id, ExpectedLegoCollections) as IDocumentClient, fakeOptions);
            LegoCollectionsController = new LegoCollectionsController(LegoCollectionsRepository);
        }
    }
}
