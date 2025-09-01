using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_Csharp
{
    public class Article
    {
        private string nom = "";
        private int quantité = 0;

        public Article() { }

        public Article(string nom, int quantité)
        {
            this.nom = nom;
            this.quantité = quantité;
        }

        public void afficher ()
        {
            Console.WriteLine("Article : " + this.nom + " Quantité : " + this.quantité);

        }

        public void ajouter()
        {
            this.quantité++;
        }

        public void retirer()
        {
            this.quantité--;
        }

        public void nouveau()
        {
            Console.WriteLine("Entrez le nom de l'article : ");
            this.nom = Console.ReadLine();

            Console.WriteLine("Entrez la quantité : ");
                this.quantité = int.Parse(Console.ReadLine());
        }
    }
}
