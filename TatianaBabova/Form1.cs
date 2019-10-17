using System;
using System.Windows.Forms;

namespace TatianaBabova
{
    public partial class Form1 : Form
    {
        
        public Form1 ()
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
           var  x = textBox1.Text;
           var y = textBox2.Text;

            

          
                if (IfnumberIfexist(x) && IfnumberIfexist(y))
                {
                        double x1 = Convert.ToDouble(x);
                        double y1 = Convert.ToDouble(y);
                    textBox4.Text = Convert .ToString( x1 + 2);
                    textBox3.Text = Convert.ToString (y1 - 2);
                    if (x1<y1)
                    {
                        
                        textBox5.Text = Convert.ToString(Summa(Convert.ToDouble(x), Convert.ToDouble(y)));
                    }
                    else
                    {
                        MessageBox.Show (@"Цифра из первой ячейки должна быть меньше, чем во второй");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
         
        }


        private double Summa(double x,double y)
        {
           
                var s = 0.0d;
                while (x < y)
                {

                    s = s + (1/((x + 2)*x));
                    x = x + 2;
                    
                }
                return s;
            
        }


        private static bool IfnumberIfexist(string a)
        {
            if (!string.IsNullOrEmpty(a))
            {
                double number;
                var result = Double.TryParse(a, out number);
                if (result)
                {
                    return true;
                }
                MessageBox.Show (@"Вы ввели не цифру,Пожалуйста введите цифру ");
                return false;
               
            }
            else
            {
                MessageBox.Show (@"Строка пустая.Пожалуйста введите цифру");
                return false;
            }

        }


        //Events
        private void OnlyNumber ( object sender, KeyPressEventArgs e )
        {

            var abc = (TextBox) sender;
            if (abc.Text.IndexOf ('0') == 0)
            {
                abc.Text = "";

            }
           if (!System.Text.RegularExpressions.Regex.Match(e.KeyChar.ToString(), @"[0-9]").Success)
             {
                 if (e.KeyChar != (char) Keys.Back)
                 {
                     e.Handled = true;
                 }
              
             }




        }

        private void Form1_Load ( object sender, EventArgs e )
        {
            toolTip1.SetToolTip(label7, "Знак 'Умножыть' ");
            toolTip1.SetToolTip (label5, "Знак 'Умножыть' ");
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            MessageBox.Show(@" Function Summa(double x,double y)
        {
           
                var s = 0.0d;
                while (x < y)
                {

                    s = s + (1/((x + 2)*x));
                    x = x + 2;
                    
                }
                return s;
            
        }
          ");
        }
        
    }
}
