﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using lib_FunEnBulles;
using System.Collections;
using System.Reflection.PortableExecutable;

namespace lib_FunEnBulles
{
    public class PersonnageCRUD
    {
        #region Propriétés
        private SQLiteConnection connection;
        #endregion
        #region Constructeurs
        /// <summary>
        /// Ingitialise une nouvelle instance de la classe PersonnageCRUD
        /// Elle dispose: d'un nom de base de données
        /// Elle créer une base de données
        /// Elle se connecte 
        /// Elle créer la table personnage si elle n'existe pas
        /// </summary>
        /// <param name="nomBdD">nom de la base de données</param>
        public PersonnageCRUD(string nomBdD)
        {
            connection = new SQLiteConnection("Data Source=" + nomBdD + ".sqlite;Version=3;");
            connection.Open();
            //SupprimerTable();
            CreerTable();
        }
        #endregion
        #region Méthodes
        /// <summary>
        /// CreerTable permet de créer la table personnage si elle n'existe pas
        /// </summary>
        public void CreerTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS personnage" +
                "(PersonnageNum INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                " PersonnageNom TEXT NOT NULL," +
                " PersonnageInspiration TEXT NOT NULL," +
                " PersonnageImage TEXT DEFAULT NULL," +
                " PersonnageSexe TEXT NOT NULL," +
                " PersonnageNationalite TEXT DEFAULT NULL," +
                " PersonnageTitre TEXT DEFAULT NULL," +
                " PersonnageNomAnglais TEXT DEFAULT NULL," +
                " PersonnageNomAllemand TEXT DEFAULT NULL)";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
            RemplirBdd();
        }
        /// <summary>
        /// RemplirBdd permets de remplir la bdd avec les données fourni
        /// </summary>
        public void RemplirBdd()
        {
            string checkTableVide = "SELECT COUNT(*) FROM personnage";
            SQLiteCommand commandCheck = new SQLiteCommand(checkTableVide, connection);
            int rowCount = Convert.ToInt32(commandCheck.ExecuteScalar());

            if (rowCount == 0)
            {
                // Appelle ta méthode pour remplir la BDD
                string remplirTableQuery = "INSERT INTO `personnage` (`PersonnageNum`, `PersonnageNom`, `PersonnageInspiration`, `PersonnageImage`, `PersonnageSexe`, `PersonnageNationalite`, `PersonnageTitre`, `PersonnageNomAnglais`, `PersonnageNomAllemand`) " +
                "VALUES (1, 'Amonbofis', 'à mon beau fils', 'amonbofis', 'M', 'egyptien', 'Achitecte architecte malheureusement mordu aux fesses', NULL, NULL),(2, 'Baba', '', 'baba', 'M', 'pirate', 'Vigie des pirates', 'Pirate Lookout', 'Baba'),(3, 'Barbe Rouge', '', 'barbe_rouge', 'M', 'pirate', 'Pirate', 'Redbeard', 'Der Rote Korsar'),(4, 'Batdaf', 'Bat d''Af pour Bataillons d''Afrique', 'batdaf', 'M', 'normand', 'Normand expert en coups de massue', 'Nescaf', 'Dompfaf'),(5, 'Cléopâtre', '', 'cleopatre', 'F', 'egyptien', 'Reine', NULL, NULL),(6, 'Casseurdebric', 'casseur de briques', 'casseurdebric', 'M', 'goth', 'Guerrier', 'Eccentric', 'Bartrik'),(7, 'Cloridric', 'chlorhydrique', 'cloridric', 'M', 'goth', 'Traitre Lâche ', 'Rhetoric', 'Holperik'),(8, 'Coudetric', 'coup de trique', 'coudetric', 'M', 'goth', 'Goth kidnappeur de druides.', 'Choleric', 'Rhetorik'),(9, 'Courdeténis', 'court de tennis', 'courdetenis', 'M', 'egyptien', 'Egyptien reprenant du service dans la légion romaine', 'Ptenisnet', 'Tennisplatzis'),(10, 'Dactilograf', 'dactylographe', 'dactilograf', 'M', 'normand', 'Normand qui fait impression', 'Firsthaf', 'Telegraf'),(11, 'Electric', 'électrique', 'electric', 'M', 'goth', 'Général prêt à tout balayer', 'Electric', 'Elektrik'),(12, 'Epidemaïs', 'épi de maïs', 'epidemais', 'M', 'phenicien', 'Entrepreneur modèle', 'Ekonomikrisis', 'Epidemais'),(13, 'Erix', '', 'erix', 'M', 'pirate', 'Stagiaire Pirate', 'Erix', 'Erix'),(14, 'Ginfis', 'gin fizz', 'ginfis', 'M', 'egyptien', 'Espion', 'Mintjulep', 'Ginfiz'),(15, 'Gueuselambix', 'gueuze lambic', 'gueuselambix', 'M', 'belge', 'Chef', 'Beefix ', 'Stellartoix'),(16, 'Histeric', 'hystérique', 'histeric', 'M', 'goth', 'Goth énervé', 'Prehistoric', 'Historik'),(17, 'Hyapados', 'Y''a pas d''os', 'hyapados', 'M', 'atlante', 'Grand prêtre d’Atlantide', 'Absolutlifabulos', 'Guanchott'),(18, 'Jolitorax', 'joli thorax', 'jolitorax', 'M', 'breton', 'Cousin germain breton ', 'Anticlimax', 'Teefax'),(19, 'Kerøsen', 'kérosène', 'kerosen', 'M', 'viking', 'Chef', 'Herendethelessen', 'Erik'),(20, 'Kiçah', 'qui ça ? ', 'kicah', 'M', 'indien d’inde', 'Fakir et chauffeur de tapis volant', 'Watziznehm', 'Erindjah'),(21, 'Kiwoalah', 'qui voilà ? ', 'kiwoalah', 'M', 'indien d’inde', 'Gourou', 'Hoodunnit', 'Daisayah'),(22, 'Liric', 'lyrique', 'liric', 'M', 'goth', 'Guerrier', 'Lyric', 'Lyrik'),(23, 'Misenplis', 'mise en plis', 'misenplis', 'M', 'egyptien', 'Scribe à la situation bien assise', 'Exlibris', 'Sekretaris'),(24, 'Numerobis', 'numéro bis', 'numerobis', 'M', 'egyptien', 'Architecte allergique aux crocodiles', 'Edifis', 'Numerobis'),(25, 'Ocatarinetabellatchitchix', 'Ô Catarinetta bella, tchi-tchi', 'ocatarinetabellatchitchix', 'M', 'corse', 'Chef', 'Boneywasawarriorwayayix', ' Osolemirnix'),(26, 'Olaf Grossebaf', 'grosse baffe', 'olaf_grossebaf', 'M', 'normand', 'Chef Normand à poigne', 'Olaf Timandahaf', 'Olaf Maulaf'),(27, 'Pasdfric', 'pas de fric', 'pasdfric', 'M', 'goth', 'Barbare sensible', 'Atmospheric', 'Symmetrik'),(28, 'Passmoilcric', 'passe-moi l''cric', 'passmoilcric', 'M', 'goth', 'Chef', 'Euphoric', 'Mickerik'),(30, 'Periferic', 'périphérique', 'periferic', 'M', 'goth', 'Barbare souvent amphorisé', 'Esoteric', 'Periferik'),(31, 'Rahazade', 'rasade', 'rahazade', 'F', ' indien d’inde', 'Fille de Chef', 'Orinjade', 'Orandschade'),(32, 'Satiric', 'satyrique', 'satiric', 'M', 'goth', 'Guerrier,Beau-frère de Liric', 'Satiric', 'Satirik'),(33, 'Soupalognon y Crouton', 'soupe à l''oignon et croûtons', 'soupalognon_y_crouton', 'M', 'ibère', 'Chef, Papa de Pépé', 'Huevos y Bacon', 'Costa y Bravo'),(34, 'Spartakis', 'Spartacus', 'spartakis', 'M', 'grec', 'Esclave,Chef de la rébellion des esclaves', 'Spartakis', 'Spartakis'),(35, 'Stenograf', 'sténographe', 'stenograf', 'M', 'normand', 'Guerrier Normand qui fait impression', 'Secondhaf', 'Stenograf'),(36, 'Téléféric', 'téléphérique', 'teleferic', 'M', 'goth', 'Chef suprême ', 'Metric', 'Cholerik'),(37, 'Theoric', 'théorique', 'theoric', 'M', 'goth', 'Guerrier', 'Tartaric', 'Theorik'),(38, 'Tournevis', 'tournevis', 'tournevis', 'M', 'egyptien', 'Scribe et sbire d’Amonbofis', 'Krukhut', 'Schraubzieris'),(39, 'Triple Patte', '', 'triple_patte', 'M', 'pirate', 'Pirate philosophe', 'Pegleg', 'Dreifuss'),(40, 'Tumehéris', 'tu me hérisses', 'tumeheris', 'M', 'egyptien', 'Capitaine', 'Sethisbackup', 'Abstosis'),(41, 'Zebigbos', 'the big boss', 'zebigbos', 'M', 'breton', 'Chef', 'Mykingdomforanos', 'Sebigbos'),(42, 'Zurix', 'Zurich', 'zurix', 'M', 'helvete', 'Banquier', 'Zurix', 'Vreneli'),(43, 'Abraracourcix', 'à bras raccourcis', 'abraracourcix', 'M', 'gaulois', 'Chef', 'Vitalstatistix', 'Majestix'),(44, 'Acidenitrix', 'acide nitrique', 'acidenitrix', 'M', 'gaulois', 'Traître à tête de hareng saur ', 'Codfix', 'Greulix'),(45, 'Agecanonix', 'âge canonique', 'agecanonix', 'M', 'gaulois', 'Retraite', 'Geriatrix', 'Methusalix'),(46, 'Alambix', 'alambic', 'alambix', 'M', 'gaulois', 'Commercant', 'Winesanspirix', 'Alkoholix'),(47, 'Amérix', 'amériques', 'amerix', 'M', 'gaulois', 'Fabricant de Serpe', 'Metallurgix', 'Talentix'),(48, 'Amnésix', 'amnésique', 'amnesix', 'M', 'gaulois', 'Druide', 'Psychoanalytix', 'Amnesix'),(49, 'Aniline', 'aniline', 'aniline', 'F', 'gaulois', 'Nourrice', 'Angelica', 'Grüblerine'),(50, 'Assurancetourix', 'assurance tous risques', 'assurancetourix', 'M', 'gaulois', 'Barde, instituteur et souffre-douleur', 'Cacofonix', 'Troubadix'),(51, 'Aplusbegalix', 'A+B=X', 'aplusbegalix', 'M', 'gallo-romain', 'Chef', 'Cassius Ceramix', 'Augenblix'),(52, 'Astérix', 'astérisque', 'asterix', 'M', 'gaulois', 'Guerrier, Mythe', 'Asterix', 'Asterix'),(53, 'Astronomix', 'astronomique', 'astronomix', 'M', 'gaulois', 'Commercant, Papa d’Astérix', 'Astronomix', 'Astronomix'),(54, 'Avoranfix', 'à vos rangs, fixe', 'avoranfix', 'M', 'gaulois', 'Trafiquant', 'Navishtrix', 'Bossix'),(55, 'Barometrix', 'barométrique', 'barometrix', 'M', 'gaulois', 'Druide', 'Suffix', 'Praktifix'),(56, 'Beaufix', 'beau fixe ou beau-fils', 'beaufix', 'M', 'gaulois', 'Chef clandestin ', 'Jellibabix', 'Schönfix'),(57, 'Berlix', 'Berlitz', 'berlix', 'M', 'gaulois', 'Professeur de langues «vivantes»', 'Berlix', 'Berlix'),(58, 'Bonemine', 'bonne mine', 'bonemine', 'F', 'gaulois', 'Femme de Chef', 'Impedimenta', 'Gutemine'),(59, 'Boufiltre', 'bout filtre', 'boufiltre', 'F', 'gaulois', 'Assistante qui fait son travail sans mégoter', 'Bicarbonatofsoda', 'Gibtermine'),(60, 'Catédralgotix', 'cathédrale gothique)', 'catedralgotix', 'M', 'gaulois', 'Ecolier gratifié d’un bon point pour son envie pressante', 'Prawnsinaspix', 'Cathedralgotix'),(61, 'César Labeldecadix', 'La Belle de Cadix', 'cesar_labeldecadix', 'M', 'gaulois', 'Tavernier, terreur de ces fadas de Romaings', 'César Drinklikafix', ' Cäsar Kneipix'),(62, 'Cétautomatix', 'c''est automatique', 'cetautomatix', 'M', 'gaulois', 'Forgeron, Mélomane averti', 'Fulliautomatix', 'Automatix'),(63, 'Cetyounix', 'c''est unique (anglais)', 'cetyounix', 'M', 'gaulois', 'Danseur', 'Tenansix', 'Denkdirnix'),(64, 'Changéledix', 'changer les disques', 'changeledix', 'M', 'gaulois', 'Capitaine', 'Seniorservix', 'Numalfix'),(65, 'Cicatrix', 'cicatrice', 'cicatrix', 'M', 'gaulois', 'Fine fleur de druide', 'Botanix', 'Florix'),(66, 'Comix', 'comique', 'comix', 'M', 'gaulois', 'Fils de Chef', 'Histrionix', 'Grünix'),(67, 'Diagnostix', 'diagnostic', 'diagnostix', 'M', 'gaulois', 'Druide aux petits soins', 'Diagnostix', 'Diagnostix'),(68, 'Eponine', 'éponyme', 'eponine', 'F', 'gaulois', 'Commercante, Epouse de César Labeldecadix', 'Hydrophobia', 'Minna'),(69, 'Falbala', 'falbala', 'falbala', 'F', 'gaulois', 'Egérie d’Obélix', 'Panacea', 'Falbala'),(70, 'Fanzine', 'faites excuse', 'fanzine', 'F', 'gaulois', 'Fille de Chef', 'Melodrama', 'Grienooline'),(71, 'Gélatine', 'gélatine', 'gelatine', 'F', 'gaulois', 'Maman d''Obelix', 'Vanilla', 'Popeline'),(72, 'Goudurix', 'goût du risque', 'goudurix', 'M', 'gaulois', 'Peureux', 'Justforkix', 'Grautvornix'),(73, 'Homéopatix', 'homéopathique', 'homeopatix', 'M', 'gaulois', 'Commercant, Frère de Bonemine', 'Homeopathix', 'Homeopatix'),(74, 'Iélosubmarine', 'Yellow Submarine', 'ielosubmarine', 'F', 'gaulois', 'Poissonière', 'Bacteria', 'Jellosubmarine'),(75, 'Keskonrix', 'qu''est-ce-qu''on risque', 'keskonrix', 'M', 'gaulois', 'Enfant, Jeune chasseur de marcassins', 'Picanmix', 'Keskonrix'),(76, 'Lentix', 'Lentisque', 'lentix', 'M', 'gaulois', 'Truand', 'Clovogarlix', 'Stupidix'),(77, 'Maestria', 'maestria', 'maestria', 'F', 'gaulois', 'Barde', 'Bravura', 'Maestria'),(78, 'Panix', '', NULL, 'M', 'gaulois', 'Tavernier', NULL, NULL),(79, 'Moralélastix', 'moral élastique', 'moralelastix', 'M', 'gaulois', 'Chef, Escroc notoire', 'Whosemoralsarelastix', 'Moralelastix'),(80, 'Obélix', 'obélisque', 'obelix', 'M', 'gaulois', 'Livreur Menhir, Pas gros', 'Obelix', 'Obelix'),(81, 'Obélodalix', 'ô belle odalisque', 'obelodalix', 'M', 'gaulois', 'Commercant, Père d’Obélix', 'Obeliscoidix', 'Obelodalix'),(82, 'Odalix', 'odalisque', 'odalix', 'M', 'gaulois', 'Cuisinier Traitre', 'Uptotrix', 'Odalix'),(83, 'Ordralfabetix', 'ordre alphabétique', 'ordralfabetix', 'M', 'gaulois', 'Marchand de poissons pas frais du village', 'Unhygienix', 'Verleihnix'),(84, 'Orthopédix', 'orthopédique', 'orthopedix', 'M', 'gaulois', 'Tavernier', 'Orthopaedix', 'Orthopädix'),(85, 'Panoramix', 'panoramique', 'panoramix', 'M', 'gaulois', 'Druide, inventeur de potions', 'Getafix', 'Miraculix'),(86, 'Plaintcontrix', 'plainte contre X', 'plaintcontrix', 'M', 'gaulois', 'Tavernier', 'Instantmix', 'Plaintcontrix'),(87, 'Praline', 'praline', 'praline', 'F', 'gaulois', 'Maman d''Asterix', 'Sarsaparilla', 'Praline'),(88, 'Préfix', 'préfixe', 'prefix', 'M', 'gaulois', 'Druide,il fait partout la pluie et le beau temps', 'Prefix', 'Barometrix'),(89, 'Prolix', 'prolixe', 'prolix', 'M', 'gaulois', 'Devin imaginaire', 'Prolix', 'Lügnix'),(90, 'Pronostix', 'pronostic', 'pronostix', 'M', 'gaulois', 'Druide diététicien fan de grains de raisin', 'Thermostatix', 'Prognostix'),(91, 'Quatrédeusix', 'quatre et deux, six', 'quatredeusix', 'M', 'gaulois', 'Brigand  prêt à tout pour vendre un Gaulois', 'Unpatriotix', 'Heuchlerix'),(92, 'Ségrégationnix', 'ségrégationniste', 'segregationnix', 'M', 'gaulois', 'Chef par la moitié droite d’un village gaulois', 'Majestix', 'Grobianix'),(93, 'Septantesix', 'septante-six : 76', 'septantesix', 'M', 'belge', 'Druide', 'Valueaddedtax', 'Spürnix'),(94, 'Tournedix', 'tourne disque', 'tournedix', 'M', 'gaulois', 'Chef par la moitié gauche d’un village gaulois', 'Cleverdix', 'Griesgramix'),(95, 'Tragicomix', 'tragi-comique', 'tragicomix', 'M', 'gaulois', 'Guerrier, Fiancé de Falbala', 'Tragicomix', 'Tragicomix'),(96, 'Coriza ', 'coryza', 'coriza ', 'F', 'gaulois', 'Fille de Tavernier', 'Influenza', 'Zechine '),(97, 'Zérozérosix', '006, allusion à James Bond 007', 'zerozerosix', 'M', 'gaulois', 'Espion, Fine mouche.', 'Dubbelosix', 'Nullnullsix'),(103, 'Dulcingetorix', '', NULL, 'M', 'gaulois', 'chef', NULL, NULL),(106, 'Absolumentexclus', 'absolument exclus', 'absolumentexclus', 'M', 'romain', 'Cadeau d’anniversaire d’Obélix', 'Ignoramus', 'Absolutus'),(107, 'Caius Aérobus', 'aérobus', 'caius_aerobus', 'M', 'romain', 'Fin stratège perturbé', 'Felix Platypus', 'Caius Aerobus'),(108, 'Bonusmalus', 'bonus malus', 'bonusmalus', 'M', 'romain', 'Préfet ', 'Bogus Genius', 'Bonusmalus'),(109, 'Gracchus Cétinconcensus ', 'nom des Gracques + c''est un consensus', 'gracchus_cetinconcensus', 'M', 'romain', 'Amiral en chef de l’Avé César', 'Crustacius', 'Gracchus Submersus'),(110, 'Chorus', 'chorus', 'chorus', 'M', 'romain', 'Général Romain qui sait se faire entendre', 'Operachorus', 'Chorus'),(111, 'Diplodocus', 'diplodocus', NULL, 'M', 'romain', NULL, NULL, NULL),(112, 'Julius Epinedecactus', 'épine de cactus', 'julius_epinedecactus ', 'M', 'romain', 'Super Nanny', 'Crismus Cactus', 'Primus Cactus'),(113, 'Faipalgugus', 'fais pas l''gugusse', NULL, 'M', 'romain', NULL, NULL, NULL),(114, 'Faimoiducuscus', 'fais-moi du couscous', 'faimoiducuscus', 'M', 'romain', 'Romain romantique', 'Radius', 'Gaudeamus'),(115, 'Lucius Fleurdelotus ', 'fleur de lotus', 'lucius_fleurdelotus', 'M', 'romain', 'Inspecteur général,envoyé spécial de César ', 'Overanxius', 'Lucius Nichtsalsverdrus'),(116, 'Gracchus Garovirus', 'gare au virus', 'gracchus_garovirus', 'M', 'romain', ' Gouverneur Romain', ' Varius Flavus', 'Agrippus Virus'),(117, 'Claudius Malosinus', 'mal aux sinus', 'claudius_malosinus ', 'M', 'romain', 'Questeur ou inspecteur des impôts', 'Vexatius Sinusitus', 'Claudius Incorruptus'),(118, 'Motus', 'motus', 'motus', 'M', 'romain', 'Général Romain connu pour ses prises de parole', 'Motus', 'Motus'),(119, 'Gracchus Nenjetépus ', 'n''en jetez plus', 'gracchus_nenjetepus ', 'M', 'romain', 'Centurion à sa maman', 'Gracchus Armisurplus', 'Gracchus Nenjetepus'),(120, 'Nenpeuplus', 'n''en peut plus', 'nenpeuplus', 'M', 'romain', 'Général Romain déprimé', 'Cantankerus', 'Cantankerus'),(121, 'Caius Obtus', 'obtus', 'caius_obtus', 'M', 'romain', 'Producteur de spectacles burlesques malgré lui', 'Caius Fatuous', 'Gaius Obtus'),(122, 'Oursenplus', 'ours en peluche', NULL, 'M', 'romain', NULL, NULL, NULL),(123, 'Pacotéalargus', 'pas coté à L''Argus', 'pacotealargus', 'M', 'romain', 'Soldat romain assommé sans modération par Ginfis', 'Superfluous', 'Grobianus'),(124, 'Gracchus Pleindastus', 'plein d''astuce', 'gracchus_pleindastus', 'M', 'romain', 'Préfet trompant son ennui dans la consommation de poulet', 'Surplus Dairiprodus', ' Gracchus Überdrus'),(125, 'Plutoqueprévus', 'plus tôt que prévu', 'plutoqueprevus', 'M', 'romain', 'Légionnaire haut en couleur', 'Infirmofpurpus', 'Handzumgrus'),(126, 'Caius Roideprus', 'roi de Prusse', 'caius_roideprus', 'M', 'romain', 'Gouverneur du palais de Londinium', 'Encyclopaedicus Britannicus', 'Caius Spiritus'),(127, 'Marcus Sacapus', 'sac à puces', 'marcus_sacapus', 'M', 'romain', 'Légionnaire qui a du chien', 'Marcus Ginantonicus', 'Marcus Ecus'),(128, 'Caius Saugrenus', 'saugrenu', 'caius_saugrenus ', 'M', 'romain', 'Jeune promu de la Nouvelle Ecole d’Affranchis', 'Caius Preposterus', 'Technokratus'),(129, 'Sciencifus', 'science infuse', 'sciencifus', 'M', 'romain', 'Légionnaire privé de Chipolata.', 'Courtingdisastus', 'Studicus'),(130, 'Sousentendus', 'sous-entendu', NULL, 'M', 'romain', NULL, NULL, NULL),(131, 'Soutienmordicus', 'soutient mordicus', NULL, 'M', 'romain', 'Chef de la police secrète de César', 'Devius Surreptitus', 'Gaius Musencus'),(132, 'Yenapus', 'y''en a plus', 'yenapus', 'M', 'romain', 'Préfet ', 'Adipus', 'Mitgenus'),(137, 'Anglaigus', 'angle aigu', 'anglaigus', 'M', 'romain', 'Jeune et brillant architecte malheureusement mordu', 'Squareonthehypothenus', 'Quadratus'),(138, 'Arrédebus', 'arrêt de bus', 'NULL', 'M', 'romain', NULL, NULL, NULL),(139, 'Ballondebaudrus', 'ballon de baudruche', 'ballondebaudrus', 'M', 'romain', 'A consommer avec modération', 'Titus Crapulus', 'Corruptus'),(140, 'Belinconnus', 'bel inconnu', NULL, 'M', 'romain', NULL, NULL, NULL),(141, 'Biscornus', 'biscornu', 'biscornus', 'M', 'romain', 'Centurion', 'Scrofulus', 'Beifus'),(142, 'Briseradius', 'brise radius', 'briseradius', 'M', 'romain', 'Dresseur de gladiateurs reconverti dans la dentelle', 'Insalubrius', 'Briseradius'),(143, 'Cartapus', 'carte à puce', NULL, 'M', 'romain', NULL, NULL, NULL),(144, 'Marcus Cubitus', 'cubitus', 'marcus_cubitus', 'M', 'romain', 'Légionnaire tombé sur un os', 'Marcus Ubiquitus', 'Marcus Konfus'),(145, 'Faitexcus', '', 'faitexcus', 'M', 'romain', 'Légionnaire très bête', 'Cadaverus', 'Fidibus'),(146, 'Gazpachoandalus', 'gaspacho andalou', NULL, 'M', 'romain', NULL, NULL, NULL),(147, 'Hotelterminus', 'hôtel Terminus', 'hotelterminus', 'M', 'romain', 'Centurion poussé à bout', 'Nefarius Purpus', 'Hotelterminus'),(148, 'Julius Humérus', 'humérus', 'julius_humerus ', 'M', 'romain', 'Légionnaire tombé sur un os', 'Julius Monotonus', 'Julius Bazillus'),(149, 'Hypothénus', 'hypoténuse', NULL, 'M', 'romain', NULL, NULL, NULL),(150, 'Incongrus', '', NULL, 'M', 'romain', NULL, NULL, NULL),(151, 'Caius Joligibus', 'joli gibus', 'caius_joligibus', 'M', 'romain', 'Le «pire tire-au-flanc» de la légion romaine', 'Caius Pusillanimus', 'Gaius Faulus'),(152, 'Lapsus', 'lapsus', NULL, 'M', 'romain', NULL, NULL, NULL),(153, 'Lupus', 'loup (en latin) ou le lupus', 'lupus', 'M', 'romain', 'Jeune loup de l’école de gladiateurs devenu doux', 'Porpus', 'Lupus'),(154, 'Caius Marchéopus', 'marché aux puces)', 'caius_marcheopus', 'M', 'romain', 'Légionnaire qui a du chien', 'Caius Flebitus', 'Gaius Barfus'),(155, 'Milexcus', 'mille excuses', 'milexcus', 'M', 'romain', 'Légionnaire coincé dans les bouchons', NULL, NULL),(156, 'Caligula Minus', 'minus', NULL, 'M', 'romain', NULL, NULL, NULL),(157, 'Mordicus', 'mordicus', NULL, 'M', 'romain', NULL, NULL, NULL),(158, 'Namaspamus', 'n''amasse pas mousse', 'namaspamus', 'M', 'romain', 'Romain tendance gourde', 'Obsequius', 'Asparagus'),(159, 'Tullius Octopus', 'octopus', 'tullius_octopus', 'M', 'romain', 'Légionnaire fan du Cirque', 'Tullius Octopus', 'Tullius Octopus'),(160, 'Olibrius', 'olibrius', 'olibrius', 'M', 'romain', 'Légionnaire bercé d’illusions', 'Oleaginus', 'Gutzufus'),(161, 'Pardessus', 'pardessus', 'pardessus', 'M', 'romain', 'Légionnaire habillé pour l’hiver par des barbares', 'Gastroenteritus', 'Appelmus'),(162, 'Perclus', 'perclus', 'perclus', 'M', 'romain', 'Romain expert en coutumes gauloises', ' Felonius Caucus', 'Spreizfus'),(163, 'Petilarus', 'Petit Larousse', 'petilarus', 'M', 'romain', 'Chef de patrouille Romain à la recherche d’Astérix et Obélix', 'Fishfingus', 'Petilarus'),(164, 'Pamplemus', 'pamplemousse', 'pamplemus', 'M', 'romain', 'Légionnaire Romain pressé', 'Arteriosclerosus', 'Pampelmus'),(165, 'Julius Pompilius ', 'Numa Pompilius', 'julius_pompilius', 'M', 'romain', 'Légionnaire ', 'Julius Pompus', ' Julius Pompilius'),(166, 'Processus', 'processus)', NULL, 'M', 'romain', NULL, NULL, NULL),(167, 'Quelquilfus', 'qui qu''ils fussent', 'quelquilfus', 'M', 'romain', 'Légionnaire perdu dans les rues de Lugdunum.', 'Fibrositus', 'Possiamus'),(168, 'Quoideplus', '', NULL, 'M', 'romain', NULL, NULL, NULL),(169, 'Rictus', 'rictus', 'rictus', 'M', 'romain', 'Responsable stressé du matériel', 'Appianglorious', 'Rictus'),(170, 'Saudepus', 'saut de puce', NULL, 'M', 'romain', NULL, NULL, NULL),(171, 'Savancosinus', 'savant Cosinus', 'savancosinus', 'M', 'romain', 'Légionnaire,Fin psychologue', 'Magnumopus', 'Taubenus'),(172, 'Stradivarius', 'Stradivarius', 'stradivarius', 'M', 'romain', NULL, NULL, NULL),(173, 'Stratocumulus', 'stratocumulus', NULL, 'M', 'romain', NULL, NULL, NULL),(174, 'Tadévirus', 'Tas de virus', NULL, 'M', 'romain', NULL, NULL, NULL),(175, 'Taxensus', 'taxe en sus', NULL, 'M', 'romain', NULL, NULL, NULL),(176, 'Tikedbus', 'ticket de bus', 'tikedbus', 'M', 'romain', 'Dépanneur accidenté par Obélix', 'Nervus Illnus', 'Omnibus'),(177, 'Tohubohus', 'tohu-bohu', NULL, 'M', 'romain', NULL, NULL, NULL),(178, 'Tomatojus', 'tomate au jus', NULL, 'M', 'romain', NULL, NULL, NULL),(179, 'Yapadebonus', 'y''a pas de bonus', NULL, 'M', 'romain', NULL, NULL, NULL),(180, 'Adrénaline', 'adrénaline', 'adrenaline', 'F', 'gaulois', 'fille de chef', 'Adrenalin', 'Adrenaline'),(181, 'Archéoptérix', 'archaeopteryx', 'archeopterix', 'M', 'gaulois', 'Druide au sommet', 'Archaeopterix', 'Archaeopterix'),(182, 'Doublepolémix', 'double polémique', 'doublepolemix', 'M', 'gaulois', 'colporteur de nouvelles', 'Confoundtheirpolitix', 'Polemix'),(183, 'Idéfix', 'idée fixe', 'idefix', 'M', 'gaulois', 'chien, Agent de protection de l’environnement', 'Dogmatix', 'Idefix'),(184, 'Maître Panix', '', NULL, 'M', 'gaulois', 'aubergiste', 'Tunafix', 'Meister Panix'),(185, 'Me Agecanonix', '', 'meagecanonix', 'F', 'gaulois', 'épouse de Agecanonix ', 'Geriatrix-s wife', 'Frau Methusalix'),(186, 'Me Cétautomatix', '', 'mecetautomatix', 'F', 'gaulois', 'épouse de Cétautomatix, Dame de fer', 'Fulliautomatix’s wife', 'Frau Automatix'),(187, 'Saingésix', 'Saintges, un ami de régiment d''Albert Uderzo', NULL, 'M', 'gaulois', 'Marchand de vin inconnu', 'Alcoholix', 'Saingesix'),(188, 'Caius Eucaliptus', 'eucalyptus', 'caius_eucaliptus', 'M', 'romain', 'collecteur impôts', 'Caius Eucaliptus', 'Gaius Raffcus'),(189, 'Caligula Alavacomgetepus ', 'à la va-comme-je-te-pousse', 'caligula_alavacomgetepus ', 'M', 'romain', 'Préfet des Gaules.', 'Odius Asparagus', 'Caligula Alavacomgetepus'),(190, 'Caliguliminix', '', 'caliguliminix', 'M', 'romain', 'Légionnaire romain Caligula Minus déguisé en gaulois', 'Caliguliminix', 'Caliguliminix'),(191, 'Caligula Minus', 'minus', 'caligula_minus', 'M', 'romain ', 'Légionnaire romain déguisé en gaulois pour infiltrer', 'Caligula Minus', 'Caligula Minus'),(192, 'Choléramorbus', 'choléra morbus(gastro-entérite)', 'choleramorbus', 'M', 'romain', 'Vil Romain', 'Choleramorbus', 'Choleramorbus'),(193, 'Claudius Cornedurus', 'corne d''urus', 'claudius_cornedurus', 'M', 'romain', 'Etoile montante', 'Gluteus Maximus', 'Claudius Musculus'),(194, 'Claudius Métrobus', 'Métrobus ou métro bus', 'claudius_metrobus ', 'M', 'romain', 'G.O. des nuits lutéciennes', 'Claudius Omnibus', 'Claudius Metrobus'),(195, 'Claudius Nonpossumus ', 'Non possumus', 'claudius_nonpossumus', 'M', 'romain', 'Centurion chargé de surveiller Pépé', 'Spurius Brontosaurus', 'Claudius Bockschus'),(197, 'Coronavirus', 'coronavirus', 'coronavirus', 'M', 'romain', 'méchant', 'Coronavirus', 'Caligarius'),(198, 'Encorutilfaluquejelesus', 'encore eût-il fallu que je le susse', 'encorutilfaluquejelesus', 'M', 'romain', 'Préfet précurseur du Petit Poucet', 'Poisonus Fungus', 'Unnutzus'),(199, 'Fercorus', 'aire chorus', 'fercorus', 'M', 'romain', 'Centurion  pris au mot', 'Raucus Hallelujachorus', 'Hohlenus'),(200, 'Flavia', 'gens Flavia, famille Rome Antique', 'flavia', 'F', 'romain', 'Romaine menée en bateau', 'Ulna', 'Flavia'),(201, 'Gracchus Sextilius', 'Sextilius, nom d''une famille romaine', 'gracchus_sextilius', 'M', 'romain', 'Sentinelle ', 'Gracchus Sextilius', 'Gracchus Torschus'),(202, 'Guilus', 'Guy Lux', 'guilus', 'M', 'romain', 'Célèbre animateur', 'Showbusinus', 'Francocampus'),(203, 'Lactus Bifidus ', 'lacté + bifidus', 'lactus_bifidus ', 'M', 'romain', 'Sénateur actif', 'Lactus Bifidus', 'Lactus Bifidus'),(204, 'Jules César ', '', 'jules_cesar', 'M', 'romain', 'grand pourvoyeur de citations impérissables', 'Julius Caesar', ' Julius Cäsar'),(205, 'Langélus', 'l''angélus', 'langelus', 'M', 'romain', 'Centurion bon qu’à sonner les cloches', 'Nebulus Nimbus', 'Lacmus'),(206, 'Latraviata', 'La Traviata', 'latraviata', 'F', 'romain', 'Grande tragédienne', 'Latraviata', 'Latraviata'),(207, 'Lucius Coquelus', 'coqueluche', 'lucius_coquelus', 'M', 'romain ', 'légionnaire , le roué de la fortune', 'Circumbendibus', ' Lucius Keuchhustus'),(208, 'Montladsus', 'monte là-dessus', 'montladsus', 'M', 'romain', 'légionnaire  taille minus', 'Homunculus', 'Microcosmus'),(209, 'Obélus', '', NULL, 'M', 'romain', 'Légionnaire Romain aux moustaches non règlementaires', 'Obelus', 'Obelus'),(210, 'Plexus', 'plexus', 'plexus', 'M', 'romain', 'Brigand', 'Villanus', 'Sinus'),(211, 'Claudius Quintilius', 'radical de quintus, cinquième en latin', 'claudius_quintilius', 'M', 'romain', 'Légionnaire du camp de Petitbonum', 'Claudius Quintilius', 'Carolus Stachus'),(212, 'Radius', '', 'radius', 'M', 'romain', 'Brigand Romain tombé sur un os', 'Unscrupulus', 'Cosinus'),(213, 'Rosaépine', 'rose à épines', 'rosaepine', 'M', 'romain', 'Super Nanny', 'Apidistra', 'Vaseline'),(214, 'Suelburnus', 'suer le burnous, ''faire suer le burnous ''', 'suelburnus', 'M', 'romain', 'Gouverneur de la Corse', 'Perfidius', 'Crassus Vampus'),(215, 'Tullius Détritus', 'détritus', 'tullius_detritus', 'M', 'romain', 'Agent spécial', 'Tortuous Convolvulus', 'Tullius Destructivus'),(216, 'Tullius Fanfrelus', 'fanfreluche', 'tullius_fanfrelus', 'M', 'romain', 'Envoyé spécial de Jules César', ' Noxius Vapus', 'Tullius Firlefanzus'),(217, 'Ziguépus', 'Zig et Puce', 'ziguepus', 'M', 'romain', 'Gardien de prison qui ne s’entend pas avec Assurancetourix', 'Sendervictorius', 'Zigepus'),(218, 'Bégonia', 'bégonia', 'begonia', 'F', 'romain', 'Belle plante romaine', 'Begonia', 'Begonia'),(220, 'Brutus', '', 'brutus', 'M', 'romain', 'Fils à Papa.', 'Brutus', 'Brutus'),(221, 'Caius Bonus ', 'bonus', 'caius_bonus ', 'M', 'romain', 'Centurion ', 'Crismus Bonus', 'Gaius Bonus'),(222, 'Lachélechampignon Y Causon', 'lâchez le champignon et causons', 'lachelechampignon_y_causon', 'M', 'ibère', 'Concessionnaire ', 'Nodepositon el Sodasiphon', 'Rento y Caron'),(223, 'Mac Oloch', 'ma coloc', 'mac_oloch', 'M', 'picte', 'Picte romantique', 'MacAroon', 'MacAphon'),(224, 'Målsen', 'malsaine', 'malsen', 'M', 'viking', 'Viking sain de corps mais non d’esprit', 'Nøgøødreässen', 'Rudersen'),(225, 'Mannekenpix', 'Manneken-pis', 'manneken', 'M', 'belge', 'Petit garçon ', 'Manikin', 'Manneken'),(226, 'Neuillisursen', 'Neuilly-sur-Seine', 'neuillisursen', 'M', 'viking', 'Viking intellectuel', 'Häräldwilssen', 'Gødskinsen'),(228, 'Pépé', '', 'pepe', 'M', 'ibère', 'Représentant du tempérament hispanique', 'Pepe', 'Pepe'),(229, 'Pourkoipàh', 'pourquoi pas ? ', 'pourkoipah', 'M', 'indien d’inde', 'Souffleur de trompes', 'Howdoo', 'Washupdah'),(230, 'Sanglier', '', NULL, 'M', 'singularis porcus', 'Fidèle compagnon', 'The boar', 'Wildschwein'),(231, 'Zøødvinsen', 'zoo de Vincennes', 'zoodvinsen', 'M', 'viking', 'Danois aux abois', 'Huntingseassen', 'Møpsen'),(232, 'Camomilla', 'camomille', 'camomilla', 'F', 'picte', 'Princesse ', 'Camomilla', 'Camilla'),(233, 'Césarion ', '', NULL, 'M', 'romain / egyptien', 'Fils de César et Cléopâtre', NULL, NULL),(234, 'Chipolata', 'chipolata', 'chipolata', 'F', 'corse', 'Femme corsée', NULL, NULL),(235, 'Øbsen', 'obscène', 'obsen', 'M', 'viking', 'Viking digne de Shakespeare', 'Odiuscømpärissen', 'Ivar'),(236, 'Chanteclairix', '', NULL, 'M', 'gaulois', 'Coq sportif', 'Chanticleerix', 'Kokolorix'),(237, 'Quintilius', 'radical de quintus, cinquième (latin)', 'quintilius', 'M', 'romain', 'Centurion Romain resté célèbre pour sa bêtise', 'Goldenslumbus', 'Quintilius'),(238, 'Bonus Promoplus', 'promo plus', 'bonus_promoplus', 'M', 'romain', 'Conseiller au bout du rouleau', 'Libellus Blockbustus', 'Rufus Syndicus'),(239, 'Asterus', '', NULL, 'M', 'romain', 'Légionnaire Romain aux moustaches non règlementaires', 'Asterus', 'Asterus'),(240, 'Allégorix', 'allégorique', 'Null', 'M', 'Gaulois', 'Villageois', 'Harmonix', NULL),(241, 'Analgésix', 'analgésique', 'Null', 'M', 'Gaulois', 'Villageois', NULL, NULL),(242, 'Arrierboutix', 'arrière-boutique', 'Null', 'M', 'Gaulois', 'Villageois', 'Atlantix', NULL),(243, 'Choucroutgarnix', 'choucroute garnie', 'Null', 'M', 'Gaulois', 'Villageois', 'Adriatix', NULL),(244, 'Déboitemenduménix', 'déboîtement du ménisque', 'Null', 'M', 'Gaulois', 'Villageois', 'Bucolix', NULL),(245, 'Harenbaltix', 'hareng baltique', 'Null', 'M', 'Gaulois', 'Villageois', 'Baltix', NULL),(246, 'Ouiskix', 'whisky', 'Null', 'M', 'Gaulois', 'Villageois', NULL, NULL),(247, 'Plantaquatix', 'plante aquatique', 'Null', 'M', 'Gaulois', 'Père de Falbala', NULL, 'Quantaplanckix\\r'),(248, 'Rézowifix', 'réseau Wi-Fi)', 'Null', 'M', 'Gaulois', 'Lecteur de l’écho de Condate', NULL, NULL),(249, 'Selfix', 'selfie', 'Null', 'M', 'Gaulois', 'fils de Cétautomatix', NULL, NULL),(250, 'Antibiotix', 'antibiotique', 'Null', 'M', 'Gaulois', 'Marchand de sanglier', NULL, NULL),(251, 'Distributiondéprix', 'distribution des prix)', 'Null', 'M', 'Gaulois', 'Expert hippique', NULL, NULL),(252, 'Pocatalitix', 'pot catalytique', 'Null', 'M', 'Gaulois', 'vendeur de chars neufs et d''occasion', NULL, NULL),(253, 'Selfservix', 'self-service', 'Null', 'M', 'Gaulois', 'tenancier de l''auberge « Chez Selfservix »', NULL, NULL),(254, 'Boxoffix', 'box-office', 'Null', 'M', 'Gaulois', 'acteur de théâtre', NULL, NULL),(255, 'Retraitarix', 'retraite à risque', 'Null', 'M', 'Gaulois', 'grand chef de la tribu des Parisii à Lutèce ', 'Partipolitix', NULL),(256, 'Adictosérix', 'addict aux séries', 'Null', 'M', 'Gaulois', 'pisteur biturige', NULL, NULL),(257, 'Ipocalorix', 'hypocalorique', 'Null', 'M', 'Gaulois', 'fait partie du FARC (Front Arverne de Résistance Checrète)', NULL, NULL),(258, 'Madamboevarix', 'Madame Bovary,', 'Null', 'M', 'Belge', 'guerrier belge', NULL, NULL),(259, 'Mouléfix', 'Moules et frites', 'Null', 'M', 'Belge', 'Belge engagé volontaire dans la Légion romaine', NULL, NULL),(260, 'Vandeuléflix', 'vingt-deux les flics', 'Null', 'M', 'Belge', 'guerrier belge', NULL, NULL),(261, 'Vanendfaillevesix', 'one and five six', 'Null', 'M', 'Belge', 'chef du village', NULL, NULL),(262, 'Apollosix', 'Apollo 6', 'Null', 'M', 'Druide', 'rédige l''horoscope', NULL, NULL),(263, 'Gasdechix', 'gaz de schiste', 'Null', 'M', 'Druide', 'druide de garde dans la forêt des Carnutes', NULL, NULL),(264, 'Informatix', 'informatique', 'Null', 'M', 'Druide', 'Voit l’avenir', NULL, NULL),(265, 'Pyrotecnix', 'pyrotechnique', 'Null', 'M', 'Druide', 'druide de garde dans la forêt des Carnutes', NULL, NULL),(266, 'Asthmatix', 'asthmatique', 'Null', 'M', 'Gaulois', 'ancien chef du village coupé en deux', NULL, NULL),(267, 'Dithyrambix', 'dithyrambique', 'Null', 'M', 'Gaulois', 'beau-frère d''Orthopédix', NULL, NULL),(268, 'Industrichimix', 'ndustrie chimique', 'Null', 'M', 'Gaulois', 'enfant ayant perdu ses parents dans l''affluence de la fête f', NULL, NULL),(269, 'Letitbix', 'Let It Be, chanson des Beatles', 'Null', 'M', 'Gaulois', 'jeune capitaine qui transporte des graines de fleurs', NULL, NULL),(270, 'Racinecubix', 'racine cubique', 'Null', 'M', 'Gaulois', 'garde dans le village du Grand Fossé', NULL, NULL),(271, 'Claudius Bouilleurdecrus', 'bouilleur de crus', 'Null', 'M', 'Romain', 'légionnaire romain', NULL, NULL),(272, 'Oranjajus', 'orange à jus', 'Null', 'M', 'Romain', 'légionnaire du camp retranché de Babaorum', NULL, NULL),(273, 'Sipilinclus', 'six piles incluses', 'Null', 'M', 'Romain', 'centurion du camp retranché de Babaorum', NULL, NULL),(274, 'Tibérius Entreméfrancorus', 'entremets Francorusse', 'Null', 'M', 'Romain', ' secrétaires de César', NULL, NULL),(275, 'Habeascorpus', 'Habeas Corpus', 'Null', 'M', 'Romain', 'chef d''une bande de brigands', NULL, NULL),(276, 'Tiramisus', 'iramisu', 'Null', 'M', 'Romain', 'Romain participant aux orgies du sénateur Lactus Bifidus', NULL, NULL),(277, 'Motussébouchecousus', 'motus et bouche cousue', 'Null', 'M', 'Romain', 'décurion, chargé par Garotiphus de trouver les légionnaires ', NULL, NULL),(278, 'Aplusdanlbus', 'À plus dans l''bus', 'Null', 'M', 'Romain', 'légionnaire pris dans la cascade', NULL, NULL),(279, 'Brisemenus', 'brise menu, de l''expression « les briser menues »', 'Null', 'M', 'Romain', ' légionnaire chargé de garder Kalachnikovna ', NULL, NULL),(280, 'Chaussetrus', 'chaussette russe', 'Null', 'M', 'Romain', 'légionnaire spécialiste de la lutte', NULL, NULL),(281, 'Fakenius', 'fake news', 'Null', 'M', 'Romain', 'légionnaire au corps de couleur verte', NULL, NULL),(282, 'Ibernatus', 'Hibernatus', 'Null', 'M', 'Romain', 'légionnaire pris dans la cascade', NULL, NULL),(283, 'Imporexpor', 'import-export', 'Null', 'M', 'Romain', 'aigle impérial apprivoisé du camp retranché de Babaorum', NULL, NULL),(284, 'Légéiatus', 'éger hiatus', 'Null', 'M', 'Romain', 'cousin de Numerusclausus', NULL, NULL),(285, 'Mercidetvenus', 'Merci d''être venus', 'Null', 'M', 'Romain', 'légionnaire pris dans la cascade', NULL, NULL),(286, 'Nautilus', 'Nautilus', 'Null', 'M', 'Romain', 'légionnaire pris dans la cascade', NULL, NULL),(287, 'Tutévucantabus', 'Tu t''es vu quand t''as bu', 'Null', 'M', 'Romain', 'légionnaire pris dans la cascade', NULL, NULL),(288, 'Volfgangamadéus', 'Wolfgang Amadeus', 'Null', 'M', 'Romain', 'légat en Belgique', NULL, NULL),(289, 'Facederax', 'face de rat', 'Null', 'M', 'Breton', 'voleur breton', NULL, NULL),(290, 'Ipipourax', 'hip, hip, hourra', 'Null', 'M', 'Breton', 'joueur de l''équipe de rugby à XV', NULL, NULL),(291, 'Madmax', 'Mad Max', 'Null', 'M', 'Breton', 'aurige breton qui participe à la course Transitalique', NULL, NULL),(292, 'Mac Atrell ', 'ma 4L', 'Null', 'M', 'Pictes', 'grand-oncle de Mac Oloch', NULL, NULL),(293, 'Mac Aye', 'ma caille, terme argotique pour ‘ma chérie’', 'Null', 'M', 'Pictes', 'membre du clan Mac Abbeh', NULL, NULL),(294, 'Mac Abbeh', 'macchabée', 'Null', 'M', 'Pictes', 'Rival de Mac Oloch', NULL, NULL),(295, 'Mac Quenoth', 'ma quenotte', 'Null', 'M', 'Pictes', 'membre du clan Mac Oloch', NULL, NULL),(296, 'Mac Rampe', 'ma crampe', 'Null', 'M', 'Pictes', 'membre du clan Mac Oloch', NULL, NULL),(297, 'Salamix', 'salami', 'Null', 'M', 'Corse', 'seul légionnaire corse', NULL, NULL),(298, 'Squinotix', 'ski nautique', 'Null', 'M', 'Corse', '', NULL, NULL),(299, 'Croquemithène', 'croque-mitaine', 'Null', 'M', 'Grec', 'cousins de Mixomatos', NULL, NULL),(300, 'Mixomatos', 'myxomatose', 'Null', 'M', 'Grec', 'guide des Gaulois à Athènes', NULL, NULL),(301, 'Bigdatha', 'big data', 'Null', 'M', 'Numides', 'scribes numides muets au service de Promoplus', NULL, NULL),(302, 'Duplicatha', 'duplicata', 'Null', 'M', 'Numides', 'chef des esclaves chargés de défricher la forêt', NULL, NULL),(303, 'Kefélapolis', 'que fait la police ?', 'Null', 'M', 'Egyptien', 'intendant égyptien du conseiller de César Bonus Promoplus', NULL, NULL),(304, 'Complétemenpaf', 'complètement paf', 'Null', 'M', 'Normand', 'guerrier normand venu en Gaule pour apprendre la peur', NULL, NULL),(305, 'Cékankondine', 'C''est quand qu''on dîne ?', 'cekankondine', 'M', 'Sarmates', 'chaman, époux de Maminovna', NULL, NULL),(306, 'Maminovna', 'Mamie Nova', 'maminovna', 'F', 'Sarmates', 'cheffe des Amazones', NULL, NULL);";
                SQLiteCommand commandRemplir = new SQLiteCommand(remplirTableQuery, connection);
                commandRemplir.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// PersonnageExiste permets de vérifier si 
        /// un personnage existe déjà dans la table table personnage
        /// </summary>
        /// <param name="Personnage">Personnage à vérifier</param>
        /// <returns>False si pas trouvé, true sinon</returns>
        public bool PersonnageExiste(Personnage Personnage)
        {
            string query = "SELECT PersonnageNum " +
                "FROM Personnage " +
                "WHERE PersonnageNom = @PersonnageNom COLLATE NOCASE";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@PersonnageNom", Personnage.PersonnageNom);
            
            var result = command.ExecuteScalar();
            return result != null;
        }
        /// <summary>
        /// AjouterPersonnage permet d'ajouter un Personnage s'il n'existe pas déjà à la table personnage
        /// Elle dispose d'un personnage
        /// </summary>
        /// <param name="Personnage"></param>
        public void AjouterPersonnage(Personnage personnage)
        {
            if (!PersonnageExiste(personnage))
            {
                //Ajouter dans la tabe un enregistrement            
                string query = "INSERT INTO personnage(" +
                    "PersonnageNom, PersonnageInspiration, PersonnageImage, " +
                    "PersonnageSexe, PersonnageNationalite, PersonnageTitre, " +
                    "PersonnageNomAnglais, PersonnageNomAllemand) " +
                    "VALUES(@PersonnageNom, @PersonnageInspiration, @PersonnageImage, " +
                    "@PersonnageSexe, @PersonnageNationalite, @PersonnageTitre, " +
                    "@PersonnageNomAnglais, @PersonnageNomAllemand)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@PersonnageNom", personnage.PersonnageNom);
                command.Parameters.AddWithValue("@PersonnageInspiration", personnage.PersonnageInspiration);
                command.Parameters.AddWithValue("@PersonnageImage", personnage.PersonnageImage);
                command.Parameters.AddWithValue("@PersonnageSexe", personnage.PersonnageSexe ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PersonnageNationalite", personnage.PersonnageNationalite ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PersonnageTitre", personnage.PersonnageTitre ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PersonnageNomAnglais", personnage.PersonnageNomAnglais ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PersonnageNomAllemand", personnage.PersonnageNomAllemand ?? (object)DBNull.Value);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// ModifierPersonnage permet de modifier un Personnage s'il existe déjàde la table personnage
        /// Elle dispose d'un Personnage
        /// </summary>
        /// <param name="personnage">Personnage selectionné</param>
        public void ModifierPersonnage(Personnage personnage)
        {
            if (PersonnageExiste(personnage))
            {
                //Modifie un enregistrement
                string query = "UPDATE personnage SET " +
                    "PersonnageNom = @PersonnageNom, " +
                    "PersonnageInspiration = @PersonnageInspiration, " +
                    "PersonnageSexe = @PersonnageSexe, " +
                    "PersonnageImage = @PersonnageImage, " +
                    "PersonnageNationalite = @PersonnageNationalite, " +
                    "PersonnageTitre = @PersonnageTitre, " +
                    "PersonnageNomAnglais = @PersonnageNomAnglais, " +
                    "PersonnageNomAllemand = @PersonnageNomAllemand " +
                    "WHERE PersonnageNum = @PersonnageNum";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@PersonnageNum", personnage.PersonnageNum);
                command.Parameters.AddWithValue("@PersonnageNom", personnage.PersonnageNom);
                command.Parameters.AddWithValue("@PersonnageInspiration", personnage.PersonnageInspiration);
                command.Parameters.AddWithValue("@PersonnageImage", personnage.PersonnageImage);
                command.Parameters.AddWithValue("@PersonnageSexe", personnage.PersonnageSexe ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PersonnageNationalite", personnage.PersonnageNationalite ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PersonnageTitre", personnage.PersonnageTitre ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PersonnageNomAnglais", personnage.PersonnageNomAnglais ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PersonnageNomAllemand", personnage.PersonnageNomAllemand ?? (object)DBNull.Value);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// SupprimerPersonnage permet de supprimer un Personnage s'il existe et qu'il n'est pas null de la table personnage
        /// </summary>
        /// <param name="personnage">Personnage selectionner</param>
        public void SupprimerPersonnage(Personnage personnage)
        {
            if (personnage != null && PersonnageExiste(personnage))
            {
                //Supprime le perosnnage de la table personnage
                string query = "DELETE FROM personnage " +
                        "WHERE PersonnageNum = @PersonnageNum";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@PersonnageNum", personnage.PersonnageNum);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Retourne la liste de tous les Personnages dans la table personnage.
        /// </summary>
        public List<Personnage> ListerPersonnages(string filtre = "")
        {
            List<Personnage> ListePersonnages = new List<Personnage>();
            string query = "SELECT PersonnageNum, PersonnageNom, PersonnageInspiration, " +
                "PersonnageSexe, PersonnageImage, PersonnageNationalite, PersonnageTitre, " +
                "PersonnageNomAnglais, PersonnageNomAllemand " +
                "FROM personnage " +
                "WHERE PersonnageNom LIKE @filtre " +
                "OR PersonnageInspiration LIKE @filtre " +
                "OR PersonnageSexe LIKE @filtre " +
                "OR PersonnageImage LIKE @filtre " +
                "OR PersonnageTitre LIKE @filtre " +
                "OR PersonnageNomAnglais LIKE @filtre " +
                "OR PersonnageNomAllemand LIKE @filtre;";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@filtre", "%" + filtre + "%");
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Personnage personnage = new Personnage(
                        Convert.ToInt16(reader["PersonnageNum"]),
                        reader["PersonnageNom"].ToString(),
                        reader["PersonnageInspiration"].ToString(),
                        reader["PersonnageSexe"].ToString(),
                        reader["PersonnageImage"].ToString(),
                        reader["PersonnageNationalite"].ToString(),
                        reader["PersonnageTitre"].ToString(),
                        reader["PersonnageNomAnglais"].ToString(),
                        reader["PersonnageNomAllemand"].ToString()
                    );
                    ListePersonnages.Add(personnage);
                }
            }
            return ListePersonnages;
        }

        /// <summary>
        /// Genere un personnage aleatoire
        /// </summary>
        /// <param name="listePersonnages">Liste de personnages</param>
        /// <returns>un perosnnage aleatoire</returns>
        public Personnage PersonnageAleatoire(List<Personnage> listePersonnages)
        {
            if (listePersonnages == null || listePersonnages.Count == 0)
                return null;

            Random random = new Random();
            int indexAleatoire = random.Next(listePersonnages.Count);

            return listePersonnages[indexAleatoire];
            
        }
        /// <summary>
        /// Permet de supprimr la table personnage si elle existe
        /// </summary>
        public void SupprimerTable()
        {
            string dropTableQuery = "DROP TABLE IF EXISTS personnage";
            SQLiteCommand command = new SQLiteCommand(dropTableQuery, connection);

            command.ExecuteNonQuery();
        }
        #endregion
    }
}
