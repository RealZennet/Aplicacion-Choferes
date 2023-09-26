namespace Aplicacion_Choferes.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFormsLoader = new System.Windows.Forms.Panel();
            this.buttonTruckersManagement = new System.Windows.Forms.Button();
            this.buttonAssignedTruckToTrucker = new System.Windows.Forms.Button();
            this.buttonDestinations = new System.Windows.Forms.Button();
            this.buttonProductsManager = new System.Windows.Forms.Button();
            this.buttonShippments = new System.Windows.Forms.Button();
            this.buttonLanguage = new System.Windows.Forms.Button();
            this.leftPanelContainer = new System.Windows.Forms.Panel();
            this.settingsManagerPanel = new System.Windows.Forms.Panel();
            this.panelTruckersManagementContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanelContainer.SuspendLayout();
            this.settingsManagerPanel.SuspendLayout();
            this.panelTruckersManagementContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormsLoader
            // 
            this.panelFormsLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFormsLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.panelFormsLoader.Location = new System.Drawing.Point(258, 31);
            this.panelFormsLoader.Name = "panelFormsLoader";
            this.panelFormsLoader.Size = new System.Drawing.Size(773, 559);
            this.panelFormsLoader.TabIndex = 5;
            // 
            // buttonTruckersManagement
            // 
            this.buttonTruckersManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTruckersManagement.FlatAppearance.BorderSize = 0;
            this.buttonTruckersManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTruckersManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTruckersManagement.Location = new System.Drawing.Point(0, 80);
            this.buttonTruckersManagement.Name = "buttonTruckersManagement";
            this.buttonTruckersManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTruckersManagement.Size = new System.Drawing.Size(250, 45);
            this.buttonTruckersManagement.TabIndex = 2;
            this.buttonTruckersManagement.Text = "Camiones y lotes";
            this.buttonTruckersManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTruckersManagement.UseVisualStyleBackColor = true;
            this.buttonTruckersManagement.Click += new System.EventHandler(this.buttonTruckersManagement_Click);
            // 
            // buttonAssignedTruckToTrucker
            // 
            this.buttonAssignedTruckToTrucker.FlatAppearance.BorderSize = 0;
            this.buttonAssignedTruckToTrucker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignedTruckToTrucker.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAssignedTruckToTrucker.Location = new System.Drawing.Point(0, 103);
            this.buttonAssignedTruckToTrucker.Name = "buttonAssignedTruckToTrucker";
            this.buttonAssignedTruckToTrucker.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAssignedTruckToTrucker.Size = new System.Drawing.Size(240, 26);
            this.buttonAssignedTruckToTrucker.TabIndex = 6;
            this.buttonAssignedTruckToTrucker.Text = "Camiones asignados";
            this.buttonAssignedTruckToTrucker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssignedTruckToTrucker.UseVisualStyleBackColor = true;
            // 
            // buttonDestinations
            // 
            this.buttonDestinations.FlatAppearance.BorderSize = 0;
            this.buttonDestinations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDestinations.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDestinations.Location = new System.Drawing.Point(0, 71);
            this.buttonDestinations.Name = "buttonDestinations";
            this.buttonDestinations.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonDestinations.Size = new System.Drawing.Size(240, 26);
            this.buttonDestinations.TabIndex = 5;
            this.buttonDestinations.Text = "Destinos";
            this.buttonDestinations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDestinations.UseVisualStyleBackColor = true;
            // 
            // buttonProductsManager
            // 
            this.buttonProductsManager.FlatAppearance.BorderSize = 0;
            this.buttonProductsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductsManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProductsManager.Location = new System.Drawing.Point(0, 4);
            this.buttonProductsManager.Name = "buttonProductsManager";
            this.buttonProductsManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonProductsManager.Size = new System.Drawing.Size(240, 29);
            this.buttonProductsManager.TabIndex = 3;
            this.buttonProductsManager.Text = "Gestionar Envios";
            this.buttonProductsManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductsManager.UseVisualStyleBackColor = true;
            this.buttonProductsManager.Click += new System.EventHandler(this.buttonProductsManager_Click);
            // 
            // buttonShippments
            // 
            this.buttonShippments.FlatAppearance.BorderSize = 0;
            this.buttonShippments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShippments.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonShippments.Location = new System.Drawing.Point(0, 39);
            this.buttonShippments.Name = "buttonShippments";
            this.buttonShippments.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonShippments.Size = new System.Drawing.Size(240, 26);
            this.buttonShippments.TabIndex = 4;
            this.buttonShippments.Text = "Recorridos";
            this.buttonShippments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShippments.UseVisualStyleBackColor = true;
            this.buttonShippments.Click += new System.EventHandler(this.buttonShippments_Click);
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.FlatAppearance.BorderSize = 0;
            this.buttonLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLanguage.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLanguage.Location = new System.Drawing.Point(3, 3);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLanguage.Size = new System.Drawing.Size(244, 29);
            this.buttonLanguage.TabIndex = 4;
            this.buttonLanguage.Text = "Idiomas";
            this.buttonLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLanguage.UseVisualStyleBackColor = true;
            // 
            // leftPanelContainer
            // 
            this.leftPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.leftPanelContainer.Controls.Add(this.buttonTruckersManagement);
            this.leftPanelContainer.Controls.Add(this.settingsManagerPanel);
            this.leftPanelContainer.Controls.Add(this.pictureBox1);
            this.leftPanelContainer.Controls.Add(this.panelTruckersManagementContainer);
            this.leftPanelContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.leftPanelContainer.Name = "leftPanelContainer";
            this.leftPanelContainer.Size = new System.Drawing.Size(250, 580);
            this.leftPanelContainer.TabIndex = 4;
            // 
            // settingsManagerPanel
            // 
            this.settingsManagerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.settingsManagerPanel.Controls.Add(this.buttonLanguage);
            this.settingsManagerPanel.Location = new System.Drawing.Point(0, 525);
            this.settingsManagerPanel.Name = "settingsManagerPanel";
            this.settingsManagerPanel.Size = new System.Drawing.Size(250, 43);
            this.settingsManagerPanel.TabIndex = 1;
            // 
            // panelTruckersManagementContainer
            // 
            this.panelTruckersManagementContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.panelTruckersManagementContainer.Controls.Add(this.buttonAssignedTruckToTrucker);
            this.panelTruckersManagementContainer.Controls.Add(this.buttonDestinations);
            this.panelTruckersManagementContainer.Controls.Add(this.buttonProductsManager);
            this.panelTruckersManagementContainer.Controls.Add(this.buttonShippments);
            this.panelTruckersManagementContainer.Location = new System.Drawing.Point(0, 131);
            this.panelTruckersManagementContainer.Name = "panelTruckersManagementContainer";
            this.panelTruckersManagementContainer.Size = new System.Drawing.Size(250, 135);
            this.panelTruckersManagementContainer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Aplicacion_Choferes.Properties.Resources.ZENNETLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1022, 580);
            this.Controls.Add(this.panelFormsLoader);
            this.Controls.Add(this.leftPanelContainer);
            this.Name = "MainForm";
            this.Text = "Aplicacion Choferes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanelContainer.ResumeLayout(false);
            this.settingsManagerPanel.ResumeLayout(false);
            this.panelTruckersManagementContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFormsLoader;
        private System.Windows.Forms.Button buttonTruckersManagement;
        private System.Windows.Forms.Button buttonAssignedTruckToTrucker;
        private System.Windows.Forms.Button buttonDestinations;
        private System.Windows.Forms.Button buttonProductsManager;
        private System.Windows.Forms.Button buttonShippments;
        private System.Windows.Forms.Button buttonLanguage;
        private System.Windows.Forms.Panel leftPanelContainer;
        private System.Windows.Forms.Panel settingsManagerPanel;
        private System.Windows.Forms.Panel panelTruckersManagementContainer;
    }
}