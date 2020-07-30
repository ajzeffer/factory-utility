using System;
using System.Collections.Generic;

namespace FactoryUtil{
    public class FactoryUtility<TType, TInterface>{

        private Dictionary<TType, TInterface> _options {get;set;}

        private FactoryUtility(Dictionary<TType, TInterface> options ){
            _options = options;
        }
        public static FactoryUtility<TType, TInterface> Init(Dictionary<TType,TInterface> options)
        {
                return new FactoryUtility<TType, TInterface>(options);
        }

        public  TInterface GetImplementation(TType value) {
            return _options[value];
        }

    }

    public interface ICancelPayment{
        string Cancel(Guid paymentID);
    }

    public class Implementation2 : ICancelPayment
    {
        public string Cancel(Guid paymentID)
        {
            return "Cancelled in Implementation2";
        }
    }

    public class ImplementationOne : ICancelPayment
    {
        public string Cancel(Guid paymentID)
        {
            return "Cancelled By ImplementationOne";
        }
    }
    public enum PaymentProvider: byte{
        Provider1 = 1,
        Provider2 = 2
    }




}