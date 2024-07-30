using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mango.Service.CouponAPI.Data;
using Mango.Service.CouponAPI.Models;
using Mango.Service.CouponAPI.Models.Dto;
using AutoMapper;

namespace Mango.Service.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _context;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public CouponAPIController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _responseDto = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet]
        public ResponseDto Get() {
            try
            {
                IEnumerable<Coupons> objList = _context.Coupons.ToList();
                _responseDto.Result = _mapper.Map<IEnumerable<CouponsDTO>>(objList);
            }
            catch (Exception ex) 
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Coupons objList = _context.Coupons.First(u=>u.CouponId==id);
                _responseDto.Result = _mapper.Map<CouponsDTO>(objList);
 
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }

        [HttpGet]
        [Route("GetbyCode/{code}")]
        public ResponseDto GetbyCode(string code)
        {
            try
            {
                Coupons objList = _context.Coupons.First(u=>u.CouponCode.ToLower()==code.ToLower());
                _responseDto.Result = _mapper.Map<CouponsDTO>(objList);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] CouponsDTO couponsDTO)
        {
            try
            {
                Coupons coupons = _mapper.Map<Coupons>(couponsDTO);
                _context.Coupons.Add(coupons);
                _context.SaveChanges();
                _responseDto.Result = _mapper.Map<CouponsDTO>(coupons);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }

        [HttpPut]
        public ResponseDto Put([FromBody] CouponsDTO couponsDTO)
        {
            try
            {
                Coupons coupons = _mapper.Map<Coupons>(couponsDTO);
                _context.Coupons.Update(coupons);
                _context.SaveChanges();
                _responseDto.Result = _mapper.Map<CouponsDTO>(coupons);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }

        [HttpDelete]
        public ResponseDto Delete(int id)
        {
            try
            {
                Coupons coupons = _context.Coupons.First(u=>u.CouponId==id);
                _context.Coupons.Remove(coupons);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }
    }
}
