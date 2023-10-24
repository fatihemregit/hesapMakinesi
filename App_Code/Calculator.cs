using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HesapMakinesi.App_Code
{
    public class Calculator
    {
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public double bol(int sayi1, int sayi2)
        {
            return (double)sayi1 / sayi2;
        }
        public string ifadeHesaplaYeni(String ifade)
        {
            //değişken tanımlamaları
            string pleaseReturnMe = "";
            ArrayList ifadeArray = new ArrayList();
            //"ifade" değişkenini boşluklara göre parçalara bölelim
            string[] ifadewithspace = ifade.Split(' ');
            int index = 0;
            //boşluklara göre bölünmüş değişkeni arraylist e atıyoruz
            foreach (string s in ifadewithspace)
            {
                ifadeArray.Add(s);
            }
            //gerekli işlemler
            foreach (string ix in ifadeArray)
            {

                index = ifadeArray.IndexOf(ix);
                double sonuc = 0;
                double s1, s2;
                //index sıfır ise çıkarma işlemi hata verir o yüzden  bunu kontrol edelim
                index = (index == 0) ? 1: index;

                if (ix.Equals(" ")) {
                    pleaseReturnMe += "d";
                    
                    pleaseReturnMe += "ifdesin";
                    s1 = Convert.ToDouble(ifade[index - 1].ToString());
                    //dizi dizin sınırları dışındaydı hatası vermesin diye bu kodları yazıyoruz
                    if ((index + 3) >= ifadeArray.Count)
                    {

                        s2 = 0;

                    }
                    else
                    {
                        s2 = Convert.ToDouble(ifade[index + 3].ToString());
                    }

                    sonuc = basitIsareteGoreIslemYap($"{ifade[index + 1] }", s1, s2);
                    ifade = nKadarkarakterSil(ifade, 4, sonuc.ToString());
                    pleaseReturnMe = ifade;
                    
                }
                else if (ix.Equals("")) {
                    break;
                }
            }
            return pleaseReturnMe;

            
        }

        public string ifadeHesaplaEski(String ifade)
        {
            
            bool whilestate = true;
            bool isNumber;
            int counter = 0;
            string pleaseReturnMe = "";

            foreach (char s in ifade)
            {
                int index = ifade.IndexOf(s);
                double sonuc = 0;
                double s1, s2;
                index = (index == 0) ? 1 : index;




                if (s.Equals(' '))
                {

                    //boşluk değeri
                    //pleaseReturnMe += "b";
                    //değeri hesaplama
                    //dizi dizin sınırları dışındaydı hatası
                    if (index -1 <= 0) {
                        index = 1;
                    }
                    s1 = Convert.ToDouble(ifade[index - 1].ToString());
                    //dizi dizin sınırları dışındaydı hatası vermesin diye bu kodları yazıyoruz
                    if ((index + 3) >= ifade.Length)
                    {

                        s2 = 0;

                    }
                    else
                    {
                        s2 = Convert.ToDouble(ifade[index + 3].ToString());
                    }
                    sonuc = basitIsareteGoreIslemYap(ifade[index + 1], s1, s2);
                    //değeri hesaplayıp hesaplanan sayıları silme
                    ifade = nKadarkarakterSil(ifade, 4, sonuc.ToString());
                }
                else if (s.Equals('\0'))
                {
                    //ifadenin sonuna geldik
                    //işlem yapılacak değer yok o yüzden döngüden çıkıyoruz
                    //pleaseReturnMe += "bitti";
                    break;
                }
                //else
                //{
                //    //ifadenin sayı olup olmadığını öğrenme
                //    isNumber = isİtNumber(s); 
                //    if(isNumber)
                //    {
                //        //ifade sayı ise çalışacak yer
                //        pleaseReturnMe += "s";
                //    }
                //    else
                //    {
                //        //ifade sayı değil ise çalışacak yer
                //        pleaseReturnMe += "i";
                //    }

                //}
                //iptal için ctrlk+ctrlu
            }
            /*
             + => toplama
             - => çıkarma
             * => çarpma
             / => bölme
             */
            return ifade;
        }



        public string nKadarkarakterSil(string ifade, int n, string writeNumber)
        {
            //verilen n e kadar index i olan karakterleri siler
            // önerim 4 karakter silmen
            /*
             Ör : smkfsjnfsdnf => fsjnfsdnf
             */
            ifade = "" + writeNumber + ifade.Substring(n + 1);

            return ifade;
        }
        public bool isİtNumber(char num)
        {
            bool pleaseReturn = true;

            try
            {
                int converter = int.Parse(num.ToString());
            }
            catch (Exception e)
            {
                pleaseReturn = false;
            }
            return pleaseReturn;
        }
        private double basitIsareteGoreIslemYap(string isaret, double sayi1, double sayi2)
        {
            double returnMe = 0;
            switch (isaret)
            {
                case "+":
                    returnMe = sayi1 + sayi2;
                    break;
                case "-":
                    returnMe = sayi1 - sayi2;
                    break;
                case "*":
                    returnMe = sayi1 * sayi2;
                    break;
                case "/":
                    returnMe = sayi1 / sayi2;
                    break;

            }

            return returnMe;
        }

        private double basitIsareteGoreIslemYap(char isaret, double sayi1, double sayi2)
        {
            double returnMe = 0;
            switch (isaret)
            {
                case '+':
                    returnMe = sayi1 + sayi2;
                    break;
                case '-':
                    returnMe = sayi1 - sayi2;
                    break;
                case '*':
                    returnMe = sayi1 * sayi2;
                    break;
                case '/':
                    returnMe = sayi1 / sayi2;
                    break;

            }

            return returnMe;
        }

        public void test()
        {
            ArrayList testArray = new ArrayList();
            testArray.Add(" ");
            testArray.Add("g");
            testArray.Add("f");
            foreach (string t in testArray)
            {
                if(t.Equals(" "))
                {
                   
                }

            }
        }
    }
}