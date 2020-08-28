using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DBLAB_EXAM
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public int CheckPassword_Basic(string username, string password)
        {
            //Query the DB to check for username/password
            string query = "SELECT priv from Users_basic where username = '" + username + "' and password='" + password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }
        /// INSERTING A NEW DOCTOR
        public int insertDoctor(int DRID, string Fname, string Minit, string Lname,string Sdate, int Contactinfo,string Gender,int superID,int Salary,int Whours,string Preformance,string Holidays,string Position,int DID)
        {

            string StoredProcedureName = Stored.insertDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DRID", DRID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Sdate", Sdate);
            Parameters.Add("@contactinfo", Contactinfo);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Super_SSN", superID);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Whours", Whours);
            Parameters.Add("@Preformance", Preformance);
            Parameters.Add("@Holidays", Holidays);
            Parameters.Add("@Position", Position);
            Parameters.Add("@DID", DID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetDoctor()
        {
            String StoredProcedureName = Stored.GetDoctors;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        /// INSERT A NEW NURSE
        public int insertNurse(int NID, string Fname, string Minit, string Lname, string Sdate, int Contactinfo, string Gender,int superID, int Salary, int Whours, string Preformance, string Holidays, string position,int DID)
        {

            string StoredProcedureName = Stored.insertNurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Sdate", Sdate);
            Parameters.Add("@contactinfo", Contactinfo);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Super_SSN", superID);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Whours", Whours);
            Parameters.Add("@Preformance", Preformance);
            Parameters.Add("@Holidays", Holidays);
            Parameters.Add("@Position", position);
            Parameters.Add("@DID", DID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetNurse()
        {
            String StoredProcedureName = Stored.GetNurses;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        /// INSERT A NEW Pharmacist
        public int insertPharmacist(int PID, string Fname, string Minit, string Lname, string Sdate, int Contactinfo, string Gender, int superID, int Salary, int Whours, string Preformance, string Holidays)
        {

            string StoredProcedureName = Stored.insertPharmacist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Sdate", Sdate);
            Parameters.Add("@contactinfo", Contactinfo);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Super_SSN", superID);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Whours", Whours);
            Parameters.Add("@Preformance", Preformance);
            Parameters.Add("@Holidays", Holidays);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetPharmacist()
        {
            String StoredProcedureName = Stored.GetPharmacists;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        /// INSERT A NEW Recp
        public int insertRecp(int RID, string Fname, string Minit, string Lname, string Sdate, int Contactinfo, string Gender, int superID, int Salary, int Whours, string Preformance, string Holidays, int TypeC, int DID)
        {

            string StoredProcedureName = Stored.insertRecp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Sdate", Sdate);
            Parameters.Add("@contactinfo", Contactinfo);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Super_SSN", superID);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Whours", Whours);
            Parameters.Add("@Preformance", Preformance);
            Parameters.Add("@Holidays", Holidays);
            Parameters.Add("@TypeC", TypeC);
            Parameters.Add("@DID", DID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetRecp()
        {
            String StoredProcedureName = Stored.GetRecp;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        /// INSERT A NEW CLINIC
        public int insertClinic(int TYP, string TypeC,int Price,int Capacity, int Whours, int HDOCID, int HNURSEID)
        {

            string StoredProcedureName = Stored.insertClinic;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TYP", TYP);
            Parameters.Add("@TypeC", TypeC);
            Parameters.Add("@Price", Price);
            Parameters.Add("@Capacity", Capacity);
            Parameters.Add("@Whours", Whours);
            Parameters.Add("@HDOCID", HDOCID);
            Parameters.Add("@HNURSEID", HNURSEID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetClinic()
        {
            String StoredProcedureName = Stored.GetClinic;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        ///--------------------------------------------------------------------------------
        public int deleteDoctor(string Fname,string Lname)
        {
            string StoredProcedureName = Stored.RemoveDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DOCFNAME", Fname);
            Parameters.Add("@DOCLNAME", Lname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///-----------------------------------------------------------------------------------
        ///Pharmacy Options
        public DataTable GetDrugs()
        {
            String StoredProcedureName = Stored.GetDrugs;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetDrugname(string DrugN)
        {

            string StoredProcedureName = Stored.GetDrugsName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Drug_Name", DrugN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int InsertDrug(string DrugName, int Quantity)
        {
            string StoredProcedureName = Stored.InsertDrugs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DrugName", DrugName);
            Parameters.Add("@Quantity", Quantity);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteDrug(string DrugName)
        {
            string StoredProcedureName = Stored.DeleteDrugs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DRUGNAME", DrugName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateDrug(int DrugQuantity,string DrugName)
        {

            string StoredProcedureName = Stored.UpdateDrugs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DQuantity", DrugQuantity);
            Parameters.Add("@DName", DrugName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///--------------------------------------------------------------------------------
        ///Patient Options
        public DataTable GetPatient()
        {
            String StoredProcedureName = Stored.GetPatients;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetPatientSSN(int SSN)
        {

            string StoredProcedureName = Stored.GetPatientSSN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Patient_ID", SSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetPatientDOCID(int DOCID)
        {

            string StoredProcedureName = Stored.GetPatientDOCID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DOC_ID", DOCID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int insertPatient(int SSN,string Fname,string Minit,string Lname,string BloodCategory,int ContactInfo,string Gender, int Age, string Record, string VisitType, int DOCID)
        {
            string StoredProcedureName = Stored.InsertPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@BLOODC", BloodCategory);
            Parameters.Add("@contactinfo", ContactInfo);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Record", Record);
            Parameters.Add("@VisitType", VisitType);
            Parameters.Add("@DOCID", DOCID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdatePatient(int Contact, int Age, string Visit, int DOCID, int SSN)
        {

            string StoredProcedureName = Stored.UpdatePatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Contact", Contact);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Visit", Visit);
            Parameters.Add("@DOCID", DOCID);
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetAttendingDoctor(int SSN)
        {
            string StoredProcedureName = Stored.GetAttendedDoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        ///---------------------------------------------------------------------------------------
        ///Department Settings
        public int insertDepartment(int DID, string Dlocation,int Capacity,string DType, int HDRID, int HNID)
        {
            string StoredProcedureName = Stored.InsertDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DID", DID);
            Parameters.Add("@DLocation", Dlocation);
            Parameters.Add("@Capacity", Capacity);
            Parameters.Add("@Dtype", DType);
            Parameters.Add("@HDOCID", HDRID);
            Parameters.Add("@HNURSEID", HNID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetDepartment()
        {
            String StoredProcedureName = Stored.GetDepartment;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetDepID(int DID)
        {
            string StoredProcedureName = Stored.GetDepartmentID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Department_ID", DID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetDepName(string DEPName)
        {
            string StoredProcedureName = Stored.GetDepartmentName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Department_Name", DEPName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetDEPHDOCName(int DepartmentID)
        {
            string StoredProcedureName = Stored.GetDepartmentHDOC;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DepartmentID", DepartmentID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetDEPHNurseName(int DepartmentID)
        {
            string StoredProcedureName = Stored.GetDepartmentHNurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DepartmentID", DepartmentID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetDEPEmployees(int DepartmentID)
        {
            string StoredProcedureName = Stored.GetDepartmentEmployees;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DepartmentID", DepartmentID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable DeleteDepartment(int DepartmentID)
        {
            string StoredProcedureName = Stored.DeleteDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DEPID", DepartmentID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable UpdateDepartment(int DepartmentID,int Capacity, int HDOCID, int HNURSEID)
        {
            string StoredProcedureName = Stored.UpdateDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DEPID", DepartmentID);
            Parameters.Add("@HDOCID", HDOCID);
            Parameters.Add("@HNURSEID", HNURSEID);
            Parameters.Add("@Capacity", Capacity);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
    }
    };
