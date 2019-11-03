﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Room
    {
        public Room()
        {
            this.Patients = new List<Patient>();
        }

        public bool isFull => this.Patients.Count >= 3;

        public List<Patient> Patients { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var patient in this.Patients.OrderBy(p => p.Name))
            {
                sb.AppendLine(patient.Name);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
