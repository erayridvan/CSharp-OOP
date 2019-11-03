using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Engine
    {
        private Hospital hospital;

        public Engine()
        {
            this.hospital = new Hospital();
        }

        public void Run()
        {
            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] arguments = command.Split();
                var departament = arguments[0];

                var firstName = arguments[1];
                var secondName = arguments[2];

                var patient = arguments[3];

                var fullName = firstName +" "+ secondName;

                this.hospital.AddDoctor(firstName, secondName);
                this.hospital.AddDepartment(departament);
                this.hospital.AddPatient(departament, fullName, patient);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] arguments = command.Split();

                if (arguments.Length==1)
                {
                    var departmentName = arguments[0];
                    var departament = this.hospital.Departments.FirstOrDefault(de => de.Name == departmentName);

                    Console.WriteLine(departament);
                }
                else
                {
                    bool isRoom = int.TryParse(arguments[1],out int resultRoom);

                    
                    if (isRoom)
                    {
                        var departmentName = arguments[0];
                        var department = this.hospital.Departments.FirstOrDefault(de=>de.Name==departmentName);
                        var currentRoom = department.Rooms[resultRoom - 1];

                        Console.WriteLine(currentRoom);
                    }
                    else
                    {
                        string firstName = arguments[0];
                        string lastName = arguments[1];

                        string fullName = firstName + " " + lastName;

                        var doctor = this.hospital.Doctors.FirstOrDefault(d => d.FullName == fullName);

                        Console.WriteLine(doctor);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}

