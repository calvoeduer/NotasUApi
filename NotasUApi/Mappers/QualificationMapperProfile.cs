using AutoMapper;
using NotasUApi.Model;
using NotasUApi.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Mappers
{
    public class QualificationMapperProfile : Profile
    {
        public QualificationMapperProfile()
        {
            CreateMap<SubjectInputModel, Subject>();
            CreateMap<SubjectEditModel, Subject>();
            CreateMap<Subject, SubjectViewModel>();

            CreateMap<Qualification, QualificationViewModel>();

            CreateMap<ActivityInputModel, Activity>();
            CreateMap<ActivityEditModel, Activity>();
            CreateMap<Activity, ActivityViewModel>();
        }
    }
}
