﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

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
        public int InsertSupplier(string snum, string sname, string city, int status)
        {
            string query = "INSERT INTO S (S#, Name, City, Status) " +
                            "Values ('" + snum + "','" + sname + "','" + city + "'," + status + ");";
            return dbMan.ExecuteNonQuery(query);
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
            string query = "SELECT * FROM S;";
            return dbMan.ExecuteReader(query);
        }
        

   
        public int CountEmployees(string ProjNum)
        {
            string query = "SELECT COUNT(Essn) FROM Works_On WHERE Pno =" + ProjNum + ";";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
