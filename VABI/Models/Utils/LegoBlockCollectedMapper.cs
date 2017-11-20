using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Repositories.DTOs;

namespace VABI.Models.Utils
{
    public class LegoBlockCollectedMapper : IMapper<LegoBlockCollected, Repositories.DTOs.LegoBlockCollected>
    {
        public Repositories.DTOs.LegoBlockCollected MapToDTO(LegoBlockCollected model)
        {
            return new Repositories.DTOs.LegoBlockCollected()
            {
                Id = model.Id,
                Amount = model.Amount
            };
        }

        public LegoBlockCollected MapToModel(Repositories.DTOs.LegoBlockCollected dto)
        {
            return new LegoBlockCollected()
            {
                Id = dto.Id,
                Amount = dto.Amount
            };
        }
    }
}
