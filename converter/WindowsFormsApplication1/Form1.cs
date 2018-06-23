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
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = USD_price_tb;
            currency_cb.SelectedIndex = 0;
            converted_price_tb.ReadOnly = true;
            USD_price_tb.Text = "0";
               
        }

        private void Convert_btn_Click(object sender, EventArgs e)
        {
            double converted = 0;
            if (USD_price_tb.Text =="")
            { MessageBox.Show("Not allowed the empty field!","Error");
                USD_price_tb.Text = "0";
            }
            string curr = "";
            
            if (currency_cb.SelectedIndex == 0)
            { curr = Converted_Currency("http://free.currencyconverterapi.com/api/v5/convert?q=USD_UAH&compact=ultra"); }
            else
                if (currency_cb.SelectedIndex == 1)
            { curr = Converted_Currency("https://free.currencyconverterapi.com/api/v5/convert?q=USD_EUR&compact=ultra"); }
            else
                if (currency_cb.SelectedIndex == 2)
            { curr = Converted_Currency("https://free.currencyconverterapi.com/api/v5/convert?q=USD_GBP&compact=ultra"); }
            if (curr != " ")
            {

                double price = Convert.ToDouble(USD_price_tb.Text);
                string[] currency_resp = curr.Split(new char[] { ':', '.', '}' });
                string c = currency_resp[1] + "," + currency_resp[2];

                double currency = Convert.ToDouble(c);

                converted = price * currency;
            }
            converted_price_tb.Text = Convert.ToString(converted);
        }
        public string Converted_Currency(string URL)
        {
            string curr = " ";
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(URL);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (StreamReader stream = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    curr = stream.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                MessageBox.Show("This program is expected to throw WebException on successful run." +
                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    MessageBox.Show("Status Code : "+ ((HttpWebResponse)e.Response).StatusCode);
                    MessageBox.Show("Status Description : "+((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return curr;
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            USD_price_tb.Clear();
            converted_price_tb.Clear();
        }

        private void USD_price_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
    }
}
