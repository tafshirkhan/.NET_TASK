using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N_TIER_WEB_API.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/Student/GetAll")]
        public List<StudentsModel> GetAllStudents()
        {
           return StudentService.GetAllStudents();
        }

        [Route("api/Student/{id}")]
        public StudentsModel GetStudent(int id)
        {
            return StudentService.GetStudent(id);
        }

        [Route("api/Student/Add")]
        public void AddStudent(StudentsModel model)
        {
            StudentService.AddStudent(model);
        }

        [Route("api/Student/Names")]
        public List<string> GetStudentsNames()
        {
            return StudentService.GetStudentsNames();
        }
    }
}
