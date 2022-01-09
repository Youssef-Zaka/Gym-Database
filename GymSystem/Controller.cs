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

        public int InsertTrainer(long trainerssn, string firstname, string lastName, string sex, string trainerdate, long phone, string link, int salary, string address, string description)

        public DataTable SelectSubscriptionDetails(int ClientID)
        {
            string query = "INSERT INTO trainer (trainerSSN, fName, lName, sex, bDate ,phoneNum, courseLinks, salary, trainerAddress ,describtion) " +
                            "Values ('" + trainerssn + "','" + firstname + "','" + lastName + "','" + sex + "','" + Convert.ToDateTime(trainerdate) + "','" + phone + "','" + link + "','" + salary + "','" + address + "','" + description + "')";

            return dbMan.ExecuteNonQuery(query);
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
        public int InsertSupplier(string snum, string sname, string city, int status)
        {
            string query = "INSERT INTO S (S#, Name, City, Status) " +
                            "Values ('" + snum + "','" + sname + "','" + city + "'," + status + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Selectmachineid()
        {
            string query = "SELECT machineID FROM machine;";
            return dbMan.ExecuteReader(query);
        }

        
        public int DeleteSupplier(string snum)
        {
            string query = "DELETE FROM S WHERE S#='" + snum + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        public int UpdateSupplier(string snum, string city)
        {
            string query = "UPDATE S SET City='" + city + "' WHERE S#='" + snum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

       

        public DataTable SelectAllSuppliers()
        {
            string query = "SELECT className FROM classes;";
            return dbMan.ExecuteReader(query);
        }
        

   
        public int CountEmployees(string ProjNum)
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
        public int Updateclass(string classname , string classdate ,int classcost ,int classfreq)
        {
            string query = "UPDATE classes SET startdate='" + Convert.ToDateTime(classdate) + "', monthlyCost= + '" + classcost + "',sessionFrequency= + '" + classfreq + "'WHERE className='" + classname + "';";
            return dbMan.ExecuteNonQuery(query);
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

