namespace FiringRangeApp
{
    internal class Weapon
    {
        private string name;
        private double costPerShot;
        private int shotsFired;

        public Weapon(string name, double costPerShot)
        {
            this.name = name;
            this.costPerShot = costPerShot;
            this.shotsFired = 0;
        }

        public string Name
        {
            get { return this.name; }
        }

        public double CostPerShot
        {
            get { return this.costPerShot; }
        }

        public int ShotsFired
        {
            get { return this.shotsFired; }
            set { this.shotsFired = value; }
        }
    }
}
