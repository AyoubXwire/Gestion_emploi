-- create database and use it
create database emploi_du_temps;
use emploi_du_temps;

-- create tables
create table secteur(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    PRIMARY KEY (id)
);

create table filiere(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    id_secteur int NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (id_secteur) REFERENCES secteur(id)
);

create table metier(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    PRIMARY KEY (id)
);

create table formateur(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    prenom varchar(255) NOT NULL,
    nb_heures int default 0,
    id_metier int NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (id_metier) REFERENCES metier(id)
);

create table groupe(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    niveau int NOT NULL,
    nb_heures int default 0,
    chaine varchar(255) NOT NULL,
    id_filiere int NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (id_filiere) REFERENCES filiere(id)
);

create table module(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    niveau int NOT NULL,
    mass_horaire int NOT NULL,
    id_metier int NOT NULL,
    id_filiere int NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (id_metier) REFERENCES metier(id),
    FOREIGN KEY (id_filiere) REFERENCES filiere(id)
);

create table affectation(
    id int NOT NULL AUTO_INCREMENT,
    id_formateur int NOT NULL,
    id_module int NOT NULL,
    id_groupe int NOT NULL,
    nb_heures float default 0,
    avancement float default 0,
    nb_heures_rates float default 0,
    date_debut date,
    date_fin date,
    nb_semaines int,
    nb_utilise int NOT NULL default 0,
    PRIMARY KEY (id),
    FOREIGN KEY (id_formateur) REFERENCES formateur(id),
    FOREIGN KEY (id_module) REFERENCES module(id),
    FOREIGN KEY (id_groupe) REFERENCES groupe(id)
);

create table type_salle(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    PRIMARY KEY (id)
);

create table salle(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    id_type_salle int NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (id_type_salle) REFERENCES type_salle(id)
);

create table jour(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    PRIMARY KEY (id)
);

create table seance(
	id int NOT NULL AUTO_INCREMENT,
    nom varchar(255) NOT NULL,
    PRIMARY KEY (id)
);

create table emploi(
	id_affectation int NOT NULL,
	id_jour int NOT NULL,
	id_seance int NOT NULL,
	id_salle int NOT NULL,
	chaine varchar(255),
    FOREIGN KEY (id_affectation) REFERENCES affectation(id),
    FOREIGN KEY (id_jour) REFERENCES jour(id),
    FOREIGN KEY (id_seance) REFERENCES seance(id),
    FOREIGN KEY (id_salle) REFERENCES salle(id)
);

-- insert in jour
INSERT INTO jour(nom) VALUES('lundi');
INSERT INTO jour(nom) VALUES('mardi');
INSERT INTO jour(nom) VALUES('mercredi');
INSERT INTO jour(nom) VALUES('jeudi');
INSERT INTO jour(nom) VALUES('vendredi');
INSERT INTO jour(nom) VALUES('samedi');

-- insert in jour
INSERT INTO seance(nom) VALUES('s1');
INSERT INTO seance(nom) VALUES('s2');
INSERT INTO seance(nom) VALUES('s3');
INSERT INTO seance(nom) VALUES('s4');

-- insert in secteur
INSERT INTO secteur(nom) VALUES('NTIC');
INSERT INTO secteur(nom) VALUES('AGC');
INSERT INTO secteur(nom) VALUES('TH');

-- insert in filiere
INSERT INTO filiere(nom, id_secteur) VALUES('TDI', 1);
INSERT INTO filiere(nom, id_secteur) VALUES('TRI', 1);
INSERT INTO filiere(nom, id_secteur) VALUES('TMSIR', 1);
INSERT INTO filiere(nom, id_secteur) VALUES('TSB', 2);
INSERT INTO filiere(nom, id_secteur) VALUES('TSGE', 2);
INSERT INTO filiere(nom, id_secteur) VALUES('TCE', 2);
INSERT INTO filiere(nom, id_secteur) VALUES('THP', 3);
INSERT INTO filiere(nom, id_secteur) VALUES('THI', 3);
INSERT INTO filiere(nom, id_secteur) VALUES('TMI', 3);
INSERT INTO filiere(nom, id_secteur) VALUES('TMMC', 3);

-- insert in metier
INSERT INTO metier(nom) VALUES('arabe');
INSERT INTO metier(nom) VALUES('francais');
INSERT INTO metier(nom) VALUES('anglais');
INSERT INTO metier(nom) VALUES('developpement');
INSERT INTO metier(nom) VALUES('reseau');
INSERT INTO metier(nom) VALUES('gestion');
INSERT INTO metier(nom) VALUES('secretariat');
INSERT INTO metier(nom) VALUES('comptabilite');
INSERT INTO metier(nom) VALUES('habillement');

