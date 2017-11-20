using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VABI.Repositories;
using VABI.Models;
using VABI.Models.Utils;

namespace VABI.Controllers
{
    [Route("api/[controller]")]
    public class LegoSetsController : Controller
    {
        private ILegoSetsRepository _legoSetsRepository;
        private IMapper<LegoSet, Repositories.DTOs.LegoSet> _legoSetMapper;

        public LegoSetsController(ILegoSetsRepository legoSetsRepository, IMapper<LegoSet, Repositories.DTOs.LegoSet> legoSetMapper)
        {
            _legoSetsRepository = legoSetsRepository ?? throw new ArgumentNullException(nameof(legoSetsRepository));
            _legoSetMapper = legoSetMapper ?? throw new ArgumentNullException(nameof(legoSetMapper));
        }

        // GET api/LegoSets
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            //TODO Enkel voor dev, in productie niet doen!
            var legoSets = await _legoSetsRepository.GetAll();
            return Json(legoSets.Select(s => _legoSetMapper.MapToModel(s)).ToList());
        }

        // GET api/LegoSets/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(string id)
        {
            var legoSet = await _legoSetsRepository.Get(id);
            return Json(_legoSetMapper.MapToModel(legoSet));
        }

        // POST api/LegoSets
        [HttpPost]
        public async void Post([FromBody]LegoSet legoSet)
        {
            legoSet.Id = Guid.NewGuid().ToString();
            var upsertedLegoSet = await _legoSetsRepository.Save(_legoSetMapper.MapToDTO(legoSet));
        }

        // PUT api/LegoSets/5
        [HttpPut("{id}")]
        public async void Put(string id, [FromBody]LegoSet legoSet)
        {
            legoSet.Id = id;
            var upsertedLegoSet = await _legoSetsRepository.Save(_legoSetMapper.MapToDTO(legoSet));
        }
    }
}
