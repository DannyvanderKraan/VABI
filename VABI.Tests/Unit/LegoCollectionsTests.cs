using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VABI.Models;
using VABI.Tests.Unit.Fixtures;
using VABI.Tests.Unit.Utils;
using Xunit;

namespace VABI.Tests.Unit
{
    public class LegoCollectionsTests : IClassFixture<LegoCollectionsFixture>
    {
        private LegoCollectionsFixture _fixture;

        public LegoCollectionsTests(LegoCollectionsFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void Get_GivenId_ResultExpectedLegoCollection()
        {
            string givenId = _fixture.Id;
            LegoCollection expectedLegoCollection = _fixture.ExpectedLegoCollection;

            var result = _fixture.LegoCollectionsController.Get(givenId);

            Assert.True(expectedLegoCollection.Id == ((LegoCollection)result.Result.Value).Id);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void GetAll_GivenNoCriteria_ResultExpectedAllLegoCollections()
        {
            int expectedNumberOfDocuments = _fixture.ExpectedLegoCollections.Count;

            var result = _fixture.LegoCollectionsController.Get();

            Assert.True(expectedNumberOfDocuments == ((List<LegoCollection>)result.Result.Value).Count);
        }

        //ToDo Test afmaken (zie DummyLegoCollectionsDocumentClient.CreateDocumentQuery<T>).
        //[Fact]
        //[Trait("Category", "Unit")]
        //public async void GetLegoBlocksInCollection_GivenId_ResultExpectedCollectedLegoBlocks()
        //{
        //    var givenId = _fixture.Id;
        //    var expectedCollectedLegoBlocks = _fixture.ExpectedLegoCollection.LegoBlocks;
        //    var result = await _fixture.LegoCollectionsRepository.GetLegoBlocksInCollection(givenId);
        //    Assert.Equal(expectedCollectedLegoBlocks, result, new LegoBlockCollectedEqualityComparer());
        //}

        [Fact]
        [Trait("Category", "Unit")]
        public void Save_GivenLegoCollection_ResultUpsertedLegoCollection()
        {
            string upsertedLegoCollectionId = _fixture.Id;
            LegoCollection upsertedLegoCollection = _fixture.UpsertedLegoCollection;

            var result = _fixture.LegoCollectionsRepository.Save(upsertedLegoCollection);

            Assert.True(upsertedLegoCollectionId == result.Result.Id);
        }
    }
}
