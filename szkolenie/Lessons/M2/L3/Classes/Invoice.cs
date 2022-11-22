namespace course_alx.Lessons.M2.L3.Classes
{
    public class Invoice
    {
        public int ID { get; set; }
        public string CustumerName { get; set; }
        public int NIP { get; set; }
        public double BruttoAmount { get; set; }
        public double NettoAmount { get; set; }

        public void PresentInvoice()
        {
            Console.WriteLine($"[Invoice] ID : {ID} ");
            Console.WriteLine($"Custumer Name : {CustumerName}");
            Console.WriteLine($"NIP : {NIP}");
            Console.WriteLine($"Income (Brutto) : {BruttoAmount}");
            Console.WriteLine($"Income (Netto) : {NettoAmount}");
        }
    }
}
