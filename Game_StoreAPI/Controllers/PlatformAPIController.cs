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
    [Route("api/PlatformAPI")]
    [ApiController]
    public class PlatformAPIController : ControllerBase
    {
        private readonly IPlatformRepository _contextPlatform;
        private readonly IMapper _mapper;
        protected APIResponse _response;
        public PlatformAPIController(IPlatformRepository contextPlatform, IMapper mapper)
        {
            _contextPlatform = contextPlatform;
            _mapper = mapper;
            this._response= new APIResponse();
        }
        [HttpGet]
        [ResponseCache(Duration =30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> GetPlatforms() 
        {
            try
            {
                IEnumerable<Platform> platforms=_contextPlatform.GetAll();
                _response.Result = _mapper.Map<List<PlatformDTO>>(platforms);
                _response.IsSuccess=true;
                _response.StatusCode=HttpStatusCode.OK;
                return Ok(_response);
            }catch (Exception ex) 
            {
                _response.IsSuccess=false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpGet("{id:int}",Name ="GetPlatform")]
        [ResponseCache(Duration =30)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> GetPlatform(int id)
        {
            try
            {
                if (id==0)
                {
                    _response.IsSuccess = false;
                    return BadRequest();
                }
                var platfotm=_contextPlatform.Get(n=>n.Id==id);
                if (platfotm==null)
                {
                    _response.IsSuccess=false;
                    return NotFound();
                }
                _response.Result=_mapper.Map<PlatformDTO>(platfotm);
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
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> CreatePlatform(PlatformCreateDTO platformCreateDTO)
        {
            try
            {
                if (_contextPlatform.Get(n=>n.Name.ToLower()==platformCreateDTO.Name.ToLower()) != null)
                {
                    ModelState.AddModelError("Error Message", "This Name of platform is already exist");
                    _response.IsSuccess = false;
                    return BadRequest(ModelState);
                }
                if (platformCreateDTO==null)
                {
                    _response.IsSuccess = false;
                    return BadRequest(platformCreateDTO);
                }
                var model = _mapper.Map<Platform>(platformCreateDTO);
                _contextPlatform.Create(model);
                _response.Result = _mapper.Map<PlatformDTO>(model);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetPlatform", new { id = model.Id }, _response);
            }catch(Exception ex) 
            {
                _response.IsSuccess=false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;

        }
        [HttpDelete("{id:int}",Name ="DeletePlatform")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> DeletePlatform(int id)
        {
            try
            {
                if (id==0)
                {
                    _response.IsSuccess= false;
                    return BadRequest();
                }
                var platform = _contextPlatform.Get(n => n.Id == id);
                if (platform==null) 
                {
                    _response.IsSuccess= false;
                    return NotFound();
                }
                _contextPlatform.Remove(platform);
                _response.IsSuccess = true;
                _response.StatusCode= HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPut("{id:int}",Name ="UpdatePlatform")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<APIResponse> UpdatePlatform(int id,PlatformDTO platformDTO)
        {
            try
            {
                if (platformDTO == null || id != platformDTO.Id)
                {
                    _response.IsSuccess = false;
                    return BadRequest();
                }
                var model = _mapper.Map<Platform>(platformDTO);
                _contextPlatform.Update(model);
                _response.IsSuccess = true;
                _response.StatusCode = HttpStatusCode.NoContent;
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
