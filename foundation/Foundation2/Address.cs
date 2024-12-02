public class Address
{

    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country){
        this.streetAddress=streetAddress;
        this.city=city;
        this.state=state;
        this.country=country;
    }

    public string StreetAddress{
        get {return streetAddress;}
        set{streetAddress=value;}
    }
    public string City{
        get {return city;}
        set{city=value;}
    }
    public string State{
        get {return state;}
        set{state=value;}
    }
    public string Country{
        get {return country;}
        set{country=value;}
    }
    public bool IsInUSA(){
        return country.ToLower()=="usa";
    }

    public string GetFullAddress(){
        return $"{streetAddress}\n{city}\n{state}\n{country}";
    }
}