
namespace HospitalAndCommunalService
{
    partial class FormMainMenu
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
            this.buttonShowAdress = new System.Windows.Forms.Button();
            this.buttonShowCommunalService = new System.Windows.Forms.Button();
            this.buttonShowCompany = new System.Windows.Forms.Button();
            this.buttonShowReceipt = new System.Windows.Forms.Button();
            this.buttonShowTenant = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowAdress
            // 
            this.buttonShowAdress.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAdress.Location = new System.Drawing.Point(110, 166);
            this.buttonShowAdress.Name = "buttonShowAdress";
            this.buttonShowAdress.Size = new System.Drawing.Size(279, 141);
            this.buttonShowAdress.TabIndex = 0;
            this.buttonShowAdress.Text = "Просмотр адресов";
            this.buttonShowAdress.UseVisualStyleBackColor = true;
            this.buttonShowAdress.Click += new System.EventHandler(this.buttonShowAdress_Click);
            // 
            // buttonShowCommunalService
            // 
            this.buttonShowCommunalService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowCommunalService.Location = new System.Drawing.Point(110, 19);
            this.buttonShowCommunalService.Name = "buttonShowCommunalService";
            this.buttonShowCommunalService.Size = new System.Drawing.Size(279, 141);
            this.buttonShowCommunalService.TabIndex = 1;
            this.buttonShowCommunalService.Text = "Просмотр коммунальных услуг";
            this.buttonShowCommunalService.UseVisualStyleBackColor = true;
            this.buttonShowCommunalService.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonShowCompany
            // 
            this.buttonShowCompany.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowCompany.Location = new System.Drawing.Point(110, 313);
            this.buttonShowCompany.Name = "buttonShowCompany";
            this.buttonShowCompany.Size = new System.Drawing.Size(279, 141);
            this.buttonShowCompany.TabIndex = 2;
            this.buttonShowCompany.Text = "Просмотр компаний";
            this.buttonShowCompany.UseVisualStyleBackColor = true;
            this.buttonShowCompany.Click += new System.EventHandler(this.buttonShowCompany_Click);
            // 
            // buttonShowReceipt
            // 
            this.buttonShowReceipt.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowReceipt.Location = new System.Drawing.Point(110, 460);
            this.buttonShowReceipt.Name = "buttonShowReceipt";
            this.buttonShowReceipt.Size = new System.Drawing.Size(279, 141);
            this.buttonShowReceipt.TabIndex = 3;
            this.buttonShowReceipt.Text = "Просмотр квитанций";
            this.buttonShowReceipt.UseVisualStyleBackColor = true;
            this.buttonShowReceipt.Click += new System.EventHandler(this.buttonShowReceipt_Click);
            // 
            // buttonShowTenant
            // 
            this.buttonShowTenant.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowTenant.Location = new System.Drawing.Point(110, 607);
            this.buttonShowTenant.Name = "buttonShowTenant";
            this.buttonShowTenant.Size = new System.Drawing.Size(279, 141);
            this.buttonShowTenant.TabIndex = 4;
            this.buttonShowTenant.Text = "Просмотр жильцов";
            this.buttonShowTenant.UseVisualStyleBackColor = true;
            this.buttonShowTenant.Click += new System.EventHandler(this.buttonShowTenant_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(110, 764);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(279, 141);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(446, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 236);
            this.button1.TabIndex = 6;
            this.button1.Text = "Просмотр счетов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 937);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowTenant);
            this.Controls.Add(this.buttonShowReceipt);
            this.Controls.Add(this.buttonShowCompany);
            this.Controls.Add(this.buttonShowCommunalService);
            this.Controls.Add(this.buttonShowAdress);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowAdress;
        private System.Windows.Forms.Button buttonShowCommunalService;
        private System.Windows.Forms.Button buttonShowCompany;
        private System.Windows.Forms.Button buttonShowReceipt;
        private System.Windows.Forms.Button buttonShowTenant;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
    }
}