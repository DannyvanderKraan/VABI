﻿using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Configuration;
using VABI.Repositories.DTOs;

namespace VABI.Repositories
{
    public class LegoCollectionsCosmosDbRepository : ILegoCollectionsRepository
    {
        private const string CollectionName = "LegoCollections";

        private IDocumentClient _client;
        private string _databaseName;

        public LegoCollectionsCosmosDbRepository(IDocumentClient client, IOptions<LegoCollectorCosmosDbSettings> optionsConnectionStrings)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (optionsConnectionStrings is null) throw new ArgumentNullException(nameof(optionsConnectionStrings));
            if (string.IsNullOrWhiteSpace(optionsConnectionStrings.Value.DatabaseName)) throw new ArgumentNullException(nameof(optionsConnectionStrings.Value.DatabaseName));
            _client = client;
            _databaseName = optionsConnectionStrings.Value.DatabaseName;
        }

        public async Task<LegoCollection> Get(string id)
        {
            LegoCollection LegoCollection = null;
            var response = await _client.ReadDocumentAsync(UriFactory.CreateDocumentUri(_databaseName, CollectionName, id));
            LegoCollection = (LegoCollection)(dynamic)response.Resource;
            return LegoCollection;
        }

        public async Task<List<LegoCollection>> GetAll()
        {
            List<LegoCollection> LegoCollections = null;
            var docs = await _client.ReadDocumentFeedAsync(UriFactory.CreateDocumentCollectionUri(_databaseName, CollectionName), new FeedOptions { MaxItemCount = 10 });
            LegoCollections = docs.AsEnumerable().Select(d => (LegoCollection)(dynamic)d).ToList();
            return LegoCollections;
        }

        public async Task<List<LegoBlockCollected>> GetLegoBlocksInCollection(string id)
        {
            FeedOptions queryOptions = new FeedOptions() { MaxItemCount = 10 };
            var query = "SELECT b.id, b.amount " +
                "FROM LegoCollections c " +
                "JOIN b IN c.legoBlocks " +
                "WHERE c.id = '" + id + "'";
            IQueryable<LegoBlockCollected> legoBlocksInCollectionQuery = _client.CreateDocumentQuery<LegoBlockCollected>(
                UriFactory.CreateDocumentCollectionUri(_databaseName, CollectionName),
                query,
                queryOptions);
            return legoBlocksInCollectionQuery.ToList();
        }

        public async Task<LegoCollection> Save(LegoCollection legoCollection)
        {
            LegoCollection newLegoCollection = null;
            var response = await _client.UpsertDocumentAsync(UriFactory.CreateDocumentCollectionUri(_databaseName, CollectionName), legoCollection);
            newLegoCollection = (LegoCollection)(dynamic)response.Resource;
            return newLegoCollection;
        }
    }
}
