namespace Hospital;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public void CollectUserInfo()
    {
        Console.Write("Adınız: ");
        FirstName = Console.ReadLine();
        Console.Write("Soyadınız: ");
        LastName = Console.ReadLine();
        Console.Write("Email: ");
        Email = Console.ReadLine();
        Console.Write("Telefon: ");
        Phone = Console.ReadLine();
    }
}

