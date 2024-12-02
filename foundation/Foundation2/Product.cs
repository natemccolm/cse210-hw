public class Product{

    private string name;
    private string productID;
    private decimal price;
    private int quantity;
    
    public Product(string name, string productID, decimal price, int quantity){
        this.name=name;
        this.productID=productID;
        this.price=price;
        this.quantity=quantity;
    }


    public string Name{
        get{return name;}
        set{name=value;}
    }

    public string ProductID{
        get{return productID;}
        set{productID=value;}
    }

    public decimal Price{
        get{return price;}
        set{price=value;}
    }

    public int Quantity{
        get{return quantity;}
        set{quantity=value;}
    }

    public decimal CalculateTotalCost(){
        return price*quantity;
    }


}