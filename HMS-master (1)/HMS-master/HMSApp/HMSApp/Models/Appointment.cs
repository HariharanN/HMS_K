using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMSApp.Models
{
    /// <summary>
    /// Entity to Hold the Appointment Information
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Appointment Time
        /// </summary>
        public DateTime AppointmentTime { get; set; }

        public long PatientId
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public long UserId
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Observation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Prescription
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