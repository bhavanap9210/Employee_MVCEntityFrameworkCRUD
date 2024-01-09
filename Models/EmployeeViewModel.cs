using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkCRUD.Models
{
    public class EmployeeViewModel
    {
        public EmployeeDTO EmployeeSearchDTO { get; set; }
        public  List<EmployeeDTO> EmployeeDTO { get; set; }

    }
}