using AlxCourseHomework.MaterialsAssignements.Storage;

namespace AlxCourseHomework
{
    public class StorageTest1
    {
        public static void Run()
        {
            var storageService1 = new StorageService();
            var id1 = 1;
            var vat1 = 0.05;
            var netto1 = 3.58;
            var cartons1 = 2;
            var amountPerCarton1 = 10;
            Console.WriteLine($"ID : {id1}");
            Console.WriteLine($"Netto cost : {netto1} PLN");
            Console.WriteLine($"Brutto cost : {storageService1.CalculateVat(netto1, vat1)} PLN");
            Console.WriteLine($"Vat : {vat1 * 100} %");
            Console.WriteLine($"All products in werehouse : {storageService1.AllProducts(cartons1, amountPerCarton1)}");
            Console.WriteLine($"All products cost in werehouse : {Math.Round(storageService1.AllProducts(cartons1, amountPerCarton1) * storageService1.CalculateVat(netto1, vat1), 2)} PLN");
            Console.WriteLine();

            var storageService2 = new StorageService();
            var id2 = 2;
            var vat2 = 0.05;
            var netto2 = 9.61;
            var cartons2 = 5;
            var amountPerCarton2 = 25;
            Console.WriteLine($"ID : {id2}");
            Console.WriteLine($"Netto cost : {netto2} PLN");
            Console.WriteLine($"Brutto cost : {storageService2.CalculateVat(netto2, vat2)} PLN");
            Console.WriteLine($"Vat : {vat2 * 100} %");
            Console.WriteLine($"All products in werehouse : {storageService2.AllProducts(cartons2, amountPerCarton2)}");
            Console.WriteLine($"All products cost in werehouse : {Math.Round(storageService2.AllProducts(cartons2, amountPerCarton2) * storageService2.CalculateVat(netto2, vat2), 2)} PLN");
            Console.WriteLine();

            var storageService3 = new StorageService();
            var id3 = 3;
            var vat3 = 0.08;
            var netto3 = 8.52;
            var cartons3 = 3;
            var amountPerCarton3 = 18;
            Console.WriteLine($"ID : {id3}");
            Console.WriteLine($"Netto cost : {netto3} PLN");
            Console.WriteLine($"Brutto cost : {storageService3.CalculateVat(netto3, vat3)} PLN");
            Console.WriteLine($"Vat : {vat3 * 100} %");
            Console.WriteLine($"All products in werehouse : {storageService3.AllProducts(cartons3, amountPerCarton3)}");
            Console.WriteLine($"All products cost in werehouse : {Math.Round(storageService3.AllProducts(cartons3, amountPerCarton3) * storageService3.CalculateVat(netto3, vat3), 2)} PLN");
            Console.WriteLine();

            var storageService4 = new StorageService();
            var id4 = 4;
            var vat4 = 0.08;
            var netto4 = 10.25;
            var cartons4 = 6;
            var amountPerCarton4 = 36;
            Console.WriteLine($"ID : {id4}");
            Console.WriteLine($"Netto cost : {netto4} PLN");
            Console.WriteLine($"Brutto cost : {storageService4.CalculateVat(netto4, vat4)} PLN");
            Console.WriteLine($"Vat : {vat4 * 100} %");
            Console.WriteLine($"All products in werehouse : {storageService4.AllProducts(cartons4, amountPerCarton4)}");
            Console.WriteLine($"All products cost in werehouse : {Math.Round(storageService4.AllProducts(cartons4, amountPerCarton4) * storageService4.CalculateVat(netto4, vat4), 2)} PLN");
            Console.WriteLine();

            var storageService5 = new StorageService();
            var id5 = 5;
            var vat5 = 0.23;
            var netto5 = 6.17;
            var cartons5 = 1;
            var amountPerCarton5 = 4;
            Console.WriteLine($"ID : {id5}");
            Console.WriteLine($"Netto cost : {netto5} PLN");
            Console.WriteLine($"Brutto cost : {storageService4.CalculateVat(netto5, vat5)} PLN");
            Console.WriteLine($"Vat : {vat5 * 100} %");
            Console.WriteLine($"All products in werehouse : {storageService5.AllProducts(cartons5, amountPerCarton5)}");
            Console.WriteLine($"All products cost in werehouse : {Math.Round(storageService5.AllProducts(cartons5, amountPerCarton5) * storageService5.CalculateVat(netto5, vat5), 2)} PLN");
            Console.WriteLine();
        }
    }
}
