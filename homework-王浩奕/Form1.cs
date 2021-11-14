using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WindowsFormsApp1;
using System.Data.SqlClient;

namespace homework_王浩奕
{
    public partial class homeWork : Form
    {
        //List<int> priceWang = new List<int>();
        //List<int> priceJo = new List<int>();
        SqlConnectionStringBuilder scsb;//資料庫連線物件
        string myDBConnectString = "";
        int count104 = 0;
        int count105 = 0;
        int countJo = 0;
        int countWang = 0;
        public string datenow = DateTime.Now.ToString(); 
        List<student> students = new List<student>();
        List<restaurant> Restaurants = new List<restaurant>();
        
       
        int orderCount=1;
        
        
        public homeWork()
        {
            InitializeComponent();
        }

        private void homeWork_Load(object sender, EventArgs e)
        {
            
            lblidn.Text = "登入身分:"+GlobalVar.idn;
            if(GlobalVar.idn=="一般登入身分")
            {
                btnOrder.Click -= btnOrder_Click;
                textBoxCount.ReadOnly = true;
                textBoxPrice.ReadOnly = true;
                textBoxTotalPrice.ReadOnly = true;
            }
            lblTime.Text = datenow;
            
            cBoxClass.Items.Clear();
            cBoxRestaurant.Items.Clear();
            cBoxMenu.Items.Clear();
            cBoxStudent.Items.Clear();
            textBoxCount.Text = orderCount.ToString();
            
            //資料庫連線
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";//資料來源設定 @是用來避免斜線
            scsb.InitialCatalog = "mydb";//指定DB名稱
            scsb.IntegratedSecurity = true;
            //因為是用本機連線 所以可以用windows整合驗證
            //較安全 若SQL驗證沒有特別設定很容易被破解

            myDBConnectString = scsb.ToString();

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
                    className=(string)reader["class"],
                    studentName=(string)reader["name"]
                });
            }
            
            foreach (student myItem in students)
            {
                
                if (myItem.className=="104級")
                {
                    if (count104 == 0)
                    {
                        
                        cBoxClass.Items.Add(myItem.className);

                    }
                    count104 += 1;
                }else
                {
                    if(count105==0)
                    {
                        cBoxClass.Items.Add(myItem.className);

                    }
                    count105 += 1;
                }
                
                cBoxStudent.Items.Add(myItem.studentName);
                
            }
            cBoxClass.SelectedIndex = 0;
            cBoxStudent.SelectedIndex = 0;
            reader.Close();
            reader.Dispose();
            cBoxStudent.SelectedIndex = 0;
            string strSQL2 = "select * from Restaurants";
            SqlCommand cmd1 = new SqlCommand(strSQL2, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while(reader1.Read())
            {
                Restaurants.Add(new restaurant
                {
                    id=(int)reader1["id"],
                    restaurants=(string)reader1["restaurant"],
                    menu=(string)reader1["menu"],
                    price=(int)reader1["price"]
                });
                
                
            }    
            foreach(restaurant myItem in Restaurants)
            {
                if (myItem.restaurants == "王品")
                {
                    if (countWang == 0)
                    {

                        cBoxRestaurant.Items.Add(myItem.restaurants);

                    }
                    countWang += 1;
                }
                else
                {
                    if (countJo == 0)
                    {
                        cBoxRestaurant.Items.Add(myItem.restaurants);

                    }
                    countJo += 1;
                }
                string strMenuPrice = myItem.menu+myItem.price.ToString();
                cBoxMenu.Items.Add(strMenuPrice);
            }
            reader1.Close();
            reader1.Dispose();
            cBoxRestaurant.SelectedIndex = 0;
            cBoxMenu.SelectedIndex = 0;

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            
        }

        private void cBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cBoxStudent.Items.Clear();
            cBoxStudent.Text = "";
            int seledex = cBoxClass.SelectedIndex;
            foreach (student myItem in students)
            {
                if (cBoxClass.Items[seledex].ToString() == "104級" && myItem.className.ToString() == "104級")
                {
                    cBoxStudent.Items.Add(myItem.studentName);
                    cBoxStudent.SelectedIndex = 0;
                }
                else if (cBoxClass.Items[seledex].ToString() == "105級" && myItem.className.ToString() == "105級")
                {
                    cBoxStudent.Items.Add(myItem.studentName);
                    cBoxStudent.SelectedIndex = 0;
                }
                
            }
        }

        private void cBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            int countR = 0;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectString = scsb.ToString();
            SqlConnection con = new SqlConnection(myDBConnectString);
            con.Open();
            string strSQL = "select count(restaurant) as Countrestaurant from Restaurants where restaurant = '王品'; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                countR = Convert.ToInt32(reader["Countrestaurant"]);
            }
            int seleIndex = cBoxMenu.SelectedIndex;
            int seleIndex1 = cBoxRestaurant.SelectedIndex;
            if (seleIndex1 == 0)
            {
                textBoxPrice.Text = Restaurants[seleIndex].price.ToString();
                textBoxTotalPrice.Text = (orderCount * Restaurants[seleIndex].price).ToString();
            }
            else if (seleIndex1 == 1)
            {
                textBoxPrice.Text = Restaurants[seleIndex+countR].price.ToString();
                textBoxTotalPrice.Text = (orderCount * Restaurants[seleIndex + countR].price).ToString();
            }
            reader.Close();
            reader.Dispose();

        }
       
        private void cBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cBoxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxMenu.Items.Clear();
            cBoxMenu.Text = "";
            int seledex = cBoxRestaurant.SelectedIndex;
            foreach (restaurant myItem in Restaurants)
            {
                if (cBoxRestaurant.Items[seledex].ToString() == "王品" && myItem.restaurants.ToString() == "王品")
                {
                    cBoxMenu.Items.Add(myItem.menu);
                    cBoxMenu.SelectedIndex = 0;
                }
                else if (cBoxRestaurant.Items[seledex].ToString() == "冒煙的喬" && myItem.restaurants.ToString() == "冒煙的喬")
                {
                    cBoxMenu.Items.Add(myItem.menu);
                    cBoxMenu.SelectedIndex = 0;
                }

            }


        }
        
        

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            
            if (textBoxCount.Text != "")
            {
                bool ifNum = Int32.TryParse(textBoxCount.Text, out orderCount);
                if ((ifNum == true) && (orderCount >= 1))
                {
                  
                }
                else
                {
                    MessageBox.Show("輸入數量錯誤");
                    orderCount = 1;
                    textBoxCount.Text = orderCount.ToString();
                }
            }
            else
            {
                orderCount = 1;
            }
            int countR = 0;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectString = scsb.ToString();
            SqlConnection con = new SqlConnection(myDBConnectString);
            con.Open();
            string strSQL = "select count(restaurant) as Countrestaurant from Restaurants where restaurant = '王品'; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                countR = Convert.ToInt32(reader["Countrestaurant"]);
            }
            int seleIndex = cBoxMenu.SelectedIndex;
            int seleIndex1 = cBoxRestaurant.SelectedIndex;
            if (seleIndex1 == 0)
            {
                textBoxTotalPrice.Text = (orderCount * Restaurants[seleIndex].price).ToString();
            }
            else if (seleIndex1 == 1)
            {
                textBoxTotalPrice.Text = (orderCount * Restaurants[seleIndex + countR].price).ToString();
            }
            reader.Close();
            reader.Dispose();

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cBoxClass.SelectedIndex > -1 && cBoxStudent.SelectedIndex > -1 && cBoxRestaurant.SelectedIndex > -1 && cBoxMenu.SelectedIndex > -1)
            {
                scsb = new SqlConnectionStringBuilder();
                scsb.DataSource = @".";
                scsb.InitialCatalog = "mydb";
                scsb.IntegratedSecurity = true;
                myDBConnectString = scsb.ToString();
                SqlConnection con = new SqlConnection(myDBConnectString);
                con.Open();
                int seleIndex = cBoxStudent.SelectedIndex;
                int seleIndex1 = cBoxMenu.SelectedIndex;
                int studentId = 0;
                int menuId = 0;
                string strSQL = "select id from Students1 where name='" + cBoxStudent.Items[seleIndex] + "'";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studentId = Convert.ToInt32(reader["id"]);
                }
                reader.Close();
                reader.Dispose();
                string strSQL1 = "select id from Restaurants where menu='" + cBoxMenu.Items[seleIndex1] + "'";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while(reader1.Read())
                {
                    menuId = Convert.ToInt32(reader1["id"]);
                }
                reader1.Close();
                reader1.Dispose();
                string strSQLInsert = "insert into Orders values("+studentId+","+menuId+","+orderCount+")";
                SqlCommand cmd2 = new SqlCommand(strSQLInsert, con);
                int rows = cmd2.ExecuteNonQuery();
                
                MessageBox.Show(rows.ToString()+"筆資料受到影響"); 
                MessageBox.Show("已成功加入訂購單");
                con.Close();
            }
            else
            {
                MessageBox.Show("請檢查欄位是否都有填入資料");
            }
            

        }

        private void btnOepnOrder_Click(object sender, EventArgs e)
        {
            homeWork2 formOrderList = new homeWork2();
            //formOrderList.Show(); 用SHOW()點了之後會一直出現同樣的表單
            // 解決方式 獨佔開啟 在沒關閉FORM2之前不能再開啟
            formOrderList.ShowDialog();
            GlobalVar.date = datenow;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
