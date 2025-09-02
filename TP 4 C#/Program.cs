using System.Collections.Generic;
using TP_4_C_;

List<Article> articles = new List<Article>();

Disque D1 = new Disque();
Livre L1 = new Livre();
Video V1 = new Video();

articles.Add(D1);
articles.Add(L1);
articles.Add(V1);


foreach (IRentable article in articles)
{
    Console.WriteLine("Article pour 6 mois : " + article.CalculateRent(6) + "euro");
}


List<Publication> publications = new List<Publication>();

publications.Add(new Disque());
publications.Add(new Livre());
publications.Add(new Video());

foreach (Publication pub in publications)
{
    pub.PublishDetails();
}

Article.DiscountStrategy strat25 = a => Article.AfficherRemise25(a);
Article.DiscountStrategy strat20 = a => Article.AfficherRemise20(a);

strat25(D1);
strat20(D1);
