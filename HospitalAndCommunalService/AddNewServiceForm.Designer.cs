
namespace HospitalAndCommunalService
{
    partial class AddNewServiceForm
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
            this.textBoxAddNameService = new System.Windows.Forms.TextBox();
            this.buttonAddNewService = new System.Windows.Forms.Button();
            this.textBoxAddUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddPriceForUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancelAddNewService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // textBoxAddNameService
            // 
            this.textBoxAddNameService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddNameService.Location = new System.Drawing.Point(354, 66);
            this.textBoxAddNameService.Name = "textBoxAddNameService";
            this.textBoxAddNameService.Size = new System.Drawing.Size(409, 51);
            this.textBoxAddNameService.TabIndex = 1;
            // 
            // buttonAddNewService
            // 
            this.buttonAddNewService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewService.Location = new System.Drawing.Point(176, 328);
            this.buttonAddNewService.Name = "buttonAddNewService";
            this.buttonAddNewService.Size = new System.Drawing.Size(178, 55);
            this.buttonAddNewService.TabIndex = 2;
            this.buttonAddNewService.Text = "Добавить";
            this.buttonAddNewService.UseVisualStyleBackColor = true;
            // 
            // textBoxAddUnit
            // 
            this.textBoxAddUnit.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddUnit.Location = new System.Drawing.Point(424, 142);
            this.textBoxAddUnit.Name = "textBoxAddUnit";
            this.textBoxAddUnit.Size = new System.Drawing.Size(100, 51);
            this.textBoxAddUnit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Единица измерения:";
            // 
            // textBoxAddPriceForUnit
            // 
            this.textBoxAddPriceForUnit.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddPriceForUnit.Location = new System.Drawing.Point(441, 215);
            this.textBoxAddPriceForUnit.Name = "textBoxAddPriceForUnit";
            this.textBoxAddPriceForUnit.Size = new System.Drawing.Size(225, 51);
            this.textBoxAddPriceForUnit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена за единицу:";
            // 
            // buttonCancelAddNewService
            // 
            this.buttonCancelAddNewService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAddNewService.Location = new System.Drawing.Point(441, 328);
            this.buttonCancelAddNewService.Name = "buttonCancelAddNewService";
            this.buttonCancelAddNewService.Size = new System.Drawing.Size(178, 55);
            this.buttonCancelAddNewService.TabIndex = 7;
            this.buttonCancelAddNewService.Text = "Отмена";
            this.buttonCancelAddNewService.UseVisualStyleBackColor = true;
            // 
            // AddNewServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelAddNewService);
            this.Controls.Add(this.textBoxAddPriceForUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddNewService);
            this.Controls.Add(this.textBoxAddNameService);
            this.Controls.Add(this.label1);
            this.Name = "AddNewServiceForm";
            this.Text = "Добавление новой услуги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddNameService;
        private System.Windows.Forms.Button buttonAddNewService;
        private System.Windows.Forms.TextBox textBoxAddUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddPriceForUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelAddNewService;
    }
}