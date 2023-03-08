// Adapter Design Pattern - Structural Category

using System;

class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var json = $$""""
                   {
                        ""FromIBAN"": ""{{transaction.ToIBAN}}"",
                        ""ToIBAN"": ""{{transaction.ToIBAN}}"",
                        ""Amount"": ""{{transaction.Amount:C2}}""
                   }
                   """";

        // Call bank api with Json
        Console.WriteLine($"{GetType().Name} worked with;");
        Console.WriteLine(json);
        return true;
    }
}