-- insert in type_salle
INSERT INTO type_salle(nom) VALUES('normale');
INSERT INTO type_salle(nom) VALUES('informatique');
INSERT INTO type_salle(nom) VALUES('indistruelle');

-- insert in salle
INSERT INTO salle(nom, id_type_salle) VALUES('salle1', 1);
INSERT INTO salle(nom, id_type_salle) VALUES('salle2', 1);
INSERT INTO salle(nom, id_type_salle) VALUES('salle3', 1);
INSERT INTO salle(nom, id_type_salle) VALUES('salle4', 1);
INSERT INTO salle(nom, id_type_salle) VALUES('salle5', 2);
INSERT INTO salle(nom, id_type_salle) VALUES('salle6', 2);
INSERT INTO salle(nom, id_type_salle) VALUES('salle7', 2);
INSERT INTO salle(nom, id_type_salle) VALUES('salle8', 3);
INSERT INTO salle(nom, id_type_salle) VALUES('salle9', 3);

-- insert in formateur
INSERT INTO formateur(nom, prenom, id_metier) VALUES('fadwa', 'fadwa', 1);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('ali', 'ali', 1);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('farid', 'farid', 2);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('mehdi', 'mehdi', 2);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('khalid', 'khalid', 3);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('hind', 'hind', 3);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('ayoub', 'ayoub', 4);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('anas', 'anas', 4);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('kenza', 'kenza', 4);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('abdou', 'abdou', 4);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('taha', 'taha', 5);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('omar', 'omar', 5);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('bilal', 'bilal', 5);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('hajar', 'hajar', 5);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('oualid', 'oualid', 6);
INSERT INTO formateur(nom, prenom, id_metier) VALUES('mourad', 'mourad', 6);

-- insert in groupe
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('A', 1, 'TDI1A', 1);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('B', 1, 'TDI1B', 1);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('C', 1, 'TDI1C', 1);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('D', 1, 'TDI1D', 1);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('A', 2, 'TDI2A', 1);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('B', 2, 'TDI2B', 1);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('C', 2, 'TDI2C', 1);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('A', 1, 'TRI1A', 2);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('B', 1, 'TRI1B', 2);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('C', 1, 'TRI1C', 2);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('D', 1, 'TRI1D', 2);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('A', 2, 'TRI2A', 2);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('B', 2, 'TRI2B', 2);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('A', 1, 'TMSIR1A', 3);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('B', 1, 'TMSIR1B', 3);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('C', 1, 'TMSIR1C', 3);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('D', 1, 'TMSIR1D', 3);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('A', 2, 'TMSIR2A', 3);
INSERT INTO groupe(nom, niveau, chaine, id_filiere) VALUES('B', 2, 'TMSIR2B', 3);

-- insert in module
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('arabe', 1, 60, 1, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('arabe', 1, 60, 1, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('arabe', 1, 60, 1, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('francais', 1, 60, 2, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('francais', 1, 60, 2, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('francais', 1, 60, 2, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('anglais', 1, 60, 3, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('anglais', 1, 60, 3, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('anglais', 1, 60, 3, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('francais', 2, 60, 2, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('francais', 2, 60, 2, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('francais', 2, 60, 2, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('anglais', 2, 60, 3, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('anglais', 2, 60, 3, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('anglais', 2, 60, 3, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('c#', 1, 120, 4, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('algorithme', 1, 140, 4, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('database', 2, 120, 4, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('backend', 2, 140, 4, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('frontend', 2, 140, 4, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('maintenance', 1, 120, 5, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('VLSM', 1, 180, 5, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('routage', 1, 120, 5, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('commutation', 1, 120, 5, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('securite', 1, 80, 5, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('DNS', 2, 140, 5, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('AD', 2, 140, 5, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('DHCP', 2, 140, 5, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('entreprenariat', 2, 100, 6, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('entreprenariat', 2, 100, 6, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('entreprenariat', 2, 100, 6, 3);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('emploi', 2, 40, 6, 1);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('emploi', 2, 40, 6, 2);
INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES('emploi', 2, 40, 6, 3);

-- select * from secteur;
-- select * from filiere;
-- select * from metier;
-- select * from formateur;
-- select * from groupe;
-- select * from module;
-- select * from affectation;