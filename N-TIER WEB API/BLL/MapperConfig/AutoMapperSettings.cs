﻿using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<Department, DepartmentModel>();
            CreateMap<Department, DepartmentDetails>();
            //CreateMap<Student, StudentsModel>();
            CreateMap<StudentsModel, Student>().ForMember(e=>e.Department, sm=>sm.Ignore());
        }
    }
}
