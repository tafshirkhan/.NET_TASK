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
    public class DepartmentController : ApiController
    {
        DemoDBEntities1 _db = new DemoDBEntities1();

        public DepartmentController()
        {
            _db.Configuration.ProxyCreationEnabled = false;
        }

        public IEnumerable<Dept> Get()
        {
            //var data = _db.Depts.ToList();
            return _db.Depts.ToList(); 
        }

        public string Post(Dept dept)
        {
            _db.Depts.Add(dept);
            _db.SaveChanges();
            return "Dept added";
        }


        public Dept Get(int id)
        {
           Dept dept = _db.Depts.Find(id);
            return dept;
        }

        public string Put(int id, Dept dept)
        {
            var _dept = _db.Depts.Find(id);
            _dept.deptName = dept.deptName;

            //_db.Entry(_dept).CurrentValues.SetValues(dept);
            _db.Entry(_dept).State = EntityState.Modified;
            _db.SaveChanges();
            return "Updated successful";
        }


        public string Delete(int id)
        {
            Dept dept = _db.Depts.Find(id);
            _db.Depts.Remove(dept);
            _db.SaveChanges();
            return "Deleted";
        }

        //public Dept Get(int id)
        //{
        //    var data = _db.Depts
        //}


    }
}
