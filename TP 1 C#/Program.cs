using System.Security.Cryptography;
using TP_1_Csharp;

Article A1 = new Article("Lait", 1);
Article A2 = new Article("Fromage", 5);

A1.afficher();
A2.afficher();


Article A3 = new Article();

A3.nouveau();

A3.afficher();