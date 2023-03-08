// Adapter Design Pattern - Structural Category

class XmlBankApiAdapter : IBankApi
{
    private readonly XmlBankApi _xmlBankApi;
    public XmlBankApiAdapter()
    {
        _xmlBankApi = new XmlBankApi();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return _xmlBankApi.ExecuteTransaction(transaction);
    }
}
