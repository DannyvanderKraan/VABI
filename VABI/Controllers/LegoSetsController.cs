using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VABI.Repository;
using VABI.Models;

namespace VABI.Controllers
{
    [Route("api/[controller]")]
    public class LegoSetsController : Controller
    {
        private ILegoSetsRepository _legoSetsRepository;

        public LegoSetsController(ILegoSetsRepository legoSetsRepository)
        {
            if (legoSetsRepository is null) throw new ArgumentNullException(nameof(legoSetsRepository));
            _legoSetsRepository = legoSetsRepository;
        }

        // GET api/LegoSets
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var legoSets = await _legoSetsRepository.GetAll();
            return Json(legoSets);
        }

        // GET api/LegoSets/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(string id)
        {
            var legoSet = await _legoSetsRepository.Get(id);
            return Json(legoSet);
        }

        // POST api/LegoSets
        [HttpPost]
        public async void Post([FromBody]LegoSet legoSet)
        {
            legoSet.Id = Guid.NewGuid().ToString();
            var upsertedLegoSet = await _legoSetsRepository.Save(legoSet);
            //ToDo Iets nuttigs doen met upsertedLegoSet.
        }

        // PUT api/LegoSets/5
        [HttpPut("{id}")]
        public async void Put(string id, [FromBody]LegoSet legoSet)
        {
            legoSet.Id = id;
            var upsertedLegoSet = await _legoSetsRepository.Save(legoSet);
            //ToDo Iets nuttigs doen met upsertedLegoSet.
        }

        //ToDo DELETE api/LegoSets/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
