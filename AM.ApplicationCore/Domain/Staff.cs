﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime? EmploymentDate { get; set; }
        public string? Function { get; set; }
        public float? Salary { get; set; }


        public override string? ToString()
        {
            return base.ToString();
        }

        public override void PassengerType() {
            base.PassengerType();
            Console.WriteLine(" I'am a Staff Memeber");
        }

    }
}
