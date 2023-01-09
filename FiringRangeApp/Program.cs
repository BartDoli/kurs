using FiringRangeApp;

class Program
{
    static void Main(string[] args)
    {
        ShootingRange range = new ShootingRange();

        // Add weapons to the shooting range
        range.AddWeapon(new Weapon("Glock", 1.5));
        range.AddWeapon(new Weapon("Rifle", 5));
        range.AddWeapon(new Weapon("Shotgun", 4));
        range.AddWeapon(new Weapon("AK-47", 2.5));
        range.AddWeapon(new Weapon("Bow", 8));

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
