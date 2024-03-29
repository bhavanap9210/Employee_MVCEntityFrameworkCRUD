//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCEntityFrameworkCRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee :IEquatable<employee>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            this.dependents = new HashSet<dependent>();
            this.employees1 = new HashSet<employee>();
        }
    
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public System.DateTime hire_date { get; set; }
        public int job_id { get; set; }
        public decimal salary { get; set; }
        public Nullable<int> manager_id { get; set; }
        public Nullable<int> department_id { get; set; }
    
        public virtual department department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dependent> dependents { get; set; }
        public virtual job job { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee> employees1 { get; set; }
        public virtual employee employee1 { get; set; }

        public bool Equals(employee obj)
        {
            if (object.ReferenceEquals(this, obj)) return true;

            if (obj == null) return false;

            return this.email == obj.email &&
                this.first_name == obj.first_name &&
                this.last_name == obj.last_name &&
                this.salary == obj.salary &&
                this.job == obj.job &&
                this.department_id == obj.department_id &&
                this.manager_id == obj.manager_id &&
                this.phone_number == obj.phone_number &&
                this.hire_date == obj.hire_date;
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
