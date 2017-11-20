using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VABI.Models;
using VABI.Repositories;
using VABI.Models.Utils;

namespace VABI.Controllers
{
    [Route("api/[controller]")]
    public class LegoCollectionsController : Controller
    {
        private ILegoCollectionsRepository _legoCollectionsRepository;
        private IMapper<LegoCollection, Repositories.DTOs.LegoCollection> _legoCollectionMapper;

        public LegoCollectionsController(ILegoCollectionsRepository legoCollectionsRepository, IMapper<LegoCollection, Repositories.DTOs.LegoCollection> mapper)
        {
            _legoCollectionsRepository = legoCollectionsRepository ?? throw new ArgumentNullException(nameof(legoCollectionsRepository));
            _legoCollectionMapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET api/LegoCollections
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            //TODO Enkel voor dev, in productie niet doen!
            var legoCollections = await _legoCollectionsRepository.GetAll();
            return Json(legoCollections.Select(c => _legoCollectionMapper.MapToModel(c)).ToList());
        }

        // GET api/LegoCollections/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(string id)
        {
            var legoCollection = await _legoCollectionsRepository.Get(id);
            return Json(_legoCollectionMapper.MapToModel(legoCollection));
        }

        // GET api/LegoCollections/5/BuildableLegoSets
        [HttpGet("{id}/GetBuildableLegoSets")]
        public async Task<JsonResult> GetBuildableLegoSets(string id,
            [FromServices]IProvideLegoSets legoSetsProvider,
            [FromServices]IMapper<LegoSet, Repositories.DTOs.LegoSet> legoSetMapper)
        {
            var legoBlocks = await _legoCollectionsRepository.GetLegoBlocksInCollection(id);
            var legoSets = await legoSetsProvider.GetByLegoBlocksInCollection(legoBlocks);
            return Json(legoSets.Select(s => legoSetMapper.MapToModel(s)).ToList());
        }

        // POST api/LegoCollections
        [HttpPost]
        public async void Post([FromBody]LegoCollection legoCollection)
        {
            legoCollection.Id = Guid.NewGuid().ToString();
            var upsertedLegoSet = await _legoCollectionsRepository.Save(_legoCollectionMapper.MapToDTO(legoCollection));
        }

        // PUT api/LegoCollections/5
        [HttpPut("{id}")]
        public async void Put(string id, [FromBody]LegoCollection legoCollection)
        {
            legoCollection.Id = id;
            var upsertedLegoSet = await _legoCollectionsRepository.Save(_legoCollectionMapper.MapToDTO(legoCollection));
        }
    }
}