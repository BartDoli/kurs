using FiringRangeApp;

class Program
{
    static void Main(string[] args)
    {
        ShootingRange range = new ShootingRange();

        // Add weapons to the shooting range
        range.AddWeapon(new Weapon("Pistol", 10));
        range.AddWeapon(new Weapon("Rifle", 15));
        range.AddWeapon(new Weapon("Shotgun", 20));

        bool continueEntering = true;
        while (continueEntering)
        {
            range.EnterShots();

            Console.WriteLine("Enter more shots? (Y/N)");
            string input = Console.ReadLine();
            if (input.ToUpper() == "N")
            {
                continueEntering = false;
            }
        }

        range.PrintStatement();
    }
}
