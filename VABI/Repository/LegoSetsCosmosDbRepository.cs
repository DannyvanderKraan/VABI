using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Configuration;
using VABI.Models;

namespace VABI.Repository
{
    public class LegoSetsCosmosDbRepository : ILegoSetsRepository
    {
        private const string CollectionName = "LegoSets";

        private IDocumentClient _client;
        private string _databaseName;

        public LegoSetsCosmosDbRepository(IDocumentClient client, IOptions<LegoCollectorCosmosDbSettings> optionsConnectionStrings)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (optionsConnectionStrings is null) throw new ArgumentNullException(nameof(optionsConnectionStrings));
            if (string.IsNullOrWhiteSpace(optionsConnectionStrings.Value.DatabaseName)) throw new ArgumentNullException(nameof(optionsConnectionStrings.Value.DatabaseName));
            _client = client;
            _databaseName = optionsConnectionStrings.Value.DatabaseName;
        }

        public async Task<LegoSet> Get(string id)
        {
            LegoSet legoSet = null;
            var response = await _client.ReadDocumentAsync(UriFactory.CreateDocumentUri(_databaseName, CollectionName, id));
            legoSet = (LegoSet)(dynamic)response.Resource;
            return legoSet;
        }

        public async Task<List<LegoSet>> GetAll()
        {
            List<LegoSet> legoSets = null;
            var docs = await _client.ReadDocumentFeedAsync(UriFactory.CreateDocumentCollectionUri(_databaseName, CollectionName), new FeedOptions { MaxItemCount = 10 });
            legoSets = docs.AsEnumerable().Select(d => (LegoSet)(dynamic)d).ToList();
            return legoSets;
        }

        public async Task<List<LegoSet>> GetByLegoBlocksInCollection(List<LegoBlockCollected> legoBlocksInCollection)
        {
            FeedOptions queryOptions = new FeedOptions() { MaxItemCount = 10 };
            var query = "SELECT * " +
                "FROM LegoSets c " +
                "WHERE udf.isLegoBlockInCollection(c.legoBlocks, " + JsonConvert.SerializeObject(legoBlocksInCollection) + ")";
            IQueryable<LegoSet> legoSetsByLegoBlocksQuery = _client.CreateDocumentQuery<LegoSet>(
                UriFactory.CreateDocumentCollectionUri(_databaseName, CollectionName),
                query,
                queryOptions);
            return legoSetsByLegoBlocksQuery.ToList();
        }

        public async Task<LegoSet> Save(LegoSet legoSet)
        {
            LegoSet newLegoSet = null;
            var response = await _client.UpsertDocumentAsync(UriFactory.CreateDocumentCollectionUri(_databaseName, CollectionName), legoSet);
            newLegoSet = (LegoSet)(dynamic)response.Resource;
            return newLegoSet;
        }
    }
}
