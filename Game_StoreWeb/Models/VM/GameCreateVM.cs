using Game_StoreWeb.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Game_StoreWeb.Models.VM
{
    public class GameCreateVM
    {
        public GameCreateVM()
        {
            Game=new GameCreateDTO();
        }
        public GameCreateDTO Game { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GameCompanyList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GameTypeList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> PlatformList { get; set; }
    }
}
