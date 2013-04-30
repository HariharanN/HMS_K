using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMSApp.Models
{
    /// <summary>
    /// Department Information
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Department code
        /// </summary>
        public string DepartmentCode { get; set; }

        /// <summary>
        /// Department Name
        /// </summary>
        public string DepartmentName { get; set; }

        public long DeptId
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public long DeptHead
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}