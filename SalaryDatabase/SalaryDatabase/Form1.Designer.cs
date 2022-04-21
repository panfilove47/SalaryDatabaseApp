namespace SalaryDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPosTax = new System.Windows.Forms.Button();
            this.btnDeals = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDealSum = new System.Windows.Forms.Button();
            this.btnEmployeeProfit = new System.Windows.Forms.Button();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.textBoxIdEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuerry = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPosition
            // 
            this.btnPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosition.Location = new System.Drawing.Point(376, 12);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(111, 23);
            this.btnPosition.TabIndex = 2;
            this.btnPosition.Text = "Show positions";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnTax
            // 
            this.btnTax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTax.Location = new System.Drawing.Point(493, 12);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(75, 23);
            this.btnTax.TabIndex = 3;
            this.btnTax.Text = "Show taxes";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployees.Location = new System.Drawing.Point(266, 12);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(104, 23);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Show employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnPosTax
            // 
            this.btnPosTax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosTax.Location = new System.Drawing.Point(574, 12);
            this.btnPosTax.Name = "btnPosTax";
            this.btnPosTax.Size = new System.Drawing.Size(150, 23);
            this.btnPosTax.TabIndex = 4;
            this.btnPosTax.Text = "Show positions with taxes";
            this.btnPosTax.UseVisualStyleBackColor = true;
            this.btnPosTax.Click += new System.EventHandler(this.btnPosTax_Click);
            // 
            // btnDeals
            // 
            this.btnDeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeals.Location = new System.Drawing.Point(730, 12);
            this.btnDeals.Name = "btnDeals";
            this.btnDeals.Size = new System.Drawing.Size(75, 23);
            this.btnDeals.TabIndex = 5;
            this.btnDeals.Text = "Show deals";
            this.btnDeals.UseVisualStyleBackColor = true;
            this.btnDeals.Click += new System.EventHandler(this.btnDeals_Click);
            // 
            // btnClients
            // 
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.Location = new System.Drawing.Point(811, 12);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(75, 23);
            this.btnClients.TabIndex = 6;
            this.btnClients.Text = "Show clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(188, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(314, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show employees salaries";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDealSum
            // 
            this.btnDealSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDealSum.Location = new System.Drawing.Point(12, 344);
            this.btnDealSum.Name = "btnDealSum";
            this.btnDealSum.Size = new System.Drawing.Size(102, 35);
            this.btnDealSum.TabIndex = 14;
            this.btnDealSum.Text = "Show sum Deals with";
            this.btnDealSum.UseVisualStyleBackColor = true;
            this.btnDealSum.Click += new System.EventHandler(this.btnDealSum_Click);
            // 
            // btnEmployeeProfit
            // 
            this.btnEmployeeProfit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeProfit.Location = new System.Drawing.Point(12, 430);
            this.btnEmployeeProfit.Name = "btnEmployeeProfit";
            this.btnEmployeeProfit.Size = new System.Drawing.Size(119, 34);
            this.btnEmployeeProfit.TabIndex = 15;
            this.btnEmployeeProfit.Text = "Employee profit";
            this.btnEmployeeProfit.UseVisualStyleBackColor = true;
            this.btnEmployeeProfit.Click += new System.EventHandler(this.btnEmployeeProfit_Click);
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Location = new System.Drawing.Point(11, 318);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdClient.TabIndex = 16;
            this.textBoxIdClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdClient_KeyPress);
            // 
            // textBoxIdEmployee
            // 
            this.textBoxIdEmployee.Location = new System.Drawing.Point(11, 404);
            this.textBoxIdEmployee.Name = "textBoxIdEmployee";
            this.textBoxIdEmployee.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdEmployee.TabIndex = 19;
            this.textBoxIdEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdEmployee_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Client\'s ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Employee\'s ID";
            // 
            // textBoxQuerry
            // 
            this.textBoxQuerry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuerry.Location = new System.Drawing.Point(458, 340);
            this.textBoxQuerry.Multiline = true;
            this.textBoxQuerry.Name = "textBoxQuerry";
            this.textBoxQuerry.Size = new System.Drawing.Size(428, 166);
            this.textBoxQuerry.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(377, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Enter querry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(76, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter date:";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(127, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Show salaries per month";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 518);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxQuerry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdEmployee);
            this.Controls.Add(this.textBoxIdClient);
            this.Controls.Add(this.btnEmployeeProfit);
            this.Controls.Add(this.btnDealSum);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDeals);
            this.Controls.Add(this.btnPosTax);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(914, 557);
            this.MinimumSize = new System.Drawing.Size(914, 557);
            this.Name = "Form1";
            this.Text = "Salary Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPosTax;
        private System.Windows.Forms.Button btnDeals;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDealSum;
        private System.Windows.Forms.Button btnEmployeeProfit;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.TextBox textBoxIdEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuerry;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

