
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
machineName varchar(50) not null,
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
--openingHours varchar (50) not null,  
mCost int not null,
lastM date,
mFrequency int not null,
)
CREATE TABLE classes
(
className varchar(50) PRIMARY KEY,  
startdate date not null,
monthlyCost int not null,
sessionFrequency int not null,
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
measurementID int PRIMARY KEY, 
clientID int not null,  
measurementDate date not null,
score int not null,
recommendedWeight int not null,
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
rBdate date not null,
sex varchar(1) not null,
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
sex varchar(1) not null,
bDate date not null,
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
tWorkout varchar(14),
PRIMARY KEY(clientID, trainerSSN, trainingDate, trainingTimeSlot),
FOREIGN KEY (clientID) REFERENCES client,
FOREIGN KEY (trainerSSN) REFERENCES trainer,
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


INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (1, 'Youssef', 'Zakaria', '1/10/2000', '01064504003', '36 el jabal october', '10/10/2020', 'cash', 3)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (2, 'Ahmed', 'Mostafa', '1/12/2003', '01245678910', '12, el harm street', '12/7/2021', 'card', 2)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (3, 'Mohamed', 'Ahmed', '2/12/1999', '01223456789', '14 el bostan street', '12/12/2019', 'cash', 5)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (4, 'Kareem', 'Medhat', '2/3/2001',	'01044432221', '25 , 47 street, zayed', '3/5/2018', 'cash', 7)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (5, 'Zeyad', 'Saleh', '11/11/2002', '01064523232', '36 el ashgar', '1/1/2022', 'card', 1)


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

INSERT trainer (trainerSSN, fName, lName,sex, bDate ,phoneNum,courseLinks, salary,trainerAddress, describtion)
values (30006160100179, 'Youssef', 'Zakaria', 'M','1/10/2000','01064504003', ' https://www.coursera.org/learn/food-and-health ', 6000 ,'36 el jabal october', 'works at H2o gym')
INSERT trainer (trainerSSN, fName, lName,sex, bDate ,phoneNum,courseLinks, salary,trainerAddress, describtion)
values (30006160100178, 'Ahmed', 'Mostafa',  'M','1/1/1999','01245678910', null, 6000 ,'14 el bostan street', null)
INSERT trainer (trainerSSN, fName, lName,sex, bDate ,phoneNum,courseLinks, salary,trainerAddress, describtion)
values (30006160100177, 'Mariam', 'Ahmed',  'F','7/24/1998','01223456789', null, 5500 ,'12 el harm street', null)
INSERT trainer (trainerSSN, fName, lName,sex, bDate ,phoneNum,courseLinks, salary,trainerAddress, describtion)
values (30006160100176, 'Noura', 'Medhat',  'F','5/15/1196','01044432221', null, 7000 ,' 47 street, zayed', null)
INSERT trainer (trainerSSN, fName, lName,sex, bDate ,phoneNum,courseLinks, salary,trainerAddress, describtion)
values (30006160100175, 'Zeyad', 'Saleh',  'M','4/26/1997','01064523232', null, 7500 ,'36 el ashgar', null)

INSERT machine(machineID,machineName,purchaseDate,mFrequency,cost,mCost,mLast)
values (1,'HAMMER STRENGTH' ,'1/1/2021',3,10000,500,'4/4/2021')
INSERT machine(machineID,machineName,purchaseDate,mFrequency,cost,mCost,mLast)
values (2,'LAT PULLDOWN','4/1/2021',2,12000,1000,'10/4/2021')
INSERT machine(machineID,machineName,purchaseDate,mFrequency,cost,mCost,mLast)
values (3,'LEG EXTENSION','1/1/2021' , 1 ,11500 ,800,'12/1/2021')
INSERT machine(machineID,machineName,purchaseDate,mFrequency,cost,mCost,mLast)
values (4,'LEG CURL ','1/20/2021',1,11000,700,'12/20/2021')
INSERT machine(machineID,machineName,purchaseDate,mFrequency,cost,mCost,mLast)
values (5,'SMITH','6/25/2021',2,10500,600,'12/27/2021')
INSERT machine(machineID,machineName,purchaseDate,mFrequency,cost,mCost,mLast)
values (6,'PECK DECK','7/25/2021',2,15000,600,'12/27/2021')

INSERT facility(facilityName,mCost,lastM,mFrequency)
values ('Sauna', 2000,'6/20/2021',5)
INSERT facility(facilityName,mCost,lastM,mFrequency)
values ('jacuzzi',1500,' ',3)


INSERT classes(className,startdate,monthlyCost,sessionFrequency)
values ('Zomba','1/1/2022',500,2)
INSERT classes(className,startdate,monthlyCost,sessionFrequency)
values ('Kickbox','1/10/2022',700,3)
INSERT classes(className,startdate,monthlyCost,sessionFrequency)
values ('Acrobat','1/15/2022',450,2)
INSERT classes(className,startdate,monthlyCost,sessionFrequency)
values ('Cardio','1/20/2022',500,2)

INSERT receptionist (rSSN, fName, lName,rBdate,sex,phoneNum,courseLinks, salary, rAddress, rShift)
values (20106160100164, 'Morsy', 'Zakaria', '1/15/1998','M','01064504002', ' https://www.coursera.org/learn/food-and-health ', 5000 ,'36 el jabal october', 'Morning')
INSERT receptionist (rSSN, fName, lName,rBdate,sex,phoneNum,courseLinks, salary, rAddress, rShift)
values (20106160111279, 'Ahmed', 'Moussa','7/12/1998' ,'M','01245678911', null, 5000 ,'18 el rashad street', 'Evening')
INSERT receptionist (rSSN, fName, lName,rBdate,sex,phoneNum,courseLinks, salary, rAddress, rShift)
values (20106170100179, 'Manar', 'Essa', '8/23/1995','F','01223456788', null, 5000 ,'14 faisal street', 'Morning')
INSERT receptionist (rSSN, fName, lName,rBdate,sex,phoneNum,courseLinks, salary, rAddress, rShift)
values (20121560100179, 'Mai', 'Medhat', '4/15/1999','F','01044432222', null, 5000 ,' 47 street october', 'Evening')
