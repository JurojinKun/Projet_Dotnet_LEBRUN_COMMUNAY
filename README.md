Question 1 : Modèle (5 pts)

Créer le modèle objet correspondant aux descriptions suivantes (la description est fonctionnelle,
libre à vous de modéliser toutes les classes qui vous paraissent utiles).

• Une personne
    
    -A un id, un nom, un prénom, une date de naissance, un téléphone, une adresse mail
    
    -Appartient à un service (relation 0..1)
    
    -A une liste de rôles (relation n..n)

• Un service a un nom et un id

• Un rôle a un id, un nom, et une liste de personnes (relation n..n)



Question 2 : Formulaires d’édition simples (5 pts)

Sur le modèle de ce qui a été réalisé en cours, créer les contrôleurs, vues liste, vues détail et entrées
de menu permettant de gérer les modèles suivants :

• Personne (sans les relations)

• Service

• Rôle (sans les relations)



Question 3 : Imports (5 pts)

En réutilisant le principe de d’initialisation des données de test vu en cours, vous devrez importer des
données de test pour chaque modèle (personnes, services, rôles, contacts, types)



Question 4 : Formulaires avec relations (5 pts)

Dans cette question, vous devrez enrichir les formulaires d’édition suivants, en permettant la saisie
et la sauvegarde des différentes relations possibles :

• Personne :

    -Service via une liste déroulante
    
    -Rôles via une liste de cases à cocher

• Rôles :

    -Personnes via une liste de cases à cocher

Il n’est pas demandé de pouvoir créer un rôle ou un service depuis le formulaire des personnes, ou
réciproquement, de créer une personne depuis le formulaire des rôles. On considère que lorsque par
exemple on affecte un rôle à une personne, le rôle existe déjà.