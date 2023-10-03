using Aplicacion_Almacen.Languages;
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
        public event Action LanguageChanged;

        public TruckerDriveTruckManagerForm()
        {
            InitializeComponent();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
        }

        private void UpdateLanguage()
        {
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonSearchByTruckByTruckerID.Text = LanguageManager.GetString("IDTrucker");

            labelIDTrucker.Text = LanguageManager.GetString("IDTrucker");

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
                MessageBox.Show(Messages.Error + " : " + ex.Message);
                return null;
            }
        }

        private static void fillDataTable(DataTable table, TruckerDriveTruckInterface trucker)
        {
            DataRow row = table.NewRow();
            row["ID Camionero"] = trucker.IDTrucker;
            row[LanguageManager.GetString("IDTruck")] = trucker.IDTruck;
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
                    table.Columns.Add(LanguageManager.GetString("IDTruck"), typeof(int));

                    TruckerDriveTruckInterface trucker = JsonConvert.DeserializeObject<TruckerDriveTruckInterface>(response.Content);
                    fillDataTable(table, trucker);

                    dataGridViewTruckerAndTruckers.DataSource = table;

                    MessageBox.Show(Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Messages.NotFound);
                }
            }
            else
            {
                MessageBox.Show(Messages.InvalidID);
            }
        }
    }
}
