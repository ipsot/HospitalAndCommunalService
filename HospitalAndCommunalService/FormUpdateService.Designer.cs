
namespace HospitalAndCommunalService
{
    partial class FormUpdateService
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
            this.textBoxPriceForUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateService = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(452, 318);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 89);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxPriceForUnit
            // 
            this.textBoxPriceForUnit.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPriceForUnit.Location = new System.Drawing.Point(324, 199);
            this.textBoxPriceForUnit.Name = "textBoxPriceForUnit";
            this.textBoxPriceForUnit.Size = new System.Drawing.Size(378, 51);
            this.textBoxPriceForUnit.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Цена за единицу:";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnit.Location = new System.Drawing.Point(362, 112);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(358, 51);
            this.textBoxUnit.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Единица измерения:";
            // 
            // buttonUpdateService
            // 
            this.buttonUpdateService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateService.Location = new System.Drawing.Point(136, 318);
            this.buttonUpdateService.Name = "buttonUpdateService";
            this.buttonUpdateService.Size = new System.Drawing.Size(161, 89);
            this.buttonUpdateService.TabIndex = 10;
            this.buttonUpdateService.Text = "Изменить";
            this.buttonUpdateService.UseVisualStyleBackColor = true;
            this.buttonUpdateService.Click += new System.EventHandler(this.buttonUpdateService_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(221, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(530, 51);
            this.textBoxName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название:";
            // 
            // FormUpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxPriceForUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateService);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateService";
            this.Text = "FormUpdateService";
            this.Load += new System.EventHandler(this.FormUpdateService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPriceForUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateService;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}