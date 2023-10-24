using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using HesapMakinesi.App_Code;

namespace HesapMakinesi
{
    public partial class Arayuz : System.Web.UI.Page
    {
       
        int sayi1,sayi2;
        Calculator calculator;
        String ifade = "";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void init()
        {
            sayi1 = int.Parse(TextBox1.Text.ToString());
            sayi2 = int.Parse(TextBox2.Text.ToString());
            calculator = new Calculator();

        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Topla butonu
            init();
            //TextBox3.Text = calculator.topla(sayi1,sayi2).ToString();
            ifade = $"{sayi1} + {sayi2}";

            TextBox4.Text = ifade;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //Çıkar butonu
            init();
            //TextBox3.Text = calculator.cikar(sayi1 ,sayi2).ToString();
            ifade = $"{sayi1} - {sayi2}";
            TextBox4.Text = ifade;
        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            // Çarp butonu
            init();
            ifade = $"{sayi1} * {sayi2}";
            TextBox4.Text = ifade;
        }

        

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Böl butonu
            init();
            ifade = $"{sayi1} / {sayi2}";
            TextBox4.Text = ifade;
        }

        

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Temizle butonu
            init();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            init();
            //hesapla butonu
            //TextBox3.Text = calculator.ifadeHesapla(TextBox4.Text.ToString()).ToString();
        }

    }
}