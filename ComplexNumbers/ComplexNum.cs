using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbers
{
    class ComplexNum
    {
        public int Real { get; set; }
        public int Fake { get; set; }
        public int I { get; set; }
        public char i { get; set; } = 'i';
        public string Checker { get; set; }
        public int Answer { get; set; }
        public int Answer1 { get; set; }
        public string SAnswer { get; set; }

        public ComplexNum(int real, int fake, string checker)
        {
            Real = real;
            Fake = fake;
            Checker = checker;
        }

        public int IChecker()
        {
            switch (Checker)
            {
                case "i":
                    I = 0;
                    break;
                case "i^2":
                    I = -1;
                    break;
                case "i^3":
                    I = -1;
                    break;
                case "i^4":
                    I = 1;
                    break;
            }    
            return I;
        }


        public string Sum(ComplexNum complexNum1, ComplexNum complexNum2)
        {
            if (IChecker() == 0)
            {
                Answer = complexNum1.Real + complexNum2.Real;
                Answer1 = complexNum1.Fake + complexNum2.Fake;
                SAnswer = Answer.ToString() + " + " + Answer1.ToString() + "i";
                return SAnswer;
            }
            else
            {
                Answer = (complexNum1.Real + complexNum2.Real) + (complexNum1.Fake + complexNum2.Fake) * I;
                return Answer.ToString();
            }
            
        }
        public string Subtraction(ComplexNum complexNum1, ComplexNum complexNum2)
        {
            if (IChecker() == 0)
            {
                Answer = complexNum1.Real - complexNum2.Real;
                Answer1 = complexNum1.Fake - complexNum2.Fake;
                SAnswer = Answer.ToString() + " + " + Answer1.ToString() + "i";
                return SAnswer;
            }
            else
            {
                Answer = (complexNum1.Real + complexNum2.Real) + (complexNum1.Fake + complexNum2.Fake) * I;
                SAnswer = Answer.ToString();
                return SAnswer;
            }
        }
        public string Multiplication(ComplexNum complexNum1, ComplexNum complexNum2)
        {
            if (IChecker() == 0)
            {
                int Answer1 = complexNum1.Real * complexNum2.Real;
                int Answer2 = complexNum1.Real * complexNum2.Fake + complexNum1.Fake * complexNum2.Real;
                Answer = complexNum1.Fake * complexNum2.Fake * -1;
                SAnswer = Answer1.ToString() + " + " + Answer2.ToString() + "i" + " + " + Answer.ToString();
                return SAnswer;
            }
            if (IChecker() == -1)
            {
                Answer1 = complexNum1.Real * complexNum2.Real;
                int Answer2 = complexNum1.Real * complexNum2.Fake + complexNum1.Fake * complexNum2.Real;
                Answer = complexNum1.Fake * complexNum2.Fake;
                SAnswer = Answer1.ToString() + " + " + Answer2.ToString() + "i^2" + " + " + Answer.ToString();
                return SAnswer;
            }
            return SAnswer;
        }
        public string Division(ComplexNum complexNum1, ComplexNum complexNum2)
        {
            ComplexNum nComplexNum2 = complexNum2;
            nComplexNum2.Fake = -nComplexNum2.Fake;

            string Answer1 = Multiplication(complexNum1, nComplexNum2);
            string Answer2 = Multiplication(complexNum2, nComplexNum2);
            string SAnswer = Answer1 + "/" + Answer2;
            return SAnswer;
        }
    }
}
