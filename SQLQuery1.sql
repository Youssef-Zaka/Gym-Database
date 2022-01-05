
CREATE DATABASE Gym
GO 
USE Gym
CREATE TABLE supplement
(
supplementID INT PRIMARY KEY, 
sName Varchar(50) ,
stock int,
cost int,
sType Varchar(50),
)
CREATE TABLE machine
(
machineID INT PRIMARY KEY, 
purchaseDate date,
mFrequency int,
cost int,
mCost int,
mLast date,
)

CREATE TABLE excersise
(
excersiseID INT PRIMARY KEY, 
exName varchar(50),
exDescription varchar(50),
duration int,
exImage image,
)

CREATE TABLE workout
(
workoutID INT PRIMARY KEY, 
workoutType varchar(50),
workoutDescription varchar(50),
)

CREATE TABLE gymAdmin
(
adminSSN varchar(14) PRIMARY KEY, 
fName varchar (50),
lName varchar (50),
salary int,
phoneNum varchar(11),
adminAddress varchar(50),
)
CREATE TABLE facility
(
facilityName varchar(50) PRIMARY KEY, 
openingHours varchar (50),  
mCost int,
lastM date,
mFrequency int,
)

CREATE TABLE achievement
(
achievementID int PRIMARY KEY, 
achievementName varchar (50),
Describtion text,  
score int,
)

CREATE TABLE measurement
(
measurementID int PRIMARY KEY, 
clientID int,  
measurementDate date,
score int,
recommendedWeight int,
cHeight int,
cBodyType varchar(50),
cWeight int,
)
CREATE TABLE receptionist
(
rSSN varchar(14) PRIMARY KEY, 
fName varchar (50),
lName varchar (50),
phoneNum varchar(11),  
courseLinks text,
salary int,
rAddress varchar(50),
rShift varchar(50),
)
CREATE TABLE trainer
(
trainerSSN varchar(14) PRIMARY KEY, 
fName varchar (50),
lName varchar (50),
phoneNum varchar(11),  
courseLinks text,
salary int,
trainerAddress varchar(50),
describtion text,
)

CREATE TABLE client
(
clientID int PRIMARY KEY, 
fName varchar (50),
lName varchar (50),
bDate date,
phoneNum varchar(11),  
clientAddress varchar(50),
startDate date,
paymentMethod varchar(50),
invitationNum int,
)

CREATE TABLE potentialClient
(
SSN varchar(14), 
fName varchar (50),
lName varchar (50),
bDate date,
phoneNum varchar(11),  
clientAddress varchar(50),
visitDate date,
)

