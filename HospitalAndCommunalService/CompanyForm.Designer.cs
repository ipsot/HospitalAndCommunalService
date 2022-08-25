
namespace HospitalAndCommunalService
{
    partial class CompanyForm
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
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.buttonDeleteCompany = new System.Windows.Forms.Button();
            this.buttonEditCompany = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dataGridViewCompany.Location = new System.Drawing.Point(86, 27);
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.Size = new System.Drawing.Size(293, 150);
            this.dataGridViewCompany.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.Width = 250;
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCompany.Location = new System.Drawing.Point(433, 12);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(165, 63);
            this.buttonAddCompany.TabIndex = 1;
            this.buttonAddCompany.Text = "Добавить";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            this.buttonAddCompany.Click += new System.EventHandler(this.buttonAddCompany_Click);
            // 
            // buttonDeleteCompany
            // 
            this.buttonDeleteCompany.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCompany.Location = new System.Drawing.Point(433, 192);
            this.buttonDeleteCompany.Name = "buttonDeleteCompany";
            this.buttonDeleteCompany.Size = new System.Drawing.Size(165, 63);
            this.buttonDeleteCompany.TabIndex = 2;
            this.buttonDeleteCompany.Text = "Удалить";
            this.buttonDeleteCompany.UseVisualStyleBackColor = true;
            this.buttonDeleteCompany.Click += new System.EventHandler(this.buttonDeleteCompany_Click);
            // 
            // buttonEditCompany
            // 
            this.buttonEditCompany.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCompany.Location = new System.Drawing.Point(433, 95);
            this.buttonEditCompany.Name = "buttonEditCompany";
            this.buttonEditCompany.Size = new System.Drawing.Size(165, 63);
            this.buttonEditCompany.TabIndex = 3;
            this.buttonEditCompany.Text = "Изменить";
            this.buttonEditCompany.UseVisualStyleBackColor = true;
            this.buttonEditCompany.Click += new System.EventHandler(this.buttonEditCompany_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainMenu.Location = new System.Drawing.Point(695, 84);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(129, 74);
            this.buttonMainMenu.TabIndex = 4;
            this.buttonMainMenu.Text = "Главное меню";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 265);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonEditCompany);
            this.Controls.Add(this.buttonDeleteCompany);
            this.Controls.Add(this.buttonAddCompany);
            this.Controls.Add(this.dataGridViewCompany);
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.Button buttonDeleteCompany;
        private System.Windows.Forms.Button buttonEditCompany;
        private System.Windows.Forms.Button buttonMainMenu;
    }
}