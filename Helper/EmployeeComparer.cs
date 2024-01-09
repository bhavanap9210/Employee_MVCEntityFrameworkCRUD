using MVCEntityFrameworkCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkCRUD.Helper
{
    public class EmployeeComparer : IEqualityComparer<employee>
    {
        public bool Equals(employee x, employee y)
        {
            if (object.ReferenceEquals(x, y)) return true;

            if (x == null && y == null) return false;

            return x.email == y.email &&
                x.first_name == y.first_name &&
                x.last_name == y.last_name &&
                x.salary == y.salary &&
                x.job == y.job &&
                x.department_id == y.department_id &&
                x.manager_id == y.manager_id &&
                x.phone_number == y.phone_number &&
                x.hire_date == y.hire_date;
        }

        public int GetHashCode(employee obj)
        {
            if (obj == null) return 0;

            return obj.employee_id.GetHashCode() ^
                 obj.first_name.GetHashCode() ^
                 obj.last_name.GetHashCode() ^
                 obj.email.GetHashCode() ^
                 obj.salary.GetHashCode() ^
                 obj.email.GetHashCode() ^
                 obj.department_id.GetHashCode() ^
                 obj.manager_id.GetHashCode() ^
                 obj.phone_number.GetHashCode() ^
                 obj.hire_date.GetHashCode();
        }
    }
}