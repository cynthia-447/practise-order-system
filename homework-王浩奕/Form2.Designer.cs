
namespace homework_王浩奕
{
    partial class homeWork2
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
            this.cBoxClass = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblClassOrderCount = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblidn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBoxClass
            // 
            this.cBoxClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(203)))), ((int)(((byte)(171)))));
            this.cBoxClass.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxClass.FormattingEnabled = true;
            this.cBoxClass.Location = new System.Drawing.Point(52, 36);
            this.cBoxClass.Name = "cBoxClass";
            this.cBoxClass.Size = new System.Drawing.Size(121, 32);
            this.cBoxClass.TabIndex = 0;
            this.cBoxClass.Text = "104級";
            this.cBoxClass.SelectedIndexChanged += new System.EventHandler(this.cBoxClass_SelectedIndexChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.lblTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTime.Location = new System.Drawing.Point(375, 39);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 24);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "訂購時間";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // listBoxItem
            // 
            this.listBoxItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(203)))), ((int)(((byte)(171)))));
            this.listBoxItem.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 24;
            this.listBoxItem.Location = new System.Drawing.Point(52, 89);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(637, 196);
            this.listBoxItem.TabIndex = 3;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalPrice.Location = new System.Drawing.Point(448, 298);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(54, 27);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "總價";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // lblClassOrderCount
            // 
            this.lblClassOrderCount.AutoSize = true;
            this.lblClassOrderCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.lblClassOrderCount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassOrderCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblClassOrderCount.Location = new System.Drawing.Point(51, 298);
            this.lblClassOrderCount.Name = "lblClassOrderCount";
            this.lblClassOrderCount.Size = new System.Drawing.Size(156, 27);
            this.lblClassOrderCount.TabIndex = 6;
            this.lblClassOrderCount.Text = "XXX級統計列表";
            this.lblClassOrderCount.Click += new System.EventHandler(this.lblClassOrderCount_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(56, 462);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 77);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "訂購單查詢";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(294, 462);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 77);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空訂單";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(551, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 77);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblidn
            // 
            this.lblidn.AutoSize = true;
            this.lblidn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))));
            this.lblidn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblidn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblidn.Location = new System.Drawing.Point(52, 381);
            this.lblidn.Name = "lblidn";
            this.lblidn.Size = new System.Drawing.Size(86, 24);
            this.lblidn.TabIndex = 10;
            this.lblidn.Text = "登入身分";
            this.lblidn.Click += new System.EventHandler(this.lblidn_Click);
            // 
            // homeWork2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(701, 560);
            this.Controls.Add(this.lblidn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblClassOrderCount);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cBoxClass);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "homeWork2";
            this.Text = "訂便當系統";
            this.Load += new System.EventHandler(this.homeWork2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxClass;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblClassOrderCount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblidn;
    }
}