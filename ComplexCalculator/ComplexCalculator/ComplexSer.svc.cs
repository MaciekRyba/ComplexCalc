using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ComplexCalculator
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie, usłudze i pliku konfiguracji.
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik Service1.svc lub Service1.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    public class ComplexCalculatorService : ComplexServices
    {
        public string Add(ComplexType FirstComplex, ComplexType SecondComplex)
        {
            string addResult = add_method(FirstComplex.RealValueOperation, SecondComplex.RealValueOperation, FirstComplex.ImaginryValueOperation,SecondComplex.ImaginryValueOperation);
            return addResult;
        }

        public string Division(ComplexType FirstComplex, ComplexType SecondComplex)
        {
            string divisionResult = division_method(FirstComplex.RealValueOperation, SecondComplex.RealValueOperation, FirstComplex.ImaginryValueOperation, SecondComplex.ImaginryValueOperation);
            return divisionResult;
        }

        public string Division(double real1, double imaginary1, double real2, double imaginary2)
        {
            string divisionResult = division_method(real1, real2, imaginary1, imaginary2);
            return divisionResult;
        }

        public string Multiply(ComplexType FirstComplex, ComplexType SecondComplex)
        {
            string multiplyResult = multiply_method(FirstComplex.RealValueOperation, SecondComplex.RealValueOperation, FirstComplex.ImaginryValueOperation, SecondComplex.ImaginryValueOperation);
            return multiplyResult;
        }

        public string Multiply(double real1, double imaginary1, double real2, double imaginary2)
        {

            string multiplyResult = multiply_method(real1, real2, imaginary1, imaginary2);
            return multiplyResult;
        }

        public string Subtract(ComplexType FirstComplex, ComplexType SecondComplex)
        {
            string subtractResult = subtract_method(FirstComplex.RealValueOperation, SecondComplex.RealValueOperation, FirstComplex.ImaginryValueOperation, SecondComplex.ImaginryValueOperation);
            return subtractResult;
        }

        public string Subtract(double real1, double imaginary1, double real2, double imaginary2)
        {
            string subtractResult = subtract_method(real1, real2, imaginary1, imaginary2);
            return subtractResult;
        }

        string ComplexServices.Add(double real1, double imaginary1, double real2, double imaginary2)
        {
            string addResult = add_method(real1, real2, imaginary1, imaginary2);
            return addResult;
        }

        public string GetStringComplex(double realValue, double imaginaryValue)
        {
            string ComplexValue = (realValue + " + " + imaginaryValue + "i").ToString();

            return ComplexValue;
        }

        public string subtract_method(double real1, double imaginary1, double real2, double imaginary2)
        {
            ComplexType ResultValue = new ComplexType();
            ResultValue.RealValueOperation = real1 - real2;
            ResultValue.ImaginryValueOperation = imaginary1 - imaginary2;
            return GetStringComplex(ResultValue.RealValueOperation, ResultValue.ImaginryValueOperation);
        }

        public string add_method(double real1, double real2, double imaginary1, double imaginary2)
        {
            ComplexType ResultValue = new ComplexType();
            ResultValue.RealValueOperation = real1 + real2;
            ResultValue.ImaginryValueOperation = imaginary1 + imaginary2;
            return GetStringComplex(ResultValue.RealValueOperation, ResultValue.ImaginryValueOperation);
        }

        public string division_method(double real1, double real2, double imaginary1, double imaginary2)
        {
            ComplexType ResultValue = new ComplexType();

            double divideValue = Math.Pow(real2, 2) - (Math.Pow(imaginary2, 2) * (-1));

            ResultValue.RealValueOperation = ((real1 * real2) + ((imaginary1 * (imaginary2 * (-1))) * (-1)) / divideValue);
            ResultValue.ImaginryValueOperation = ((real1 * (imaginary2 * (-1))) + (imaginary1 * real2) / divideValue);

            return GetStringComplex(ResultValue.RealValueOperation, ResultValue.ImaginryValueOperation);
        }


        public string multiply_method(double real1, double real2, double imaginary1, double imaginary2)
        {
            ComplexType ResultValue = new ComplexType();
            ResultValue.RealValueOperation = (real1 * real2) + ((imaginary1 * imaginary2) * (-1));
            ResultValue.ImaginryValueOperation = (real1 * imaginary2) + (imaginary1 * real2);
            return GetStringComplex(ResultValue.RealValueOperation, ResultValue.ImaginryValueOperation);
        }
    }





}
