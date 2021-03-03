using System.Collections.Generic;

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }
}

class Espresso : IBeverage
{
    public List<string> Ingredients {get;set }

    public string CupType => throw new System.NotImplementedException();
    //FDBMNNBKRTBMÖBARE
    //HJEHEJEHEJEJ
    //HEJHEJ
    //This is a test.
    //fgbaedrfbaerbe
}

class Latte : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();
}