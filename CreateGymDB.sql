
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
values (2, 'Ahmed', 'Mohamed', '1/12/2003', '01245678910', '12, el harm street', '12/7/2021', 'card', 2)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (3, 'mohamed', 'Ahmed', '2/12/1999', '01223456789', '14 el bostan street', '12/12/2019', 'cash', 5)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (4, 'kareem', 'medhat', '2/3/2001',	'01044432221', '25 , 47 street, zayed', '3/5/2018', 'cash', 7)
INSERT client (clientID, fName, lName,bDate,phoneNum,clientAddress, startDate,paymentMethod, invitationNum)
values (5, 'zyad', 'saleh', '11/11/2002', '01064523232', '36 el ashgar', '1/1/2022', 'card', 1)


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


INSERT machine(machineID, purchaseDate,mFrequency,cost,mCost,mLast)
values (3, '1/6/2022' , 1 ,11500 ,800,null)