using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hotel_Database_Opgave_15_11_22
{
    public class DBClient
    {
        public void Start(string queryString)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""DBOpgave "";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                if (queryString.Contains("select"))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(" " + reader[i] + ", ");
                        }
                        
                        Console.WriteLine();
                    }
                    reader.Close();
                }
                else
                {
                    int numberOfRowsAffected = command.ExecuteNonQuery();
                    if (numberOfRowsAffected == 1)
                    {
                        Console.WriteLine("Facility Insert Accepted");
                    }
                    else
                    {
                        Console.WriteLine("Facility Insert fail!");
                    }
                }

                command.Connection.Close();

                #region Read Facilities 1
                //Console.WriteLine();
                //Console.WriteLine("Show all facilities");

                //string queryString1 = "select * from Facilities";
                //SqlCommand command = new SqlCommand(queryString1, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();

                //while (reader.Read())
                //{
                //    int id = reader.GetInt32(0); //--læser int fra første søjle
                //    string name = reader.GetString(1); //--læser string fra anden søjle
                //    Console.WriteLine($"{id} - {name}");
                //}
                //command.Connection.Close();
                #endregion

                #region Create Facility
                //Console.WriteLine();
                //Console.WriteLine("Insert facility");

                //string insertCommand = "INSERT INTO Facilities Values(7, 'Sodavands Automat')";

                //SqlCommand command = new SqlCommand(insertCommand, connection);
                //command.Connection.Open();
                //int numberOfRowsAffected = command.ExecuteNonQuery();
                //if (numberOfRowsAffected == 1)
                //{
                //    Console.WriteLine("Facility Insert Accepted");
                //}
                //else
                //{
                //    Console.WriteLine("Facility Insert fail!");
                //}
                //command.Connection.Close();
                #endregion

                #region Read Facilities 1.5
                //Console.WriteLine();
                //Console.WriteLine("Show all facilities");

                //string queryString15 = "select * from Facilities";
                //SqlCommand command = new SqlCommand(queryString15, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();

                //while (reader.Read())
                //{
                //    int id = reader.GetInt32(0); //--læser int fra første søjle
                //    string name = reader.GetString(1); //--læser string fra anden søjle
                //    Console.WriteLine($"{id} - {name}");
                //}
                //command.Connection.Close();
                #endregion

                #region Update Facilities
                //Console.WriteLine();
                //Console.WriteLine("Update facility");
                //string UpdateCommandf = "Update Facilities set Facility_No = 7, Facility_Name = 'Mini Golf' where Facility_No = 7";
                //// UPDATE DemoRoom SET Price = FLOOR(Price * 1.05)

                //SqlCommand command = new SqlCommand(UpdateCommandf, connection);
                //command.Connection.Open();
                //int numberOfRowsAffected2 = command.ExecuteNonQuery();
                //if (numberOfRowsAffected2 == 1)
                //{
                //    Console.WriteLine("Hotel Updated");
                //}
                //command.Connection.Close();
                #endregion

                #region Read Facilities 2
                //Console.WriteLine();
                //Console.WriteLine("Show all facilities");

                //string queryString2 = "select * from Facilities";
                //SqlCommand command = new SqlCommand(queryString2, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();

                //while (reader.Read())
                //{
                //    int id = reader.GetInt32(0); //--læser int fra første søjle
                //    string name = reader.GetString(1); //--læser string fra anden søjle
                //    Console.WriteLine($"{id} - {name}");
                //}
                //command.Connection.Close();
                #endregion

                #region Delete Facility
                //Console.WriteLine();
                //Console.WriteLine("Delete Facility");
                //string DeleteCommand = "Delete from Facilities where Facility_No = 7";
                //SqlCommand command = new SqlCommand(DeleteCommand, connection);
                //command.Connection.Open();
                //int numberOfRowsAffected = command.ExecuteNonQuery();
                //if (numberOfRowsAffected == 1)
                //{
                //    Console.WriteLine("Facility Deleted");
                //}
                //command.Connection.Close();
                #endregion

                #region Read Facilities 3
                //Console.WriteLine();
                //Console.WriteLine("Show all facilities");

                //string queryString3 = "select * from Facilities";
                //SqlCommand command = new SqlCommand(queryString3, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();

                //while (reader.Read())
                //{
                //    int id = reader.GetInt32(0); //--læser int fra første søjle
                //    string name = reader.GetString(1); //--læser string fra anden søjle
                //    Console.WriteLine($"{id} - {name}");
                //}
                //command.Connection.Close();
                #endregion



                #region Facilities in Hotels 1
                //Console.WriteLine();
                //Console.WriteLine("Show all facilities in hotels");

                //string queryFString1 = "select * from HotelFacilities join Facilities on Facilities.Facility_No = HotelFacilities.Facility_No ";
                ////string queryFString = "";
                //SqlCommand command = new SqlCommand(queryFString1, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();

                //Console.WriteLine("Hotel - Facility");
                //while (reader.Read())
                //{
                //    int id1 = reader.GetInt32(0); //--læser int fra første søjle
                //    int id2 = reader.GetInt32(1); //--læser string fra anden søjle
                //    string id3 = reader.GetString(3); //--læser string fra anden søjle

                //    Console.WriteLine($" {id1} - {id2}: {id3}");
                //}
                //command.Connection.Close();
                #endregion

                #region Add Facility to Hotel
                //Console.WriteLine();
                //Console.WriteLine("Add facility to hotel");
                //string insertFacilityCommand = "INSERT INTO HotelFacilities Values(5, 3)";
                //SqlCommand command = new SqlCommand(insertFacilityCommand, connection);
                //command.Connection.Open();
                //int numberOfRowsAffected = command.ExecuteNonQuery();
                //if (numberOfRowsAffected == 1)
                //{
                //    Console.WriteLine("Facility Insert Accepted");
                //}
                //else
                //{
                //    Console.WriteLine("Facility Insert fail!");
                //}
                //command.Connection.Close();
                #endregion

                #region Facilities in Hotels 1.5
                //Console.WriteLine();
                //Console.WriteLine("Show all facilities in hotels");

                //string queryFString15 = "select * from HotelFacilities join Facilities on Facilities.Facility_No = HotelFacilities.Facility_No ";
                ////string queryFString = "";
                //SqlCommand command = new SqlCommand(queryFString15, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();

                //Console.WriteLine("Hotel - Facility");
                //while (reader.Read())
                //{
                //    int id1 = reader.GetInt32(0); //--læser int fra første søjle
                //    int id2 = reader.GetInt32(1); //--læser string fra anden søjle
                //    string id3 = reader.GetString(3); //--læser string fra anden søjle

                //    Console.WriteLine($" {id1} - {id2}: {id3}");
                //}
                //command.Connection.Close();
                #endregion

                #region Update hotel facilities
                //Console.WriteLine();
                //Console.WriteLine("Update facility");
                //string UpdateCommand = "Update HotelFacilities set Hotel_No = 5, Facility_No = 2 where Hotel_No = 5 AND Facility_No = 3";
                //// UPDATE DemoRoom SET Price = FLOOR(Price * 1.05)

                //SqlCommand command = new SqlCommand(UpdateCommand, connection);
                //command.Connection.Open();
                //int numberOfRowsAffected = command.ExecuteNonQuery();
                //if (numberOfRowsAffected == 1)
                //{
                //    Console.WriteLine("Hotel Updated");
                //}
                //command.Connection.Close();
                #endregion

                #region Facilities in Hotels 2
                //Console.WriteLine();
                //Console.WriteLine("Show all facilities in hotels");

                //string queryFString2 = "select * from HotelFacilities join Facilities on Facilities.Facility_No = HotelFacilities.Facility_No ";
                ////string queryFString = "";
                //SqlCommand command = new SqlCommand(queryFString2, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();

                //Console.WriteLine("Hotel - Facility");
                //while (reader.Read())
                //{
                //    int id1 = reader.GetInt32(0); //--læser int fra første søjle
                //    int id2 = reader.GetInt32(1); //--læser string fra anden søjle
                //    string id3 = reader.GetString(3); //--læser string fra anden søjle

                //    Console.WriteLine($" {id1} - {id2}: {id3}");
                //}
                //command.Connection.Close();
                #endregion

                #region Remove Facility From Hotel
                //Console.WriteLine();
                //Console.WriteLine("Remove facility from hotel");
                //string RemoveCommand = "Delete from HotelFacilities where Hotel_No = 5 AND Facility_No = 2";
                //SqlCommand command = new SqlCommand(RemoveCommand, connection);
                //command.Connection.Open();
                //int numberOfRowsAffected = command.ExecuteNonQuery();
                //if (numberOfRowsAffected == 1)
                //{
                //    Console.WriteLine("Facility Removed");
                //}
                //command.Connection.Close();
                #endregion

                #region Facilities in Hotels
                //Console.WriteLine();
                //Console.WriteLine("Show all facilities in hotels");

                //string queryFString3 = "select * from HotelFacilities join Facilities on Facilities.Facility_No = HotelFacilities.Facility_No ";
                ////string queryFString = "";
                //SqlCommand command = new SqlCommand(queryFString3, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();

                //Console.WriteLine("Hotel - Facility");
                //while (reader.Read())
                //{
                //    int id1 = reader.GetInt32(0); //--læser int fra første søjle
                //    int id2 = reader.GetInt32(1); //--læser string fra anden søjle
                //    string id3 = reader.GetString(3); //--læser string fra anden søjle

                //    Console.WriteLine($" {id1} - {id2}: {id3}");
                //}
                //command.Connection.Close();
                #endregion
            }
        }   
    }
}
