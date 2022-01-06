
CREATE DATABASE Gym
GO 
USE Gym
CREATE TABLE supplement
(
supplementID INT PRIMARY KEY, 
sName Varchar(50) not null,
stock int not null,
cost int not null,
sType Varchar(50) not null,
)
CREATE TABLE machine
(
machineID INT PRIMARY KEY, 
purchaseDate date not null,
mFrequency int not null,
cost int  not null,
mCost int not null,
mLast date,
)

CREATE TABLE excersise
(
excersiseID INT PRIMARY KEY, 
exName varchar(50) not null,
exDescription varchar(50),
duration int not null,
exImage image,
)

CREATE TABLE workout
(
workoutID INT PRIMARY KEY, 
workoutType varchar(50) not null,
workoutDescription varchar(50),
)

CREATE TABLE contain
(
workoutID INT, 
excersiseID INT,
PRIMARY KEY(workoutID,excersiseID),
FOREIGN KEY (workoutID) REFERENCES workout,
FOREIGN KEY (excersiseID) REFERENCES excersise,
)

CREATE TABLE gymAdmin
(
adminSSN varchar(14) PRIMARY KEY, 
fName varchar (50) not null,
lName varchar (50) not null,
salary int not null,
phoneNum varchar(11) not null,
adminAddress varchar(50) not null,
)

CREATE TABLE facility
(
facilityName varchar(50) PRIMARY KEY, 
openingHours varchar (50) not null,  
mCost int not null,
lastM date not null,
mFrequency int not null,
)

CREATE TABLE client
(
clientID int PRIMARY KEY, 
fName varchar (50) not null,
lName varchar (50) not null,
bDate date not null,
phoneNum varchar(11) not null,  
clientAddress varchar(50) not null,
startDate date not null,
paymentMethod varchar(50) not null,
invitationNum int not null,
)

CREATE TABLE achievement
(
achievementID int PRIMARY KEY, 
achievementName varchar (50) not null,
Describtion text,  
score int not null,
)

CREATE TABLE achieved
(
clientID int , 
achievementID int,
PRIMARY KEY(clientID,achievementID),
FOREIGN KEY (clientID) REFERENCES client,
FOREIGN KEY (achievementID) REFERENCES achievement,
)


CREATE TABLE measurement
(
measurementID int IDENTITY(1,1) PRIMARY KEY  , 
clientID int not null,  
measurementDate date not null,
score int ,
recommendedWeight int ,
cHeight int not null,
cBodyType varchar(50) not null,
cWeight int not null,
FOREIGN KEY (clientID) REFERENCES client,
)

CREATE TABLE receptionist
(
rSSN varchar(14) PRIMARY KEY, 
fName varchar (50) not null,
lName varchar (50) not null,
phoneNum varchar(11) not null,  
courseLinks text,
salary int not null,
rAddress varchar(50) not null,
rShift varchar(50) not null,
)

CREATE TABLE trainer
(
trainerSSN varchar(14) PRIMARY KEY, 
fName varchar (50) not null,
lName varchar (50) not null,
phoneNum varchar(11) not null,  
courseLinks text,
salary int not null,
trainerAddress varchar(50) not null,
describtion text,
)
CREATE TABLE trains
(
trainerSSN varchar(14) , 
clientID int,
trainingDate date,
trainingTimeSlot time,
tWorkout int,
PRIMARY KEY(clientID, trainerSSN, trainingDate, trainingTimeSlot),
FOREIGN KEY (clientID) REFERENCES client,
FOREIGN KEY (trainerSSN) REFERENCES trainer,
FOREIGN KEY (tWorkout) REFERENCES workout,
)

CREATE TABLE potentialClient
(
SSN varchar(14) not null, 
fName varchar (50) not null,
lName varchar (50) not null,
bDate date not null,
phoneNum varchar(11) not null,  
clientAddress varchar(50) not null,
visitDate date not null,
)

CREATE TABLE subscription
(
subscriptionID int PRIMARY KEY , 
cost int not null,
duration int not null,
subType varchar(50) not null,
)

CREATE TABLE subcribed_In
(
subscriptionID int,
clientID int , 
PRIMARY KEY(clientID,subscriptionID),
FOREIGN KEY (clientID) REFERENCES client,
FOREIGN KEY (subscriptionID) REFERENCES subscription,
)

----------------------------------- Client Insersion -------------------------------------------------
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (1, 'Youssef', 'Zakaria', '1/10/2000', '01064504003', '36 el jabal october', '10/10/2020', 'cash', 3)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (2, 'Ahmed', 'Mohamed', '1/12/2003', '01245678910', '12, el harm street', '12/7/2021', 'card', 2)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (3, 'mohamed', 'Ahmed', '2/12/1999', '01223456789', '14 el bostan street', '12/12/2019', 'cash', 5)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (4, 'kareem', 'medhat', '2/3/2001',	'01044432221', '25 , 47 street, zayed', '3/5/2018', 'cash', 7)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (5, 'zyad', 'saleh', '11/11/2002', '01064523232', '36 el ashgar', '1/1/2022', 'card', 1)

