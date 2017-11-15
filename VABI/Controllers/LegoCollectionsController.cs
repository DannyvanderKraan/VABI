using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VABI.Models;
using VABI.Repository;

namespace VABI.Controllers
{
    [Route("api/[controller]")]
    public class LegoCollectionsController : Controller
    {
        private ILegoCollectionsRepository _legoCollectionsRepository;

        public LegoCollectionsController(ILegoCollectionsRepository legoCollectionsRepository)
        {
            if (legoCollectionsRepository is null) throw new ArgumentNullException(nameof(legoCollectionsRepository));
            _legoCollectionsRepository = legoCollectionsRepository;
        }

        // GET api/LegoCollections
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var legoCollections = await _legoCollectionsRepository.GetAll();
            return Json(legoCollections);
        }

        // GET api/LegoCollections/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(string id)
        {
            var legoCollection = await _legoCollectionsRepository.Get(id);
            return Json(legoCollection);
        }

        // GET api/LegoCollections/5/BuildableLegoSets
        [HttpGet("{id}/GetBuildableLegoSets")]
        public async Task<JsonResult> GetBuildableLegoSets(string id,
            [FromServices]IProvideLegoSets legoSetsProvider)
        {
            var legoBlocks = await _legoCollectionsRepository.GetLegoBlocksInCollection(id);
            var legoSets = await legoSetsProvider.GetByLegoBlocksInCollection(legoBlocks);
            return Json(legoSets);
        }

        // POST api/LegoCollections
        [HttpPost]
        public async void Post([FromBody]LegoCollection legoCollection)
        {
            legoCollection.Id = Guid.NewGuid().ToString();
            var upsertedLegoSet = await _legoCollectionsRepository.Save(legoCollection);
            //ToDo Iets nuttigs doen met upsertedLegoCollection.
        }

        // PUT api/LegoCollections/5
        [HttpPut("{id}")]
        public async void Put(string id, [FromBody]LegoCollection legoCollection)
        {
            legoCollection.Id = id;
            var upsertedLegoSet = await _legoCollectionsRepository.Save(legoCollection);
            //ToDo Iets nuttigs doen met upsertedLegoCollection.
        }
    }
}