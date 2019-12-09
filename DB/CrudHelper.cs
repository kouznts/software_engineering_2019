﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GasStationMs.Dal;

namespace GasStationMs.App.DB
{
    class CrudHelper
    {
        private readonly SqlConnection _connection;

        public CrudHelper(SqlConnection connection)
        {
            _connection = connection;
        }

        public void DeleteFuelFromDb(ListBox listFuels)
        {
            DataRowView row = listFuels.SelectedItem as DataRowView;

            var fuelId = row["Id"].ToString();
            var rawSqlCommand = "DELETE FROM Fuels WHERE(Id = " + fuelId + ")";

            SqlCommand sqlCommand = new SqlCommand(rawSqlCommand, _connection);

            sqlCommand.ExecuteNonQuery();
        }

        public void AddFuelToDb(string fuelName, double price)
        {
            var rawSqlCommand = "INSERT INTO Fuels ([Name], [Price]) VALUES(N'" + fuelName + "'," +
                                " " + price + ")";

            SqlCommand sqlCommand = new SqlCommand(rawSqlCommand, _connection);

            sqlCommand.ExecuteNonQuery();
        }
    }
}
