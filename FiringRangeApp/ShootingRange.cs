namespace FiringRangeApp
{
    internal class ShootingRange
    {
        private List<Weapon> weapons;
        private double totalCost;

        public ShootingRange()
        {
            this.weapons = new List<Weapon>();
            this.totalCost = 0;
        }

        public void AddWeapon(Weapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public void CalculateTotalCost()
        {
            foreach (Weapon weapon in this.weapons)
            {
                this.totalCost += weapon.CostPerShot * weapon.ShotsFired;
            }
        }

        public void EnterShots()
        {
            Console.WriteLine("Enter the number of shots for each weapon:");
            foreach (Weapon weapon in this.weapons)
            {
                Console.Write(weapon.Name + ": ");
                int shots = int.Parse(Console.ReadLine());
                weapon.ShotsFired = shots;
            }
        }

        public void PrintStatement()
        {
            CalculateTotalCost();
            double vat = this.totalCost * 0.15;
            double totalToPay = this.totalCost + vat;

            // Create a new folder on the desktop to store the statements
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Shooting Range Statements";
            Directory.CreateDirectory(folderPath);

            // Generate a unique file name for the statement
            string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt";
            string filePath = folderPath + "\\" + fileName;

            // Write the statement to the text file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Total cost of all shots: " + this.totalCost);
                writer.WriteLine("VAT (15%): " + vat);
                writer.WriteLine("Total to pay: " + totalToPay);
            }
        }
    }
}
