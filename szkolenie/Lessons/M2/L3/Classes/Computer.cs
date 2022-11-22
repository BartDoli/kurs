namespace course_alx.Lessons.M2.L3.Classes
{
    public class Computer
    {
        private string _brand;
        public string Brand
        {
            get 
            {
                Console.WriteLine($"Getting computer brand.");
                return _brand; 
            }
            set 
            { 
                Console.WriteLine($"Getting computer brand as {value}");
                _brand = value; 
            }
        }

        public string Name { get; set; }

        private double? _procesorFrequency;

        public double? ProcesorFrequency
        {
            get
            {
                Console.WriteLine("Getting processor clock frequency [GHz] ... ");
                return _procesorFrequency;
            }
            set 
            { 
                if (value > 0 && value < 4)
                {
                    Console.WriteLine($"Setting computer's processor clock frequency as {value} [GHz].");
                    _procesorFrequency = value;
                }
                else
                {
                    Console.WriteLine("Invalid processor frequency value!");
                }
            }
        }
        public int NumberOfCores { get; set; }
    }
}
