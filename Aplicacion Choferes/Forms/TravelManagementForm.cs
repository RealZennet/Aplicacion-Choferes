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
    public partial class TravelManagementForm : Form
    {

        private string jsonBody;

        public TravelManagementForm()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region getTravels

        private List<TravelsInterface> deserializeTravels(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<TravelsInterface>>(content);
        }

        private static RestResponse getTravelsByTruckID(int truckID)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:50294");
                RestRequest request = new RestRequest($"/api/v1/transporta/{truckID}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el camion con ID: " + ex.Message);
                return null;
            }
        }

        private static void fillDataTable(DataTable table, TravelsInterface travels)
        {
            DataRow rows = table.NewRow();
            rows["ID Camion"] = travels.IDTruck;
            rows["ID Lote"] = travels.IDBatch;
            rows["ID Destino"] = travels.IDDestination;
            rows["Estado del pedido"] = travels.ShippingStatus;
            table.Rows.Add(rows);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDTruck.Text, out int searchID))
            {
                RestResponse response = getTravelsByTruckID(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Camion", typeof(int));
                    table.Columns.Add("ID Lote", typeof(int));
                    table.Columns.Add("ID Destino", typeof(int));
                    table.Columns.Add("Estado del pedido", typeof(string));

                    TravelsInterface travel = JsonConvert.DeserializeObject<TravelsInterface>(response.Content);
                    fillDataTable(table, travel);

                    dataGridViewTravels.DataSource = table;

                    MessageBox.Show("Camion con datos encontrado.");
                }
                else
                {
                    MessageBox.Show("Camion no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID de camion inválido. Ingresa un número válido.");
            }
        }

        #endregion getTravels

        #region validationsAndUtils

        private bool validateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDBatch.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruck.Text) ||
                string.IsNullOrWhiteSpace(txtBoxDestination.Text))
            {
                return false;
            }

            return true;
        }

        private void clearTxtBoxs()
        {
            txtBoxIDBatch.Clear();
            txtBoxIDTruck.Clear();
            txtBoxDestination.Clear();
        }


        #endregion validationsAndUtils

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            
        }


    }
}
