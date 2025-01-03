﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SlidersController(ISliderService sliderService)
        {
            this._sliderService = sliderService;
        }
        [HttpGet]
        public IActionResult SliderList()
        {
            return Ok( _sliderService.TGetListAll());
        }
    }
}
