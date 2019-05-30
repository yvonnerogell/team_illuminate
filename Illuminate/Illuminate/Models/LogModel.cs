using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Illuminate.Models
{
    public class LogModel
    {
        // The ID of the result
        public string ResultID { get; set; } = Guid.NewGuid().ToString();

        // The test result sent by the phone, TSB level in mg/dl in .5 increments
        public double TSBResult { get; set; }

        // The date and time the test result was recorded by the phone
        public DateTime ResultDateTime { get; set; }

        // ID of the clinic at which the test result was recorded
        public int ClinicID { get; set; }

        // The baby's age in hours at the time the test result was recorded
        public int BabyAgeHours { get; set; }

    }
}

