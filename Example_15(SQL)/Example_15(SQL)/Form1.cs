using System;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Example_15_SQL_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool TableNotExists(string TableName)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.LoginsConnectionString);
                connection.Open();

                // посылаем запрос comand к БД ...результат в dr
                SqlCommand command = new SqlCommand("SELECT * FROM " + TableName, connection);
                SqlDataReader dr = command.ExecuteReader();
                
                dr.Close();
                connection.Close();
                return false;
            }
            catch{}
            return true;
        }

        private string CreateCommand()
        {
            string strCommand = "CREATE TABLE[dbo].[" + tbTableName.Text + "]([intId] INT NOT NULL PRIMARY KEY IDENTITY,";
            for(int i=0;i<grid.RowCount-1;i++)//пробегаемся по всей таблице
            {
                strCommand += "[" + grid.Rows[i].Cells[1].Value + "] " + grid.Rows[i].Cells[0].Value + " NULL";
                if (i + 1 != grid.RowCount-1) strCommand += ",";
                else strCommand += ")";
            }
            Console.WriteLine(strCommand);
            return strCommand;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableNotExists(tbTableName.Text))//если данной таблицы нет
                {
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.LoginsConnectionString);//берем строку подключения
                    SqlCommand command = new SqlCommand(CreateCommand(), connection);
                    connection.Open();//открываем подкючение
                    command.ExecuteNonQuery();//выпполняем команду
                    connection.Close();//зыкрываем подключение
                    MessageBox.Show("Table successfully added");
                }else
                {
                    throw new InvalidOperationException("A table with this name already exists");
                }
            }
             catch (InvalidOperationException exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAddRows_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[A-Z]{3,8}");//ограничение на длину и кол-во символо
            if(regex.IsMatch(cbDataType.Text))
                grid.Rows.Insert(grid.RowCount-1, cbDataType.Text,tbNameCell.Text);
            else MessageBox.Show("Incorrect input in the field Data Type", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableNotExists(tbNameDataBase.Text) == false)//если данная таблица существует
                {
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.LoginsConnectionString);
                    SqlCommand command = new SqlCommand("DROP TABLE " + tbNameDataBase.Text, connection);//отправляем запрос для удаления выбранной табицы
                    connection.Open();//открываем подкючение
                    command.ExecuteNonQuery();//выпполняем команду
                    connection.Close();//зыкрываем подключение
                    MessageBox.Show("Table successfully removed");
                }
                else
                {
                    throw new InvalidOperationException("Данная табилца не существует !");
                }
            }
            catch(InvalidOperationException exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Logins". При необходимости она может быть перемещена или удалена.
            this.loginsTableAdapter.Fill(this.dataSet.Logins);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Logins". При необходимости она может быть перемещена или удалена.
            this.loginsTableAdapter.Fill(this.dataSet.Logins);

        }

        private void UpdateTable()
        {
            switch (cbDtLogins.Text)
            {
                case "intId":
                    {
                        dgvLoginsUpdate.Rows[Convert.ToInt32(bindingNavigatorPositionItem.Text) - 1].Cells[0].Value = tbNewValue.Text;
                        break;
                    }
                case "nvcLogins":
                    {
                        dgvLoginsUpdate.Rows[Convert.ToInt32(bindingNavigatorPositionItem.Text) - 1].Cells[1].Value = tbNewValue.Text;
                        break;
                    }
                case "nvcPassword":
                    {
                        dgvLoginsUpdate.Rows[Convert.ToInt32(bindingNavigatorPositionItem.Text) - 1].Cells[2].Value = tbNewValue.Text;
                        break;
                    }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableNotExists("Logins") == false)//если данная таблица существует
                {
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.LoginsConnectionString);
                    SqlCommand command = new SqlCommand("Select * from Logins", connection);
                    connection.Open();

                    command.CommandText = "Update Logins Set " + cbDtLogins.Text + "='" + tbNewValue.Text + "' where intId=" + Convert.ToInt32(bindingNavigatorPositionItem.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    UpdateTable();
                    reader.Close();
                    connection.Close();

                    MessageBox.Show("Data updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    throw new InvalidOperationException("Данная табилца не существует !");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.loginsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableNotExists("Logins") == false)//если данная таблица существует
                {
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.LoginsConnectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO Logins (nvcLogins,nvcPassword) VALUES ('" + tbNewnvcLogins.Text + "','" + tbNewnvcPassword.Text + "')", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("New field successfully added to table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new InvalidOperationException("Данная табилца не существует !");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
