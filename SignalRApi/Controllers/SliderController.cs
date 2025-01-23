using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntitiLayer.Entities;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _SliderService;
        private readonly IMapper _mapper;

        public SliderController(ISliderService sliderService, IMapper mapper)
        {
            _SliderService = sliderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SliderList()
        {
            var value = _mapper.Map<List<ResultSliderDto>>(_SliderService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            var value = _mapper.Map<Slider>(createSliderDto);
            _SliderService.TAdd(value);
            return Ok("Öne Çıkan Alan Bilgisi  Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSlider(int id)
        {
            var value = _SliderService.TGetByID(id);
            _SliderService.TDelete(value);
            return Ok("Öne Çıkan Alan Bilgisi  Silindi");
        }
        [HttpGet("id")]
        public IActionResult GetSlider(int id)
        {
            var value = _SliderService.TGetByID(id);
            return Ok(_mapper.Map<GetSliderDto>(value));
        }
        [HttpPut]
        public IActionResult UpdateSlider(UpdaTeSliderDto updaTeSliderDto)
        {
            var value = _mapper.Map<Slider>(updaTeSliderDto);
            _SliderService.TUpdate(value);
            return Ok("Öne Çıkan Alan Bilgisi Güncellendi");
        }
    }
}
