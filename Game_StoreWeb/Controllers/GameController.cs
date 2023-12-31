﻿using AutoMapper;
using Azure;
using Game_StoreUtility;
using Game_StoreWeb.Models;
using Game_StoreWeb.Models.DTO;
using Game_StoreWeb.Models.VM;
using Game_StoreWeb.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

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
        public async Task<IActionResult> IndexPc()
        {
            List<GameDTO> list = new();
            var response=await _gameService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response !=null && response.IsSuccess)
                list=JsonConvert.DeserializeObject<List<GameDTO>>(Convert.ToString(response.Result));
            return View(list.Where(n=>n.GamePlatform.Any(n=>n.PlatformId==3)));
        }
        public async Task<IActionResult> IndexPs()
        {
            List<GameDTO> list = new();
            var response = await _gameService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
                list = JsonConvert.DeserializeObject<List<GameDTO>>(Convert.ToString(response.Result));
            return View(list.Where(n => n.GamePlatform.Any(n => n.PlatformId == 1 || n.PlatformId == 2)));
        }
        public async Task<IActionResult> IndexXbox()
        {
            List<GameDTO> list = new();
            var response = await _gameService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
                list = JsonConvert.DeserializeObject<List<GameDTO>>(Convert.ToString(response.Result));
            return View(list.Where(n => n.GamePlatform.Any(n => n.PlatformId == 5 
            || n.PlatformId == 6 || n.PlatformId==7 || n.PlatformId == 8)));
        }
        public async Task<IActionResult> FilterPc(string searchString)
        {
            List<GameDTO> allGames = new();
            var response= await _gameService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            allGames= JsonConvert.DeserializeObject<List<GameDTO>>(Convert.ToString(response.Result));
            var gamePc = allGames.Where(n => n.GamePlatform.Any(n => n.PlatformId == 3));
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = gamePc.Where((n => n.Name.Contains(searchString) || n.Description.Contains(searchString))).ToList();
                if (filteredResult.Any())
                {
                    return View("IndexPc", filteredResult);
                }
                else
                {
                    TempData["error"] = "Not Found";
                    return View("IndexPc", gamePc);
                }
            }
            return View("IndexPc", gamePc);
        }
        public async Task<IActionResult> FilterPs(string searchString)
        {
            List<GameDTO> allGames = new();
            var response = await _gameService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            allGames = JsonConvert.DeserializeObject<List<GameDTO>>(Convert.ToString(response.Result));
            var gamePs = allGames.Where(n => n.GamePlatform.Any(n => n.PlatformId == 1 || n.PlatformId == 2));
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = gamePs.Where((n => n.Name.Contains(searchString) || n.Description.Contains(searchString))).ToList();
                if (filteredResult.Any())
                {
                    return View("IndexPs", filteredResult);
                }
                else
                {
                    TempData["error"] = "Not Found";
                    return View("IndexPs", gamePs);
                }
            }
            return View("IndexPs", gamePs);
        }
        public async Task<IActionResult> FilterXbox(string searchString)
        {
            List<GameDTO> allGames = new();
            var response = await _gameService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            allGames = JsonConvert.DeserializeObject<List<GameDTO>>(Convert.ToString(response.Result));
            var gameXbox = allGames.Where(n => n.GamePlatform.Any(n => n.PlatformId == 5
            || n.PlatformId == 6 || n.PlatformId == 7 || n.PlatformId == 8));
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = gameXbox.Where((n => n.Name.Contains(searchString) || n.Description.Contains(searchString))).ToList();
                if (filteredResult.Any())
                {
                    return View("IndexXbox", filteredResult);
                }
                else
                {
                    TempData["error"] = "Not Found";
                    return View("IndexXbox", gameXbox);
                }
            }
            return View("IndexXbox", gameXbox);
        }
        [Authorize(Roles = "admin")]
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
        [Authorize(Roles = "admin")]
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
                    return RedirectToAction("Platform","Home");
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
        [Authorize(Roles = "admin")]
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
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(GameUpdateVM gameUpdateVM)
        {
            if (ModelState.IsValid)
            {
                var response = await _gameService.UpdateAsync<APIResponse>(gameUpdateVM.Game, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    TempData["success"] = "Game Updated Successfully";
                    return RedirectToAction("Platform", "Home");
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
        [Authorize(Roles = "admin")]
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
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(GameDeleteVM gameDeleteVM)
        {
            var response = await _gameService
                .DeleteAsync<APIResponse>(gameDeleteVM.Game.Id, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess) 
            {
                TempData["success"] = "Game Deleted Successfully";
                return RedirectToAction("Platform", "Home");
            }
            TempData["error"] = "Error Encountered.";
            return View(gameDeleteVM);
        }
    }
}
