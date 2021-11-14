using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace homework_王浩奕
{
    public partial class Login : Form
    {
        SqlConnectionStringBuilder scsb;//資料庫連線物件
        string myDBConnectString = "";
        List<Accounts> accounts = new List<Accounts>();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool ifCorrect = false;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectString = scsb.ToString();
            SqlConnection con = new SqlConnection(myDBConnectString);
            con.Open();
            string strSQL1 = "select * from Account";
            SqlCommand cmd = new SqlCommand(strSQL1, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                accounts.Add(new Accounts
                {
                    StudentID=(int)reader["fk_student_id"],
                    account=reader["account"].ToString(),
                    password=reader["password"].ToString(),
                    authority=(int)reader["authority"]
                });
            }
            
            reader.Close();
            reader.Dispose();
            con.Close();
            SqlConnection con2 = new SqlConnection(myDBConnectString);
            con2.Open();
            string strSQL2 = "select * from Account join Students1 on Students1.id = Account.fk_student_id " +
                "where Account.account COLLATE Latin1_General_CS_AI = @acc and Account.password  COLLATE Latin1_General_CS_AI = @ps";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
            cmd2.Parameters.AddWithValue("@acc",tboxAccount.Text);
            cmd2.Parameters.AddWithValue("@ps", tBoxPassword.Text);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while(reader2.Read())
            {
                ifCorrect = true;
                string authLevel = "";
                switch (reader2["authority"])
                {
                    case 0:
                        authLevel = "管理員";
                        break;
                    case 1:
                        authLevel = "值日生";
                        break;
                    case 2:
                        authLevel = "一般登入身分";
                        break;
                }
                if(ifCorrect)
                {
                    MessageBox.Show("帳號密碼正確");
                    string result = "哈囉，"+reader2["name"].ToString()+"歡迎登入\n"+
                           "您現在的登入身分是"+authLevel;
                    MessageBox.Show(result);
                    GlobalVar.idn = authLevel;
                    homeWork formOrderList = new homeWork();
                    formOrderList.ShowDialog();
                } 
            }
            if(ifCorrect)
            {

            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤");
            }
            reader2.Close();
            reader2.Dispose();
            con2.Close();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxAccount.Text = "";
            tBoxPassword.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
