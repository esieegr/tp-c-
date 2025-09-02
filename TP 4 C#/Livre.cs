using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_C_
{
    public class Livre : Article, IRentable
    {
        public Livre()
        {
            this.price = 5f;
        }
        public float CalculateRent(int number_months)
        {
            return this.price * number_months;
        }

        public override void PublishDetails()
        {
            Console.WriteLine("Les meilleurs histoires du moyen âge.");
        }
    }
}

