using AutoMapper;
using Game_StoreAPI.Models;
using Game_StoreAPI.Models.DTO;
using Game_StoreAPI.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Net;

namespace Game_StoreAPI.Controllers
{
    [Route("api/GameCompanyAPI")]
    [ApiController]
    public class GameCompanyAPIController : ControllerBase
    {
        private readonly IGameCompanyRepository _contextGameCompany;
        private readonly IMapper _mapper;
        protected APIResponse _response;
        public GameCompanyAPIController(IGameCompanyRepository contextGameCompany,IMapper mapper)
        {
            _contextGameCompany = contextGameCompany;
            _mapper = mapper;
            this._response= new APIResponse();
        }
        [HttpGet]
        [ResponseCache(Duration =30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> GetGameCompanies()
        {
            try
            {
                var gameCompanies = _contextGameCompany.GetAll();
                _response.Result = _mapper.Map<List<GameCompanyDTO>>(gameCompanies);
                _response.IsSuccess = true;
                _response.StatusCode=HttpStatusCode.OK;
                return Ok(_response);

            }catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages=new List<string> { ex.Message};
            }
            return _response;
        }
        [HttpGet("{id:int}",Name ="GetGameCompany")]
        [ResponseCache(Duration =30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> GetGameCompany(int id)
        {
            try
            {
                if(id==0)
                {
                    _response.IsSuccess = false;
                    return BadRequest();
                }
                var gameCompany=_contextGameCompany.Get(n=>n.Id==id);
                if (gameCompany==null)
                {
                    _response.IsSuccess = false;
                    return NotFound();
                }
                _response.Result=_mapper.Map<GameCompanyDTO>(gameCompany);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }catch(Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages=new List<string> { ex.Message};
            }
            return _response;
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> CreateGameCompany(GameCompanyCreateDTO gameCompanyCreateDTO)
        {
            try
            {
                if (_contextGameCompany.Get(n => n.Name.ToLower() == gameCompanyCreateDTO.Name.ToLower()) != null)
                {
                    ModelState.AddModelError("Error Message", "This Game Comapany name is already exist");
                    _response.IsSuccess = false;
                    return BadRequest(ModelState);
                }
                if (gameCompanyCreateDTO == null)
                {
                    _response.IsSuccess = false;
                    return BadRequest(gameCompanyCreateDTO);
                }
                var model = _mapper.Map<GameCompany>(gameCompanyCreateDTO);
                _contextGameCompany.Create(model);
                _response.IsSuccess = true;
                _response.Result = _mapper.Map<GameCompanyDTO>(model);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetGameCompany", new { id = model.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpDelete("{id:int}",Name ="DeleteGameCompany")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> DeleteGameCompany(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.IsSuccess = false;
                    return BadRequest();
                }
                var gameCompany=_contextGameCompany.Get(n=>n.Id == id);
                if (gameCompany == null) 
                {
                    _response.IsSuccess = false;
                    return NotFound();
                }
                _contextGameCompany.Remove(gameCompany);
                _response.IsSuccess = true;
                _response.StatusCode=HttpStatusCode.NoContent;
                return Ok(_response);
            }catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPut("{id:int}",Name ="UpdateGameCompany")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> UpdateGameCompany(int id,GameCompanyDTO gameCompanyDTO)
        {
            try
            {
                if (gameCompanyDTO == null||gameCompanyDTO.Id !=id)
                {
                    _response.IsSuccess = false;
                    return BadRequest();
                }
                var model=_mapper.Map<GameCompany>(gameCompanyDTO);
                _contextGameCompany.Update(model);
                _response.IsSuccess=true;
                _response.StatusCode=HttpStatusCode.NoContent;
                return Ok(_response);
            }catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
    }
}
