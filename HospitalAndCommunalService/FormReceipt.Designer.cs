
namespace HospitalAndCommunalService
{
    partial class FormReceipt
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
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewReceipt = new System.Windows.Forms.Button();
            this.buttonEditReceipt = new System.Windows.Forms.Button();
            this.buttonDeleteReceipt = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_service,
            this.count_unit,
            this.id_tenant,
            this.id_adress,
            this.id_company});
            this.dataGridViewReceipt.Location = new System.Drawing.Point(45, 37);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.Size = new System.Drawing.Size(744, 206);
            this.dataGridViewReceipt.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // id_service
            // 
            this.id_service.HeaderText = "Услуга";
            this.id_service.Name = "id_service";
            // 
            // count_unit
            // 
            this.count_unit.HeaderText = "Количество";
            this.count_unit.Name = "count_unit";
            // 
            // id_tenant
            // 
            this.id_tenant.HeaderText = "Жилец";
            this.id_tenant.Name = "id_tenant";
            // 
            // id_adress
            // 
            this.id_adress.HeaderText = "Адрес дома";
            this.id_adress.Name = "id_adress";
            this.id_adress.Width = 300;
            // 
            // id_company
            // 
            this.id_company.HeaderText = "Компания";
            this.id_company.Name = "id_company";
            // 
            // buttonAddNewReceipt
            // 
            this.buttonAddNewReceipt.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewReceipt.Location = new System.Drawing.Point(85, 278);
            this.buttonAddNewReceipt.Name = "buttonAddNewReceipt";
            this.buttonAddNewReceipt.Size = new System.Drawing.Size(159, 52);
            this.buttonAddNewReceipt.TabIndex = 1;
            this.buttonAddNewReceipt.Text = "Добавить";
            this.buttonAddNewReceipt.UseVisualStyleBackColor = true;
            this.buttonAddNewReceipt.Click += new System.EventHandler(this.buttonAddNewReceipt_Click);
            // 
            // buttonEditReceipt
            // 
            this.buttonEditReceipt.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditReceipt.Location = new System.Drawing.Point(282, 278);
            this.buttonEditReceipt.Name = "buttonEditReceipt";
            this.buttonEditReceipt.Size = new System.Drawing.Size(159, 52);
            this.buttonEditReceipt.TabIndex = 2;
            this.buttonEditReceipt.Text = "Изменить";
            this.buttonEditReceipt.UseVisualStyleBackColor = true;
            this.buttonEditReceipt.Click += new System.EventHandler(this.buttonEditReceipt_Click);
            // 
            // buttonDeleteReceipt
            // 
            this.buttonDeleteReceipt.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteReceipt.Location = new System.Drawing.Point(469, 278);
            this.buttonDeleteReceipt.Name = "buttonDeleteReceipt";
            this.buttonDeleteReceipt.Size = new System.Drawing.Size(159, 52);
            this.buttonDeleteReceipt.TabIndex = 3;
            this.buttonDeleteReceipt.Text = "Удалить";
            this.buttonDeleteReceipt.UseVisualStyleBackColor = true;
            this.buttonDeleteReceipt.Click += new System.EventHandler(this.buttonDeleteReceipt_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainMenu.Location = new System.Drawing.Point(841, 59);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(144, 84);
            this.buttonMainMenu.TabIndex = 4;
            this.buttonMainMenu.Text = "Главное меню";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 366);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonDeleteReceipt);
            this.Controls.Add(this.buttonEditReceipt);
            this.Controls.Add(this.buttonAddNewReceipt);
            this.Controls.Add(this.dataGridViewReceipt);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.Button buttonAddNewReceipt;
        private System.Windows.Forms.Button buttonEditReceipt;
        private System.Windows.Forms.Button buttonDeleteReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_company;
        private System.Windows.Forms.Button buttonMainMenu;
    }
}