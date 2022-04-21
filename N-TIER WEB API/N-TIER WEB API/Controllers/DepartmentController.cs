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
    public class DepartmentController : ApiController
    {
        [Route("api/Department/Names")]
        [HttpGet]

        public List<string> GetNames()
        {
            return DepartmentService.GetDepartmentNames();
        }

        [Route("api/Department/GetAll")]
        [HttpGet]
        public List<DepartmentModel> GetAllDepartments()
        {
            return DepartmentService.GetDepartments();
        }

        [Route("api/Department/Add")]
        [HttpPost]
        public void Add(DepartmentModel dept)
        {
            DepartmentService.AddDepartments(dept);
        }

        [Route("api/Department/All/Details")]
        public List<DepartmentDetails> GetDepartmentWithDetails()
        {
            return DepartmentService.GetDepartmentWithDetails();
        }

        [Route("api/Department/{id}/Details")]
        public DepartmentDetails GetDepartmentDetails(int id)
        {
            return DepartmentService.GetDepartmentDetails(id);
        }
    }
}
