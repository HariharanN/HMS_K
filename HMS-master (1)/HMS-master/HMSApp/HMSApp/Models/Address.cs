using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMSApp.Models
{
    /// <summary>
    /// Entity to hold the address information
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Address Line 1
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address Line 2
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Zip Code
        /// </summary>
        public int ZipCode { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Day Time Phone number
        /// </summary>
        public int DayPhoneNumber { get; set; }

        /// <summary>
        /// Mobile Number
        /// </summary>
        public int MobileNumber { get; set; }

        public string Email
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

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
    }
}