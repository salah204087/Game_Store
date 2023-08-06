using AutoMapper;
using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

namespace Game_StoreWeb.Controllers
{
    public class GameTypeController : Controller
    {
        private readonly IGameTypeService _gameTypeService;
        private readonly IMapper _mapper;
        public GameTypeController(IGameTypeService gameTypeServic, IMapper mapper)
        {
            _gameTypeService = gameTypeServic;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            List<GameTypeDTO> list = new();
            var response=await _gameTypeService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
                list = JsonConvert.DeserializeObject<List<GameTypeDTO>>(Convert.ToString(response.Result));
            return View(list);
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GameTypeCreateDTO gameTypeCreateDTO)
        {
            if (ModelState.IsValid)
            {
                var response = await _gameTypeService
                    .CreateAsync<APIResponse>(gameTypeCreateDTO, HttpContext.Session.GetString(SD.SessionToken));
                if (response !=null && response.IsSuccess)
                {
                    TempData["success"] = "Game Type Created Successfully";
                    return RedirectToAction("Index");
                }
            }
            TempData["error"] = "Error Encountered";
            return View(gameTypeCreateDTO);
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Update(int id)
        {
            var response = await _gameTypeService
                .GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
            if (response !=null && response.IsSuccess)
            {
                GameTypeDTO model=JsonConvert.DeserializeObject<GameTypeDTO>(Convert.ToString(response.Result));
                return View(_mapper.Map<GameTypeUpdateDTO>(model));
            }
            return NotFound();
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(GameTypeUpdateDTO gameTypeUpdateDTO)
        {
            if (ModelState.IsValid) 
            {
                var response =await _gameTypeService
                    .UpdateAsync<APIResponse>(gameTypeUpdateDTO, HttpContext.Session.GetString(SD.SessionToken));
                if (response !=null && response.IsSuccess)
                {
                    TempData["success"] = "Game Type Updated Successfully";
                    return RedirectToAction("Index");
                }  
            }
            TempData["error"] = "Error Encountered";
            return View(gameTypeUpdateDTO);
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _gameTypeService
                .GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
            if (response !=null && response.IsSuccess) 
            {
                GameTypeDTO model=JsonConvert.DeserializeObject<GameTypeDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(GameTypeDTO gameTypeDTO)
        {
            var response = await _gameTypeService
                .DeleteAsync<APIResponse>(gameTypeDTO.Id, HttpContext.Session.GetString(SD.SessionToken));
            if (response!=null&& response.IsSuccess) 
            {
                TempData["success"] = "Game Type Deleted Successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Error Encountered.";
            return View(gameTypeDTO);
        }
    }
}
