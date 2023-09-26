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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customMenus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void customMenus()
        {
            panelTruckersManagementContainer.Visible = false;
        }

        private void hideMenus()
        {
            if (panelTruckersManagementContainer.Visible == true)
            {
                panelTruckersManagementContainer.Visible = false;
            }
        }

        private void showMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form currentForm = null;

        private void showForm(Form newForm)
        {
            if (currentForm != null)
            {
                panelFormsLoader.Controls.Remove(currentForm);
                currentForm.Dispose();
            }

            currentForm = newForm;
            newForm.TopLevel = false;
            panelFormsLoader.Controls.Add(newForm);
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void showTravelsForm()
        {
            TravelManagementForm formTravelCtl = new TravelManagementForm();
            showForm(formTravelCtl);
        }

        private void showShippmentsForm()
        {
            ShippmentsManagerForm formShippmentsCtl = new ShippmentsManagerForm();
            showForm(formShippmentsCtl);
        }

        private void showTruckerCarryForm()
        {
            TruckerCarryForm formTruckerCarryCtl = new TruckerCarryForm();
            showForm(formTruckerCarryCtl);
        }

        private void showDestinationForm()
        {
            DestinationManagerForm formDestinationCtl = new DestinationManagerForm();
            showForm(formDestinationCtl);
        }

        private void buttonProductsManager_Click(object sender, EventArgs e)
        {
            showTravelsForm();
        }

        private void buttonTruckersManagement_Click(object sender, EventArgs e)
        {
            showMenus(panelTruckersManagementContainer);
        }

        private void buttonShippments_Click(object sender, EventArgs e)
        {
            showShippmentsForm();
        }

        private void buttonTruckerCarryManagement_Click(object sender, EventArgs e)
        {
            showTruckerCarryForm();
        }

        private void buttonDestinations_Click(object sender, EventArgs e)
        {
            showDestinationForm();
        }
    }
}
