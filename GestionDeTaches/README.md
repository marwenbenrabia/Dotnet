- L’architecture choisie
 
L'application repose sur une architecture MVC avec une structure orientée objet.
Elle est composée des éléments suivants :

- Modèle (Task.cs) : Représente une tâche avec un titre, une priorité et un état d'achèvement.
- Vue (MainForm.cs) : Contient les composants graphiques pour l'ajout, l'affichage, la modification et la suppression des tâches.
- Controller (TaskManager.cs) : Gère la logique métier pour manipuler les tâches (ajout, suppression, modification .. ).
- Persistance des données (DataStorage.cs) : Assure la sauvegarde et le chargement des tâches en JSON/XML.


- Les fonctionnalités implémentées :

L’application devra permettre à l’utilisateur de :
 - Ajouter une tâche avec un titre et un niveau de priorité (Haute, Moyenne, Basse).
 - Afficher la liste des tâches, triées par priorité (Haute en premier, puis Moyenne, puis Basse).
 - Marquer une tâche comme terminée (avec une indication visuelle, par exemple en grisé ou barré).
 - Supprimer une tâche.
 - Sauvegarder et charger les tâches depuis un fichier local (JSON ou XML)

- Les éventuelles limitations :
   
   - Aucun stockage en base de données, uniquement des fichiers locaux (JSON/XML).
   - La gestion des erreurs pourrait être approfondie pour éviter certaines incohérences.
 
