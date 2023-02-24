using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Product product) 
        {


            Console.WriteLine("Sepete Eklendi! : " + product.Adi + " : " + product.Stok);

        }
    }
}
