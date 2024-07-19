namespace Hospital;

using System;
using System.Collections.Generic;
using System.Numerics;

public class HospitalL
{
    public List<Department> Departments { get; set; } = new List<Department>();

    public void Initialize()
    {
        Departments.Add(new Department("Pediatriya", new List<Doctor>
        {
            new Doctor("Hekim1", "Soyad1", 10),
            new Doctor("Hekim2", "Soyad2", 5),
            new Doctor("Hekim3", "Soyad3", 7)
        }));

        Departments.Add(new Department("Travmatologiya", new List<Doctor>
        {
            new Doctor("Hekim4", "Soyad4", 12),
            new Doctor("Hekim5", "Soyad5", 6)
        }));

        Departments.Add(new Department("Stomatologiya", new List<Doctor>
        {
            new Doctor("Hekim6", "Soyad6", 8),
            new Doctor("Hekim7", "Soyad7", 9),
            new Doctor("Hekim8", "Soyad8", 4),
            new Doctor("Hekim9", "Soyad9", 15)
        }));
    }

    public void DisplayDepartments()
    {
        for (int i = 0; i < Departments.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Departments[i].Name}");
        }
    }
}
