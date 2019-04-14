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

        int variableR = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateDrobResault_Click(object sender, EventArgs e)
        {
            Drob newDrob = (drob + SecondDrob) * (drob - ThirdDrob);
            newDrob.ToString();
        }

        private void rotateDrob_Click(object sender, EventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            drob = new Drob();
            SecondDrob = new Drob();
            ThirdDrob = new Drob();


            drob.NumeratorDrob = Convert.ToInt32(textNumenator.Text);
            drob.DenominatorDrob = Convert.ToInt32(textDenominator.Text);

            SecondDrob.NumeratorDrob = Convert.ToInt32(textNumerSecDrob.Text);
            SecondDrob.DenominatorDrob = Convert.ToInt32(textDenomiSecondDrob.Text);

            ThirdDrob.NumeratorDrob = Convert.ToInt32(textThirdNumer.Text);
            ThirdDrob.DenominatorDrob = Convert.ToInt32(textThirdDenomin.Text);

            richTextBox1.Text = String.Format("{0} \n\n {1} \n\n {2}",drob.ToString(),SecondDrob.ToString(),ThirdDrob.ToString());

            textNumenator.Clear();
            textDenominator.Clear();
            textNumerSecDrob.Clear();
            textDenomiSecondDrob.Clear();
            textThirdNumer.Clear();
            textThirdDenomin.Clear();
        }
    }
}
