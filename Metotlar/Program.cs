namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyat = 15;
            product1.Aciklama = "Amasya";
            product1.Stok = 1;

            Product product2 = new Product();
            product2.Adi = "Armut";
            product2.Fiyat = 23;
            product2.Aciklama = "En iyisi";
            product2.Stok = 2;

            Product product3 = new Product();
            product3.Adi = "Çilek";
            product3.Fiyat = 78;
            product3.Aciklama = "Dağ Çileği";
            product3.Stok = 13;



            Product[] products = new Product[] {product1, product2, product3};

            foreach (Product product in products)
            {
                Console.WriteLine(".........");
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(".........");


            }

            Console.WriteLine("..............Metotlar..........");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);    
        }
    }
}