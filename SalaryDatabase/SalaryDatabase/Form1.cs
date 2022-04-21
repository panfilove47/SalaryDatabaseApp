using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SalaryDatabase
{
    public partial class Form1 : Form
    {
        string connect = "Server=localhost;Database=SalaryDB;Uid=root;password=Vbifcfif;charset=utf8";
        public MySqlConnection MyConn; // Коннектор к БД
        public MySqlCommand MyComm; // Для отправки запроса
        public MySqlDataAdapter adapter; // Предоставляет выборку из запроса.
        private BindingSource bindingSource;
        DataTable dt;
        DateTime firstDate;
        DateTime secondDate;

        public Form1() 
        {
            InitializeComponent();
            MyConn = new MySqlConnection(connect);
            MyConn.Open();
        }
        ~Form1()
        {
            MyConn.Close();
        }

        private void fillTableInRequest(string querry) // Метод для отправки запроса из 1 или нескольких таблиц в MYSQL и заполнения таблицы. (Без изменений)
        {
            try
            {
                adapter = new MySqlDataAdapter(querry, connect); // Предоставляет выборку из запроса.
                DataTable table = new DataTable(); // Временная таблица для заполнения нашей.
                adapter.Fill(table); // Заполнение временной таблицы.
                bindingSource = new BindingSource();
                bindingSource.DataSource = table;
                dataGridView1.DataSource = bindingSource; // Перенесение временной таблицы в основную.
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            
        }
        private void fillTableWithChanges(string querry)
        {
            try
            {
                adapter = new MySqlDataAdapter(querry, connect); // Метод для отправки запроса из 1 таблицы в MYSQL и заполнения таблицы. (С возможностью изменений)
                MySqlCommandBuilder myCommandBuilder = new MySqlCommandBuilder(adapter as MySqlDataAdapter);
                adapter.InsertCommand = myCommandBuilder.GetInsertCommand();
                adapter.UpdateCommand = myCommandBuilder.GetUpdateCommand();
                adapter.DeleteCommand = myCommandBuilder.GetDeleteCommand();
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e) // Показать сотрудников
        {
            fillTableWithChanges("select * from employees;");
        }

        private void btnPosition_Click(object sender, EventArgs e) // Показать профессию
        {
            fillTableWithChanges("select * from Position;");
        }

        private void btnTax_Click(object sender, EventArgs e) // Показать налоги
        {
            fillTableWithChanges("select * from Tax;");
        }

        private void btnPosTax_Click(object sender, EventArgs e) // Показать налоги к профессии
        {
            fillTableWithChanges("select * from Position_has_Tax;");
        }

        private void btnDeals_Click(object sender, EventArgs e) // Показать сделки
        {
            fillTableWithChanges("select * from Deals;");
        }

        private void btnClients_Click(object sender, EventArgs e) // Показать клиентов
        {
            fillTableWithChanges("select * from Clients");
        }

        private void btnAdd_Click(object sender, EventArgs e) // Сохранить изменения в таблице
        {
            if (MessageBox.Show("Вы действительно хотите сохранить изменения?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    adapter.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) // Удалить строку в таблице
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    adapter.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Указать зарплату за определенный срок начиная от месяца + премия
        {

            fillTableInRequest("with Employes_premias as (select idEmployees, EmployFIO, sum(DealSum * DealPercent/100)" + // Можно использовать текстбоксы вместо дат, смотря как правильней
                " as Premia from employees left join deals on idemployees = employees_idemployees where DealDate between" +
                " '" + firstDate.Year + "-" + firstDate.Month + "-"+firstDate.Day+"' and '" + secondDate.Year +"-"+secondDate.Month +"-"+secondDate.Day+"'  group by idemployees union select idEmployees, EmployFIO, sum(DealSum * DealPercent/100)" +
                " as Premia from employees right join deals on idemployees = employees_idemployees where DealDate between" +
                " '" + firstDate.Year + "-" + firstDate.Month + "-"+firstDate.Day+"' and '" + secondDate.Year + "-" + secondDate.Month + "-"+secondDate.Day+"' group by idemployees), Normal_Salary as (select idPosition, sum(TaxPercent)" +
                " as AllPercent, (Salary-(Salary*sum(TaxPercent)/100)) as NormalSalary from position p, tax, position_has_tax pt where" +
                " pt.position_idposition = p.idposition and idTax = Tax_idTax group by idPosition), salary_per_month as" +
                " (select idsalarypermonth, Year, Month_idMonth as Month, idEmployees, EmployFIO, idPosition, sum(NormalSalary) as" +
                " Salary from salarypermonth spm, normal_salary ns, employees e, `year` y where spm.employees_idemployees = e.idemployees" +
                " and ns.idPosition = spm.Position_idPosition and year_idYear = idyear and Month_idMonth between "+ firstDate.Month + " and "+secondDate.Month+" and year_idYear = "+ secondDate.Year + " group by idEmployees)" +
                " select year, Month, spm.idEmployees, spm.EmployFIO, spm.idPosition," +
                " round(if(Premia is not Null, Salary + Premia, Salary),2) as Salary from salary_per_month spm left join Employes_premias ep" +
                " on spm.idEmployees = ep.idEmployees order by idEmployees;");
            
        }

        public int i = 0;


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) // Календарь для выбора периода
        {
            this.monthCalendar1.MaxSelectionCount = 365;
            if (i == 0)
            {
                this.textBox1.Text = this.monthCalendar1.SelectionRange.Start.ToShortDateString();
                firstDate = DateTime.Parse(textBox1.Text);
                i = 1;
            }
            else
            {
                this.textBox2.Text = this.monthCalendar1.SelectionRange.End.ToShortDateString();
                secondDate = DateTime.Parse(textBox2.Text);
                i = 0;
            }
        }

        private void btnDealSum_Click(object sender, EventArgs e) //Показать сумму сделок с определенным клиентом
        {
            try
            {
                MyConn = new MySqlConnection(connect);
                MyConn.Open();
                MySqlCommand cmd = new MySqlCommand("select exists(select * from Clients where idClients =" + textBoxIdClient.Text + ");", MyConn);
                bool isClientExists = System.Convert.ToBoolean(cmd.ExecuteScalar());
                if (isClientExists)
                {
                    fillTableInRequest("select idClients, ClientFIO, sum(DealSum)" +
                        " as AllSum from clients, deals where idClients = Clients_idClients and (Clients_idClients =" + textBoxIdClient.Text + ")");
                }
                else
                    MessageBox.Show("Такого клиента не существует!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            } 
        }

        private void btnEmployeeProfit_Click(object sender, EventArgs e) // Показать сколько сотрудник принес денег от клиентов за определенный срок
        {
            try
            {
                MyConn = new MySqlConnection(connect);
                MyConn.Open();
                MySqlCommand cmd = new MySqlCommand("select exists(select * from Employees where idEmployees =" + textBoxIdEmployee.Text + ");", MyConn);
                bool isEmployeeExists = System.Convert.ToBoolean(cmd.ExecuteScalar());
                if (isEmployeeExists)
                {
                    fillTableInRequest("select idemployees, EmployFIO,sum(DealSum) from employees, deals where idemployees" +
                        " = employees_idemployees and idemployees =" + textBoxIdEmployee.Text + " and DealDate" +
                        " between '" + firstDate.ToString("yyyyMMdd") + "' and '" + secondDate.ToString("yyyyMMdd") + "';");
                }
                else
                    MessageBox.Show("Такого сотрудника не существует!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e) // пользовательский запрос
        {
            fillTableInRequest(textBoxQuerry.Text);
        }

        private void textBoxIdEmployee_KeyPress(object sender, KeyPressEventArgs e) // Проверка на ввод только чисел для работников
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(textBoxIdEmployee.Text) && e.KeyChar == ','))
            {
                return;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnEmployeeProfit_Click(null, null);
                }
            }

            e.Handled = true;
        }

        private void textBoxIdClient_KeyPress(object sender, KeyPressEventArgs e) // Проверка на ввод только чисел для клиентов
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(textBoxIdClient.Text) && e.KeyChar == ','))
            {
                return;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnDealSum_Click(null, null);
                }
            }

            e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e) // Показать список зарплат за месяц
        {
            fillTableWithChanges("select * from salarypermonth");
        }
    }
}
