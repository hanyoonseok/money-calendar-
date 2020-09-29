using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccountBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime day = DateTime.Now;
            titleYear.Text = day.Year.ToString();
            titleMonth.Text = day.Month.ToString();
            listView1.Items.Clear();
            listView2.Items.Clear();
            totalSpend.Text = "0";
            totalEarn.Text = "0";
            totalMoney.Text = "0";
            if (File.Exists("Data\\" + titleYear.Text + titleMonth.Text + ".csv") == true)
            {
                string[] list = File.ReadAllLines("Data\\" + titleYear.Text + titleMonth.Text + ".csv", Encoding.UTF8);
                for (int i = 1; i < list.Length; i++)
                {
                    string s = list[i]; // 한 줄에대한 전체 내용
                    string[] ss = s.Split(',');
                    if (ss[0].Equals("1")) //지출 관련 내용일 때
                    {
                        string[] detail1 = s.Split(',');
                        ListViewItem item = listView1.Items.Add(detail1[1]);
                        item.SubItems.Add(detail1[2]);
                        totalSpend.Text = detail1[3];
                        totalMoney.Text = detail1[4];
                    }
                    else //수입 관련 내용일 때
                    {
                        string[] detail2 = s.Split(',');
                        ListViewItem item = listView2.Items.Add(detail2[1]);
                        item.SubItems.Add(detail2[2]);
                        totalEarn.Text = detail2[3];
                    }
                }

            }
        }

        private void btn_regist_spend_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txt_spend_list.Text);
            item.SubItems.Add(txt_spend_price.Text);

            int total = Convert.ToInt32(totalSpend.Text); // 총 지출
            int New = Convert.ToInt32(txt_spend_price.Text); // 새 지출
            int earn = Convert.ToInt32(totalEarn.Text);

            total += New;
            totalSpend.Text = total.ToString();

            total *= -1;
            total += earn;
            totalMoney.Text = total.ToString();
            listView1.Items.Add(item);
            listView1.EndUpdate();
            txt_spend_list.Text = "";
            txt_spend_price.Text = "";

        }

        private void btn_regist_earn_Click(object sender, EventArgs e)
        {
            ListViewItem item= new ListViewItem(txt_earn_list.Text);
            item.SubItems.Add(txt_earn_price.Text);

            int total = Convert.ToInt32(totalEarn.Text);
            int New = Convert.ToInt32(txt_earn_price.Text);
            int spend = Convert.ToInt32(totalSpend.Text);

            total += New;
            totalEarn.Text = total.ToString();

            total += spend*(-1);
            totalMoney.Text = total.ToString();
            listView2.Items.Add(item);
            listView2.EndUpdate();
            txt_earn_list.Text = "";
            txt_earn_price.Text = "";
        }

        private void btn_delete_spend_Click(object sender, EventArgs e)
        {
            int idx = listView1.FocusedItem.Index;
            ListViewItem item = listView1.SelectedItems[0];
            int money = Convert.ToInt32(item.SubItems[1].Text);
            int spend = Convert.ToInt32(totalSpend.Text);
            int total = Convert.ToInt32(totalMoney.Text);

            spend -= money;
            total += money;

            totalSpend.Text = spend.ToString();
            totalMoney.Text = total.ToString();
            listView1.Items.RemoveAt(idx);
        }

        private void btn_delete_earn_Click(object sender, EventArgs e)
        {
            int idx = listView2.FocusedItem.Index;
            ListViewItem item = listView2.SelectedItems[0];
            int money = Convert.ToInt32(item.SubItems[1].Text);
            int earn = Convert.ToInt32(totalEarn.Text);
            int total = Convert.ToInt32(totalMoney.Text);

            earn -= money;
            total -= money;

            totalEarn.Text = earn.ToString();
            totalMoney.Text = total.ToString();
            listView2.Items.RemoveAt(idx);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Data";
            string fileName = filePath + "\\"+ titleYear.Text+titleMonth.Text + ".csv";
            string list="";

            if (Directory.Exists("Data") == false) // 만약 저장하려는 폴더가 없으면
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Data");
                int a1 = listView1.Items.Count;
                int a2 = listView2.Items.Count;
                for (int i = 0; i < a1; i++)
                {
                    ListViewItem item = listView1.Items[i];
                    string name1 = item.SubItems[0].Text;
                    string spend = item.SubItems[1].Text;
                    string totalS = totalSpend.Text;
                    string totalM = totalMoney.Text;

                    list += "\r\n" + "1" + "," + name1 + "," + spend + "," + totalS + "," + totalM;
                }
                for (int j = 0; j < a2; j++)
                {
                    ListViewItem item = listView2.Items[j];
                    string name2 = item.SubItems[0].Text;
                    string earn = item.SubItems[1].Text;
                    string totalE = totalEarn.Text;
                    list += "\r\n" + "2" + "," + name2 + "," + earn + "," + totalE;
                }

                File.WriteAllText(fileName, list, System.Text.Encoding.UTF8);
                MessageBox.Show("파일이 저장되었습니다!");
            }
            else // 폴더 있으면
            {
                int a1 = listView1.Items.Count;
                int a2 = listView2.Items.Count;
                for (int i = 0; i < a1; i++)
                {
                    ListViewItem item = listView1.Items[i];
                    string name1 = item.SubItems[0].Text;
                    string spend = item.SubItems[1].Text;
                    string totalS = totalSpend.Text;
                    string totalM = totalMoney.Text;

                    list += "\r\n" + "1" + "," + name1 + "," + spend + "," + totalS + "," + totalM;
                }
                for (int j = 0; j < a2; j++)
                {
                    ListViewItem item = listView2.Items[j];
                    string name2 = item.SubItems[0].Text;
                    string earn = item.SubItems[1].Text;
                    string totalE = totalEarn.Text;
                    list += "\r\n" + "2" + "," + name2 + "," + earn + "," + totalE;
                }

                File.WriteAllText(fileName, list, System.Text.Encoding.UTF8);
                MessageBox.Show("파일이 저장되었습니다!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e) //이전 달
        {
            //리스트 뷰 비움
            listView1.Items.Clear();
            listView2.Items.Clear();
            totalSpend.Text = "0";
            totalEarn.Text = "0";
            totalMoney.Text = "0";

            //타이틀 월 변경
            int prevMonth = Convert.ToInt32(titleMonth.Text);
            prevMonth--;
            if(prevMonth==0)
            {
                int newY = Convert.ToInt32(titleYear.Text);
                newY--;
                prevMonth = 12;
                titleYear.Text = newY.ToString();
            }
            titleMonth.Text = prevMonth.ToString();

            //파일있으면 불러오기
            if (File.Exists("Data\\" + titleYear.Text + titleMonth.Text + ".csv") == true)
            {
                string[] list = File.ReadAllLines("Data\\" + titleYear.Text + titleMonth.Text + ".csv", Encoding.UTF8);
                for(int i=1; i<list.Length; i++)
                {
                    string s = list[i]; // 한 줄에대한 전체 내용
                    string[] ss = s.Split(',');
                    if (ss[0].Equals("1")) //지출 관련 내용일 때
                    {
                        string[] detail1 = s.Split(',');
                        ListViewItem item = listView1.Items.Add(detail1[1]);
                        item.SubItems.Add(detail1[2]);
                        totalSpend.Text = detail1[3];
                        totalMoney.Text = detail1[4];
                    }
                    else //수입 관련 내용일 때
                    {
                        string[] detail2 = s.Split(',');
                        ListViewItem item = listView2.Items.Add(detail2[1]);
                        item.SubItems.Add(detail2[2]);
                        totalEarn.Text = detail2[3];
                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e) // 다음 달
        {
            //리스트 뷰 비움
            listView1.Items.Clear();
            listView2.Items.Clear();
            totalSpend.Text = "0";
            totalEarn.Text = "0";
            totalMoney.Text = "0";

            //타이틀 월 변경
            int prevMonth = Convert.ToInt32(titleMonth.Text);
            prevMonth++;
            if (prevMonth == 13)
            {
                int newY = Convert.ToInt32(titleYear.Text);
                newY++;
                prevMonth = 1;
                titleYear.Text = newY.ToString();
            }
            titleMonth.Text = prevMonth.ToString();

            //파일있으면 불러오기
            if (File.Exists("Data\\" + titleYear.Text + titleMonth.Text + ".csv") == true)
            {
                string[] list = File.ReadAllLines("Data\\" + titleYear.Text + titleMonth.Text + ".csv", Encoding.UTF8);
                for (int i = 1; i < list.Length; i++)
                {
                    string s = list[i]; // 한 줄에대한 전체 내용
                    string[] ss = s.Split(',');
                    if (ss[0].Equals("1")) //지출 관련 내용일 때
                    {
                        string[] detail1 = s.Split(',');
                        ListViewItem item = listView1.Items.Add(detail1[1]);
                        item.SubItems.Add(detail1[2]);
                        totalSpend.Text = detail1[3];
                        totalMoney.Text = detail1[4];
                    }
                    else //수입 관련 내용일 때
                    {
                        string[] detail2 = s.Split(',');
                        ListViewItem item = listView2.Items.Add(detail2[1]);
                        item.SubItems.Add(detail2[2]);
                        totalEarn.Text = detail2[3];
                    }
                }
            }
        }
    }
}