----------------------------------- Subscribtion Insersion -------------------------------------------------
INSERT subscription (subscriptionID, cost,duration,subType)
values (1, 400, 1, 'paid')
INSERT subscription (subscriptionID, cost,duration,subType)
values (2, 1000, 3, 'paid')
INSERT subscription (subscriptionID, cost,duration,subType)
values (3, 1800, 6, 'paid')
INSERT subscription (subscriptionID, cost,duration,subType)
values (4, 3000, 12, 'paid')
INSERT subscription (subscriptionID, cost,duration,subType)
values (5, 0, 1, 'bonus')
INSERT subscription (subscriptionID, cost,duration,subType)
values (6, 0, 3, 'bonus')
INSERT subscription (subscriptionID, cost,duration,subType)
values (7, 200, 1, 'paid-discounted')
INSERT subscription (subscriptionID, cost,duration,subType)
values (8, 500, 3, 'paid-discounted')

----------------------------------- subscribed in relation-------------------------------------------------

INSERT subcribed_In (subscriptionID,clientID)
values (1 , 1)
INSERT subcribed_In (subscriptionID,clientID)
values (3 , 2)
INSERT subcribed_In (subscriptionID,clientID)
values (5 , 3)
INSERT subcribed_In (subscriptionID,clientID)
values (2 , 4)
INSERT subcribed_In (subscriptionID,clientID)
values (4 , 5)

----------------------------------- acheivement Insersion -------------------------------------------------

INSERT achievement (achievementID, achievementName,Describtion,score)
values (1, '100Pushups','Do a 100 pushups for 7 days in a row',10)
INSERT achievement (achievementID, achievementName,Describtion,score)
values (2, '100Situps','Do a 100 situps for 7 days in a row',10)
INSERT achievement (achievementID, achievementName,Describtion,score)
values (3, '120KGLegPress','Do 10 reps of 120 kg leg press',50)
INSERT achievement (achievementID, achievementName,Describtion,score)
values (4, '120KGBenchPress','Do 10 reps of 120 kg bench press',50)
INSERT achievement (achievementID, achievementName,Describtion,score)
values (5, 'Run20KM','Run 20 kms on the Treadmil in under 90 minutes',100)
INSERT achievement (achievementID, achievementName,Describtion,score)
values (6, 'Bike40KM','bike 40 kms on the Bike machine in under 30 minutes',100)

----------------------------------- Measurement Insersion -------------------------------------------------

SET IDENTITY_INSERT measurement ON
INSERT measurement (measurementID,clientID,measurementDate,recommendedWeight,cWeight,cHeight,cBodyType,score)
Values (1,1,'1/10/2021' , 70, 80,  170,'fit',90)
INSERT measurement (measurementID,clientID,measurementDate,recommendedWeight,cWeight,cHeight,cBodyType,score)
Values (2,2,'1/10/2020' , 80, 90,  190,'obese',85)
INSERT measurement (measurementID,clientID,measurementDate,recommendedWeight,cWeight,cHeight,cBodyType,score)
Values (3,3,'1/3/2021' , 60, 60,  140,'slim',93)
INSERT measurement (measurementID,clientID,measurementDate,recommendedWeight,cWeight,cHeight,cBodyType,score)
Values (4,4,'3/5/2021' , 65, 70,  180,'fit',84)
INSERT measurement (measurementID,clientID,measurementDate,recommendedWeight,cWeight,cHeight,cBodyType,score)
Values (5,5,'1/1/2022' , 67, 67,  165,'fit',82)
INSERT measurement (measurementID,clientID,measurementDate,recommendedWeight,cWeight,cHeight,cBodyType,score)
Values (7,1,'1/12/2021' , 70, 79,  171,'fit',92)
SET IDENTITY_INSERT measurement OFF


----------------------------------- acheived relation-------------------------------------------------
INSERT achieved (clientID, achievementID)
values (1,1)
INSERT achieved (clientID, achievementID)
values (1,2)
INSERT achieved (clientID, achievementID)
values (2,3)
INSERT achieved (clientID, achievementID)
values (3,4)
INSERT achieved (clientID, achievementID)
values (4,5)
INSERT achieved (clientID, achievementID)
values (5,6)

----------------------------------- trainer Insersion -------------------------------------------------
INSERT trainer (trainerSSN, fName, lName, phoneNum, courseLinks, salary, trainerAddress, describtion)
values (29762368974566, 'Hossam', 'Mahmoud', '01064504003', 
		'https://www.udemy.com/course/complete-fitness-trainer-certification-beginner-to-advanced/', 
		10100, '12 Ali Abdelaziz street', '5+ years of experience in fitness training')

INSERT trainer (trainerSSN, fName, lName, phoneNum, courseLinks, salary, trainerAddress, describtion)
values (24621238976533, 'Mohamed', 'Hanafy', '01148955762', 
		'https://www.udemy.com/course/internationally-accredited-diploma-certificate-in-fitness/', 
		8500, '12 Mahmoud Saied street', 'Personal Trainer')

