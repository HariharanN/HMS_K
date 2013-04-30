using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMSApp.Models
{
    /// <summary>
    /// Entity to hold user information
    /// </summary>
    public class User
    {
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Middle Inital
        /// </summary>
        public string MiddleInitial { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// User Type
        /// </summary>
        public UserType UserType { get; set; }

        public long AddressId
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Password
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

    /// <summary>
    /// User Type Enum
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// Admin User
        /// </summary>
        Admin,
        /// <summary>
        /// Front Office Staff
        /// </summary>
        FrontOffice,
        /// <summary>
        /// UserId
        /// </summary>
        Physician
    }
}