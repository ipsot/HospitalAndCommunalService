
namespace HospitalAndCommunalService
{
    partial class FormTenant
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
            this.dataGridViewTenant = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewTenant = new System.Windows.Forms.Button();
            this.buttonEditTenant = new System.Windows.Forms.Button();
            this.buttonDeleteTenant = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTenant
            // 
            this.dataGridViewTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.secondname,
            this.patronymic});
            this.dataGridViewTenant.Location = new System.Drawing.Point(47, 25);
            this.dataGridViewTenant.Name = "dataGridViewTenant";
            this.dataGridViewTenant.Size = new System.Drawing.Size(943, 257);
            this.dataGridViewTenant.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "Имя";
            this.firstname.Name = "firstname";
            this.firstname.Width = 300;
            // 
            // secondname
            // 
            this.secondname.HeaderText = "Фамилия";
            this.secondname.Name = "secondname";
            this.secondname.Width = 300;
            // 
            // patronymic
            // 
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.Name = "patronymic";
            this.patronymic.Width = 300;
            // 
            // buttonAddNewTenant
            // 
            this.buttonAddNewTenant.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewTenant.Location = new System.Drawing.Point(71, 337);
            this.buttonAddNewTenant.Name = "buttonAddNewTenant";
            this.buttonAddNewTenant.Size = new System.Drawing.Size(199, 63);
            this.buttonAddNewTenant.TabIndex = 1;
            this.buttonAddNewTenant.Text = "Добавить";
            this.buttonAddNewTenant.UseVisualStyleBackColor = true;
            this.buttonAddNewTenant.Click += new System.EventHandler(this.buttonAddNewTenant_Click);
            // 
            // buttonEditTenant
            // 
            this.buttonEditTenant.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTenant.Location = new System.Drawing.Point(401, 337);
            this.buttonEditTenant.Name = "buttonEditTenant";
            this.buttonEditTenant.Size = new System.Drawing.Size(199, 63);
            this.buttonEditTenant.TabIndex = 2;
            this.buttonEditTenant.Text = "Изменить";
            this.buttonEditTenant.UseVisualStyleBackColor = true;
            this.buttonEditTenant.Click += new System.EventHandler(this.buttonEditTenant_Click);
            // 
            // buttonDeleteTenant
            // 
            this.buttonDeleteTenant.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTenant.Location = new System.Drawing.Point(723, 337);
            this.buttonDeleteTenant.Name = "buttonDeleteTenant";
            this.buttonDeleteTenant.Size = new System.Drawing.Size(199, 63);
            this.buttonDeleteTenant.TabIndex = 3;
            this.buttonDeleteTenant.Text = "Удалить";
            this.buttonDeleteTenant.UseVisualStyleBackColor = true;
            this.buttonDeleteTenant.Click += new System.EventHandler(this.buttonDeleteTenant_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainMenu.Location = new System.Drawing.Point(1024, 69);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(133, 97);
            this.buttonMainMenu.TabIndex = 4;
            this.buttonMainMenu.Text = "Главное меню";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // FormTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 493);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonDeleteTenant);
            this.Controls.Add(this.buttonEditTenant);
            this.Controls.Add(this.buttonAddNewTenant);
            this.Controls.Add(this.dataGridViewTenant);
            this.Name = "FormTenant";
            this.Text = "FormTenant";
            this.Load += new System.EventHandler(this.FormTenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondname;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.Button buttonAddNewTenant;
        private System.Windows.Forms.Button buttonEditTenant;
        private System.Windows.Forms.Button buttonDeleteTenant;
        private System.Windows.Forms.Button buttonMainMenu;
    }
}