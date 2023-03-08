// Adapter Design Pattern - Structural Category

using System;


var trans = new TransferTransaction() { Amount = 10, FromIBAN = "TR 1", ToIBAN = "TR 2" };
var adapter = new JsonBankApiAdapter();

var result = adapter.ExecuteTransaction(trans);

Console.WriteLine("Result: {0}", result);

Console.ReadLine();
 