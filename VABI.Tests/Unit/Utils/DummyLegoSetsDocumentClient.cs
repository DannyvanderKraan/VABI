using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Documents.Client;
using System.IO;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using VABI.Repositories.DTOs;

namespace VABI.Tests.Unit.Utils
{
    public class DummyLegoSetsDocumentClient : IDocumentClient
    {
        private string _documentId;
        private List<LegoSet> _legoSets;
        private List<LegoSet> _expectedLegoSetsByLegoBlocksCollection;

        public DummyLegoSetsDocumentClient(string documentId, List<LegoSet> legoSets, List<LegoSet> expectedLegoSetsByLegoBlocksCollection)
        {
            _documentId = documentId;
            _legoSets = legoSets;
            _expectedLegoSetsByLegoBlocksCollection = expectedLegoSetsByLegoBlocksCollection;

        }
        public object Session { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Uri ServiceEndpoint => throw new NotImplementedException();

        public Uri WriteEndpoint => throw new NotImplementedException();

        public Uri ReadEndpoint => throw new NotImplementedException();

        public ConnectionPolicy ConnectionPolicy => throw new NotImplementedException();

        public SecureString AuthKey => throw new NotImplementedException();

        public ConsistencyLevel ConsistencyLevel => throw new NotImplementedException();

