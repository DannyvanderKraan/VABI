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
    public class LegoSetsFixture
    {
        public string Id { get; private set; }
        public LegoSet ExpectedLegoSet { get; private set; }
        public LegoSet UpsertedLegoSet { get; private set; }
        public List<LegoBlockCollected> CollectedLegoBlocks { get; private set; }
        public List<LegoSet> ExpectedLegoSets { get; private set; }
        public List<LegoSet> ExpectedLegoSetsByLegoBlocksCollection { get; private set; }
        public ILegoSetsRepository LegoSetsRepository { get; private set; }
        public LegoSetsController LegoSetsController { get; private set; }

        public LegoSetsFixture()
        {
            Id = Guid.NewGuid().ToString();
            ExpectedLegoSet = new LegoSet()
            {
                Id = Id
            };
            UpsertedLegoSet = new LegoSet()
            {
                Id = Id
            };
            CollectedLegoBlocks = new List<LegoBlockCollected>()
            {
                new LegoBlockCollected()
                {
                    Id = Guid.NewGuid().ToString(),
                    Amount = 12
                }
            };
            ExpectedLegoSets = new List<LegoSet>()
            {
                new LegoSet()
                {
                    Id = Guid.NewGuid().ToString(),
                    LegoBlocks = new List<LegoBlockCollected>()
                    {
                        new LegoBlockCollected()
                        {
                            Id = CollectedLegoBlocks[0].Id,
                            Amount = 5
                        }
                    }
                },
                new LegoSet()
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
            ExpectedLegoSetsByLegoBlocksCollection = new List<LegoSet>()
            {
                new LegoSet()
                {
                    Id = ExpectedLegoSets[0].Id,
                    LegoBlocks = new List<LegoBlockCollected>()
                    {
                        new LegoBlockCollected()
                        {
                            Id = ExpectedLegoSets[0].LegoBlocks[0].Id,
                            Amount = ExpectedLegoSets[0].LegoBlocks[0].Amount
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
            LegoSetsRepository = new LegoSetsCosmosDbRepository(new DummyLegoSetsDocumentClient(Id, ExpectedLegoSets, ExpectedLegoSetsByLegoBlocksCollection) as IDocumentClient, fakeOptions);
            LegoSetsController = new LegoSetsController(LegoSetsRepository);
        }
    }
}
