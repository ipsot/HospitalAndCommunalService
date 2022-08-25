
namespace HospitalAndCommunalService
{
    partial class FormAddNewCompany
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
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompanyName.Location = new System.Drawing.Point(218, 41);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(547, 51);
            this.textBoxCompanyName.TabIndex = 1;
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCompany.Location = new System.Drawing.Point(62, 136);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(212, 59);
            this.buttonAddCompany.TabIndex = 2;
            this.buttonAddCompany.Text = "Добавить";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            this.buttonAddCompany.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(341, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(268, 59);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAddNewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 248);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddCompany);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewCompany";
            this.Text = "FormAddNewCompany";
            this.Load += new System.EventHandler(this.FormAddNewCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.Button buttonCancel;
    }
}