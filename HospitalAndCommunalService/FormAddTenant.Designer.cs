
namespace HospitalAndCommunalService
{
    partial class FormAddTenant
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
            this.buttonAddTenant = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancelTenant = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // buttonAddTenant
            // 
            this.buttonAddTenant.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTenant.Location = new System.Drawing.Point(112, 278);
            this.buttonAddTenant.Name = "buttonAddTenant";
            this.buttonAddTenant.Size = new System.Drawing.Size(204, 70);
            this.buttonAddTenant.TabIndex = 1;
            this.buttonAddTenant.Text = "Добавить";
            this.buttonAddTenant.UseVisualStyleBackColor = true;
            this.buttonAddTenant.Click += new System.EventHandler(this.buttonAddTenant_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(196, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(592, 51);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecondName.Location = new System.Drawing.Point(196, 95);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(592, 51);
            this.textBoxSecondName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия:";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(196, 165);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(592, 51);
            this.textBoxPatronymic.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество:";
            // 
            // buttonCancelTenant
            // 
            this.buttonCancelTenant.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelTenant.Location = new System.Drawing.Point(444, 278);
            this.buttonCancelTenant.Name = "buttonCancelTenant";
            this.buttonCancelTenant.Size = new System.Drawing.Size(204, 70);
            this.buttonCancelTenant.TabIndex = 7;
            this.buttonCancelTenant.Text = "Отмена";
            this.buttonCancelTenant.UseVisualStyleBackColor = true;
            this.buttonCancelTenant.Click += new System.EventHandler(this.buttonCancelTenant_Click);
            // 
            // FormAddTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelTenant);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddTenant);
            this.Controls.Add(this.label1);
            this.Name = "FormAddTenant";
            this.Text = "FormAddTenant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTenant;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelTenant;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}