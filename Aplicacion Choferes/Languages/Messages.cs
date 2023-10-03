﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.Languages
{
    public static class Messages
    {
        public static string ProductFound => LanguageManager.GetString("ProductFound");
        public static string ProductNotFound => LanguageManager.GetString("ProductNotFound");
        public static string Error => LanguageManager.GetString("Error");
        public static string ErrorSyntax => LanguageManager.GetString("ErrorSyntax");
        public static string CompleteAllBoxAndStatus => LanguageManager.GetString("CompleteAllBoxAndStatus");
        public static string Successful => LanguageManager.GetString("Successfull");
        public static string SelectAnIndex => LanguageManager.GetString("SelectAnIndex");
        public static string LotFound => LanguageManager.GetString("LotFound");
        public static string LotNotFound => LanguageManager.GetString("LotNotFound");
        public static string UserFound => LanguageManager.GetString("UserFound");
        public static string UserNotFound => LanguageManager.GetString("UserNotFound");
        public static string InvalidID => LanguageManager.GetString("InvalidID");
        public static string VerifyData => LanguageManager.GetString("VerifyData");
        public static string TruckID => LanguageManager.GetString("TruckID");
        public static string TruckerID => LanguageManager.GetString("TruckerID");
        public static string DestinationID => LanguageManager.GetString("DestinationID");
        public static string AssignedLotToTrucker => LanguageManager.GetString("AssignedLotToTrucker");
        public static string ManageShipments => LanguageManager.GetString("ManageShipments");
        public static string ManageTravels => LanguageManager.GetString("ManageTravels");
        public static string TrucksAndLots => LanguageManager.GetString("TrucksAndLots");
        public static string AssignLotToTrucker => LanguageManager.GetString("AssignLotToTrucker");
        public static string ApplicationTrucker => LanguageManager.GetString("ApplicationTrucker");
        public static string AssignedTruck => LanguageManager.GetString("AssignedTruck");
    }

}
