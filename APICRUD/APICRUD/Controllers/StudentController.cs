using APICRUD.Models.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICRUD.Controllers
{
    public class StudentController : ApiController
    {
        DemoDBEntities1 _db = new DemoDBEntities1();


        //public IHttpActionResult GetAll()
        //{
        //    //List<Dept> dp = _db.Depts.ToList();
        //    //List<Student> st = _db.Students.ToList();

        //    //var data = (from n in _db.Students where n.DId == n.Dept.deptId select n).FirstOrDefault();
        //    //return Ok(data);

        //}
        public StudentController()
        {
            _db.Configuration.ProxyCreationEnabled = false;
        }

        public IEnumerable<Student> Get()
        {
            //var data = _db.Depts.ToList();
            return _db.Students.ToList();
        }

        public string Post(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return "Students added";
        }

        public Student Get(int id)
        {
            Student student = _db.Students.Find(id);
            return student;
        }

    }
}
