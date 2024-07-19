namespace Hospital;

public class AppointmentSlot
{
    public string TimeSlot { get; set; }
    public bool IsBooked { get; set; }
    public User BookedBy { get; set; }

    public AppointmentSlot(string timeSlot)
    {
        TimeSlot = timeSlot;
        IsBooked = false;
    }

    public void BookSlot(User user)
    {
        IsBooked = true;
        BookedBy = user;
    }
}
