using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_C_
{
    public class ArticleType
    {

        private string nom = "Aucun";
        private int quantité = 0;
        private string type = "Aucun";
        private string[] types = { "alimentaire", "droguerie", "habillement", "loisir" };

        public ArticleType() { }
        public ArticleType(string nom, int quantité, string type)
        {
            this.nom = nom;
            this.quantité = quantité;

            if (types.Contains(type)){
                this.type = type;
            }
        }


        public void afficher()
        {
            Console.WriteLine("Type : " + this.type + " Nom : " + this.nom + " Quantité : " + this.quantité);
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
            Console.WriteLine("Sélectionnez un type :");

            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine(i + ") " + types[i]);
            }

            string answer = Console.ReadLine();

            this.type = types[Convert.ToInt32(answer)];

            Console.WriteLine("Entrez le nom : ");

            this.nom = Console.ReadLine();

            Console.WriteLine("Entrez une quantité : ");
            this.quantité = Convert.ToInt32(Console.ReadLine());



        }
    }
}
