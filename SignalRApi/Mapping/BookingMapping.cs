﻿using AutoMapper;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntitiLayer.Entities;

namespace SignalRApi.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
        }
    }
}
