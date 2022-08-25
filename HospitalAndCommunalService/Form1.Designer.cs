
namespace HospitalAndCommunalService
{
    partial class AdressForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAdress = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewAdress = new System.Windows.Forms.Button();
            this.buttonEditAdress = new System.Windows.Forms.Button();
            this.buttonDeleteAdress = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdress)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdress
            // 
            this.dataGridViewAdress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Street,
            this.home,
            this.flat,
            this.countPeople,
            this.Square});
            this.dataGridViewAdress.Location = new System.Drawing.Point(161, 12);
            this.dataGridViewAdress.Name = "dataGridViewAdress";
            this.dataGridViewAdress.ReadOnly = true;
            this.dataGridViewAdress.Size = new System.Drawing.Size(894, 445);
            this.dataGridViewAdress.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // Street
            // 
            this.Street.HeaderText = "Улица";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            this.Street.Width = 300;
            // 
            // home
            // 
            this.home.HeaderText = "Дом";
            this.home.Name = "home";
            this.home.ReadOnly = true;
            // 
            // flat
            // 
            this.flat.HeaderText = "Квартира";
            this.flat.Name = "flat";
            this.flat.ReadOnly = true;
            // 
            // countPeople
            // 
            this.countPeople.HeaderText = "Количество жильцов";
            this.countPeople.Name = "countPeople";
            this.countPeople.ReadOnly = true;
            // 
            // Square
            // 
            this.Square.HeaderText = "Площадь";
            this.Square.Name = "Square";
            this.Square.ReadOnly = true;
            this.Square.Width = 250;
            // 
            // buttonAddNewAdress
            // 
            this.buttonAddNewAdress.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewAdress.Location = new System.Drawing.Point(161, 520);
            this.buttonAddNewAdress.Name = "buttonAddNewAdress";
            this.buttonAddNewAdress.Size = new System.Drawing.Size(229, 60);
            this.buttonAddNewAdress.TabIndex = 1;
            this.buttonAddNewAdress.Text = "Добавить";
            this.buttonAddNewAdress.UseVisualStyleBackColor = true;
            this.buttonAddNewAdress.Click += new System.EventHandler(this.buttonAddNewAdress_Click);
            // 
            // buttonEditAdress
            // 
            this.buttonEditAdress.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditAdress.Location = new System.Drawing.Point(499, 520);
            this.buttonEditAdress.Name = "buttonEditAdress";
            this.buttonEditAdress.Size = new System.Drawing.Size(229, 60);
            this.buttonEditAdress.TabIndex = 2;
            this.buttonEditAdress.Text = "Изменить";
            this.buttonEditAdress.UseVisualStyleBackColor = true;
            this.buttonEditAdress.Click += new System.EventHandler(this.buttonEditAdress_Click);
            // 
            // buttonDeleteAdress
            // 
            this.buttonDeleteAdress.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAdress.Location = new System.Drawing.Point(843, 520);
            this.buttonDeleteAdress.Name = "buttonDeleteAdress";
            this.buttonDeleteAdress.Size = new System.Drawing.Size(229, 60);
            this.buttonDeleteAdress.TabIndex = 3;
            this.buttonDeleteAdress.Text = "Удалить";
            this.buttonDeleteAdress.UseVisualStyleBackColor = true;
            this.buttonDeleteAdress.Click += new System.EventHandler(this.buttonDeleteAdress_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainMenu.Location = new System.Drawing.Point(1122, 103);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(153, 101);
            this.buttonMainMenu.TabIndex = 4;
            this.buttonMainMenu.Text = "Главное меню";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // AdressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 637);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonDeleteAdress);
            this.Controls.Add(this.buttonEditAdress);
            this.Controls.Add(this.buttonAddNewAdress);
            this.Controls.Add(this.dataGridViewAdress);
            this.Name = "AdressForm";
            this.Text = "Адрес";
            this.Load += new System.EventHandler(this.Adress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdress;
        private System.Windows.Forms.Button buttonAddNewAdress;
        private System.Windows.Forms.Button buttonEditAdress;
        private System.Windows.Forms.Button buttonDeleteAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn flat;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn Square;
        private System.Windows.Forms.Button buttonMainMenu;
    }
}

