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


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
