
namespace HospitalAndCommunalService
{
    partial class FormUpdateCompany
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdateCompany = new System.Windows.Forms.Button();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(420, 157);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(268, 59);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdateCompany
            // 
            this.buttonUpdateCompany.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCompany.Location = new System.Drawing.Point(92, 157);
            this.buttonUpdateCompany.Name = "buttonUpdateCompany";
            this.buttonUpdateCompany.Size = new System.Drawing.Size(212, 59);
            this.buttonUpdateCompany.TabIndex = 6;
            this.buttonUpdateCompany.Text = "Изменить";
            this.buttonUpdateCompany.UseVisualStyleBackColor = true;
            this.buttonUpdateCompany.Click += new System.EventHandler(this.buttonUpdateCompany_Click);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompanyName.Location = new System.Drawing.Point(211, 62);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(547, 51);
            this.textBoxCompanyName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название:";
            // 
            // FormUpdateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 312);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdateCompany);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateCompany";
            this.Text = "FormUpdateCompany";
            this.Load += new System.EventHandler(this.FormUpdateCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdateCompany;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label label1;
    }
}