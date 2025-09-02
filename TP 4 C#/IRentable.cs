using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_C_
{
    public interface IRentable
    {
        public float CalculateRent(int number_months)
        {
            float day_price = 0f;
            return day_price * number_months;
        }
    }
}
