
namespace HospitalAndCommunalService
{
    partial class FormPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_receipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddPayment = new System.Windows.Forms.Button();
            this.buttonEditPayment = new System.Windows.Forms.Button();
            this.buttonDeletePayment = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.total,
            this.id_receipt});
            this.dataGridViewPayment.Location = new System.Drawing.Point(140, 32);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPayment.Size = new System.Drawing.Size(444, 210);
            this.dataGridViewPayment.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // total
            // 
            this.total.HeaderText = "Итого";
            this.total.Name = "total";
            this.total.Width = 200;
            // 
            // id_receipt
            // 
            this.id_receipt.HeaderText = "Квитанция";
            this.id_receipt.Name = "id_receipt";
            this.id_receipt.Width = 200;
            // 
            // buttonAddPayment
            // 
            this.buttonAddPayment.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPayment.Location = new System.Drawing.Point(103, 287);
            this.buttonAddPayment.Name = "buttonAddPayment";
            this.buttonAddPayment.Size = new System.Drawing.Size(157, 49);
            this.buttonAddPayment.TabIndex = 1;
            this.buttonAddPayment.Text = "Добавить";
            this.buttonAddPayment.UseVisualStyleBackColor = true;
            this.buttonAddPayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditPayment
            // 
            this.buttonEditPayment.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditPayment.Location = new System.Drawing.Point(305, 287);
            this.buttonEditPayment.Name = "buttonEditPayment";
            this.buttonEditPayment.Size = new System.Drawing.Size(157, 49);
            this.buttonEditPayment.TabIndex = 2;
            this.buttonEditPayment.Text = "Изменить";
            this.buttonEditPayment.UseVisualStyleBackColor = true;
            this.buttonEditPayment.Click += new System.EventHandler(this.buttonEditPayment_Click);
            // 
            // buttonDeletePayment
            // 
            this.buttonDeletePayment.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePayment.Location = new System.Drawing.Point(501, 287);
            this.buttonDeletePayment.Name = "buttonDeletePayment";
            this.buttonDeletePayment.Size = new System.Drawing.Size(157, 49);
            this.buttonDeletePayment.TabIndex = 3;
            this.buttonDeletePayment.Text = "Удалить";
            this.buttonDeletePayment.UseVisualStyleBackColor = true;
            this.buttonDeletePayment.Click += new System.EventHandler(this.buttonDeletePayment_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainMenu.Location = new System.Drawing.Point(632, 62);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(158, 92);
            this.buttonMainMenu.TabIndex = 4;
            this.buttonMainMenu.Text = "Главное меню";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 386);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonDeletePayment);
            this.Controls.Add(this.buttonEditPayment);
            this.Controls.Add(this.buttonAddPayment);
            this.Controls.Add(this.dataGridViewPayment);
            this.Name = "FormPayment";
            this.Text = "Оплата";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_receipt;
        private System.Windows.Forms.Button buttonAddPayment;
        private System.Windows.Forms.Button buttonEditPayment;
        private System.Windows.Forms.Button buttonDeletePayment;
        private System.Windows.Forms.Button buttonMainMenu;
    }
}