
namespace HospitalAndCommunalService
{
    partial class FormUpdatePayment
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
            this.comboBoxIdReceipt = new System.Windows.Forms.ComboBox();
            this.buttonCancelPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdatePayment = new System.Windows.Forms.Button();
            this.textBoxItogo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxIdReceipt
            // 
            this.comboBoxIdReceipt.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdReceipt.FormattingEnabled = true;
            this.comboBoxIdReceipt.Location = new System.Drawing.Point(310, 152);
            this.comboBoxIdReceipt.Name = "comboBoxIdReceipt";
            this.comboBoxIdReceipt.Size = new System.Drawing.Size(409, 42);
            this.comboBoxIdReceipt.TabIndex = 12;
            // 
            // buttonCancelPayment
            // 
            this.buttonCancelPayment.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelPayment.Location = new System.Drawing.Point(440, 289);
            this.buttonCancelPayment.Name = "buttonCancelPayment";
            this.buttonCancelPayment.Size = new System.Drawing.Size(211, 88);
            this.buttonCancelPayment.TabIndex = 11;
            this.buttonCancelPayment.Text = "Отмена";
            this.buttonCancelPayment.UseVisualStyleBackColor = true;
            this.buttonCancelPayment.Click += new System.EventHandler(this.buttonCancelPayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Квитанция:";
            // 
            // buttonUpdatePayment
            // 
            this.buttonUpdatePayment.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePayment.Location = new System.Drawing.Point(108, 289);
            this.buttonUpdatePayment.Name = "buttonUpdatePayment";
            this.buttonUpdatePayment.Size = new System.Drawing.Size(211, 88);
            this.buttonUpdatePayment.TabIndex = 9;
            this.buttonUpdatePayment.Text = "Изменить";
            this.buttonUpdatePayment.UseVisualStyleBackColor = true;
            this.buttonUpdatePayment.Click += new System.EventHandler(this.buttonUpdatePayment_Click);
            // 
            // textBoxItogo
            // 
            this.textBoxItogo.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItogo.Location = new System.Drawing.Point(256, 56);
            this.textBoxItogo.Name = "textBoxItogo";
            this.textBoxItogo.Size = new System.Drawing.Size(323, 51);
            this.textBoxItogo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Итого:";
            // 
            // FormUpdatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxIdReceipt);
            this.Controls.Add(this.buttonCancelPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdatePayment);
            this.Controls.Add(this.textBoxItogo);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePayment";
            this.Text = "FormUpdatePayment";
            this.Load += new System.EventHandler(this.FormUpdatePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdReceipt;
        private System.Windows.Forms.Button buttonCancelPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdatePayment;
        private System.Windows.Forms.TextBox textBoxItogo;
        private System.Windows.Forms.Label label1;
    }
}