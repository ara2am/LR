using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoMapper;
using DAL;

namespace BLL.Mapper
{
    class Mapper : Profile
    {
        public void MapperConfig()
        {
            CreateMap<BLL.Object.Cafe, DAL.Entities.Cafe>(MemberList.Source).PreserveReferences();
            CreateMap<BLL.Object.CafeInfo, DAL.Entities.CafeInfo>(MemberList.Destination).PreserveReferences();
            CreateMap<BLL.Object.Place, DAL.Entities.Place>(MemberList.Source).PreserveReferences();
            CreateMap<BLL.Object.Worker, DAL.Entities.Worker>(MemberList.Destination).PreserveReferences();
        }
    }
}