INSERT trainer (trainerSSN, fName, lName, phoneNum, courseLinks, salary, trainerAddress, describtion)
values (30004170104569, 'Reem', 'Mosaad', '01224697845', 
		'https://www.udemy.com/course/complete-fitness-trainer-certification-beginner-to-advanced/ , https://www.udemy.com/course/internationally-accredited-diploma-certificate-in-fitness/', 
		7000, '10 Elmohamdy street', 'Personal Fitness Trainer')

INSERT trainer (trainerSSN, fName, lName, phoneNum, courseLinks, salary, trainerAddress, describtion)
values (27895632138977, 'Ahmed', 'Hossney', '01112659786', 
		'https://www.udemy.com/course/complete-fitness-trainer-certification-beginner-to-advanced/', 
		5700, 'Nasr street, Maadi', 'ISSA Certified Fitness Trainer, Specialist in Performance Nutrition')


INSERT trainer (trainerSSN, fName, lName, phoneNum, courseLinks, salary, trainerAddress, describtion)
values (28885675542369, 'Ramy', 'Hassanein', '01164904700', 
		NULL, 
		10200, '77 street', 'Body building specialist')


INSERT trainer (trainerSSN, fName, lName, phoneNum, courseLinks, salary, trainerAddress, describtion)
values (30001359794566, 'Mona', 'Waheed', '01068504103', 
		'https://www.udemy.com/course/the-complete-fitness-health-masterclass/', 
		7500, '1 Eldokki street', '3+ year of experience in nutrition science')

INSERT trainer (trainerSSN, fName, lName, phoneNum, courseLinks, salary, trainerAddress, describtion)
values (30008976564599, 'Walaa', 'Waheed', '01003265323', 
		NULL, 
		6500, '1 Eldokki street', 'Nutrition Specialist')

----------------------------------- workout Insertion ------------------------------------------------
INSERT workout (workoutID, workoutType, workoutDescription)
values (1, 'Cardio', 'Includes exercises increase a person�s heart rate. Cardio exercises can be beneficial to people who want to reach or maintain a moderate weight or stay healthy.')
INSERT workout (workoutID, workoutType, workoutDescription)
values (2, 'Stretching', 'Stretching keeps the muscles flexible, strong, and healthy.')
INSERT workout (workoutID, workoutType, workoutDescription)
values (3, 'Balance', 'Balance training involves doing exercises that strengthen the muscles that help keep you upright, including your legs and core.')
INSERT workout (workoutID, workoutType, workoutDescription)
values (4, 'Weigh lifting', 'Weightlifting is a type of strength training that uses weights for resistance, by creating a stress to the muscles performed with free weights or weight machines.')

----------------------------------- trains Insersion -------------------------------------------------
INSERT trains (trainerSSN, clientID, trainingDate, trainingTimeSlot, tWorkout)
values (30008976564599, 2, '1-1-2022', '08:00:00', 1)
INSERT trains (trainerSSN, clientID, trainingDate, trainingTimeSlot, tWorkout)
values (30008976564599, 2, '3-1-2022', '08:00:00', 4)
INSERT trains (trainerSSN, clientID, trainingDate, trainingTimeSlot, tWorkout)
values (28885675542369, 3, '1-1-2022', '13:00:00', 2)
INSERT trains (trainerSSN, clientID, trainingDate, trainingTimeSlot, tWorkout)
values (28885675542369, 3, '2-1-2022', '10:00:00', 4)
INSERT trains (trainerSSN, clientID, trainingDate, trainingTimeSlot, tWorkout)
values (24621238976533, 4, '9-1-2022', '12:00:00', 3)
INSERT trains (trainerSSN, clientID, trainingDate, trainingTimeSlot, tWorkout)
values (29762368974566, 5, '22-2-2022', '17:30:00', 1)

----------------------------------- Excercises Insersion -------------------------------------------------
INSERT excersise (excersiseID, exName, exDescription, duration, exImage)
values (1, 'Jogging', 'Running in small paces ahead', 5, NULL)
INSERT excersise (excersiseID, exName, exDescription, duration, exImage)
values (2, 'Jump Rope', 'Using rope to jump over it', 6, NULL)
INSERT excersise (excersiseID, exName, exDescription, duration, exImage)
values (3, 'Side Stretch', 'raising the left arm up and sideways over the head', 3, NULL)
INSERT excersise (excersiseID, exName, exDescription, duration, exImage)
values (4, 'Lunges', 'stepping forward, lowering your body toward the ground, and returning back to the starting position.', 3, NULL)
INSERT excersise (excersiseID, exName, exDescription, duration, exImage)
values (5, 'Heel-to-toe Walk', 'For older adults to keep balance', 7, NULL)
INSERT excersise (excersiseID, exName, exDescription, duration, exImage)
values (6, 'Step-up', 'Moving legs over stairs one leg at at time', 6, NULL)
INSERT excersise (excersiseID, exName, exDescription, duration, exImage)
values (7, 'Deadlift', 'Use a weighted bar and lift it up the ground with hands and your straight back', 10, NULL)
INSERT excersise (excersiseID, exName, exDescription, duration, exImage)
values (8, 'Bench Press', 'Lean on the bench, and push the weighted bar in your chest level', 8, NULL)




