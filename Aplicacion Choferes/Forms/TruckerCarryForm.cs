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
    public partial class TruckerCarryForm : Form
    {
        public TruckerCarryForm()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<TruckerCarryInterface> deserialize(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<TruckerCarryInterface>>(content);
        }

        private static RestResponse getCarrieByID(int truckID)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:50294");
                RestRequest request = new RestRequest($"/api/v1/llevan/{truckID}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el cargamento con ID: " + ex.Message);
                return null;
            }
        }

        private static void fillDataTable(DataTable table, TruckerCarryInterface carry)
        {
            DataRow row = table.NewRow();
            row["ID Camion"] = carry.IDTruck;
            row["ID Lote"] = carry.IDBatch;
            row["Fecha Salida"] = carry.ShippmentDate;
            table.Rows.Add(row);
        }

        private void buttonSearchByTruckerID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDTrucker.Text, out int searchID))
            {
                RestResponse response = getCarrieByID(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Camion", typeof(int));
                    table.Columns.Add("ID Lote", typeof(int));
                    table.Columns.Add("Fecha Salida", typeof(DateTime));

                    TruckerCarryInterface carrie = JsonConvert.DeserializeObject<TruckerCarryInterface>(response.Content);
                    fillDataTable(table, carrie);

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
    }
}
