using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThirdLab_FirstCourse
{
    class Drob
    {
        private int Numerator;
        private int Denominator;

        public Drob()
        {
            NumeratorDrob = 1;
            DenominatorDrob = 1;
        }

        public Drob(int numer)
        {
            NumeratorDrob = numer;
            DenominatorDrob = 1;
        }

        public Drob(int numer, int denomer)
        {
            NumeratorDrob = numer;
            DenominatorDrob = denomer;
        }

        public Drob(Drob drob)
        {
            NumeratorDrob = drob.Numerator;
            Denominator = drob.Denominator;
        }

        public int NumeratorDrob { get => Numerator; set => Numerator = value != 0 ? value : 1; }
        public int DenominatorDrob { get => Denominator; set => Denominator = value != 0 ? value : 1; }


        public Drob BackFraction(Drob drob)
        {
            return drob;
        }

        public void Flip()
        {
            int temp = NumeratorDrob;
            NumeratorDrob = DenominatorDrob;
            DenominatorDrob = temp;
        }

        public Drob Flip(Drob fraction)
        {
            Drob tmpFraction = new Drob(fraction);
            tmpFraction.Flip();
            return tmpFraction;
        }

        public void PrintDrob()
        {
            Console.WriteLine(NumeratorDrob);
            Console.WriteLine("---");
            Console.WriteLine(DenominatorDrob);
        }

        override public string ToString()
        {
            return " " + NumeratorDrob + "\n---\n " + DenominatorDrob;
        }

        public static Drob operator +(Drob FirstDrob, Drob SecondDrob)
        {
            int commonDenominator = FirstDrob.DenominatorDrob * SecondDrob.DenominatorDrob;
            int commonNumerator = FirstDrob.NumeratorDrob * SecondDrob.DenominatorDrob + SecondDrob.NumeratorDrob * FirstDrob.DenominatorDrob;
            return new Drob(commonNumerator, commonDenominator);
        }

        public static Drob operator -(Drob SubFirstDrob, Drob SubSecondDrob)
        {
            int commonDenominator = SubFirstDrob.DenominatorDrob * SubSecondDrob.DenominatorDrob;
            int commonNumerator = SubFirstDrob.NumeratorDrob * SubSecondDrob.DenominatorDrob - SubSecondDrob.NumeratorDrob * SubSecondDrob.DenominatorDrob;
            return new Drob(commonNumerator, commonDenominator);
        }

        public static Drob operator *(Drob MultFirstDrob, Drob MultSecondDrob)
        {
            int commonDenominator = MultFirstDrob.DenominatorDrob * MultSecondDrob.DenominatorDrob;
            int commonNumerator = MultFirstDrob.NumeratorDrob * MultSecondDrob.NumeratorDrob;
            return new Drob(commonNumerator, commonDenominator);
        }
    }
}
