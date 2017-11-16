using System;
using System.Collections.Generic;
using VABI.Models;
using VABI.Tests.Unit.Fixtures;
using Xunit;

namespace VABI.Tests.Unit
{
    public class LegoSetsTests: IClassFixture<LegoSetsFixture>
    {
        private LegoSetsFixture _fixture;

        public LegoSetsTests(LegoSetsFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void Get_GivenId_ResultExpectedLegoSet()
        {
            string givenId = _fixture.Id;
            LegoSet expectedLegoSet = _fixture.ExpectedLegoSet;

            var result = _fixture.LegoSetsController.Get(givenId);

            Assert.True(expectedLegoSet.Id == ((LegoSet)result.Result.Value).Id);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void GetAll_GivenNoCriteria_ResultExpectedAllLegoSets()
        {
            int expectedNumberOfDocuments = _fixture.ExpectedLegoSets.Count;

            var result = _fixture.LegoSetsController.Get();

            Assert.True(expectedNumberOfDocuments == ((List<LegoSet>)result.Result.Value).Count);
        }

        //ToDo Test afmaken (zie DummyLegoSetsDocumentClient.CreateDocumentQuery<T>).
        [Fact]
        [Trait("Category", "Unit")]
        public async void GetByLegoBlocksInCollection_GivenLegoBlocks_ResultExpectedLegoSets()
        {
            List<LegoSet> expectedLegoSets = _fixture.ExpectedLegoSetsByLegoBlocksCollection;

            var result = await _fixture.LegoSetsRepository.GetByLegoBlocksInCollection(_fixture.CollectedLegoBlocks);

            Assert.True(expectedLegoSets[0].Id == result[0].Id);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void Save_GivenLegoSet_ResultUpsertedLegoSet()
        {
            string upsertedLegoSetId = _fixture.Id;
            LegoSet upsertedLegoSet = _fixture.UpsertedLegoSet;

            var result = _fixture.LegoSetsRepository.Save(upsertedLegoSet);

            Assert.True(upsertedLegoSetId == result.Result.Id);
        }
    }
}
