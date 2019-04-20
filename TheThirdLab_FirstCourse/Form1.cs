using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheThirdLab_FirstCourse
{
    public partial class Form1 : Form
    {
        Drob drob;
        Drob SecondDrob;
        Drob ThirdDrob;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateDrobResault_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Drob newDrob = (drob + SecondDrob) * (drob - ThirdDrob);
            Drob rotateAnswerDrob = newDrob.Flip(newDrob);
            richTextBox1.Text = String.Format("R = \n{0} \n\n 1/R = \n{1}", newDrob.ToString(), rotateAnswerDrob.ToString());
        }

        private void rotateDrob_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = String.Format("Rotated drob: \n\n {0} \n\n {1} \n\n {2}", drob.Flip(drob).ToString(), SecondDrob.Flip(SecondDrob).ToString()
                , ThirdDrob.Flip(ThirdDrob).ToString());
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            drob = new Drob();
            SecondDrob = new Drob();
            ThirdDrob = new Drob();

            if (String.IsNullOrWhiteSpace(textNumenator.Text) == false && String.IsNullOrWhiteSpace(textDenominator.Text) == false)
            {
                drob.NumeratorDrob = Convert.ToInt32(textNumenator.Text);
                drob.DenominatorDrob = Convert.ToInt32(textDenominator.Text);
            }
            else
            {
                Exception exception = new NullDrobException("Заполните поля корректно");
                MessageBox.Show(exception.ToString());                
            }
            if (String.IsNullOrWhiteSpace(textNumerSecDrob.Text) == false && String.IsNullOrWhiteSpace(textDenomiSecondDrob.Text) == false)
            {
                SecondDrob.NumeratorDrob = Convert.ToInt32(textNumerSecDrob.Text);
                SecondDrob.DenominatorDrob = Convert.ToInt32(textDenomiSecondDrob.Text);
            }
            else
            {
                Exception exception = new NullDrobException("Заполните поля корректно");
                MessageBox.Show(exception.ToString());
            }
            if (String.IsNullOrWhiteSpace(textThirdNumer.Text) == false && String.IsNullOrWhiteSpace(textThirdDenomin.Text) == false)
            {
                ThirdDrob.NumeratorDrob = Convert.ToInt32(textThirdNumer.Text);
                ThirdDrob.DenominatorDrob = Convert.ToInt32(textThirdDenomin.Text);
            }
            else 
            {
                Exception exception = new NullDrobException ("Заполните поля корректно");
                MessageBox.Show(exception.ToString());
            }
            richTextBox1.Text = String.Format("{0} \n\n {1} \n\n {2}",drob.ToString(),SecondDrob.ToString(),ThirdDrob.ToString());

            textNumenator.Clear();
            textDenominator.Clear();
            textNumerSecDrob.Clear();
            textDenomiSecondDrob.Clear();
            textThirdNumer.Clear();
            textThirdDenomin.Clear();

            // Страховка от Exception
            drob.NumeratorDrob = 1;
            drob.DenominatorDrob = 1;

            SecondDrob.NumeratorDrob = 1;
            SecondDrob.DenominatorDrob = 1;

            ThirdDrob.NumeratorDrob = 1;
            ThirdDrob.DenominatorDrob = 1;
        }


    }
}
