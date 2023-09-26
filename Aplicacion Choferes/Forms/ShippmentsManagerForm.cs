using Aplicacion_Choferes.APIRequests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Choferes.Forms
{
    public partial class ShippmentsManagerForm : Form
    {
        public ShippmentsManagerForm()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<ShippmentsInterface> deserializeShipps(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<ShippmentsInterface>>(content);
        }

        private static RestResponse getShippByDestinationID(int destinationID)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:50294");
                RestRequest request = new RestRequest($"/api/v1/destino/recorrido/{destinationID}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el recorrido con ID: " + ex.Message);
                return null;
            }
        }

        private static void fillDataTable(DataTable table, ShippmentsInterface shipp)
        {
            DataRow row = table.NewRow();
            row["ID Destino"] = shipp.IDDestination;
            row["ID Almacen"] = shipp.IDStoreHouse;
            row["Tipo recorrido"] = shipp.TypeTravel;
            row["Fecha recorrido"] = shipp.ShippmentDate;
            table.Rows.Add(row);
        }

        private void buttonSearchByDestinationID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDDestination.Text, out int searchID))
            {
                RestResponse response = getShippByDestinationID(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Destino", typeof(int));
                    table.Columns.Add("ID Almacen", typeof(int));
                    table.Columns.Add("Tipo recorrido", typeof(string));
                    table.Columns.Add("Fecha recorrido", typeof(DateTime));

                    ShippmentsInterface shipp = JsonConvert.DeserializeObject<ShippmentsInterface>(response.Content);
                    fillDataTable(table, shipp);

                    dataGridViewShippments.DataSource = table;

                    MessageBox.Show("Recorrido encontrado.");
                }
                else
                {
                    MessageBox.Show("Recorrido no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID de recorrido inválido. Ingresa un número válido.");
            }
        }

        #region findbyStoreHouse

        private List<ShippmentsInterface> deserializeShippsStoreHouseID(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<ShippmentsInterface>>(content);
        }

        private static RestResponse getShippByStoreHouseID(int storehouseID)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:50294");
                RestRequest request = new RestRequest($"/api/v1/almacen/recorrido/{storehouseID}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el recorrido con ID: " + ex.Message);
                return null;
            }
        }

        private static void fillDataTableStoreHouseData(DataTable table, ShippmentsInterface shipp)
        {
            DataRow row = table.NewRow();
            row["ID Destino"] = shipp.IDDestination;
            row["ID Almacen"] = shipp.IDStoreHouse;
            row["Tipo recorrido"] = shipp.TypeTravel;
            row["Fecha recorrido"] = shipp.ShippmentDate;
            table.Rows.Add(row);
        }

        private void buttonSearchByStoreHouseID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxStoreHouseID.Text, out int searchID))
            {
                RestResponse response = getShippByDestinationID(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Destino", typeof(int));
                    table.Columns.Add("ID Almacen", typeof(int));
                    table.Columns.Add("Tipo recorrido", typeof(string));
                    table.Columns.Add("Fecha recorrido", typeof(DateTime));

                    ShippmentsInterface shipp = JsonConvert.DeserializeObject<ShippmentsInterface>(response.Content);
                    fillDataTable(table, shipp);

                    dataGridViewShippments.DataSource = table;

                    MessageBox.Show("Recorrido encontrado.");
                }
                else
                {
                    MessageBox.Show("Recorrido no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID de recorrido inválido. Ingresa un número válido.");
            }
        }
        #endregion findByStoreHouse

    }
}
