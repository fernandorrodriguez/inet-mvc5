using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea.Models
{
    public class EmployeesModel
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string ReportsTo { get; set; }
    }
}