using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Repositories.DTOs;

namespace VABI.Models.Utils
{
    public class LegoCollectionMapper : IMapper<LegoCollection, Repositories.DTOs.LegoCollection>
    {
        private IMapper<LegoBlockCollected, Repositories.DTOs.LegoBlockCollected> _legoBlockCollectedMapper;

        public LegoCollectionMapper(IMapper<LegoBlockCollected, Repositories.DTOs.LegoBlockCollected> legoBlockCollectedMapper)
        {
            _legoBlockCollectedMapper = legoBlockCollectedMapper ?? throw new ArgumentNullException(nameof(legoBlockCollectedMapper));
        }

        public Repositories.DTOs.LegoCollection MapToDTO(LegoCollection model)
        {
            return new Repositories.DTOs.LegoCollection()
            {
                Id = model.Id,
                LegoBlocks = model.LegoBlocks.Select(b => _legoBlockCollectedMapper.MapToDTO(b)).ToList(),
                LegoSets = model.LegoSets
            };
        }

        public LegoCollection MapToModel(Repositories.DTOs.LegoCollection dto)
        {
            return new LegoCollection()
            {
                Id = dto.Id,
                LegoBlocks = dto.LegoBlocks.Select(b => _legoBlockCollectedMapper.MapToModel(b)).ToList(),
                LegoSets = dto.LegoSets
            };
        }
    }
}
