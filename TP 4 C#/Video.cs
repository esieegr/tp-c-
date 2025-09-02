using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_C_
{
    public class Video : Article, IRentable
    {
        public Video()
        {
            this.price = 7f;
        }
        public float CalculateRent(int number_months)
        {
            return this.price * number_months;
        }

        public override void PublishDetails()
        {
            Console.WriteLine("Top 10 des châteaux de France.");
        }
    }
}
