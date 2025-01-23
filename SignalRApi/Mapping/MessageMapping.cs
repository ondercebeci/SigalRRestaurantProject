﻿using AutoMapper;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntitiLayer.Entities;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class MessageMapping:Profile
    {
        public MessageMapping()
        {
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetMessageDto>().ReverseMap();
            CreateMap<Message, ResultMessageDto>().ReverseMap();
        }
    }
}
