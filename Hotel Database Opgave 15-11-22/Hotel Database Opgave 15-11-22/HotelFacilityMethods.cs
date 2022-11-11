using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Database_Opgave_15_11_22
{
    public class HotelFacilityMethods
    {
        DBClient DBClient = new();
        string queryString = " ";

        public void AddHotelFacility()
        {
            Console.WriteLine("Add a facility to a hotel");
            queryString = "INSERT INTO HotelFacilities Values(5, 3)";
            DBClient.Start(queryString);
            Console.WriteLine();
            Next();
        }

        public void ReadHotelFacilities()
        {
            Console.WriteLine("Read all facilities for hotles");
            queryString = "select  HotelFacilities.Hotel_No, Name, HotelFacilities.Facility_No, Facility_Name from HotelFacilities " +
                "join Facilities on Facilities.Facility_No = HotelFacilities.Facility_No " +
                "join DemoHotel on DemoHotel.Hotel_No = HotelFacilities.Hotel_No";
            DBClient.Start(queryString);
            Console.WriteLine();
            Next();
        }

        public void UpdateHotelFacility()
        {
            Console.WriteLine("Update a facility on a hotel");
            queryString = "Update HotelFacilities set Hotel_No = 5, Facility_No = 2 where Hotel_No = 5 AND Facility_No = 3";
            DBClient.Start(queryString);
            Console.WriteLine();
            Next();
        }

        public void RemoveFacility()
        {
            Console.WriteLine("Remove a facility from a hotel");
            queryString = "Delete from HotelFacilities where Hotel_No = 5 AND Facility_No = 2";
            DBClient.Start(queryString);
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
