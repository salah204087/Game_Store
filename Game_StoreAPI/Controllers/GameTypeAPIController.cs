using AutoMapper;
using Game_StoreAPI.Models;
using Game_StoreAPI.Models.DTO;
using Game_StoreAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Game_StoreAPI.Controllers
{
    [Route("api/GameTypeAPI")]
    [ApiController]
    public class GameTypeAPIController : ControllerBase
    {
        private readonly IGameTypeRepository _contextGameType;
        private readonly IMapper _mapper;
        protected APIResponse _response;
        public GameTypeAPIController(IGameTypeRepository contextGameType, IMapper mapper)
        {
            _contextGameType = contextGameType;
            _mapper = mapper;
            this._response = new APIResponse();
        }
        [HttpGet]
        [ResponseCache(Duration =30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult <APIResponse> GetGameTypes()
        {
            try
            {
                IEnumerable<GameType> gameTypes = _contextGameType.GetAll();
                _response.Result = _mapper.Map<List<GameTypeDTO>>(gameTypes);
                _response.IsSuccess = true;
                _response.StatusCode=HttpStatusCode.OK;
                return Ok(_response);

            }catch (Exception ex) 
            {
                _response.IsSuccess=false;
                _response.ErrorMessages=new List<string> {ex.ToString() };
            }
            return _response;
        }
        [HttpGet("{id:int}", Name = "GetGameType")]
        [ResponseCache(Duration =30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> GetGameType(int id)
        {
            try
            {
                if (id==0)
                {
                    _response.IsSuccess=false;
                    return BadRequest();
                }
                var gameType = _contextGameType.Get(n => n.Id == id);
                if (gameType == null)
                {
                    _response.IsSuccess=false;
                    return NotFound();
                }
                _response.IsSuccess=true;
                _response.StatusCode=HttpStatusCode.OK;
                _response.Result = _mapper.Map<GameTypeDTO>(gameType);
                return Ok(_response);
            }catch(Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<APIResponse> CreateGameType(GameTypeCreateDTO gameTypeCreateDTO)
        {
            try
            {
                if(_contextGameType.Get(n=>n.Name.ToLower()==gameTypeCreateDTO.Name.ToLower())!=null)
                {
                    ModelState.AddModelError("Error Message", "Game type already exist");
                    _response.IsSuccess = false;
                    return BadRequest(ModelState);
                }
                if (gameTypeCreateDTO==null)
                {
                    _response.IsSuccess=false;
                    return BadRequest(gameTypeCreateDTO);
                }
                var model=_mapper.Map<GameType>(gameTypeCreateDTO);
                _contextGameType.Create(model);
                _response.Result = _mapper.Map<GameTypeDTO>(model);
                _response.IsSuccess=true;
                _response.StatusCode=HttpStatusCode.Created;
                return CreatedAtRoute("GetGameType", new {id=model.Id},_response);
            }
            catch(Exception ex) 
            {
                _response.IsSuccess= false;
                _response.ErrorMessages= new List<string> { ex.ToString() } ;
            }
            return _response;
        }
        [HttpDelete("{id:int}",Name="DeleteGameType")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> DeleteGameType(int id)
        {
            try
            {
                if (id==0)
                {
                    _response.IsSuccess=false;
                    return BadRequest();
                }
                var gameType=_contextGameType.Get(n=>n.Id==id);
                if(gameType==null)
                {
                    _response.IsSuccess=false;
                    return NotFound();
                }
                _contextGameType.Remove(gameType);
                _response.IsSuccess=true;
                _response.StatusCode=HttpStatusCode.NoContent;
                return Ok(_response);
            }catch(Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages=new List<string> { ex.ToString()} ;
            }
            return _response;
        }
        [HttpPut("{id:int}",Name ="UpdateGameType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult <APIResponse> UpdateGameType(int id,GameTypeUpdateDTO gameTypeUpdateDTO)
        {
            try
            {
                if (gameTypeUpdateDTO==null||id!=gameTypeUpdateDTO.Id)
                {
                    _response.IsSuccess= false;
                    return BadRequest();
                }
                var model = _mapper.Map<GameType>(gameTypeUpdateDTO);
                _contextGameType.Update(model);
                _response.IsSuccess=true;
                _response.StatusCode=HttpStatusCode.NoContent;
                return Ok(_response);
            }catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
    }
}
