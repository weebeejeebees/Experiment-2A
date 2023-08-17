    internal class Experiment2
{
    public static void Main(string[] args)
    {
        int p_Code = 1;
        string p_Name = "Hotzogg";
        int s_Code = 082502;
        string s_Name = "Ethan James O. Zogg";
        double price = 99999;
        
        Product(p_Code, p_Name, s_Code, s_Name, price);
    }

    public static void Product(int p_Code, string p_Name, int s_Code, string s_Name, double price)
    {
        Console.WriteLine("Product Code: " + p_Code + "       " + "Name: " + p_Name);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Supplier Code: " + s_Code + "       " + "Supplier: " + s_Name);
    }
}
