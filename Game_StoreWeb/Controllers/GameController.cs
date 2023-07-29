using AutoMapper;
using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Models.VM;
using Game_StoreWeb.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Game_StoreWeb.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IGameCompanyService _gameCompanyService;
        private readonly IGameTypeService _gameTypeService;
        private readonly IPlatformService _platformService;
        private IMapper _mapper;
        public GameController(IGameService gameService, IMapper mapper, IGameCompanyService gameCompanyService, IGameTypeService gameTypeService, IPlatformService platformService)
        {
            _gameService = gameService;
            _mapper = mapper;
            _gameCompanyService = gameCompanyService;
            _gameTypeService = gameTypeService;
            _platformService = platformService;

        }
        public async Task<IActionResult> Index()
        {
            List<GameDTO> list = new();
            var response=await _gameService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response !=null && response.IsSuccess)
                list=JsonConvert.DeserializeObject<List<GameDTO>>(Convert.ToString(response.Result));
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            GameCreateVM gameCreateVM = new();
            var gameComapanyResponse=await _gameCompanyService
                .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if(gameComapanyResponse != null && gameComapanyResponse.IsSuccess)
            {
                gameCreateVM.GameCompanyList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameComapanyResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }

            var gameTypeResponse = await _gameTypeService
                .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (gameTypeResponse != null && gameTypeResponse.IsSuccess)
            {
                gameCreateVM.GameTypeList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameTypeResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }

            var platformResponse = await _platformService
                .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (platformResponse != null && platformResponse.IsSuccess)
            {
                gameCreateVM.PlatformList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(platformResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }
            return View(gameCreateVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GameCreateVM gameCreateVM)
        {
            if (ModelState.IsValid)
            {
                var response=await _gameService
                    .CreateAsync<APIResponse>(gameCreateVM.Game,HttpContext.Session.GetString(SD.SessionToken));
                if (response !=null && response.IsSuccess) 
                {
                    TempData["success"] = "Game Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    if (response.ErrorMessages.Count>0)
                    {
                        ModelState.AddModelError("Error Messages", response.ErrorMessages.FirstOrDefault());
                    }
                }
            }
            var gameComapanyResponse = await _gameCompanyService
                .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (gameComapanyResponse != null && gameComapanyResponse.IsSuccess)
            {
                gameCreateVM.GameCompanyList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameComapanyResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }

            var gameTypeResponse = await _gameTypeService
                .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (gameTypeResponse != null && gameTypeResponse.IsSuccess)
            {
                gameCreateVM.GameTypeList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameTypeResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }

            var platformResponse = await _platformService
                .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (platformResponse != null && platformResponse.IsSuccess)
            {
                gameCreateVM.PlatformList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(platformResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }
            TempData["error"] = "Error Encountered.";
            return View(gameCreateVM);
        }
        public async Task<IActionResult> Update(int id)
        {
            GameUpdateVM gameUpdateVM = new();
            var response=await _gameService.GetAsync<APIResponse>(id,HttpContext.Session.GetString(SD.SessionToken));
            if (response!=null && response.IsSuccess)
            {
                GameDTO model=JsonConvert.DeserializeObject<GameDTO>(Convert.ToString(response.Result));
                gameUpdateVM.Game=_mapper.Map<GameUpdateDTO>(model);
                var gameComapanyResponse = await _gameCompanyService
              .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
                if (gameComapanyResponse != null && gameComapanyResponse.IsSuccess)
                {
                    gameUpdateVM.GameCompanyList = JsonConvert
                        .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameComapanyResponse.Result))
                        .Select(n => new SelectListItem
                        {
                            Text = n.Name,
                            Value = n.Id.ToString(),
                        });
                }

                var gameTypeResponse = await _gameTypeService
                    .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
                if (gameTypeResponse != null && gameTypeResponse.IsSuccess)
                {
                    gameUpdateVM.GameTypeList = JsonConvert
                        .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameTypeResponse.Result))
                        .Select(n => new SelectListItem
                        {
                            Text = n.Name,
                            Value = n.Id.ToString(),
                        });
                }

                var platformResponse = await _platformService
                    .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
                if (platformResponse != null && platformResponse.IsSuccess)
                {
                    gameUpdateVM.PlatformList = JsonConvert
                        .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(platformResponse.Result))
                        .Select(n => new SelectListItem
                        {
                            Text = n.Name,
                            Value = n.Id.ToString(),
                        });
                }
                return View(gameUpdateVM);
            }
            return NotFound();
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(GameUpdateVM gameUpdateVM)
        {
            if (ModelState.IsValid)
            {
                var response = await _gameService
                    .UpdateAsync<APIResponse>(gameUpdateVM.Game, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess) 
                {
                    TempData["success"] = "Game Updated Succssefully";
                    return RedirectToAction("Index");
                }
                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        ModelState.AddModelError("ErrorMessages", response.ErrorMessages.FirstOrDefault());
                    }
                }
            }
            var gameComapanyResponse = await _gameCompanyService
               .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (gameComapanyResponse != null && gameComapanyResponse.IsSuccess)
            {
                gameUpdateVM.GameCompanyList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameComapanyResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }

            var gameTypeResponse = await _gameTypeService
                .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (gameTypeResponse != null && gameTypeResponse.IsSuccess)
            {
                gameUpdateVM.GameTypeList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameTypeResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }

            var platformResponse = await _platformService
                .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (platformResponse != null && platformResponse.IsSuccess)
            {
                gameUpdateVM.PlatformList = JsonConvert
                    .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(platformResponse.Result))
                    .Select(n => new SelectListItem
                    {
                        Text = n.Name,
                        Value = n.Id.ToString(),
                    });
            }
            TempData["error"] = "Error Encountered.";
            return View(gameUpdateVM);
        }
        public async Task<IActionResult> Delete(int id)
        {
            GameDeleteVM gameDeleteVM = new();
            var response = await _gameService.GetAsync<APIResponse>(id, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                GameDTO model = JsonConvert.DeserializeObject<GameDTO>(Convert.ToString(response.Result));
                gameDeleteVM.Game = model;
                var gameComapanyResponse = await _gameCompanyService
              .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
                if (gameComapanyResponse != null && gameComapanyResponse.IsSuccess)
                {
                    gameDeleteVM.GameCompanyList = JsonConvert
                        .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameComapanyResponse.Result))
                        .Select(n => new SelectListItem
                        {
                            Text = n.Name,
                            Value = n.Id.ToString(),
                        });
                }

                var gameTypeResponse = await _gameTypeService
                    .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
                if (gameTypeResponse != null && gameTypeResponse.IsSuccess)
                {
                    gameDeleteVM.GameTypeList = JsonConvert
                        .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(gameTypeResponse.Result))
                        .Select(n => new SelectListItem
                        {
                            Text = n.Name,
                            Value = n.Id.ToString(),
                        });
                }

                var platformResponse = await _platformService
                    .GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
                if (platformResponse != null && platformResponse.IsSuccess)
                {
                    gameDeleteVM.PlatformList = JsonConvert
                        .DeserializeObject<List<GameCompanyDTO>>(Convert.ToString(platformResponse.Result))
                        .Select(n => new SelectListItem
                        {
                            Text = n.Name,
                            Value = n.Id.ToString(),
                        });
                }
                return View(gameDeleteVM);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(GameDeleteVM gameDeleteVM)
        {
            var response = await _gameService
                .DeleteAsync<APIResponse>(gameDeleteVM.Game.Id, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess) 
            {
                TempData["success"] = "Game Deleted Successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Error Encountered.";
            return View(gameDeleteVM);
        }
    }
}
