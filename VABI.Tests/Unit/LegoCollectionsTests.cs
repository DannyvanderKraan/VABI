﻿using System;
using System.Collections.Generic;
using System.Text;
using VABI.Models;
using VABI.Tests.Unit.Fixtures;
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

            var result = _fixture.LegoCollectionsRepository.Get(givenId);

            Assert.True(expectedLegoCollection.Id == result.Result.Id);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void GetAll_GivenNoCriteria_ResultExpectedAllLegoCollections()
        {
            int expectedNumberOfDocuments = _fixture.ExpectedLegoCollections.Count;

            var result = _fixture.LegoCollectionsRepository.GetAll();

            Assert.True(expectedNumberOfDocuments == result.Result.Count);
        }

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
