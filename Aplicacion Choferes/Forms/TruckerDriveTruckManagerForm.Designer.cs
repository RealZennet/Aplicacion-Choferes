namespace Aplicacion_Choferes.Forms
{
    partial class TruckerDriveTruckManagerForm
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
            this.buttonSearchByTruckByTruckerID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxIDTrucker = new System.Windows.Forms.TextBox();
            this.dataGridViewDestination = new System.Windows.Forms.DataGridView();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchByTruckByTruckerID
            // 
            this.buttonSearchByTruckByTruckerID.Location = new System.Drawing.Point(12, 333);
            this.buttonSearchByTruckByTruckerID.Name = "buttonSearchByTruckByTruckerID";
            this.buttonSearchByTruckByTruckerID.Size = new System.Drawing.Size(57, 23);
            this.buttonSearchByTruckByTruckerID.TabIndex = 82;
            this.buttonSearchByTruckByTruckerID.Text = "Buscar";
            this.buttonSearchByTruckByTruckerID.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "ID Camionero";
            // 
            // txtBoxIDTrucker
            // 
            this.txtBoxIDTrucker.Location = new System.Drawing.Point(12, 307);
            this.txtBoxIDTrucker.Name = "txtBoxIDTrucker";
            this.txtBoxIDTrucker.Size = new System.Drawing.Size(57, 20);
            this.txtBoxIDTrucker.TabIndex = 80;
            // 
            // dataGridViewDestination
            // 
            this.dataGridViewDestination.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestination.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewDestination.Name = "dataGridViewDestination";
            this.dataGridViewDestination.Size = new System.Drawing.Size(265, 216);
            this.dataGridViewDestination.TabIndex = 79;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 9);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 78;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            // 
            // TruckerDriveTruckManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(696, 385);
            this.Controls.Add(this.buttonSearchByTruckByTruckerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxIDTrucker);
            this.Controls.Add(this.dataGridViewDestination);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TruckerDriveTruckManagerForm";
            this.Text = "TruckerDriveTruckManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearchByTruckByTruckerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxIDTrucker;
        private System.Windows.Forms.DataGridView dataGridViewDestination;
        private System.Windows.Forms.Button buttonBackToMainMenu;
    }
}