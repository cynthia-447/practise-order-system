
namespace homework_王浩奕
{
    partial class homeWork
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.cBoxStudent = new System.Windows.Forms.ComboBox();
            this.cBoxClass = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnOepnOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cBoxRestaurant = new System.Windows.Forms.ComboBox();
            this.cBoxMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblidn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.lblClass.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblClass.Location = new System.Drawing.Point(31, 44);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 24);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "班級";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.lblStudent.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStudent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStudent.Location = new System.Drawing.Point(31, 145);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(67, 24);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "訂購人";
            // 
            // lblItem
            // 
            this.lblItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.lblItem.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblItem.Location = new System.Drawing.Point(255, 45);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(100, 25);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "品項";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.lblCount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCount.Location = new System.Drawing.Point(31, 287);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(48, 24);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "數量";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrice.Location = new System.Drawing.Point(260, 287);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "單價";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalPrice.Location = new System.Drawing.Point(501, 287);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(48, 24);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "總價";
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.textBoxCount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCount.Location = new System.Drawing.Point(30, 329);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 33);
            this.textBoxCount.TabIndex = 7;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.textBoxPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPrice.Location = new System.Drawing.Point(259, 329);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 33);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.textBoxTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(499, 329);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(100, 33);
            this.textBoxTotalPrice.TabIndex = 9;
            this.textBoxTotalPrice.TextChanged += new System.EventHandler(this.textBoxTotalPrice_TextChanged);
            // 
            // cBoxStudent
            // 
            this.cBoxStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.cBoxStudent.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxStudent.FormattingEnabled = true;
            this.cBoxStudent.Location = new System.Drawing.Point(31, 188);
            this.cBoxStudent.Name = "cBoxStudent";
            this.cBoxStudent.Size = new System.Drawing.Size(121, 32);
            this.cBoxStudent.TabIndex = 10;
            this.cBoxStudent.SelectedIndexChanged += new System.EventHandler(this.cBoxStudent_SelectedIndexChanged);
            // 
            // cBoxClass
            // 
            this.cBoxClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.cBoxClass.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxClass.FormattingEnabled = true;
            this.cBoxClass.Location = new System.Drawing.Point(29, 87);
            this.cBoxClass.Name = "cBoxClass";
            this.cBoxClass.Size = new System.Drawing.Size(121, 32);
            this.cBoxClass.TabIndex = 11;
            this.cBoxClass.SelectedIndexChanged += new System.EventHandler(this.cBoxClass_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(188)))));
            this.btnOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrder.Location = new System.Drawing.Point(29, 461);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(130, 64);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "訂購";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnOepnOrder
            // 
            this.btnOepnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(188)))));
            this.btnOepnOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOepnOrder.Location = new System.Drawing.Point(259, 461);
            this.btnOepnOrder.Name = "btnOepnOrder";
            this.btnOepnOrder.Size = new System.Drawing.Size(130, 64);
            this.btnOepnOrder.TabIndex = 13;
            this.btnOepnOrder.Text = "開啟訂單";
            this.btnOepnOrder.UseVisualStyleBackColor = false;
            this.btnOepnOrder.Click += new System.EventHandler(this.btnOepnOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(188)))));
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(505, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 64);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cBoxRestaurant
            // 
            this.cBoxRestaurant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.cBoxRestaurant.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxRestaurant.FormattingEnabled = true;
            this.cBoxRestaurant.Location = new System.Drawing.Point(310, 95);
            this.cBoxRestaurant.Name = "cBoxRestaurant";
            this.cBoxRestaurant.Size = new System.Drawing.Size(139, 32);
            this.cBoxRestaurant.TabIndex = 15;
            this.cBoxRestaurant.SelectedIndexChanged += new System.EventHandler(this.cBoxRestaurant_SelectedIndexChanged);
            // 
            // cBoxMenu
            // 
            this.cBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.cBoxMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxMenu.FormattingEnabled = true;
            this.cBoxMenu.Location = new System.Drawing.Point(309, 184);
            this.cBoxMenu.Name = "cBoxMenu";
            this.cBoxMenu.Size = new System.Drawing.Size(139, 32);
            this.cBoxMenu.TabIndex = 16;
            this.cBoxMenu.SelectedIndexChanged += new System.EventHandler(this.cBoxMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(255, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "餐廳";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(255, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "餐點";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.lblTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTime.Location = new System.Drawing.Point(363, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 24);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "訂購時間";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblidn
            // 
            this.lblidn.AutoSize = true;
            this.lblidn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(89)))), ((int)(((byte)(126)))));
            this.lblidn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblidn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblidn.Location = new System.Drawing.Point(31, 9);
            this.lblidn.Name = "lblidn";
            this.lblidn.Size = new System.Drawing.Size(86, 24);
            this.lblidn.TabIndex = 20;
            this.lblidn.Text = "登入身分";
            // 
            // homeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(701, 560);
            this.Controls.Add(this.lblidn);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxMenu);
            this.Controls.Add(this.cBoxRestaurant);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOepnOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cBoxClass);
            this.Controls.Add(this.cBoxStudent);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblClass);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "homeWork";
            this.Text = "訂便當系統";
            this.Load += new System.EventHandler(this.homeWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.ComboBox cBoxStudent;
        private System.Windows.Forms.ComboBox cBoxClass;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnOepnOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cBoxRestaurant;
        private System.Windows.Forms.ComboBox cBoxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblidn;
    }
}

