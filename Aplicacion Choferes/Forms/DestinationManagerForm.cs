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
    public partial class DestinationManagerForm : Form
    {
        public DestinationManagerForm()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<DestinationInterface> deserialize(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<DestinationInterface>>(content);
        }

        private static RestResponse getDestinationByID(int destinationID)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:50294");
                RestRequest request = new RestRequest($"/api/v1/camion/destinos/{destinationID}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el destino con ID: " + ex.Message);
                return null;
            }
        }

        private static void fillDataTable(DataTable table, DestinationInterface destination)
        {
            DataRow row = table.NewRow();
            row["ID Destino"] = destination.IDDestination;
            row["Calle"] = destination.StreetDestination;
            row["Numero"] = destination.DoorNumber;
            row["Esquina"] = destination.CornerDestination;
            row["Fecha estimada"] = destination.EstimatedDate;
            row["Activado"] = destination.ActivedDestination;
            table.Rows.Add(row);
        }

        private void buttonSearchByDestinationID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDDestination.Text, out int searchID))
            {
                RestResponse response = getDestinationByID(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Destino", typeof(int));
                    table.Columns.Add("Calle", typeof(string));
                    table.Columns.Add("Numero", typeof(string));
                    table.Columns.Add("Esquina", typeof(string));
                    table.Columns.Add("Fecha estimada", typeof(DateTime));
                    table.Columns.Add("Activado", typeof(bool));

                    DestinationInterface destination = JsonConvert.DeserializeObject<DestinationInterface>(response.Content);
                    fillDataTable(table, destination);

                    dataGridViewDestination.DataSource = table;

                    MessageBox.Show("Destino encontrado.");
                }
                else
                {
                    MessageBox.Show("Destino no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID de Destino inválido. Ingresa un número válido.");
            }
        }

        #region getAllDestinations

        private static RestResponse getAllDestinations()
        {
            try
            {
                RestClient client = new RestClient("http://localhost:50294");
                RestRequest request = new RestRequest("/api/v1/destinos", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener todos los destinos: " + ex.Message);
                return null;
            }
        }

        

        private void fillDataTableWithDestinations(DataTable table, List<DestinationInterface> destinations)
        {
            foreach (var destination in destinations)
            {
                DataRow row = table.NewRow();
                row["ID Destino"] = destination.IDDestination;
                row["Calle"] = destination.StreetDestination;
                row["Numero"] = destination.DoorNumber;
                row["Esquina"] = destination.CornerDestination;
                row["Fecha estimada"] = destination.EstimatedDate;
                row["Activado"] = destination.ActivedDestination;
                table.Rows.Add(row);
            }
        }

        private void buttonGetAllDestinations_Click(object sender, EventArgs e)
        {
            RestResponse response = getAllDestinations();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID Destino", typeof(int));
                table.Columns.Add("Calle", typeof(string));
                table.Columns.Add("Numero", typeof(string));
                table.Columns.Add("Esquina", typeof(string));
                table.Columns.Add("Fecha estimada", typeof(DateTime));
                table.Columns.Add("Activado", typeof(bool));

                List<DestinationInterface> destinations = JsonConvert.DeserializeObject<List<DestinationInterface>>(response.Content);
                fillDataTableWithDestinations(table, destinations);

                dataGridViewDestination.DataSource = table;

                MessageBox.Show("Destinos encontrados.");
            }
            else
            {
                MessageBox.Show("No se encontraron destinos.");
            }
        }
        #endregion getAlldestination
    }
}
