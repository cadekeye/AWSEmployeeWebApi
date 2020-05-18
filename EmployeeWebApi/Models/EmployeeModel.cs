using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Town { get; set; }

        public string PostCode { get; set; }

        public int DepartmentId { get; set; }

        public virtual DepartmentModel Department { get; set; }

        public string FullName
        {
            get
            {
                return string.Join(' ', new string[] { FirstName, LastName });
            }
        }
    }
}