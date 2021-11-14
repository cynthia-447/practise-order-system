using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using System.Collections;//arraylist命名空間
using System.Data.SqlClient;

namespace homework_王浩奕
{
    public partial class homeWork2 : Form
    {
        
        SqlConnectionStringBuilder scsb;//資料庫連線物件
        string myDBConnectString = "";
        int count104 = 0;
        int count105 = 0;
        List<Orders> orders = new List<Orders>();
        List<student> students = new List<student>();
        List<restaurant> Restaurants = new List<restaurant>(); 
        public homeWork2()
        {
            InitializeComponent();
        }

        private void homeWork2_Load(object sender, EventArgs e)
        {
            lblidn.Text = "登入身分:" + GlobalVar.idn;
            if (GlobalVar.idn == "一般登入身分")
            {
                btnClear.Click -= btnClear_Click;
            }
            listBoxItem.Items.Clear();
            //資料庫連線
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectString = scsb.ToString();
            lblTime.Text = GlobalVar.date;            
            cBoxClass.Items.Clear();
            cBoxClass.Text = ""; 
            listBoxItem.Text = "請先選擇班級";
            SqlConnection con = new SqlConnection(myDBConnectString);
            con.Open();
            string strSQL1 = "select * from Students1";
            SqlCommand cmd = new SqlCommand(strSQL1, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                students.Add(new student
                {
                    id = (int)reader["id"],
                    className = (string)reader["class"],
                    studentName = (string)reader["name"]
                });
            }
            foreach(student myItem in students)
            {
                if (myItem.className == "104級")
                {
                    if (count104 == 0)
                    {

                        cBoxClass.Items.Add(myItem.className);

                    }
                    count104 += 1;
                }
                else
                {
                    if (count105 == 0)
                    {
                        cBoxClass.Items.Add(myItem.className);

                    }
                    count105 += 1;
                }
            }
            cBoxClass.SelectedIndex = 0;
            lblClassOrderCount.Text = "104級統計列表";
            reader.Close();
            reader.Dispose();
            string strSQL2 = "select * from Restaurants";
            SqlCommand cmd1 = new SqlCommand(strSQL2, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                Restaurants.Add(new restaurant
                {
                    id = (int)reader1["id"],
                    restaurants = (string)reader1["restaurant"],
                    menu = (string)reader1["menu"],
                    price = (int)reader1["price"]
                });
            }
            reader1.Close();
            reader1.Dispose();
            string strSQL3 = "select * from Orders";
            SqlCommand cmd2 = new SqlCommand(strSQL3, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while(reader2.Read())
            {
                orders.Add(new Orders
                {
                    studentID=(int)reader2["fk_student_id"],
                    restaurantID=(int)reader2["fk_restaurant_id"],
                    orderCount=(int)reader2["count"]
                });
            }
            reader2.Close();
            reader2.Dispose();
            con.Close();
        }

        
        
        private void cBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            

        }

        

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblClassOrderCount_Click(object sender, EventArgs e)
        {

        }

        

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            string strOrder = "";
            string strOrder1 = "";
            int seleIndex = cBoxClass.SelectedIndex;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectString = scsb.ToString();
            SqlConnection con = new SqlConnection(myDBConnectString);
            con.Open();
            string strSQL1 = "select * from Orders join Students1 on Students1.id = fk_student_id join Restaurants on Restaurants.id = fk_restaurant_id;";
            SqlCommand cmd = new SqlCommand(strSQL1, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["class"].ToString() == "104級"&&seleIndex==0)
                {
                    int count104 = Convert.ToInt32(reader["count"]);
                    int price104 = Convert.ToInt32(reader["price"]);
                    int totalPrice104 = count104 * price104;
                    //int totalPriceText104 = 0;
                    strOrder = String.Format("id是:"+reader["id"] +" "+ reader["name"] + "訂了" + reader["restaurant"] + reader["menu"] + " " + reader["count"] + "個 共" + totalPrice104 + "元");
                    listBoxItem.Items.Add(strOrder);
                    lblClassOrderCount.Text = "104級統計列表";
                    //totalPriceText104 += totalPrice104;
                    //lblTotalPrice.Text = totalPriceText104.ToString();

                }
                else if (reader["class"].ToString() == "105級"&&seleIndex==1)
                {
                    int count105 = Convert.ToInt32(reader["count"]);
                    int price105 = Convert.ToInt32(reader["price"]);
                    int totalPrice105 = count105 * price105;
                    //int totalPriceText105 = 0;

                    strOrder1 = String.Format("id是:"+reader["id"] + " " + reader["name"] + "訂了" + reader["restaurant"] + reader["menu"] + " " + reader["count"] + "個 共" + totalPrice105 + "元");
                    listBoxItem.Items.Add(strOrder1);
                    lblClassOrderCount.Text = "105級統計列表";
                    //totalPriceText105 += totalPrice105;
                    //lblTotalPrice.Text = totalPriceText105.ToString();
                }
            }
            reader.Close();
            reader.Dispose();
            string strSQL2 = "select sum(Restaurants.price*Orders.count) as countClass104 from Orders join Students1 on Students1.id = fk_student_id and Students1.class='104級'join Restaurants on Restaurants.id=fk_restaurant_id;";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while(reader2.Read())
            {   if (seleIndex ==0)
                {
                    lblTotalPrice.Text = "總價是: " + reader2["countClass104"].ToString();
                }                
            }
            reader2.Close();
            reader2.Dispose();
            string strSQL3 = "select sum(Restaurants.price*Orders.count) as countClass105 from Orders join Students1 on Students1.id = fk_student_id and Students1.class='105級' join Restaurants on Restaurants.id=fk_restaurant_id;";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                if (seleIndex == 1)
                {
                    lblTotalPrice.Text = "總價是: "+reader3["countClass105"].ToString();
                }
            }
            reader3.Close();
            reader3.Dispose();
            con.Close();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int lboxCount = listBoxItem.Items.Count;
            if(lboxCount>0)
            {
                scsb = new SqlConnectionStringBuilder();
                scsb.DataSource = @".";
                scsb.InitialCatalog = "mydb";
                scsb.IntegratedSecurity = true;
                myDBConnectString = scsb.ToString();
                SqlConnection con = new SqlConnection(myDBConnectString);
                con.Open();
                listBoxItem.Items.Clear();
                lblTotalPrice.Text = "";
                string strSQL1 = "truncate table Orders";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                int rows = cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("共"+ rows.ToString() + "筆資料受到影響" );
                
            }
            else
            {
                MessageBox.Show("查無任何訂單");
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblidn_Click(object sender, EventArgs e)
        {

        }
    }
}
