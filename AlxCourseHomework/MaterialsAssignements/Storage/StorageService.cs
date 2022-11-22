namespace AlxCourseHomework.MaterialsAssignements.Storage
{
    internal class StorageService
    {
        public double CalculateVat(double netto, double vat)
        {
            var bruttoCost = vat * netto + netto;
            return Math.Round(bruttoCost, 2);
        }

        public int AllProducts(int cartons, int amountPerCarton)
        {
            return cartons * amountPerCarton;
        }
    }
}