        public Task<ResourceResponse<Attachment>> CreateAttachmentAsync(string documentLink, object attachment, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> CreateAttachmentAsync(string documentLink, Stream mediaStream, MediaOptions options = null, RequestOptions requestOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> CreateAttachmentAsync(Uri documentUri, object attachment, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> CreateAttachmentAsync(Uri documentUri, Stream mediaStream, MediaOptions options = null, RequestOptions requestOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<T> CreateAttachmentQuery<T>(Uri documentUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> CreateAttachmentQuery<T>(Uri documentUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> CreateAttachmentQuery<T>(Uri documentUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Attachment> CreateAttachmentQuery(Uri documentUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateAttachmentQuery(Uri documentUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateAttachmentQuery(Uri documentUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<T> CreateAttachmentQuery<T>(string documentLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> CreateAttachmentQuery<T>(string documentLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> CreateAttachmentQuery<T>(string documentLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Attachment> CreateAttachmentQuery(string documentLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateAttachmentQuery(string documentLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateAttachmentQuery(string documentLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Conflict> CreateConflictQuery(Uri documentCollectionUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateConflictQuery(Uri documentCollectionUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateConflictQuery(Uri documentCollectionUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Conflict> CreateConflictQuery(string collectionLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateConflictQuery(string collectionLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateConflictQuery(string collectionLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Database>> CreateDatabaseAsync(Database database, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Database> CreateDatabaseQuery(FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDatabaseQuery(string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDatabaseQuery(SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> CreateDocumentAsync(string collectionLink, object document, RequestOptions options = null, bool disableAutomaticIdGeneration = false)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> CreateDocumentAsync(Uri documentCollectionUri, object document, RequestOptions options = null, bool disableAutomaticIdGeneration = false)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<DocumentCollection>> CreateDocumentCollectionAsync(string databaseLink, DocumentCollection documentCollection, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<DocumentCollection>> CreateDocumentCollectionAsync(Uri databaseUri, DocumentCollection documentCollection, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<DocumentCollection> CreateDocumentCollectionQuery(Uri databaseUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDocumentCollectionQuery(Uri databaseUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDocumentCollectionQuery(Uri databaseUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<DocumentCollection> CreateDocumentCollectionQuery(string databaseLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDocumentCollectionQuery(string databaseLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDocumentCollectionQuery(string databaseLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<T> CreateDocumentQuery<T>(Uri documentCollectionUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> CreateDocumentQuery<T>(Uri documentCollectionUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            List<T> legoSets = new List<T>();
            _expectedLegoSetsByLegoBlocksCollection.ForEach(s => legoSets.Add((dynamic)s));
            return legoSets.AsQueryable();
        }

        public IQueryable<T> CreateDocumentQuery<T>(Uri documentCollectionUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Document> CreateDocumentQuery(Uri documentCollectionUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDocumentQuery(Uri documentCollectionUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDocumentQuery(Uri documentCollectionUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<T> CreateDocumentQuery<T>(string collectionLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> CreateDocumentQuery<T>(string collectionLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> CreateDocumentQuery<T>(string collectionLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Document> CreateDocumentQuery(string collectionLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDocumentQuery(string collectionLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateDocumentQuery(string collectionLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Offer> CreateOfferQuery(FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateOfferQuery(string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateOfferQuery(SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> CreatePermissionAsync(string userLink, Permission permission, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> CreatePermissionAsync(Uri userUri, Permission permission, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Permission> CreatePermissionQuery(Uri userUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreatePermissionQuery(Uri userUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreatePermissionQuery(Uri userUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Permission> CreatePermissionQuery(string permissionsLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreatePermissionQuery(string permissionsLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreatePermissionQuery(string permissionsLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> CreateStoredProcedureAsync(string collectionLink, StoredProcedure storedProcedure, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> CreateStoredProcedureAsync(Uri documentCollectionUri, StoredProcedure storedProcedure, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<StoredProcedure> CreateStoredProcedureQuery(Uri documentCollectionUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateStoredProcedureQuery(Uri documentCollectionUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateStoredProcedureQuery(Uri documentCollectionUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<StoredProcedure> CreateStoredProcedureQuery(string collectionLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateStoredProcedureQuery(string collectionLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateStoredProcedureQuery(string collectionLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> CreateTriggerAsync(string collectionLink, Trigger trigger, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> CreateTriggerAsync(Uri documentCollectionUri, Trigger trigger, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Trigger> CreateTriggerQuery(Uri documentCollectionUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateTriggerQuery(Uri documentCollectionUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateTriggerQuery(Uri documentCollectionUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Trigger> CreateTriggerQuery(string collectionLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateTriggerQuery(string collectionLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateTriggerQuery(string collectionLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> CreateUserAsync(string databaseLink, User user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> CreateUserAsync(Uri databaseUri, User user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> CreateUserDefinedFunctionAsync(string collectionLink, UserDefinedFunction function, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> CreateUserDefinedFunctionAsync(Uri documentCollectionUri, UserDefinedFunction function, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<UserDefinedFunction> CreateUserDefinedFunctionQuery(Uri documentCollectionUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateUserDefinedFunctionQuery(Uri documentCollectionUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateUserDefinedFunctionQuery(Uri documentCollectionUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<UserDefinedFunction> CreateUserDefinedFunctionQuery(string collectionLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateUserDefinedFunctionQuery(string collectionLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateUserDefinedFunctionQuery(string collectionLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<User> CreateUserQuery(Uri documentCollectionUri, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateUserQuery(Uri documentCollectionUri, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateUserQuery(Uri documentCollectionUri, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<User> CreateUserQuery(string usersLink, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateUserQuery(string usersLink, string sqlExpression, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> CreateUserQuery(string usersLink, SqlQuerySpec querySpec, FeedOptions feedOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> DeleteAttachmentAsync(string attachmentLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> DeleteAttachmentAsync(Uri attachmentUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Conflict>> DeleteConflictAsync(string conflictLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Conflict>> DeleteConflictAsync(Uri conflictUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Database>> DeleteDatabaseAsync(string databaseLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Database>> DeleteDatabaseAsync(Uri databaseUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> DeleteDocumentAsync(string documentLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> DeleteDocumentAsync(Uri documentUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<DocumentCollection>> DeleteDocumentCollectionAsync(string documentCollectionLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<DocumentCollection>> DeleteDocumentCollectionAsync(Uri documentCollectionUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> DeletePermissionAsync(string permissionLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> DeletePermissionAsync(Uri permissionUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> DeleteStoredProcedureAsync(string storedProcedureLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> DeleteStoredProcedureAsync(Uri storedProcedureUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> DeleteTriggerAsync(string triggerLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> DeleteTriggerAsync(Uri triggerUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> DeleteUserAsync(string userLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> DeleteUserAsync(Uri userUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> DeleteUserDefinedFunctionAsync(string functionLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> DeleteUserDefinedFunctionAsync(Uri functionUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<StoredProcedureResponse<TValue>> ExecuteStoredProcedureAsync<TValue>(string storedProcedureLink, params dynamic[] procedureParams)
        {
            throw new NotImplementedException();
        }

        public Task<StoredProcedureResponse<TValue>> ExecuteStoredProcedureAsync<TValue>(string storedProcedureLink, RequestOptions options, params dynamic[] procedureParams)
        {
            throw new NotImplementedException();
        }

        public Task<StoredProcedureResponse<TValue>> ExecuteStoredProcedureAsync<TValue>(Uri storedProcedureUri, params dynamic[] procedureParams)
        {
            throw new NotImplementedException();
        }

        public Task<StoredProcedureResponse<TValue>> ExecuteStoredProcedureAsync<TValue>(Uri storedProcedureUri, RequestOptions options, params dynamic[] procedureParams)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseAccount> GetDatabaseAccountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> ReadAttachmentAsync(string attachmentLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> ReadAttachmentAsync(Uri attachmentUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Attachment>> ReadAttachmentFeedAsync(string documentLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Attachment>> ReadAttachmentFeedAsync(Uri documentUri, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Conflict>> ReadConflictAsync(string conflictLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Conflict>> ReadConflictAsync(Uri conflictUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Conflict>> ReadConflictFeedAsync(string collectionLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Conflict>> ReadConflictFeedAsync(Uri documentCollectionUri, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Database>> ReadDatabaseAsync(string databaseLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Database>> ReadDatabaseAsync(Uri databaseUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Database>> ReadDatabaseFeedAsync(FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> ReadDocumentAsync(string documentLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> ReadDocumentAsync(Uri documentUri, RequestOptions options = null)
        {
            Document document = new Document();
            document.Id = _documentId;
            ResourceResponse<Document> response = new ResourceResponse<Document>(document);
            return Task.FromResult(response);
        }

        public Task<ResourceResponse<DocumentCollection>> ReadDocumentCollectionAsync(string documentCollectionLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<DocumentCollection>> ReadDocumentCollectionAsync(Uri documentCollectionUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<DocumentCollection>> ReadDocumentCollectionFeedAsync(string databaseLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<DocumentCollection>> ReadDocumentCollectionFeedAsync(Uri databaseUri, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<dynamic>> ReadDocumentFeedAsync(string collectionLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<dynamic>> ReadDocumentFeedAsync(Uri documentCollectionUri, FeedOptions options = null)
        {
            List<dynamic> docs = new List<dynamic>();
            foreach (var legoSet in _legoSets)
            {
                var newLegoSet = new LegoSet()
                {
                    Id = legoSet.Id
                };
                newLegoSet.LegoBlocks.AddRange(legoSet.LegoBlocks.Select(l => new LegoBlockCollected()
                {
                    Id = l.Id,
                    Amount = l.Amount
                }));
                docs.Add(newLegoSet);
            }
            FeedResponse<dynamic> feedResponse = new FeedResponse<dynamic>(docs);
            return Task.FromResult(feedResponse);
        }

        public Task<MediaResponse> ReadMediaAsync(string mediaLink)
        {
            throw new NotImplementedException();
        }

        public Task<MediaResponse> ReadMediaMetadataAsync(string mediaLink)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Offer>> ReadOfferAsync(string offerLink)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Offer>> ReadOffersFeedAsync(FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> ReadPermissionAsync(string permissionLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> ReadPermissionAsync(Uri permissionUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Permission>> ReadPermissionFeedAsync(string userLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Permission>> ReadPermissionFeedAsync(Uri userUri, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> ReadStoredProcedureAsync(string storedProcedureLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> ReadStoredProcedureAsync(Uri storedProcedureUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<StoredProcedure>> ReadStoredProcedureFeedAsync(string collectionLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<StoredProcedure>> ReadStoredProcedureFeedAsync(Uri documentCollectionUri, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> ReadTriggerAsync(string triggerLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> ReadTriggerAsync(Uri triggerUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Trigger>> ReadTriggerFeedAsync(string collectionLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<Trigger>> ReadTriggerFeedAsync(Uri documentCollectionUri, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> ReadUserAsync(string userLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> ReadUserAsync(Uri userUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> ReadUserDefinedFunctionAsync(string functionLink, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> ReadUserDefinedFunctionAsync(Uri functionUri, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<UserDefinedFunction>> ReadUserDefinedFunctionFeedAsync(string collectionLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<UserDefinedFunction>> ReadUserDefinedFunctionFeedAsync(Uri documentCollectionUri, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<User>> ReadUserFeedAsync(string databaseLink, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeedResponse<User>> ReadUserFeedAsync(Uri databaseUri, FeedOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> ReplaceAttachmentAsync(Attachment attachment, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> ReplaceAttachmentAsync(Uri attachmentUri, Attachment attachment, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> ReplaceDocumentAsync(string documentLink, object document, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> ReplaceDocumentAsync(Document document, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> ReplaceDocumentAsync(Uri documentUri, object document, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<DocumentCollection>> ReplaceDocumentCollectionAsync(DocumentCollection documentCollection, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<DocumentCollection>> ReplaceDocumentCollectionAsync(Uri documentCollectionUri, DocumentCollection documentCollection, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Offer>> ReplaceOfferAsync(Offer offer)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> ReplacePermissionAsync(Permission permission, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> ReplacePermissionAsync(Uri permissionUri, Permission permission, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> ReplaceStoredProcedureAsync(StoredProcedure storedProcedure, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> ReplaceStoredProcedureAsync(Uri storedProcedureUri, StoredProcedure storedProcedure, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> ReplaceTriggerAsync(Trigger trigger, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> ReplaceTriggerAsync(Uri triggerUri, Trigger trigger, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> ReplaceUserAsync(User user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> ReplaceUserAsync(Uri userUri, User user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> ReplaceUserDefinedFunctionAsync(UserDefinedFunction function, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> ReplaceUserDefinedFunctionAsync(Uri userDefinedFunctionUri, UserDefinedFunction function, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<MediaResponse> UpdateMediaAsync(string mediaLink, Stream mediaStream, MediaOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> UpsertAttachmentAsync(string documentLink, object attachment, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> UpsertAttachmentAsync(string documentLink, Stream mediaStream, MediaOptions options = null, RequestOptions requestOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> UpsertAttachmentAsync(Uri documentUri, object attachment, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Attachment>> UpsertAttachmentAsync(Uri documentUri, Stream mediaStream, MediaOptions options = null, RequestOptions requestOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> UpsertDocumentAsync(string collectionLink, object document, RequestOptions options = null, bool disableAutomaticIdGeneration = false)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Document>> UpsertDocumentAsync(Uri documentCollectionUri, object document, RequestOptions options = null, bool disableAutomaticIdGeneration = false)
        {
            Document doc = new Document();
            doc.Id = _documentId;
            ResourceResponse<Document> resourceResponse = new ResourceResponse<Document>(doc);
            return Task.FromResult(resourceResponse);
        }

        public Task<ResourceResponse<Permission>> UpsertPermissionAsync(string userLink, Permission permission, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Permission>> UpsertPermissionAsync(Uri userUri, Permission permission, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> UpsertStoredProcedureAsync(string collectionLink, StoredProcedure storedProcedure, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<StoredProcedure>> UpsertStoredProcedureAsync(Uri documentCollectionUri, StoredProcedure storedProcedure, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> UpsertTriggerAsync(string collectionLink, Trigger trigger, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<Trigger>> UpsertTriggerAsync(Uri documentCollectionUri, Trigger trigger, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> UpsertUserAsync(string databaseLink, User user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<User>> UpsertUserAsync(Uri databaseUri, User user, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> UpsertUserDefinedFunctionAsync(string collectionLink, UserDefinedFunction function, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceResponse<UserDefinedFunction>> UpsertUserDefinedFunctionAsync(Uri documentCollectionUri, UserDefinedFunction function, RequestOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
