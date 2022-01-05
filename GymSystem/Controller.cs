using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int InsertSupplier(string snum, string sname, string city, int status)
        {
            string query = "INSERT INTO S (S#, Name, City, Status) " +
                            "Values ('" + snum + "','" + sname + "','" + city + "'," + status + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertEmployee(string FName, string Minit, string LName, string SSN, DateTime BDate, string Adress
            , string Sex, string Sallary , string SuperSSN, string Dno)
        {
            string query = "INSERT INTO Employee (Fname, Minit, Lname, SSN, Bdate, Address, Sex, Salary, Super_SSN, Dno) " +
                            "Values ('" + FName + "','" + Minit + "','" + LName + "'," + SSN;

            if (BDate.Year >= DateTime.Now.Year)
            {
                query += ", NULL";
            }
            else
            {
                query += ",'" + BDate.ToShortDateString() + "'";
            }

            if (Adress == "")
            {
                query += ", NULL";
            }
            else
            {
                query += ",'" + Adress + "'";
            }
            if (Sex == "Default")
            {
                query += ", NULL";
            }
            else
            {
                query += ",'" + Sex + "'";
            }
            if (Sallary == "")
            {
                query += ", NULL";
            }
            else
            {
                query += "," + Sallary;
            }
            if (SuperSSN == "")
            {
                query += ", NULL";
            }
            else
            {
                query += "," + SuperSSN;
            }
            if (Dno == "")
            {
                query += ", NULL";
            }
            else
            {
                query += "," + Dno ;
            }
            query += ");";

            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteSupplier(string snum)
        {
            string query = "DELETE FROM S WHERE S#='" + snum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteDepartment(string dnum)
        {
            string query = "DELETE FROM Department WHERE Dnumber=" + dnum + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateSupplier(string snum, string city)
        {
            string query = "UPDATE S SET City='" + city + "' WHERE S#='" + snum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateProject(string pnum, string plocation)
        {
            string query = "UPDATE Project SET Plocation='" + plocation + "' WHERE Pnumber=" + pnum + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllSuppliers()
        {
            string query = "SELECT * FROM S;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllEmployeesFromDepartment(string Dno)
        {
            string query = "SELECT Fname FROM Employee WHERE Dno =" +  Dno +";";
            return dbMan.ExecuteReader(query);
        }

        public int CountSuppliers()
        {
            string query = "SELECT COUNT(S#) FROM S;";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int CountEmployees(string ProjNum)
        {
            string query = "SELECT COUNT(Essn) FROM Works_On WHERE Pno =" + ProjNum + ";";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int InsertDepartment(string Dname, string DNO, string MgrSSN, DateTime MgrStartDate)
        {
            string query = "INSERT INTO Department (Dname, Dnumber, Mgr_SSN, Mgr_Start_Date)" +
                "Values ('" + Dname +"', " +  DNO + ", " + MgrSSN + ",' " + MgrStartDate.ToShortDateString() + "');"; 
            return (int)dbMan.ExecuteNonQuery(query);
        }
        public int InsertDepartmentLoc(string Dloc, string DNO)
        {
            string query = "INSERT INTO Dept_Locations (Dnumber, Dlocation)" +
                "Values (" + DNO + ", '" + Dloc + "'" + ");";
            return (int)dbMan.ExecuteNonQuery(query);
        }
        public int InsertProject(string Pname, string Dno, string Pnum, string ProjLoc)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                "Values ('" + Pname  + "', " + Pnum + ", '"+ ProjLoc + "', "+ Dno+ ");";
            return (int)dbMan.ExecuteNonQuery(query);
        }
        public DataTable getProjects(string SSN)
        {
            string query = "Select Pname FROM Project , Works_On " +
                     "Where Works_On.Essn = " + SSN + " AND Project.Pnumber = Works_On.Pno ;";
          return dbMan.ExecuteReader(query);
        }

        public void getAvailableDnos(int array )
        { 
            
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
