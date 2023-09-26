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
    public partial class TruckerDriveTruckManagerForm : Form
    {
        public TruckerDriveTruckManagerForm()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<TruckerDriveTruckInterface> deserialize(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<TruckerDriveTruckInterface>>(content);
        }

        private static RestResponse getDestinationByID(int truckerID)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:50294");
                RestRequest request = new RestRequest($"/api/v1/camionero/conduce/{truckerID}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de el camionero con ID: " + ex.Message);
                return null;
            }
        }

        private static void fillDataTable(DataTable table, TruckerDriveTruckInterface trucker)
        {
            DataRow row = table.NewRow();
            row["ID Camionero"] = trucker.IDTrucker;
            row["ID Camion"] = trucker.IDTruck;
            table.Rows.Add(row);
        }

        private void buttonSearchByTruckByTruckerID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDTrucker.Text, out int searchID))
            {
                RestResponse response = getDestinationByID(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Camionero", typeof(int));
                    table.Columns.Add("ID Camion", typeof(int));

                    TruckerDriveTruckInterface trucker = JsonConvert.DeserializeObject<TruckerDriveTruckInterface>(response.Content);
                    fillDataTable(table, trucker);

                    dataGridViewTruckerAndTruckers.DataSource = table;

                    MessageBox.Show("Camionero encontrado.");
                }
                else
                {
                    MessageBox.Show("Camionero no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID de camionero inválido. Ingresa un número válido.");
            }
        }
    }
}
