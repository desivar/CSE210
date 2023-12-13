public class Address
{
    private string=_streetAdress;
    private string=_city;
    private string=_stateOrProvince;
    private string= _country;
    public Address(string street, string city, string stateOrProvince, string country)
{
_streetAddress=_street;
_city=city;
_stateOrProvice=stateOrProvince;
_country=country;


}
public bool GetLivesInUSA()
{
     if( _country.ToUpper().Equals("USA"))
        {
            return true;
        }
        return false;
        }
    public string GetFormattedAddress()
    {
        string formattedAddress = $"   {_streetAddress}\n   {_city}\n   {_stateOrProvince}\n   {_country}";
        return formattedAddress;
    }
}

