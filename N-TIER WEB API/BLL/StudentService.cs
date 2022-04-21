using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentService
    {
        static StudentService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        }

        public static void AddStudent(StudentsModel model)
        {
            var data = AutoMapper.Mapper.Map<StudentsModel, Student>(model);
            StudentRepo.AddStudent(data);
        }

        public static StudentsModel GetStudent(int id)
        {
            var data = StudentRepo.GetStudent(id);
            var st = AutoMapper.Mapper.Map<Student, StudentsModel>(data);
            return st;
        }

        public static List<StudentsModel> GetAllStudents()
        {
            var data = StudentRepo.GetAllStudents();
            var st = AutoMapper.Mapper.Map<List<Student>, List<StudentsModel>>(data);
            return st;
        }

        public static List<string> GetStudentsNames()
        {
            var data = StudentRepo.GetStudentName();
            return data;
        }
    }
}
