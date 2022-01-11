-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: tracnghiemapp
-- ------------------------------------------------------
-- Server version	8.0.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Tiếng anh'),(2,'Triết học Mác - Lênin'),(3,'Cơ sở lập trình'),(4,'Cơ sở dữ liệu');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `histories`
--

DROP TABLE IF EXISTS `histories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `histories` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name_id` int DEFAULT NULL,
  `timefinish` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `score` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_nameId` (`name_id`),
  CONSTRAINT `FK_nameId` FOREIGN KEY (`name_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `histories`
--

LOCK TABLES `histories` WRITE;
/*!40000 ALTER TABLE `histories` DISABLE KEYS */;
INSERT INTO `histories` VALUES (1,1,'30',8),(2,7,'32',6);
/*!40000 ALTER TABLE `histories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `question`
--

DROP TABLE IF EXISTS `question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `question` (
  `id` int NOT NULL AUTO_INCREMENT,
  `content` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `a` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `b` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `c` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `d` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `result` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `category_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_cateId` (`category_id`),
  CONSTRAINT `FK_cateId` FOREIGN KEY (`category_id`) REFERENCES `category` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `question`
--

LOCK TABLES `question` WRITE;
/*!40000 ALTER TABLE `question` DISABLE KEYS */;
INSERT INTO `question` VALUES (1,'Lệnh nào trong các lệnh sau cho phép dừng câu lệnh điều khiển:','break','goto','continue','Cả 3 đáp án','B',3),(2,'Lệnh nào trong các lệnh sau cho phép dừng câu lệnh điều khiển:','exit','goto','continue','Cả 3 đáp án','B',3),(3,'Lệnh nào trong các lệnh sau cho phép dừng câu lệnh điều khiển:','exit','goto','continue','Cả 3 đáp án','B',3),(4,'Lệnh nào trong các lệnh sau cho phép dừng câu lệnh điều khiển:','exit','goto','continue','Cả 3 đáp án','B',3),(5,'Lệnh nào trong các lệnh sau cho phép dừng câu lệnh điều khiển:','exit','goto','continue','Cả 3 đáp án','B',3),(6,'Lệnh nào trong các lệnh sau cho phép dừng câu lệnh điều khiển:','exit','goto','continue','Cả 3 đáp án','B',3),(8,'Lệnh nào trong các lệnh sau cho phép dừng câu lệnh điều khiển:','exit','goto','continue','Cả 3 đáp án','B',3),(9,'I have been waiting for you……………','since early morning','since 9 a.m','for two hours','all are correct','D',1),(10,'My sister…………for you since yesterday.','is looking','was looking','has been looking','looked','C',1),(11,'Jack…………the door.','has just painted','paint','will have painted','painting','A',1),(12,'\"I have never been to Russia. I think I shall go there next year.” said Bill.','Bill said that he had never been to Russia and he thought he would go there the next year.','Bill said that he would have never been to Russia and he thinks he would go there the next year.','Bill said that he had never been to Russia and he thinks he will go there the next year.','Bill said that he has never been to Russia and he thinks he would go there the next year.','A',1),(13,'People believed that Jane retired because of her poor health.','Jane is believed to have retired because of her poor health.','Jane was believed to have retired because of her poor health.','It is believed that Jane retired because of her poor health.','Jane retired because of her poor health was believed.','B',1),(14,'The government knows the extent of the problem. The government needs to take action soon.','The government knows the extent of the problem whereas it needs to take action soon.','The government knows the extent of the problem so that it needs to take action soon.','Knowing the extent of the problem, the government needs to take action soon.','The government knows the extent of the problem, or else it needs to take action soon.','C',1),(15,'The substance is very toxic. Protective clothing must be worn at all times.','Since the substance is very toxic, so protective clothing must be worn at all times.','So toxic is the substance that protective clothing must be worn at all times.','The substance is such toxic that protective clothing must be worn at all times.','The substance is too toxic to wear protective clothing at all times.','B',1),(16,'John is studying hard. He doesn’t want to fail the exam.','John is studying hard in Oder not to fail the next exam','John is studying hard in Oder that he not fail the next exam','John is studying hard so as to fail the next exam',' John is studying hard in Oder to not to fail the next exam','A',1),(17,'She gave in her notice. She planned to start her new job in January','She gave in her notice, plan to start her new job in January','She gave in her notice with a view to starting her new job in January','Her notice was given in with an aim to start her new job in January','Her notice was given in order for her to start her new job in January.','B',1),(18,'When the unemployment rate is high, the crime rate is usually also high.','The unemployment rate and the crime rate are both higher.',' The higher the unemployment rate is, the higher the crime rate is.','The unemployment rate is as high as the crime rate.','The high rate of unemployment depends on the high rate of crime.','B',1),(19,'Steve said to Mike, “Don’t touch the electric wires. It might be deadly.”','Steve advised Mike not to touch the electric wires as it might be deadly.','Steve warned Mike not to touch the wires as it might be deadly.','Steve suggested that Mike not touch the electric wires as it might be deadly.','Steve did not allow Mike to touch the electric wires as it might be deadly.','B',1),(20,'I did not see Susan off at the airport. I feel bad about it now.','I could have seen Susan off at the airport.','If only I had seen Susan off at the airport.','That I did not see Susan off at the airport escapes me now.','It suddenly dawns on me that I should have seen Susan off at the airport.','B',1),(21,'Sam doesn’t find it difficult to get up early in the morning.','Sam is in two minds about getting up early in the morning.','Sam is not hesitant to get up early in the morning.','Sam is accustomed to getting up early in the morning.','Sam is pleased with getting up early in the morning.','C',1),(22,'People rumour that the Prince secretly got married to an ordinary girl.','The Prince is rumoured to have secretly got married to an ordinary girl.','It was rumoured that the Prince secretly got married to an ordinary girl.','The Prince was rumoured to secretly get married to an ordinary girl.','The Prince had secretly got married to an ordinary girl, as it was rumoured.','A',1),(23,'There is no doubt that Martin is the best candidate for the job.','Martin is by all means the best candidate for the job.','Without question, Martin is the best candidate for the job.','In all likelihood, Martin is the best candidate for the job.','Quite by chance, Martin is the best candidate for the job.','B',1),(24,'He is very intelligent. He can solve all the problems in no time.','So intelligent is he that he can solve all the problems in no time.','He is very intelligent that he can solve all the problems in no time.','An intelligent student is he that he can solve all the problems in no time.','So intelligent a student is he that he can solve all the problems in no time.','A',1),(25,'We cut down many forests. The Earth becomes hot.','The more forests we cut down, the hotter the Earth becomes.','The more we cut down forests, the hotter the Earth becomes.','The more forests we cut down, the Earth becomes hotter.','The more we cut down forests, the Earth becomes hotter.','A',1),(26,'It was an interesting novel. I, therefore, stayed up all night to finish it.','Though it was an interesting novel, I stayed up all night to finish it.','Unless it was an interesting novel, I would stay up all night to finish it.','So interesting was the novel that I stayed up all night to finish it.','I stayed up all night to finish the novel, therefore, it was interesting.','C',1),(27,'“Go on Jack, apply for the job” said Mary.','Mary told Jack to go on and apply for the job.','Mary suggested applying for the job.','Mary said that Jack would apply for the job.','Mary encouraged Jack to apply for the job.','D',1),(28,'I hardly know the truth about Jean’s success in the institute.','I do not know much about Jean’s success in the institute.','It is difficult for Jean to be successful in the institute.','Jean’s success in the institute was not to be known.','Jean hardly become known and successful in the institute.','A',1),(29,'Mary doesn’t like sport. Her two brothers don’t, either.','Neither Mary or her two brothers like sport.','Either Mary nor her two brothers likes sport.','Neither Mary nor her two brothers like sport.','Either Mary or her two brothers like sport.','C',1),(30,'How long have you ------------- he was a liar.','been knowing','knew','know','known','D',1),(31,'This soup is very hot, but I always think the ............... better.','hotter the','hottest','hotter','hot the','A',1),(32,'In my country it\'s ........ warmer than in Japan.','more','many','lot','much','D',1),(33,'Do you get ......................... well with your neighbors?','during','on','next','last','B',1),(34,'It isn\'t as cold today as it ..................... yesterday.','was','were','is','be','A',1),(35,'He is ...................................... boy in the class.','funny','funniest','funnier','the funniest','D',1),(36,'I\'m as ......................... as you are.','worried','worry','worrying','worry','A',1),(37,'My car wasn\'t .................... expensive as yours.','more','the most','as','much','C',1),(39,'How long did it _________ you to type this letter?','want','take','need','require','B',1),(40,'“Where are the letter and the postcard?” They ...... on the table.','were','are','is','have been','B',1),(41,'What is your purpose ........... learning English?','of','to','for','on','A',1),(42,'To my .........., John is very good at Vietnamese.','amazing','amazed','amaze','amazement','D',1),(43,'When I came home yesterday, my wife .............','cooks','cooked','cooking','was cooking','D',1),(44,'What .... to do when you graduate?','are you going','are going','you are going','are you go','A',1);
/*!40000 ALTER TABLE `question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fullname` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Thanh Sang'),(2,'sang'),(3,'sa'),(4,'sang'),(5,'sang'),(6,'sa'),(7,'abc'),(8,'sa');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-01-11 12:29:00
