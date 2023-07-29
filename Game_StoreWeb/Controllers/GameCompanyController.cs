using AutoMapper;
using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Game_StoreWeb.Controllers
{
    public class GameCompanyController : Controller
    {
        private readonly IGameCompanyService _gameCompanyService;
        private readonly IMapper _mapper;
        public GameCompanyController(IGameCompanyService gameCompanyService, IMapper mapper)
        {
            _gameCompanyService = gameCompanyService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            List<GameCompanyDTO> list = new();
            var response=await _gameCompanyService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
                list=JsonConvert.DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(response.Result));
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GameCompanyCreateDTO gameCompanyCreateDTO)
        {
            if (ModelState.IsValid)
            {
                var response=await _gameCompanyService
                    .CreateAsync<APIResponse>(gameCompanyCreateDTO,HttpContext.Session.GetString(SD.SessionToken));
                if (response !=null && response.IsSuccess)
                {
                    TempData["success"] = "Game Company Created Successfully";
                    return RedirectToAction("Index");
                }
            }
            TempData["error"] = "Error Encountered";
            return View(gameCompanyCreateDTO);
        }
        public async Task<IActionResult> Update(int id)
        {
            var response = await _gameCompanyService
                .GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                GameCompanyDTO model=JsonConvert.DeserializeObject<GameCompanyDTO>(Convert.ToString(response.Result));
                return View(_mapper.Map<GameCompanyDTO>(model));
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(GameCompanyDTO gameCompanyDTO)
        {
            if (ModelState.IsValid) 
            {
                var response=await _gameCompanyService
                    .UpdateAsync<APIResponse>(gameCompanyDTO,HttpContext.Session.GetString(SD.SessionToken));
                if (response !=null && response.IsSuccess)
                {
                    TempData["success"] = "Game Company Updated Successfully";
                    return RedirectToAction("Index");
                }

            }
            TempData["error"] = "Error Encountered";
            return View(gameCompanyDTO);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _gameCompanyService
                .GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
            if (response!=null && response.IsSuccess) 
            {
                GameCompanyDTO model=JsonConvert.DeserializeObject<GameCompanyDTO>(Convert.ToString(response.Result));
                return View(_mapper.Map<GameCompanyDTO>(model));
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(GameCompanyDTO gameCompanyDTO)
        {
            if (ModelState.IsValid)
            {
                var response = await _gameCompanyService
                    .DeleteAsync<APIResponse>(gameCompanyDTO.Id, HttpContext.Session.GetString(SD.SessionToken));
                if (response!=null && response.IsSuccess)
                {
                    TempData["success"] = "Game Company Deleted Successfully";
                    return RedirectToAction("Index");
                }
            }
            TempData["error"] = "Error Encountered";
            return View(gameCompanyDTO);
        }
    }
}
