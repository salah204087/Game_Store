using AutoMapper;
using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Game_StoreWeb.Controllers
{
    public class PlatformController : Controller
    {
        private readonly IPlatformService _platformService;
        private readonly IMapper _mapper;
        public PlatformController(IPlatformService platformService, IMapper mapper)
        {
            _platformService = platformService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            List<PlatformDTO> list = new();
            var response=await _platformService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
                list = JsonConvert.DeserializeObject<List<PlatformDTO>>(Convert.ToString(response.Result));
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PlatformCreateDTO platformCreateDTO)
        {
            if (ModelState.IsValid)
            {
                var response=await _platformService
                    .CreateAsync<APIResponse>(platformCreateDTO,HttpContext.Session.GetString(SD.SessionToken));
                if (response !=null && response.IsSuccess)
                {
                    TempData["success"] = "Platform Created Successfully";
                    return RedirectToAction("Index");
                }
            }
            TempData["error"] = "Error Encountered";
            return View(platformCreateDTO);
        }
        public async Task<IActionResult> Update(int id)
        {
            var response = await _platformService
                .GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
            if (response !=null && response.IsSuccess)
            {
                PlatformDTO model=JsonConvert.DeserializeObject<PlatformDTO>(Convert.ToString(response.Result));
                return View(_mapper.Map<PlatformDTO>(model));
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(PlatformDTO platformDTO)
        {
            if (ModelState.IsValid) 
            {
                var response = await _platformService
                    .UpdateAsync<APIResponse>(platformDTO, HttpContext.Session.GetString(SD.SessionToken));
                if (response !=null && response.IsSuccess)
                {
                    TempData["success"] = "Platform Updated Successfully";
                    return RedirectToAction("Index");
                }
            }
            TempData["error"] = "Error Encountered";
            return View(platformDTO);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _platformService
                .GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
            if (response !=null && response.IsSuccess)
            {
                PlatformDTO model = JsonConvert.DeserializeObject<PlatformDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(PlatformDTO platformDTO)
        {
            if (ModelState.IsValid)
            {
                var response = await _platformService
                    .DeleteAsync<APIResponse>(platformDTO.Id, HttpContext.Session.GetString(SD.SessionToken));
                if (response !=null &&response.IsSuccess)
                {
                    TempData["success"] = "Platform Deleted Successfully";
                    return RedirectToAction("Index");
                }

            }
            TempData["error"] = "Error Encountered";
            return View(platformDTO);
        }
    }
}
