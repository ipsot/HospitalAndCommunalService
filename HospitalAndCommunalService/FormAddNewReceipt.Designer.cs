
namespace HospitalAndCommunalService
{
    partial class FormAddNewReceipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddReceipt = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.comboBoxTenant = new System.Windows.Forms.ComboBox();
            this.comboBoxAdress = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуга:";
            // 
            // buttonAddReceipt
            // 
            this.buttonAddReceipt.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReceipt.Location = new System.Drawing.Point(105, 354);
            this.buttonAddReceipt.Name = "buttonAddReceipt";
            this.buttonAddReceipt.Size = new System.Drawing.Size(164, 55);
            this.buttonAddReceipt.TabIndex = 2;
            this.buttonAddReceipt.Text = "Добавить";
            this.buttonAddReceipt.UseVisualStyleBackColor = true;
            this.buttonAddReceipt.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(339, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(314, 51);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество единиц:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Жилец:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Компания:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(459, 354);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(164, 55);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxService
            // 
            this.comboBoxService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(167, 28);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(576, 42);
            this.comboBoxService.TabIndex = 12;
            // 
            // comboBoxTenant
            // 
            this.comboBoxTenant.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTenant.FormattingEnabled = true;
            this.comboBoxTenant.Location = new System.Drawing.Point(168, 149);
            this.comboBoxTenant.Name = "comboBoxTenant";
            this.comboBoxTenant.Size = new System.Drawing.Size(575, 42);
            this.comboBoxTenant.TabIndex = 13;
            // 
            // comboBoxAdress
            // 
            this.comboBoxAdress.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdress.FormattingEnabled = true;
            this.comboBoxAdress.Location = new System.Drawing.Point(212, 215);
            this.comboBoxAdress.Name = "comboBoxAdress";
            this.comboBoxAdress.Size = new System.Drawing.Size(531, 42);
            this.comboBoxAdress.TabIndex = 14;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(212, 274);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(531, 42);
            this.comboBoxCompany.TabIndex = 15;
            // 
            // FormAddNewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.comboBoxAdress);
            this.Controls.Add(this.comboBoxTenant);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddReceipt);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewReceipt";
            this.Text = "Добавить квитанцию";
            this.Load += new System.EventHandler(this.FormAddNewReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddReceipt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.ComboBox comboBoxTenant;
        private System.Windows.Forms.ComboBox comboBoxAdress;
        private System.Windows.Forms.ComboBox comboBoxCompany;
    }
}