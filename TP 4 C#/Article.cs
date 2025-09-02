using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_C_
{
    public class Article : Publication
    {

        protected float price = 0f;
        public Article()
        {

        }

        public override void PublishDetails()
        {
        }

        public delegate float DiscountStrategy(Article article);

        public static float AfficherRemise25(Article article)
        {

            Console.WriteLine($"remise de 25% : {(article.price * 0.75f)}euro");

            return article.price * 0.75f;
        }

        public static float AfficherRemise20(Article article)
        {

            Console.WriteLine($"remise de 20% : {(article.price * 0.80f)}euro");

            return article.price * 0.80f;
        }

    }
}
