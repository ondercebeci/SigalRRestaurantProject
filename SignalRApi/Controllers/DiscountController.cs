﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            var value = _mapper.Map<Discount>(createDiscountDto);
            value.status = false;
            _discountService.TAdd(value);
            return Ok("İletişim Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("İndirim Silindi");
        }
        [HttpGet("id")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var value = _mapper.Map<Discount>(updateDiscountDto);
            value.status = false;
            _discountService.TUpdate(value);
            return Ok("İndirim Güncellendi");
        }
        [HttpGet("ChangeStatusToTrue/{id}")]
        public IActionResult ChangeStatusToTrue(int id)
        {
            _discountService.TChangeStatusToTrue(id);
            return Ok("İndirim Durumu Değiştiildi");
        }
        [HttpGet("ChangeStatusToFalse/{id}")]
        public IActionResult ChangeStatusToFalse(int id)
        {
            _discountService.TChangeStatusToFalse(id);
            return Ok("İndirim Durumu Değiştiildi");
        }
        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            
            return Ok(_discountService.TGetListByStatusTrue());
        }
    }
}
