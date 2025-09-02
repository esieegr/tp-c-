using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_C_
{
    public class Disque : Article, IRentable
    {
        public Disque()
        {
            this.price = 6f;
        }
        public float CalculateRent(int number_months)
        {
            return this.price * number_months;
        }

        public override void PublishDetails()
        {
            Console.WriteLine("Un super disque des plus gros hits de l'année !");
        }
    }
}
