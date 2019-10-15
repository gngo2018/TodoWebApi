using System;
using AutoMapper;
using TodoBusinessLayer.DataContract.Todo;
using TodoData.Entities;
using TodoWebApi.DataContract.Todo;

namespace TodoWebApi.MappingProfiles
{
    public class TodoMappingProfile : Profile
    {
        public TodoMappingProfile()
        {
            //Post Mapping
            CreateMap<TodoCreateRequest, TodoCreateDTO>();
            CreateMap<TodoCreateDTO, TodoCreateRAO>();
            CreateMap<TodoCreateRAO, TodoDataModel>();

            //Get Mapping
            CreateMap<TodoDataModel, TodoGetListItemRAO>();
            CreateMap<TodoGetListItemRAO, TodoGetListItemDTO>();
            CreateMap<TodoGetListItemDTO, TodoGetListItemResponse>();
        }
    }
}
