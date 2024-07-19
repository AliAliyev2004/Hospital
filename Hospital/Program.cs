using Hospital;
using System;

class Program
{
    static void Main()
    {
        HospitalL hospital=new HospitalL();
        hospital.Initialize();

        while (true)
        {
            User user = new User();
            user.CollectUserInfo();

            Console.WriteLine("sobe secin:");
            hospital.DisplayDepartments();
            int departmentChoice = int.Parse(Console.ReadLine());
            Department selectedDepartment = hospital.Departments[departmentChoice - 1];

            Console.WriteLine("hekim secin:");
            selectedDepartment.DisplayDoctors();
            int doctorChoice = int.Parse(Console.ReadLine());
            Doctor selectedDoctor = selectedDepartment.Doctors[doctorChoice - 1];

            Console.WriteLine("Qebulu rezerv etmek ucun saat secin:");
            int slotChoice = int.Parse(Console.ReadLine());

            if (selectedDoctor.AppointmentSlots[slotChoice - 1].IsBooked)
            {
                Console.WriteLine("Bu vaxt artıq rezerv olunub, zehmet olmasa basqa bir vaxt secin.");
            }
            else
            {
                selectedDoctor.AppointmentSlots[slotChoice - 1].BookSlot(user);
                Console.WriteLine($"Teşekkurler {user.FirstName} {user.LastName}, siz saat {selectedDoctor.AppointmentSlots[slotChoice - 1].TimeSlot}-de {selectedDoctor.FirstName} hekimin qebuluna yazıldınız.");
            }
        }
    }
}
