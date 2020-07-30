using System;
using System.Collections.Generic;

namespace FactoryUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = PaymentProvider.Provider1;
            var id = Guid.NewGuid();

            var result = FactoryUtility<PaymentProvider,ICancelPayment>
                .Init(new Dictionary<PaymentProvider, ICancelPayment>
                        {
                            {PaymentProvider.Provider2,new Implementation2()},
                            {PaymentProvider.Provider1,new ImplementationOne()}
                        }).GetImplementation(provider)
                .Cancel(id);

            Console.WriteLine(result);

        }
    }
}
