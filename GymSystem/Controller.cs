using System;
using System.Data;

namespace GymSystem
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        
        public DataTable SelectSubscriptionDetails(int ClientID)
        {
            
            string query = "Select * FROM subscription,subcribed_In Where clientID = " + ClientID + " AND subscription.subscriptionID = subcribed_In.subscriptionID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAchievementsDetails(int ClientID)
        {
            string query = "Select achievement.achievementName , .achievement.Describtion, achievement.score FROM client, achieved, achievement Where client.clientID = "
                + ClientID + " AND client.clientID = achieved.clientID AND achieved.achievementID = achievement.achievementID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectClient(int ClientID)
        {
            string query = "Select * FROM client WHERE clientID = " + ClientID;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectHallOfFame()
        {
            string query = "Select TOP(3)	client.fName, client.lName, " +
        " SUM(achievement.score) AS Score FROM client, achieved, achievement" +
        " WHERE achieved.clientID = client.clientID AND achieved.achievementID = achievement.achievementID " +
        " GROUP BY client.fName, client.lName , client.clientID "+
        " ORDER BY SUM(achievement.score) DESC ";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectMeasurements(int ClientID)
        {
            string query = "Select * FROM measurement WHERE  measurement.clientID = " + ClientID +
                " ORDER BY measurement.measurementDate DESC";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectFoodMeasurements(int ClientID)
        {
            string query = "Select * FROM foodMeasurement WHERE  foodMeasurement.clientID = " + ClientID +
                " ORDER BY foodMeasurement.measurementDate DESC";
            return dbMan.ExecuteReader(query);
        }

        public int InsertMeasurement(int ClientID, DateTime date, int cWeight, int cHeight, string cBodyType)
        {
            string query = "INSERT measurement (clientID,measurementDate,cWeight,cHeight,cBodyType)" +
                            "Values (" + ClientID + ", '" + date.ToShortDateString() + "', "+ cWeight +", " + cHeight + ", '" + cBodyType + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertFoodMeasurement(int ClientID, DateTime date, int callories, int sleepHours, int numCups)
        {
            string query = "INSERT foodMeasurement (clientID,measurementDate,callories,sleepHours,numCups)" +
                            "Values (" + ClientID + ", '" + date.ToShortDateString() + "', " + callories + ", " + sleepHours + ", " + numCups + ");";
            return dbMan.ExecuteNonQuery(query);
        }




        // ========================= "Trainer" Functions =========================


        public DataTable SelectTrainer(string trainerSSN)
        {
            string query = $"Select * FROM trainer WHERE trainerSSN = '{trainerSSN}';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectClientsTrainedBy(string trainerSSN)
		{
            string query = "SELECT DISTINCT client.clientID, fName, lName, bDate, phoneNum, clientAddress, startDate " +
                "FROM client, trains " +
                $"WHERE client.clientID = trains.clientID AND trains.trainerSSN = '{trainerSSN}';";

            return dbMan.ExecuteReader(query);
		}

        public DataTable SelectCourseLinks(string SSN)
        {
            string query = $"SELECT C.courseLink FROM trainerCourses C WHERE C.trainerSSN = '{SSN}';";
            return dbMan.ExecuteReader(query);
        }











        // ========================= ================================ =========================
        public int InsertTrainer(long trainerssn, string firstname, string lastName, string sex, string trainerdate, long phone, string link, int salary, string address, string description)

        {
            string query = "INSERT INTO trainer (trainerSSN, fName, lName, sex, bDate ,phoneNum, courseLinks, salary, trainerAddress ,describtion) " +
                            "Values ('" + trainerssn + "','" + firstname + "','" + lastName + "','" + sex + "','" + Convert.ToDateTime(trainerdate) + "','" + phone + "','" + link + "','" + salary + "','" + address + "','" + description + "')";

            return dbMan.ExecuteNonQuery(query);
        }

        public int Insertreceptionist(long receptionssn, string firstname, string lastName, string rbdate, string sex, long rphone, string link, int salary, string raddress, string rshift)

        {
            string query = "INSERT INTO receptionist (rSSN, fName, lName, rBdate, sex , phoneNum ,courseLinks, salary, rAddress ,rShift) " +
                            "Values ('" + receptionssn + "','" + firstname + "','" + lastName + "','" + Convert.ToDateTime(rbdate) + "','" + sex + "','" + rphone + "','" + link + "','" + salary + "','" + raddress + "','" + rshift + "')";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Selecttrainer()
        {
            string query = "SELECT trainerSSN FROM trainer;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectreceptionist()
        {
            string query = "SELECT rSSN FROM receptionist;";
            return dbMan.ExecuteReader(query);
        }

        public int deletereceptionist(long receptionssn)
        {
            string query = "DELETE FROM receptionist WHERE rSSN = " + receptionssn;
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletatrainer(long trainerssn)
        {
            string query = "DELETE FROM trainer WHERE trainerSSN = " + trainerssn;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Selectallmachines()
        {
            string query = "SELECT * FROM machine;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectmachineid()
        {
            string query = "SELECT machineID FROM machine;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Selectmachine(int id)
        {
            string query = "SELECT * FROM machine WHERE machineID='" + id + "'";
            return dbMan.ExecuteReader(query);
        }


        public DataTable Selectallclasses()
        {
            string query = "SELECT * FROM classes;";
            return dbMan.ExecuteReader(query);
        }


        public int Insertclass(string className, string startdate, int monthlyCost, int sessionFrequency)
        {
            string query = "INSERT INTO classes (className, startdate, monthlyCost, sessionFrequency) " +
                            "Values ('" + className + "','" + Convert.ToDateTime(startdate) + "','" + monthlyCost + "','" + sessionFrequency + "')";

            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteclass(string classname)
        {
            string query = "DELETE FROM classes WHERE className='" + classname + "';"; ;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Selectclassnames()
        {
            string query = "SELECT className FROM classes;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectclassForClients()
        {
            string query = "Select className, monthlyCost, sessionFrequency from classes";
            return dbMan.ExecuteReader(query);
        }

        public int Insertservice(string facilityName, int mcost, string lastmaintenance, int maintenancefreq)
        {
            string query = "INSERT INTO facility (facilityName, mCost, lastM, mFrequency) " +
                            "Values ('" + facilityName + "','" + mcost + "','" + Convert.ToDateTime(lastmaintenance) + "','" + maintenancefreq + "')";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable showservices()
        {
            string query = "SELECT * FROM facility;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable showservicename()
        {
            string query = "SELECT facilityName FROM facility;";
            return dbMan.ExecuteReader(query);
        }
        public int deleteservice(string servicename)
        {
            string query = "DELETE FROM facility WHERE facilityName='" + servicename + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable showstrainersinfo()
        {
            string query = "SELECT trainerSSN,fName,lName,salary FROM trainer;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable showsreceptioninfo()
        {
            string query = "SELECT rSSN,fName,lName,salary FROM receptionist;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable showtrainerSSN()
        {
            string query = "SELECT trainerSSN FROM trainer;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable showreceptionSSN()
        {
            string query = "SELECT rSSN FROM receptionist;";
            return dbMan.ExecuteReader(query);
        }
        public int Updateclass(string classname, string classdate, int classcost, int classfreq)
        {
            string query = "UPDATE classes SET startdate='" + Convert.ToDateTime(classdate) + "', monthlyCost= + '" + classcost + "',sessionFrequency= + '" + classfreq + "'WHERE className='" + classname + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectPrivateWorkoutSchedule(int Id)
        {
            string query = "Select trainer.fName as NameOfTrainer, trains.trainingDate  as trainingDate , trains.trainingTimeSlot as trainingTimeSlot, workout.workoutType as Workout "
                            + "from trains , trainer, workout where trains.clientID = " + Id + " AND trainer.trainerSSN = trains.trainerSSN AND workout.workoutID = trains.tWorkout";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectWorkouts(int Id)
        {
            string query = "SELECT workoutType FROM workout ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectExcerciseInWorkout(string WorkoutType)
        {
            string query = "Select excersise.exName, excersise.duration, excersise.exDescription From workout , excersise, contain where workout.workoutType = '"
                            + WorkoutType + "' AND workout.workoutID = contain.workoutID AND excersise.excersiseID = contain.excersiseID";
            return dbMan.ExecuteReader(query);
        }



        public int Updateservice(string facilityname, int mCost, string lastM, int mFrequency)
        {
            string query = "UPDATE facility SET mCost='" + mCost + "', lastM= + '" + Convert.ToDateTime(lastM) + "',mFrequency= + '" + mFrequency + "'WHERE facilityName='" + facilityname + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

