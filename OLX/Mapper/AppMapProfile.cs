using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OLX.Entities;
using OLX.ViewModels;

namespace OLX.Mapper
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<DbUser, UserItemViewModel>();
        }
    }
}
