using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepo
    {
        static StudentMSEntities context;
        static DepartmentRepo()
        {
            context = new StudentMSEntities();
        }
        public static List<string> GetDepartmentNames()
        {
            var data = context.Departments.Select(s => s.Name).ToList();
            return data;
        }

        public static List<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }

        public static void AddDepartments(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }

        public static Department GetDepartmentDetails(int id)
        {
           return context.Departments.FirstOrDefault(d => d.Id == id);
        }
    }
}
