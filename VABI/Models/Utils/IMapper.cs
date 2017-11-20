using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABI.Models.Utils
{
    public interface IMapper<Model, DTO>
    {
        Model MapToModel(DTO dto);
        DTO MapToDTO(Model model);
    }
}
