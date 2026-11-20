public class Address
{
    private string _streetAddress;
    private string _city;
    private string _province;
    private string _country;

    public Address(string streetAddress, string city, string province, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA" || _country == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}\n{_province}\n{_country}";
    }
}