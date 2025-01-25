CREATE DATABASE IF NOT EXISTS gestionnaire;

CREATE TABLE IF NOT EXISTS `gestionnaire` (
    id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    nom VARCHAR (255),
    prenom VARCHAR (255),
    matricule VARCHAR (255),
    poste VARCHAR (255)
);

INSERT INTO gestionnaire (id_utilisateur, nom, prenom, matricule, poste)
VALUES (1, 'Test', 'Test', '111ZZZA', 'Test'); 