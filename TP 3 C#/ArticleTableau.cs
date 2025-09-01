using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_C_
{
    public class ArticleTableau
    {

        private List<ArticleType> articleTab;
        public ArticleTableau() {
            articleTab = new List<ArticleType>();
        }

        public void ajouter(ArticleType input)
        {
            this.articleTab.Add(input);
        }

        public void supprimer(ArticleType input)
        {
            this.articleTab.Remove(input);
        }

        public void afficher()
        {
            foreach (ArticleType i in articleTab)
            {
                i.afficher();
            }
        }

        public ArticleType this[int i]
        {
            get => articleTab[i];
            set => articleTab[i] = value;
        }

    }
}
