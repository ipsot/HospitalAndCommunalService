
namespace HospitalAndCommunalService
{
    partial class FormAddNewPayment
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
            this.textBoxItogo = new System.Windows.Forms.TextBox();
            this.buttonAddNewPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelPayment = new System.Windows.Forms.Button();
            this.comboBoxIdReceipt = new System.Windows.Forms.ComboBox();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итого:";
            // 
            // textBoxItogo
            // 
            this.textBoxItogo.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItogo.Location = new System.Drawing.Point(282, 63);
            this.textBoxItogo.Name = "textBoxItogo";
            this.textBoxItogo.Size = new System.Drawing.Size(323, 51);
            this.textBoxItogo.TabIndex = 1;
            // 
            // buttonAddNewPayment
            // 
            this.buttonAddNewPayment.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewPayment.Location = new System.Drawing.Point(142, 249);
            this.buttonAddNewPayment.Name = "buttonAddNewPayment";
            this.buttonAddNewPayment.Size = new System.Drawing.Size(211, 88);
            this.buttonAddNewPayment.TabIndex = 2;
            this.buttonAddNewPayment.Text = "Добавить";
            this.buttonAddNewPayment.UseVisualStyleBackColor = true;
            this.buttonAddNewPayment.Click += new System.EventHandler(this.buttonAddNewPayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Квитанция:";
            // 
            // buttonCancelPayment
            // 
            this.buttonCancelPayment.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelPayment.Location = new System.Drawing.Point(418, 249);
            this.buttonCancelPayment.Name = "buttonCancelPayment";
            this.buttonCancelPayment.Size = new System.Drawing.Size(211, 88);
            this.buttonCancelPayment.TabIndex = 5;
            this.buttonCancelPayment.Text = "Отмена";
            this.buttonCancelPayment.UseVisualStyleBackColor = true;
            this.buttonCancelPayment.Click += new System.EventHandler(this.buttonCancelPayment_Click);
            // 
            // comboBoxIdReceipt
            // 
            this.comboBoxIdReceipt.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdReceipt.FormattingEnabled = true;
            this.comboBoxIdReceipt.Location = new System.Drawing.Point(336, 159);
            this.comboBoxIdReceipt.Name = "comboBoxIdReceipt";
            this.comboBoxIdReceipt.Size = new System.Drawing.Size(409, 42);
            this.comboBoxIdReceipt.TabIndex = 6;
            this.comboBoxIdReceipt.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdReceipt_SelectedIndexChanged);
            this.comboBoxIdReceipt.SelectionChangeCommitted += new System.EventHandler(this.comboBoxIdReceipt_SelectionChangeCommitted);
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSquare.Location = new System.Drawing.Point(12, 12);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(147, 51);
            this.textBoxSquare.TabIndex = 7;
            this.textBoxSquare.Visible = false;
            // 
            // textBoxService
            // 
            this.textBoxService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxService.Location = new System.Drawing.Point(186, 6);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(102, 51);
            this.textBoxService.TabIndex = 8;
            this.textBoxService.Visible = false;
            // 
            // FormAddNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.comboBoxIdReceipt);
            this.Controls.Add(this.buttonCancelPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddNewPayment);
            this.Controls.Add(this.textBoxItogo);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewPayment";
            this.Text = "Добавить оплату";
            this.Load += new System.EventHandler(this.FormAddNewPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxItogo;
        private System.Windows.Forms.Button buttonAddNewPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelPayment;
        private System.Windows.Forms.ComboBox comboBoxIdReceipt;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.TextBox textBoxService;
    }
}