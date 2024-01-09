using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkCRUD.Models
{
    /// <summary>
    /// This is a generic class.
    /// </summary>
    /// <remarks>
    /// This example shows how to specify the <see cref="List{T}"/>
    /// type as a cref attribute.
    /// In generic classes and methods, you'll often want to reference the
    /// generic type, or the type parameter.
    /// </remarks>
    public class EmployeeDTO
    {
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public string job_title { get; set; }

        /// <value>
        /// The <c>Label</c> property represents a label
        /// for this instance.
        /// </value>
        /// <remarks>
        /// The <see cref="Label"/> is a <see langword="string"/>
        /// that you use for a label.
        /// <para>
        /// Note that there isn't a way to provide a "cref" to
        /// each accessor, only to the property itself.
        /// </para>
        /// </remarks>
        public DateTime? hire_date { get; set; }

    }
}