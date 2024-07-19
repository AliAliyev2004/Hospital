namespace Hospital;

using System.Collections.Generic;
using System.Numerics;

public class Department
{
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }

    public Department(string name, List<Doctor> doctors)
    {
        Name = name;
        Doctors = doctors;
    }

    public void DisplayDoctors()
    {
        for (int i = 0; i < Doctors.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Doctors[i].FirstName} {Doctors[i].LastName}");
        }
    }
}
