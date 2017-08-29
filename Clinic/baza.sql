/*
SQLyog Ultimate v9.50 
MySQL - 5.5.20 : Database - stomatolog
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`stomatolog` /*!40100 DEFAULT CHARACTER SET cp1251 COLLATE cp1251_ukrainian_ci */;

USE `stomatolog`;

/*Table structure for table `adm` */

DROP TABLE IF EXISTS `adm`;

CREATE TABLE `adm` (
  `kodpas` int(10) NOT NULL AUTO_INCREMENT,
  `passord` tinytext COLLATE cp1251_ukrainian_ci,
  KEY `kodpas` (`kodpas`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=cp1251 COLLATE=cp1251_ukrainian_ci;

/*Data for the table `adm` */

insert  into `adm`(`kodpas`,`passord`) values (1,'1234');

/*Table structure for table `adr` */

DROP TABLE IF EXISTS `adr`;

CREATE TABLE `adr` (
  `koda` int(4) NOT NULL AUTO_INCREMENT,
  `kraina` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  `misto` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  `vylica` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  `dom` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  `kabinet` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  `lic` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  KEY `koda` (`koda`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=cp1251 COLLATE=cp1251_bin;

/*Data for the table `adr` */

insert  into `adr`(`koda`,`kraina`,`misto`,`vylica`,`dom`,`kabinet`,`lic`) values (14,'Україна','Хмельницький','Свободи','56','1','542'),(15,'Україна','Львів','перемоги','13','2','654ра');

/*Table structure for table `doc` */

DROP TABLE IF EXISTS `doc`;

CREATE TABLE `doc` (
  `kodd` int(4) NOT NULL AUTO_INCREMENT,
  `last` varchar(44) DEFAULT NULL,
  `first` varchar(44) DEFAULT NULL,
  `middle` varchar(44) DEFAULT NULL,
  `phone` varchar(44) DEFAULT NULL,
  `graf` varchar(100) DEFAULT NULL,
  `lic` varchar(44) DEFAULT NULL,
  `kodpos` int(4) DEFAULT NULL,
  `koda` int(4) DEFAULT NULL,
  KEY `kodd` (`kodd`),
  KEY `kodpos` (`kodpos`),
  KEY `koda` (`koda`),
  CONSTRAINT `doc_ibfk_1` FOREIGN KEY (`kodpos`) REFERENCES `pos` (`kodpos`),
  CONSTRAINT `doc_ibfk_2` FOREIGN KEY (`koda`) REFERENCES `adr` (`koda`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=cp1251;

/*Data for the table `doc` */

insert  into `doc`(`kodd`,`last`,`first`,`middle`,`phone`,`graf`,`lic`,`kodpos`,`koda`) values (10,'Нагреба','Стаініслав','Валерович','654465','08:00-17:00','варв4',12,14),(11,'Щерба','Петро','Ігорович','645745','08:00-17:00','роав3',13,14),(12,'Мартинюк','Надія','Іванівна','325365','08:00-17:00','5ив35',14,14),(13,'Мількевич','Іванна','Олегівна','754334','08:00-17:00','645рва',14,15),(14,'Білоус','Сергій','Олександрович','756543','(NULL)08:00-17:00','ра5433',12,15);

/*Table structure for table `graf` */

DROP TABLE IF EXISTS `graf`;

CREATE TABLE `graf` (
  `kodg` int(4) NOT NULL AUTO_INCREMENT,
  `kodd` int(4) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `zap` varchar(44) COLLATE cp1251_ukrainian_ci DEFAULT NULL,
  `spr` tinyint(1) DEFAULT NULL,
  KEY `kodg` (`kodg`),
  KEY `kodd` (`kodd`),
  CONSTRAINT `graf_ibfk_1` FOREIGN KEY (`kodd`) REFERENCES `doc` (`kodd`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=cp1251 COLLATE=cp1251_ukrainian_ci;

/*Data for the table `graf` */

insert  into `graf`(`kodg`,`kodd`,`date`,`zap`,`spr`) values (16,10,'2013-03-21','прогуляв',1),(17,11,'2013-03-06','прогуляв',1),(18,12,'2013-03-13','запізнився',0);

/*Table structure for table `hvorobu` */

DROP TABLE IF EXISTS `hvorobu`;

CREATE TABLE `hvorobu` (
  `kodhv` int(4) NOT NULL AUTO_INCREMENT,
  `nazva` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  `opis` varchar(255) CHARACTER SET cp1251 DEFAULT NULL,
  `simpt` varchar(255) CHARACTER SET cp1251 DEFAULT NULL,
  `liku` varchar(255) CHARACTER SET cp1251 DEFAULT NULL,
  KEY `kodhv` (`kodhv`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=cp1251 COLLATE=cp1251_ukrainian_ci;

/*Data for the table `hvorobu` */

insert  into `hvorobu`(`kodhv`,`nazva`,`opis`,`simpt`,`liku`) values (7,'Каріес','зуби розїдаюця чорними бактеріями','зуби стають чорними ','чистка зубів або якшо вже зуб потерян то ставити пломбу'),(8,'жовтизна','емаль потрохи знишена','стали жовті на колів','чистка і відбілювання зубів'),(9,'зуба','з хворобою випав зуб','зуба в рту','поставити коронку'),(10,'ясна','ясна зараженні бакетріями','іде кров з ясен','використовувати лічашю мазь на яснах'),(11,'поганий запах','ротова порожнина заповнена бактеріми','поганий запах зі рта','повна читска рта');

/*Table structure for table `lik` */

DROP TABLE IF EXISTS `lik`;

CREATE TABLE `lik` (
  `kodl` int(4) NOT NULL AUTO_INCREMENT,
  `pochv` date DEFAULT NULL,
  `kinhv` date DEFAULT NULL,
  `kodhv` int(4) DEFAULT NULL,
  `kodp` int(4) DEFAULT NULL,
  `liku` varchar(44) COLLATE cp1251_ukrainian_ci DEFAULT NULL,
  `last` varchar(44) COLLATE cp1251_ukrainian_ci DEFAULT NULL,
  `efek` tinyint(1) DEFAULT NULL,
  KEY `kodl` (`kodl`),
  KEY `kodhv` (`kodhv`),
  KEY `kodp` (`kodp`),
  CONSTRAINT `lik_ibfk_1` FOREIGN KEY (`kodhv`) REFERENCES `hvorobu` (`kodhv`),
  CONSTRAINT `lik_ibfk_2` FOREIGN KEY (`kodp`) REFERENCES `pac` (`kodp`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=cp1251 COLLATE=cp1251_ukrainian_ci;

/*Data for the table `lik` */

insert  into `lik`(`kodl`,`pochv`,`kinhv`,`kodhv`,`kodp`,`liku`,`last`,`efek`) values (29,'2013-03-01','2013-03-10',7,15,'hgdfhhgf','Слободян',0),(31,'2013-03-01','2013-03-03',7,15,'gdfgdf','Слободян',0),(32,'2013-03-01','2013-03-07',8,16,'ggfd','',1),(33,'2013-03-01','2013-03-07',8,16,'варива','Черний',1),(34,'2013-03-01','2013-03-07',8,16,'варива','Черний',NULL);

/*Table structure for table `pac` */

DROP TABLE IF EXISTS `pac`;

CREATE TABLE `pac` (
  `kodp` int(10) NOT NULL AUTO_INCREMENT,
  `last` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  `first` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  `middle` varchar(44) CHARACTER SET cp1251 DEFAULT NULL,
  KEY `kodp` (`kodp`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=cp1251 COLLATE=cp1251_bin;

/*Data for the table `pac` */

insert  into `pac`(`kodp`,`last`,`first`,`middle`) values (15,'Слободян','Богданний ','Валерович'),(16,'Черний','Богдан','Валерович');

/*Table structure for table `pos` */

DROP TABLE IF EXISTS `pos`;

CREATE TABLE `pos` (
  `kodpos` int(4) NOT NULL AUTO_INCREMENT,
  `nazva` varchar(44) DEFAULT NULL,
  `vimogi` varchar(255) DEFAULT NULL,
  `oklad` int(44) DEFAULT NULL,
  KEY `kodpos` (`kodpos`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=cp1251;

/*Data for the table `pos` */

insert  into `pos`(`kodpos`,`nazva`,`vimogi`,`oklad`) values (12,'Лікар-стоматолог','Мати диплом закінчення уніерситету мтоматологій',5000),(13,'Лікар-практикант','Мати диплом закінчення стоматологічного університету',4000),(14,'Медсистера','Закінчити курси месистер',NULL);

/*Table structure for table `zapis` */

DROP TABLE IF EXISTS `zapis`;

CREATE TABLE `zapis` (
  `kodz` int(4) NOT NULL AUTO_INCREMENT,
  `zapv` time DEFAULT NULL,
  `zapd` date DEFAULT NULL,
  `kodd` int(4) DEFAULT NULL,
  `zamitka` varchar(255) CHARACTER SET cp1251 DEFAULT NULL,
  `kodp` int(4) DEFAULT NULL,
  KEY `kodz` (`kodz`),
  KEY `kodp` (`kodp`),
  KEY `kodd` (`kodd`),
  CONSTRAINT `zapis_ibfk_3` FOREIGN KEY (`kodp`) REFERENCES `pac` (`kodp`),
  CONSTRAINT `zapis_ibfk_4` FOREIGN KEY (`kodd`) REFERENCES `doc` (`kodd`)
) ENGINE=InnoDB AUTO_INCREMENT=185 DEFAULT CHARSET=cp1251 COLLATE=cp1251_ukrainian_ci;

/*Data for the table `zapis` */

insert  into `zapis`(`kodz`,`zapv`,`zapd`,`kodd`,`zamitka`,`kodp`) values (177,'14:32:00','2013-03-22',13,'    hdfhgf    ',15),(178,'14:32:00','2013-03-22',10,'       hdfhgf       ',15),(179,'14:32:00','2013-03-22',10,'   hdfhgf   ',15),(180,'14:32:00','2013-03-22',12,' hdfhgf ',15),(181,'14:32:00','2013-03-22',13,'  hdfhgf  ',15),(182,'14:32:00','2013-03-22',13,'  hdfhgf  ',15),(183,'14:32:00','2013-03-22',10,'   hdfhgf   ',15),(184,'14:32:00','2013-03-22',10,' hdfhgf ',15);

/* Trigger structure for table `zapis` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `triger` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `triger` BEFORE INSERT ON `zapis` FOR EACH ROW BEGIN
if new.zapd> NOW() then
set new.zapd := now();
end if;
    END */$$


DELIMITER ;

/* Procedure structure for procedure `delete_adr` */

/*!50003 DROP PROCEDURE IF EXISTS  `delete_adr` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_adr`()
BEGIN
	SELECT
  `koda`,
  `kraina`,
  `misto`,
  `vylica`,
  `dom`,
  `kabinet`,
  `lic`
FROM `stomatolog`.`adr`
LIMIT 0, 1000;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sele` */

/*!50003 DROP PROCEDURE IF EXISTS  `sele` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sele`()
BEGIN
	SELECT
  `koda`,
  `kraina`,
  `misto`,
  `vylica`,
  `dom`,
  `kabinet`,
  `lic`
FROM `stomatolog`.`adr`
LIMIT 0, 1000;
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
