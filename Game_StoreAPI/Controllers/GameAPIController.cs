using AutoMapper;
using Game_StoreAPI.Models;
using Game_StoreAPI.Models.DTO;
using Game_StoreAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Game_StoreAPI.Controllers
{
    [Route("api/GameAPI")]
    [ApiController]
    public class GameAPIController : ControllerBase
    {
        private readonly IGameRepository _contextGame;
        private readonly IGamePlatformRepository _contextGamePlatform;
        private readonly IPlatformRepository _contextPlatform;
        private readonly IMapper _mapper;
        protected APIResponse _response;
        public GameAPIController(IGameRepository contextGame, IMapper mapper, IGamePlatformRepository contextGamePlatform, IPlatformRepository contextPlatform)
        {
            _contextGame = contextGame;
            _contextGamePlatform = contextGamePlatform;
            _contextPlatform = contextPlatform;
            _mapper = mapper;
            _response = new APIResponse();
        }
        [HttpGet]
        [ResponseCache(Duration =30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> GetGames()
        {
            try
            {
                List<string> Properties = new List<string> { "GameCompany", "GameType", "GamePlatform" };
                IEnumerable<Game> games = _contextGame.GetAll(includeproperties: Properties);
                _response.Result = _mapper.Map<List<GameDTO>>(games);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpGet("{id:int}",Name ="GetGame")]
        [ResponseCache(Duration =30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> GetGame(int id)
        {
            try
            {
                List<string> Properties = new List<string> { "GameCompany", "GameType", "GamePlatform" };
                IEnumerable<Game> games = _contextGame.GetAll(includeproperties: Properties);
                if (id==0)
                {
                    _response.IsSuccess = false;
                    return BadRequest();
                }
                var game=_contextGame.Get(n=>n.Id==id, includeproperties: Properties);
                if (game==null)
                {
                    _response.IsSuccess = false;
                    return NotFound();
                }
                _response.Result = _mapper.Map<GameDTO>(game);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> CreateGame(GameCreateDTO gameCreateDTO)
        {
            try
            {
                if (_contextGame.Get(n => n.Name.ToLower() == gameCreateDTO.Name.ToLower()) != null)
                {
                    _response.IsSuccess = false;
                    ModelState.AddModelError("Error Message", "This Game Name already exists");
                    return BadRequest(ModelState);
                }
                if (gameCreateDTO == null)
                {
                    _response.IsSuccess = false;
                    return BadRequest(gameCreateDTO);
                }

                var model = _mapper.Map<Game>(gameCreateDTO);

                _contextGame.Create(model);

                if (gameCreateDTO.PlatformIds != null && gameCreateDTO.PlatformIds.Any())
                {
                    foreach (var platformId in gameCreateDTO.PlatformIds)
                    {
                        var gamePlatform = new GamePlatformCreateDTO { GameId = model.Id, PlatformId = platformId };
                        var platform=_contextPlatform.Get(n=>n.Id==platformId);
                        var modelGamePlatform = new GamePlatform{ GameId = model.Id, PlatformId = platformId,Game=model,Platform=platform};
                        _contextGamePlatform.Create(modelGamePlatform);
                    }
                }

                _response.Result = _mapper.Map<GameDTO>(model);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.Created;

                return CreatedAtRoute("GetGame", new { id = model.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }

            return _response;
        }
        [HttpDelete("{id:int}",Name ="DeleteGame")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> DeleteGame(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.IsSuccess=false;
                    return BadRequest();
                }
                var game = _contextGame.Get(n => n.Id == id);
                if (game==null)
                {
                    _response.IsSuccess = false;
                    return NotFound();
                }
                _contextGame.Remove(game);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages=new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPut("{id:int}",Name ="UpdateGame")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> UpdateGame(int id, GameUpdateDTO gameUpdateDTO)
        {
            try
            {
                if (gameUpdateDTO == null || gameUpdateDTO.Id != id)
                {
                    _response.IsSuccess = false;
                    return BadRequest();
                }
                var model = _mapper.Map<Game>(gameUpdateDTO);

                _contextGame.Update(model);

                if (gameUpdateDTO.PlatformIds != null && gameUpdateDTO.PlatformIds.Any())
                {
                    foreach (var platformId in gameUpdateDTO.PlatformIds)
                    {
                        var gamePlatform = new GamePlatformUpdateDTO { GameId = model.Id, PlatformId = platformId };
                        var platform = _contextPlatform.Get(n => n.Id == platformId);
                        var modelGamePlatform = new GamePlatform { GameId = model.Id, PlatformId = platformId, Game = model, Platform = platform };
                        _contextGamePlatform.Update(modelGamePlatform);
                    }
                }

                _response.Result = _mapper.Map<GameDTO>(model);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.NoContent;

                return Ok(_response);
            }catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages=new List<string> { ex.ToString() };
            }
            return _response;
        }
            

    }
}
