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
    public partial class TravelManagementForm : Form
    {
        public event Action LanguageChanged;

        public TravelManagementForm()
        {
            InitializeComponent();
            comboBoxStatusShipp.Items.Add("Entregado");
            comboBoxStatusShipp.Items.Add("EnCamino");
            comboBoxStatusShipp.Items.Add("Retrasado");
            comboBoxStatusShipp.Items.Add("NoEnviado");
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
        }

        private void UpdateLanguage()
        {
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonChangeStatus.Text = LanguageManager.GetString("ChangeStatus");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonSearch.Text = LanguageManager.GetString("Search");
            buttonDelete.Text = LanguageManager.GetString("Delete");

            labelIDTruck.Text = LanguageManager.GetString("IDTruck");
            labelIDLotToAssign.Text = LanguageManager.GetString("LotIDToAssign");
            labelIDDestination.Text = LanguageManager.GetString("IDDestination");
            labelIDTrucker.Text = LanguageManager.GetString("IDTrucker");
            labelStatus.Text = LanguageManager.GetString("Status");

        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                MessageBox.Show(Messages.InvalidID + " : " + ex.Message);
                return null;
            }
        }

        private static void fillDataTable(DataTable table, TravelsInterface travels)
        {
            DataRow row = table.NewRow();
            row["ID Camión"] = travels.IDTruck;
            row[LanguageManager.GetString("LotID")] = travels.IDBatch;
            row[LanguageManager.GetString("IDDestination")] = travels.IDDestination;
            row[LanguageManager.GetString("Status")] = travels.ShippingStatus;
            table.Rows.Add(row);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDTruck.Text, out int searchID))
            {
                RestResponse response = getTravelsByTruckID(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Camión", typeof(int));
                    table.Columns.Add(LanguageManager.GetString("LotID"), typeof(int));
                    table.Columns.Add(LanguageManager.GetString("IDDestination"), typeof(int));
                    table.Columns.Add(LanguageManager.GetString("Status"), typeof(string));

                    TravelsInterface travel = JsonConvert.DeserializeObject<TravelsInterface>(response.Content);
                    fillDataTable(table, travel);

                    dataGridViewTravels.DataSource = table;

                    MessageBox.Show(Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Messages.NotFound);
                }
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.InvalidID);
            }
        }

        private bool editTravel(string status, int truckerID)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:50294");
                RestRequest request = new RestRequest($"/api/v1/transporta/{truckerID}", Method.Patch);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");

                var requestBody = new
                {
                    newShippingStatus = status
                };

                var jsonBody = JsonConvert.SerializeObject(requestBody);
                request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(Messages.Error + " : " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Messages.Error + " : " + ex.Message);
                return false;
            }
        }


        private bool validateInputsUser()
        {
            if (string.IsNullOrWhiteSpace(txtBoxIDBatch.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruck.Text) ||
                string.IsNullOrWhiteSpace(txtBoxDestination.Text) ||
                string.IsNullOrWhiteSpace(txtBoxTruckerID.Text))
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
            txtBoxTruckerID.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            if (!validateInputsUser())
            {
                MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                return;
            }

            if (int.TryParse(txtBoxIDTruck.Text, out int truckID) &&
                int.TryParse(txtBoxIDBatch.Text, out int batchID) &&
                int.TryParse(txtBoxDestination.Text, out int destinationID) &&
                int.TryParse(txtBoxTruckerID.Text, out int truckerID))
            {
                if (editTravel(comboBoxStatusShipp.SelectedItem.ToString(), truckerID))
                {
                    MessageBox.Show(Messages.Successful + ". ->" + comboBoxStatusShipp.SelectedItem.ToString());
                    clearTxtBoxs();
                }
                else
                {
                    MessageBox.Show(Messages.Error + ". ->" + comboBoxStatusShipp.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show(Messages.InvalidID+"'s");
            }
        }

    }
}
