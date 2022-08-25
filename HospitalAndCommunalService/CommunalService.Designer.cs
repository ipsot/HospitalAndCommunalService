
namespace HospitalAndCommunalService
{
    partial class CommunalService
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
            this.dataGridViewCommunalService = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceForUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewService = new System.Windows.Forms.Button();
            this.buttonEditService = new System.Windows.Forms.Button();
            this.buttonDeleteService = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommunalService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCommunalService
            // 
            this.dataGridViewCommunalService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommunalService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.unit,
            this.priceForUnit});
            this.dataGridViewCommunalService.Location = new System.Drawing.Point(138, 33);
            this.dataGridViewCommunalService.Name = "dataGridViewCommunalService";
            this.dataGridViewCommunalService.Size = new System.Drawing.Size(443, 305);
            this.dataGridViewCommunalService.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Название услуги";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // unit
            // 
            this.unit.HeaderText = "единица измерения";
            this.unit.Name = "unit";
            // 
            // priceForUnit
            // 
            this.priceForUnit.HeaderText = "Стоимость за единицу";
            this.priceForUnit.Name = "priceForUnit";
            // 
            // buttonAddNewService
            // 
            this.buttonAddNewService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewService.Location = new System.Drawing.Point(84, 408);
            this.buttonAddNewService.Name = "buttonAddNewService";
            this.buttonAddNewService.Size = new System.Drawing.Size(164, 65);
            this.buttonAddNewService.TabIndex = 1;
            this.buttonAddNewService.Text = "Добавить";
            this.buttonAddNewService.UseVisualStyleBackColor = true;
            this.buttonAddNewService.Click += new System.EventHandler(this.buttonAddNewService_Click);
            // 
            // buttonEditService
            // 
            this.buttonEditService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditService.Location = new System.Drawing.Point(281, 408);
            this.buttonEditService.Name = "buttonEditService";
            this.buttonEditService.Size = new System.Drawing.Size(164, 65);
            this.buttonEditService.TabIndex = 2;
            this.buttonEditService.Text = "Изменить";
            this.buttonEditService.UseVisualStyleBackColor = true;
            this.buttonEditService.Click += new System.EventHandler(this.buttonEditService_Click);
            // 
            // buttonDeleteService
            // 
            this.buttonDeleteService.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteService.Location = new System.Drawing.Point(461, 408);
            this.buttonDeleteService.Name = "buttonDeleteService";
            this.buttonDeleteService.Size = new System.Drawing.Size(164, 65);
            this.buttonDeleteService.TabIndex = 3;
            this.buttonDeleteService.Text = "Удалить";
            this.buttonDeleteService.UseVisualStyleBackColor = true;
            this.buttonDeleteService.Click += new System.EventHandler(this.buttonDeleteService_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(693, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 85);
            this.button1.TabIndex = 4;
            this.button1.Text = "Главное меню";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CommunalService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDeleteService);
            this.Controls.Add(this.buttonEditService);
            this.Controls.Add(this.buttonAddNewService);
            this.Controls.Add(this.dataGridViewCommunalService);
            this.Name = "CommunalService";
            this.Text = "Коммунальные услуги";
            this.Load += new System.EventHandler(this.CommunalService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommunalService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCommunalService;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceForUnit;
        private System.Windows.Forms.Button buttonAddNewService;
        private System.Windows.Forms.Button buttonEditService;
        private System.Windows.Forms.Button buttonDeleteService;
        private System.Windows.Forms.Button button1;
    }
}