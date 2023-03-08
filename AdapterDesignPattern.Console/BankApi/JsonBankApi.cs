// Adapter Design Pattern - Structural Category

using System;

class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $$""""
                   {
                        ""FromIBAN"": ""{{transaction.ToIBAN}}"",
                        ""ToIBAN"": ""{{transaction.ToIBAN}}"",
                        ""Amount"": ""{{transaction.Amount:C2}}""
                   }
                   """";

        // Call bank api with Json
        Console.WriteLine($"{GetType().Name} worked");
        return true;
    }
}
