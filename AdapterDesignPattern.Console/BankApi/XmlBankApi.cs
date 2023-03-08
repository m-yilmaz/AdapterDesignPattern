// Adapter Design Pattern - Structural Category

using System;

class XmlBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $"""
                        <TransferTransaction>
                            <FromIBAN>{transaction.FromIBAN}</FromIBAN>
                            <ToIBAN>{transaction.ToIBAN}</ToIBAN>
                            <Amount>{transaction.Amount:C2}</Amount>
                        </TransferTransaction>
                   """;

        // Call bank api with XML
        Console.WriteLine($"{GetType().Name} worked with;");
        Console.WriteLine(xml);
        return true;
    }
}
