using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Database_Opgave_15_11_22
{
    public class FacilityMethods
    {

        string queryString = " ";
        DBClient DBClient = new DBClient();

        public void CreateFacility()
        {
            Console.WriteLine("Create a facility");
            queryString = "INSERT INTO Facilities Values(7, 'Sodavands Automat')";
            DBClient.Start(queryString);
            Console.WriteLine(queryString);
            Console.WriteLine();
            Next();
        }

        public void ReadAllFacilities()
        {
            Console.Clear();
            Console.WriteLine("Read all facilities");
            queryString = "select * from Facilities";
            DBClient.Start(queryString);
            Console.WriteLine();
            Next();
        }

        public void UpdateFacility()
        {
            Console.WriteLine("Update a facility");
            queryString = "Update Facilities set Facility_No = 7, Facility_Name = 'Mini Golf' where Facility_No = 7";
            DBClient.Start(queryString);
            Console.WriteLine(queryString);
            Console.WriteLine();
            Next();
        }

        public void DeleteFacility()
        {
            Console.WriteLine("Delete a Facility");
            queryString = "Delete from Facilities where Facility_No = 7";
            DBClient.Start(queryString);
            Console.WriteLine(queryString);
            Console.WriteLine();
            Next();
        }

        public static void Next()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
