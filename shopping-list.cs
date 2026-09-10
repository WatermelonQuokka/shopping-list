List<string> product = [];
List<int> price = [];
// possible to change currency here
string ccy = "kr";

static string Ask(string option)
{
    Console.Write(option + " ");
    return Console.ReadLine();
}

while (true)
{
    Console.Clear();
    string[] options = [
        "Choose an option.",
        "1. Add a product and price",
        "2. Show your lists",
        "3. Remove a product",
        "9. Exit"
    ];
    string choice = Ask(string.Join("\n", options) + "\n");

    
    // adds a product and price to the lists
    if(choice == "1")
    {
        Console.Clear();
        string productName = Ask("Enter product name: ");
        string priceForProduct;
        int priceNum;
        do
        {
        priceForProduct = Ask($"Enter price of {productName}: ");
        }
        while(!int.TryParse(priceForProduct, out priceNum));
        product.Add(productName);
        price.Add(priceNum);

    }
    // shows the full lists with total price
    else if(choice == "2")
    {
        
    }
    // removes both product and price from the lists
    else if(choice == "3")
    {
        
    }
    // exits the loop
    else if(choice == "9")
    {
        break;
    }

}