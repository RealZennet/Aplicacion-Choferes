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

        private void buttonProductsManager_Click(object sender, EventArgs e)
        {
            showTravelsForm();
        }

        private void buttonTruckersManagement_Click(object sender, EventArgs e)
        {
            showMenus(panelTruckersManagementContainer);
        }
    }
}
