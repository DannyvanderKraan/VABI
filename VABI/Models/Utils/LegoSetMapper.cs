using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Repositories.DTOs;

namespace VABI.Models.Utils
{
    public class LegoSetMapper : IMapper<LegoSet, Repositories.DTOs.LegoSet>
    {
        private IMapper<LegoBlockCollected, Repositories.DTOs.LegoBlockCollected> _legoBlockCollectedMapper;

        public LegoSetMapper(IMapper<LegoBlockCollected, Repositories.DTOs.LegoBlockCollected> legoBlockCollectedMapper)
        {
            _legoBlockCollectedMapper = legoBlockCollectedMapper ?? throw new ArgumentNullException(nameof(legoBlockCollectedMapper));
        }
        public Repositories.DTOs.LegoSet MapToDTO(LegoSet model)
        {
            return new Repositories.DTOs.LegoSet()
            {
                Id = model.Id,
                LegoBlocks = model.LegoBlocks.Select(b => _legoBlockCollectedMapper.MapToDTO(b)).ToList()
            };
        }

        public LegoSet MapToModel(Repositories.DTOs.LegoSet dto)
        {
            return new LegoSet()
            {
                Id = dto.Id,
                LegoBlocks = dto.LegoBlocks.Select(b => _legoBlockCollectedMapper.MapToModel(b)).ToList()
            };
        }
    }
}
