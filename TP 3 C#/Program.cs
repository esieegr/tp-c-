
using TP3_C_;


ArticleTableau articleTab = new ArticleTableau();

ArticleType A1 = new ArticleType();
A1.nouveau();
articleTab.ajouter(A1);

ArticleType A2 = new ArticleType();
A2.nouveau();
articleTab.ajouter(A2);

ArticleType A3 = new ArticleType();
A3.nouveau();
articleTab.ajouter(A3);

articleTab.afficher();

Console.WriteLine("Suppression du premier article du tableau.");
articleTab.supprimer(A1);
articleTab.afficher();


Console.WriteLine("Avec Indexeur");
articleTab[1].afficher();
