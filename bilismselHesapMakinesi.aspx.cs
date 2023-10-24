using HesapMakinesi.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HesapMakinesi
{
    public partial class bilismselHesapMakinesi : System.Web.UI.Page
    {
        Calculator calculator = new Calculator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void yaz(String ifade) {
            //TODO: sender ile bilgi alma işlemini burada yapılabilir boşluklu olup olmadığı ise if kontrol edilebilir

            TextBox1.Text += $"{ifade}";
        }
        
        protected void forNumberButton(object sender, EventArgs e) {
            //numara butonlarına (0,1,2,3,4,5,6,7,8,9) basılınca çalışacak fonksiyon
            
            String s = (sender as Button).Text;
            yaz(s);
        }
        protected void forBasicOperationButton(object sender, EventArgs e)
        {
            //işlem butonlarına(+,-,*,/) basınca çalışacak fonksiyon 
            String s = (sender as Button).Text;
            yaz($" {s} ");
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            //Temizle Butonu
            TextBox1.Text = "";
        }

        protected void Button26_Click(object sender, EventArgs e)
        {

            //hesapla butonu
            string ifade = TextBox1.Text.ToString();
            //string ifade = "3 + 4 + 5 + 6";
            //string ifade = "3 + 4";
            //string ifade = " ";
            //ifade = calculator.nKadarkarakterSil(ifade, 4,"7");
            // Response.Write(ifade);
            //Response.Write(calculator.ifadeHesaplaYeni(ifade));
            //Response.Write(calculator.test());
            //Response.Write(calculator.ifadeHesaplaEski(ifade));
            //Response.Write(calculator.ifadeHesaplaChatgbt(ifade));
            Response.Write(calculator.ifadeHesaplaChatgbt2(ifade));

            Response.Write("<br>");
            Response.Write(ifade);


        }
    }
}