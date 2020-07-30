# Factory Utility

Initialize your Factory Utility with the mapping of enum to concrete implementation, then call your implementation method all via a fluent api

```
var result = FactoryUtility<PaymentProvider,ICancelPayment>
        .Init(new Dictionary<PaymentProvider, ICancelPayment>
                {
                    {PaymentProvider.Provider2,new Implementation2()},
                    {PaymentProvider.Provider1,new ImplementationOne()}
                })
        .GetImplementation(provider)
        .Cancel(id);
```