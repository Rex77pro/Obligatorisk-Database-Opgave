using Microsoft.EntityFrameworkCore;
using Hotel_Database_Opgave_15_11_22;
using System;

//Console.WriteLine("Start DBConnect");
//Console.WriteLine();
//new Hotel_Database_Opgave_15_11_22.DBClient().Start();

FacilityMethods FacilityMethods = new FacilityMethods();
HotelFacilityMethods HotelFacilityMethods = new HotelFacilityMethods();

FacilityMethods.CreateFacility();
FacilityMethods.ReadAllFacilities();
FacilityMethods.UpdateFacility();
FacilityMethods.DeleteFacility();

//HotelFacilityMethods.AddHotelFacility();
//HotelFacilityMethods.ReadHotelFacilities();
//HotelFacilityMethods.UpdateHotelFacility();
//HotelFacilityMethods.RemoveFacility();

