using AutoMapper;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntitiLayer.Entities;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class SliderMapping:Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, UpdaTeSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
        }
    }
}
