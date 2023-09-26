namespace Aplicacion_Choferes.Forms
{
    partial class TravelManagementForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxIDBatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxIDProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewAssignedProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatusShipp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 57;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 56;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(272, 334);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(147, 26);
            this.buttonRefresh.TabIndex = 55;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(351, 302);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 26);
            this.buttonDelete.TabIndex = 54;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(272, 302);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 26);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "ID del lote a asignar";
            // 
            // txtBoxIDBatch
            // 
            this.txtBoxIDBatch.Location = new System.Drawing.Point(272, 156);
            this.txtBoxIDBatch.Name = "txtBoxIDBatch";
            this.txtBoxIDBatch.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDBatch.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID Camion";
            // 
            // txtBoxIDProduct
            // 
            this.txtBoxIDProduct.Location = new System.Drawing.Point(272, 89);
            this.txtBoxIDProduct.Name = "txtBoxIDProduct";
            this.txtBoxIDProduct.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDProduct.TabIndex = 49;
            // 
            // dataGridViewAssignedProducts
            // 
            this.dataGridViewAssignedProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAssignedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAssignedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedProducts.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewAssignedProducts.Name = "dataGridViewAssignedProducts";
            this.dataGridViewAssignedProducts.Size = new System.Drawing.Size(231, 410);
            this.dataGridViewAssignedProducts.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID Destino";
            // 
            // comboBoxStatusShipp
            // 
            this.comboBoxStatusShipp.FormattingEnabled = true;
            this.comboBoxStatusShipp.Location = new System.Drawing.Point(272, 261);
            this.comboBoxStatusShipp.Name = "comboBoxStatusShipp";
            this.comboBoxStatusShipp.Size = new System.Drawing.Size(98, 21);
            this.comboBoxStatusShipp.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Estado del envio";
            // 
            // TravelManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStatusShipp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxIDBatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxIDProduct);
            this.Controls.Add(this.dataGridViewAssignedProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TravelManagementForm";
            this.Text = "TravelManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxIDBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxIDProduct;
        private System.Windows.Forms.DataGridView dataGridViewAssignedProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatusShipp;
        private System.Windows.Forms.Label label4;
    }
}