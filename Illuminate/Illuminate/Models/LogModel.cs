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

        // Constructor for Log Model
        // Calls to Initialize to set initial settings
        public LogModel()
        {
            Initialize();
        }

        // Intialize
        // Sets default values as needed by the system
        public void Initialize()
        {
            // None right now...
        }

        // Update fields passed in
        // Updates all fields to be the values passed in
        // Does NOT update the ID field, this allows for the method to be used as part of a copy.
        public bool Update(LogModel data)
        {
            if (data == null)
            {
                return false;
            }

            // Don't update the ID, leave the old on in place
            ResultID = data.ResultID;

            // Update all the other fields
            TSBResult = data.TSBResult;
            ResultDateTime = data.ResultDateTime;
            ClinicID = data.ClinicID;
            BabyAgeHours = data.BabyAgeHours;

            return true;
        }
    }
}

