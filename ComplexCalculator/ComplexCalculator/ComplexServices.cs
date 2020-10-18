using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ComplexCalculator
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface ComplexServices
    {


        [OperationContract(Name = "AddTwoValue")]
        string Add(ComplexType FirstComplex, ComplexType SecondComplex);

        [OperationContract(Name = "AddFourValue")]
        string Add(double real1,double imaginary1, double real2, double imaginary2);


        [OperationContract(Name = "SubtractTwoValue")]
        string Subtract(ComplexType FirstComplex, ComplexType SecondComplex);

        [OperationContract(Name = "SubtractFourValue")]
        string Subtract(double real1, double imaginary1, double real2, double imaginary2);


        [OperationContract(Name = "DivisionTwoValue")]
        string Division(ComplexType FirstComplex, ComplexType SecondComplex);

        [OperationContract(Name = "DivisionFourValue")]
        string Division(double real1, double imaginary1, double real2, double imaginary2);


        [OperationContract(Name = "MultiplyTwoValue")]
        string Multiply(ComplexType FirstComplex, ComplexType SecondComplex);

        [OperationContract(Name = "MultiplyFourValue")]
        string Multiply(double real1, double imaginary1, double real2, double imaginary2);


    }


    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
    [DataContract]
    public class ComplexType
    {
        double RealValue;
        double ImaginaryValue;

        [DataMember]
        public double RealValueOperation
        {
            get { return RealValue; }
            set { RealValue = value; }
        }

        [DataMember]
        public double ImaginryValueOperation
        {
            get { return ImaginaryValue; }
            set { ImaginaryValue = value; }
        }


    }
}
