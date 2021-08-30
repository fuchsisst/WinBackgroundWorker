using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace WinAsynchMethod
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSumm(int a, int b);
   
        public Form1()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
               Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.Language);
            }

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("de-De"),
                System.Globalization.CultureInfo.GetCultureInfo("ru-RU")
            };
            comboBox1.DisplayMember = "NatibeName";
            comboBox1.ValueMember = "Name";
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                comboBox1.SelectedValue = Properties.Settings.Default.Language;
            }
        }
        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           
                int a, b; try
                {
                   
                    a = Int32.Parse(txbA.Text); 
                    b = Int32.Parse(txbB.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                    txbA.Text = txbB.Text = ""; return;
                }
                AsyncSumm summdelegate = new AsyncSumm(Summ); AsyncCallback cb = new AsyncCallback(CallBackMethod);
                summdelegate.BeginInvoke(a, b, cb, summdelegate);
            
        }
        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState; str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar)); 
            MessageBox.Show(str, "Результат операции");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        private void viewDocumetationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Language = comboBox1.SelectedValue.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
