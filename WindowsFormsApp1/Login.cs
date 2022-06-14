using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
            int _port = 3306; //DB 서버 포트
            string _database = "new_schema"; //DB 이름
            string _id = "root"; //계정 아이디
            string _pw = ""; //계정 비밀번호
            string url = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", _server, _port, _database, _id, _pw);

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(url))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT count(*) FROM member where id = '" + textBox1.Text + "' and pw = '" + textBox2.Text + "'; ");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();


                    while (table.Read())
                    {
                        if(table.GetInt32(0) >= 1)
                        {
                            State ste = new State();
                            ste.id = textBox1.Text;
                            Main f2 = new Main(ref ste);
                            f2.Tag = this;
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("x");
                        }
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
