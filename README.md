### Gianni RUGGIERO

# Qu’apporte un ORM comme Entity Framework par rapport à des requêtes SQL écrites à la main ?

Abstraction : manipulation des objets C# (Student, Course), pas des lignes de tables SQL.

Productivité : pas besoin d’écrire les INSERT, UPDATE, DELETE à la main, EF les génère automatiquement à partir des entités.

Évolutivité : avec les migrations, le schéma de la BDD évolue en même temps que le code.

Sécurité : EF paramètre les requêtes donc moins de risques d’injections SQL.

Portabilité : il est possible de changer de SGBD (SQLite, SQL Server, PostgreSQL…) en changeant juste le provider.
Concentration accrue sur la logique métier plutôt que sur la syntaxe SQL.

# Pourquoi utiliser un DbContext ?

C’est la porte d’entrée vers la base de données dans EF.

Il expose les DbSet<TEntity> (comme Students, Courses) qui représentent les tables.

Il garde une unité de travail : il suit les entités qu'on charge/modifie, et sait générer les requêtes SQL correspondantes quand on fait SaveChanges().

Il gère la connexion à la DB, la configuration (provider, chemin DB, options), et le mapping entre classes C#, tables SQL.
Sans DbContext, pas de “couche intermédiaire” entre le code objet et la DB.

# Que se passe-t-il si on supprime EnsureCreated() ?

EnsureCreated() fait en sorte que si la DB n’existe pas encore, EF la crée ainsi que les tables définies par le modèle.

Si on le supprimes :

Si la DB existe déjà et a été créée par une migration, rien.

Si la DB n’existe pas encore il y auras des erreurs no such table car aucune table n’est générée.

