
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
PRIMARY KEY(clientID,trainerSSN),
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


