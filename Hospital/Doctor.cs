namespace Hospital;

using System.Collections.Generic;

public class Doctor
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Experience { get; set; }
    public List<AppointmentSlot> AppointmentSlots { get; set; }

    public Doctor(string firstName, string lastName, int experience)
    {
        FirstName = firstName;
        LastName = lastName;
        Experience = experience;
        AppointmentSlots = new List<AppointmentSlot>
        {
            new AppointmentSlot("09:00-11:00"),
            new AppointmentSlot("12:00-14:00"),
            new AppointmentSlot("15:00-17:00")
        };
    }

    public void DisplayAppointmentSlots()
    {
        for (int i = 0; i < AppointmentSlots.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {AppointmentSlots[i].TimeSlot} - {(AppointmentSlots[i].IsBooked ? "Rezerv olunub" : "Rezerv olunmayıb")}");
        }
    }
}
