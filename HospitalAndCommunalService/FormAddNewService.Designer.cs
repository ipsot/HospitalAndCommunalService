
namespace HospitalAndCommunalService
{
    partial class FormAddNewService
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddNewService = new System.Windows.Forms.Button();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPriceForUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(236, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(530, 51);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonAddNewService
            // 
            this.buttonAddNewService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewService.Location = new System.Drawing.Point(151, 309);
            this.buttonAddNewService.Name = "buttonAddNewService";
            this.buttonAddNewService.Size = new System.Drawing.Size(161, 89);
            this.buttonAddNewService.TabIndex = 2;
            this.buttonAddNewService.Text = "Добавить";
            this.buttonAddNewService.UseVisualStyleBackColor = true;
            this.buttonAddNewService.Click += new System.EventHandler(this.buttonAddNewService_Click);
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnit.Location = new System.Drawing.Point(377, 103);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(358, 51);
            this.textBoxUnit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Единица измерения:";
            // 
            // textBoxPriceForUnit
            // 
            this.textBoxPriceForUnit.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPriceForUnit.Location = new System.Drawing.Point(339, 190);
            this.textBoxPriceForUnit.Name = "textBoxPriceForUnit";
            this.textBoxPriceForUnit.Size = new System.Drawing.Size(378, 51);
            this.textBoxPriceForUnit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена за единицу:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(467, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 89);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxPriceForUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddNewService);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewService";
            this.Text = "FormAddNewService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddNewService;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPriceForUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
    }
}