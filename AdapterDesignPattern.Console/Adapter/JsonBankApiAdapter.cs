// Adapter Design Pattern - Structural Category

class JsonBankApiAdapter : IBankApi
{
    private readonly JsonBankApi _jsonBankApi;
    public JsonBankApiAdapter()
    {
        _jsonBankApi = new JsonBankApi();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return _jsonBankApi.ExecuteTransaction(transaction);
    }
}
