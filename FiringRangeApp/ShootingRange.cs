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
            double vat = this.totalCost * 0.23;
            double totalToPay = this.totalCost + vat;

            Console.WriteLine("Total cost of all shots: " + this.totalCost);
            Console.WriteLine("VAT (23%): " + vat);
            Console.WriteLine("Total to pay: " + totalToPay + " PLN");

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Shooting Range Statements";
            Directory.CreateDirectory(folderPath);

            string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt";
            string filePath = folderPath + "\\" + fileName;

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Total cost of all shots: " + this.totalCost);
                writer.WriteLine("VAT (23%): " + vat);
                writer.WriteLine("Total to pay: " + totalToPay + " PLN");
            }
        }
    }
}
