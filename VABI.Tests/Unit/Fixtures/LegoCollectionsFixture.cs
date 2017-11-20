using FakeItEasy;
using Microsoft.Azure.Documents;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using VABI.Configuration;
using VABI.Controllers;
using VABI.Models.Utils;
using VABI.Repositories;
using VABI.Repositories.DTOs;
using VABI.Tests.Unit.Utils;

namespace VABI.Tests.Unit.Fixtures
{
    public class LegoCollectionsFixture
    {
        public string Id { get; private set; }
        public LegoCollection ExpectedLegoCollection { get; private set; }
        public LegoCollection UpsertedLegoCollection { get; private set; }
        public List<LegoCollection> ExpectedLegoCollections { get; private set; }
        public List<LegoSet> ExpectedLegoSets { get; private set; }
        public List<LegoSet> ExpectedLegoSetsByLegoBlocksCollection { get; private set; }
        public ILegoCollectionsRepository LegoCollectionsRepository { get; private set; }
        public LegoCollectionsController LegoCollectionsController { get; private set; }
        public IMapper<Models.LegoCollection, Repositories.DTOs.LegoCollection> LegoCollectionMapper { get; private set; }
        public IProvideLegoSets LegoSetsProvider { get; private set; }
        public IMapper<Models.LegoSet, Repositories.DTOs.LegoSet> LegoSetMapper { get; private set; }

        public LegoCollectionsFixture()
        {
            Id = Guid.NewGuid().ToString();
            GetExpectedLegoCollection();
            GetUpsertedLegoCollection();

            GetExpectedLegoCollections();
            GetExpectedLegoSets();
            GetExpectedLegoSetsByLegoBlocksCollection();
            GetLegoCollectionsRepository();
            GetLegoCollectionMapper();
            GetLegoSetMapper();

            LegoCollectionsController = new LegoCollectionsController(LegoCollectionsRepository, LegoCollectionMapper);

            GetLegoSetsProvider();

        }

        private void GetLegoSetMapper()
        {
            LegoBlockCollectedMapper legoBlockCollectedMapper = new LegoBlockCollectedMapper();
            LegoSetMapper = new LegoSetMapper(legoBlockCollectedMapper) as IMapper<Models.LegoSet, Repositories.DTOs.LegoSet>;
        }

        private void GetLegoCollectionMapper()
        {
            LegoBlockCollectedMapper legoBlockCollectedMapper = new LegoBlockCollectedMapper();
            LegoCollectionMapper = new LegoCollectionMapper(legoBlockCollectedMapper) as IMapper<Models.LegoCollection, Repositories.DTOs.LegoCollection>;
        }

        private void GetLegoSetsProvider()
        {
            LegoCollectorCosmosDbSettings connectionStrings = new LegoCollectorCosmosDbSettings()
            {
                DatabaseName = "Test"
            };
            IOptions<LegoCollectorCosmosDbSettings> fakeOptions = A.Fake<IOptions<LegoCollectorCosmosDbSettings>>();
            A.CallTo(() => fakeOptions.Value).Returns(connectionStrings);

            LegoSetsProvider = new LegoSetsCosmosDbRepository(new DummyLegoSetsDocumentClient(Id, ExpectedLegoSets, ExpectedLegoSetsByLegoBlocksCollection) as IDocumentClient, fakeOptions);
        }

        private void GetLegoCollectionsRepository()
        {
            LegoCollectorCosmosDbSettings connectionStrings = new LegoCollectorCosmosDbSettings()
            {
                DatabaseName = "Test"
            };
            IOptions<LegoCollectorCosmosDbSettings> fakeOptions = A.Fake<IOptions<LegoCollectorCosmosDbSettings>>();
            A.CallTo(() => fakeOptions.Value).Returns(connectionStrings);
            LegoCollectionsRepository = new LegoCollectionsCosmosDbRepository(new DummyLegoCollectionsDocumentClient(Id, ExpectedLegoCollections, ExpectedLegoCollection.LegoBlocks) as IDocumentClient, fakeOptions);
        }

        private void GetExpectedLegoSetsByLegoBlocksCollection()
        {
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
        }

        private void GetExpectedLegoSets()
        {
            ExpectedLegoSets = new List<LegoSet>()
            {
                new LegoSet()
                {
                    Id = Guid.NewGuid().ToString(),
                    LegoBlocks = new List<LegoBlockCollected>()
                    {
                        new LegoBlockCollected()
                        {
                            Id = ExpectedLegoCollections[0].LegoBlocks[0].Id,
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
        }

        private void GetExpectedLegoCollections()
        {
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
        }

        private void GetUpsertedLegoCollection()
        {
            UpsertedLegoCollection = new LegoCollection()
            {
                Id = Id
            };
        }

        private void GetExpectedLegoCollection()
        {
            ExpectedLegoCollection = new LegoCollection()
            {
                Id = Id
            };
        }
    }
}
