using System;
interface IPayment
{
    float calculateValue();
    void setCurrency(string currency);

}

class PurchaseInvoice :IPayment
{
    private int ProductID;
    private int Quantity;
    private float Price;

    private string Currency;

    public PurchaseInvoice(int ProductID, int Quantity, int Price)
    {
        this.ProductID = ProductID;
        this.Quantity = Quantity;
        this.Price = Price;
    }

    public float calculateValue()
    {
        return Quantity*Price;
    }

    public void setCurrency(string currency)
    {
        this.Currency = Currency;
    }

    public void getCurrency()
    {
        Console.WriteLine(Currency);
    }

}

public class Interfaces{
    public static void Test()
    {
    IPayment Purchase1 = new PurchaseInvoice(21, 1, 100);
    Purchase1.setCurrency("USD");
    Console.WriteLine(Purchase1.calculateValue());
    //Console.WriteLine(Purchase1.getCurrency);
    
    }
}
