namespace AccountBook
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleMonth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_spend_list = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_regist_spend = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.asd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_spend_price = new System.Windows.Forms.TextBox();
            this.txt_earn_list = new System.Windows.Forms.TextBox();
            this.txt_earn_price = new System.Windows.Forms.TextBox();
            this.btn_delete_spend = new System.Windows.Forms.Button();
            this.btn_delete_earn = new System.Windows.Forms.Button();
            this.btn_regist_earn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalSpend = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalEarn = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalMoney = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.titleYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleMonth
            // 
            this.titleMonth.AutoSize = true;
            this.titleMonth.Font = new System.Drawing.Font("돋움", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleMonth.Location = new System.Drawing.Point(351, 21);
            this.titleMonth.Name = "titleMonth";
            this.titleMonth.Size = new System.Drawing.Size(0, 28);
            this.titleMonth.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "◀";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_spend_list
            // 
            this.txt_spend_list.Location = new System.Drawing.Point(123, 260);
            this.txt_spend_list.Multiline = true;
            this.txt_spend_list.Name = "txt_spend_list";
            this.txt_spend_list.Size = new System.Drawing.Size(104, 27);
            this.txt_spend_list.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(225, 442);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 35);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "이 달 가계부 저장";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_regist_spend
            // 
            this.btn_regist_spend.Location = new System.Drawing.Point(247, 263);
            this.btn_regist_spend.Name = "btn_regist_spend";
            this.btn_regist_spend.Size = new System.Drawing.Size(53, 23);
            this.btn_regist_spend.TabIndex = 4;
            this.btn_regist_spend.Text = "등록";
            this.btn_regist_spend.UseVisualStyleBackColor = true;
            this.btn_regist_spend.Click += new System.EventHandler(this.btn_regist_spend_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 5;
            this.button4.Text = "▶";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.asd,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 175);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // asd
            // 
            this.asd.Text = "이름";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "지출";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(323, 75);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(288, 175);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "수입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "지출 내역 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "지출 금액 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "수입 내역 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "수입 금액 :";
            // 
            // txt_spend_price
            // 
            this.txt_spend_price.Location = new System.Drawing.Point(123, 293);
            this.txt_spend_price.Multiline = true;
            this.txt_spend_price.Name = "txt_spend_price";
            this.txt_spend_price.Size = new System.Drawing.Size(104, 27);
            this.txt_spend_price.TabIndex = 12;
            // 
            // txt_earn_list
            // 
            this.txt_earn_list.Location = new System.Drawing.Point(441, 260);
            this.txt_earn_list.Multiline = true;
            this.txt_earn_list.Name = "txt_earn_list";
            this.txt_earn_list.Size = new System.Drawing.Size(104, 27);
            this.txt_earn_list.TabIndex = 13;
            // 
            // txt_earn_price
            // 
            this.txt_earn_price.Location = new System.Drawing.Point(441, 297);
            this.txt_earn_price.Multiline = true;
            this.txt_earn_price.Name = "txt_earn_price";
            this.txt_earn_price.Size = new System.Drawing.Size(104, 27);
            this.txt_earn_price.TabIndex = 14;
            // 
            // btn_delete_spend
            // 
            this.btn_delete_spend.Location = new System.Drawing.Point(247, 297);
            this.btn_delete_spend.Name = "btn_delete_spend";
            this.btn_delete_spend.Size = new System.Drawing.Size(53, 23);
            this.btn_delete_spend.TabIndex = 15;
            this.btn_delete_spend.Text = "제거";
            this.btn_delete_spend.UseVisualStyleBackColor = true;
            this.btn_delete_spend.Click += new System.EventHandler(this.btn_delete_spend_Click);
            // 
            // btn_delete_earn
            // 
            this.btn_delete_earn.Location = new System.Drawing.Point(558, 297);
            this.btn_delete_earn.Name = "btn_delete_earn";
            this.btn_delete_earn.Size = new System.Drawing.Size(53, 23);
            this.btn_delete_earn.TabIndex = 17;
            this.btn_delete_earn.Text = "제거";
            this.btn_delete_earn.UseVisualStyleBackColor = true;
            this.btn_delete_earn.Click += new System.EventHandler(this.btn_delete_earn_Click);
            // 
            // btn_regist_earn
            // 
            this.btn_regist_earn.Location = new System.Drawing.Point(558, 263);
            this.btn_regist_earn.Name = "btn_regist_earn";
            this.btn_regist_earn.Size = new System.Drawing.Size(53, 23);
            this.btn_regist_earn.TabIndex = 16;
            this.btn_regist_earn.Text = "등록";
            this.btn_regist_earn.UseVisualStyleBackColor = true;
            this.btn_regist_earn.Click += new System.EventHandler(this.btn_regist_earn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "총 지출 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "총 수입 :";
            // 
            // totalSpend
            // 
            this.totalSpend.AutoSize = true;
            this.totalSpend.Location = new System.Drawing.Point(85, 345);
            this.totalSpend.Name = "totalSpend";
            this.totalSpend.Size = new System.Drawing.Size(15, 15);
            this.totalSpend.TabIndex = 20;
            this.totalSpend.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "원";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "원";
            // 
            // totalEarn
            // 
            this.totalEarn.AutoSize = true;
            this.totalEarn.Location = new System.Drawing.Point(397, 345);
            this.totalEarn.Name = "totalEarn";
            this.totalEarn.Size = new System.Drawing.Size(15, 15);
            this.totalEarn.TabIndex = 22;
            this.totalEarn.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(381, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "원";
            // 
            // totalMoney
            // 
            this.totalMoney.AutoSize = true;
            this.totalMoney.Location = new System.Drawing.Point(310, 405);
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.Size = new System.Drawing.Size(15, 15);
            this.totalMoney.TabIndex = 25;
            this.totalMoney.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(233, 405);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 15);
            this.label.TabIndex = 24;
            this.label.Text = "총 자산 :";
            // 
            // titleYear
            // 
            this.titleYear.AutoSize = true;
            this.titleYear.Font = new System.Drawing.Font("돋움", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleYear.Location = new System.Drawing.Point(242, 23);
            this.titleYear.Name = "titleYear";
            this.titleYear.Size = new System.Drawing.Size(0, 28);
            this.titleYear.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(315, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleYear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.totalMoney);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalEarn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalSpend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_delete_earn);
            this.Controls.Add(this.btn_regist_earn);
            this.Controls.Add(this.btn_delete_spend);
            this.Controls.Add(this.txt_earn_price);
            this.Controls.Add(this.txt_earn_list);
            this.Controls.Add(this.txt_spend_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_regist_spend);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_spend_list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_spend_list;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_regist_spend;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader asd;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_spend_price;
        private System.Windows.Forms.TextBox txt_earn_list;
        private System.Windows.Forms.TextBox txt_earn_price;
        private System.Windows.Forms.Button btn_delete_spend;
        private System.Windows.Forms.Button btn_delete_earn;
        private System.Windows.Forms.Button btn_regist_earn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalSpend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalEarn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalMoney;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label titleYear;
        private System.Windows.Forms.Label label1;
    }
}

