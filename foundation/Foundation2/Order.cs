public class Order{

    private List<Product> products;
    private Customer customer;

    public Order(Customer customer){
        this.customer=customer;
        this.products=new List<Product>();
    }

    public void AddProduct(Product product){
        products.Add(product);
    }

    public decimal CalculateTotalCost(){
        decimal totalCost=0;

        foreach(var product in products){
            totalCost+=product.CalculateTotalCost();
        }
        
        decimal shippingCost = customer.IsInUSA() ? 5.0m: 35.0m;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel(){
        string label="Packing Label: \n";
        foreach(var product in products){
            label += $"{product.Name} (ID: {product.ProductID})\n";
        }
        return label;
    }

    public string GetShippingLabel(){
        string label="Shipping Label:\n";
        label += $"Customer: {customer.Name}\n";
        label += customer.GetFullAddress();
        return label;
    }

}