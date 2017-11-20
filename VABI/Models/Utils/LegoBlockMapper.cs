using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Repositories.DTOs;

namespace VABI.Models.Utils
{
    public class LegoBlockMapper : IMapper<LegoBlock, Repositories.DTOs.LegoBlock>
    {
        public Repositories.DTOs.LegoBlock MapToDTO(LegoBlock model)
        {
            return new Repositories.DTOs.LegoBlock()
            {
                Id = model.Id
            };
        }

        public LegoBlock MapToModel(Repositories.DTOs.LegoBlock dto)
        {
            return new LegoBlock()
            {
                Id = dto.Id
            };
        }
    }
}
