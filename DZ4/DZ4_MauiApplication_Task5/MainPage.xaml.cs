namespace DZ4_MauiApplication_Task5
{
    public partial class MainPage : ContentPage
    {
        List<Product> cart = new List<Product>();
        public void AddToCartClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Product product = (Product)button.BindingContext;
            
            cart.Add(product);
            productsList.ItemsSource = cart;

            DisplayAlert("Success", "Product have been added to the cart.", "OK");
        }

        public void RemoveFromCartClicked(object sender, EventArgs e)
        {

            var button = (Button)sender;
            Product product = (Product)button.BindingContext;

            cart.Remove(product);
            productsList.ItemsSource = cart;

            DisplayAlert("Success", "Product have been removed from the cart.", "OK");
        }

        public MainPage()
        {
            InitializeComponent();

            Books book1 = new Books();
            book1.Name = "Anxious People";
            book1.Author = "Fredrik Backman";
            book1.Price = 430;
            book1.Country = "Sweden";
            book1.NumberOfPages = 336;
            book1.Publisher = "Simon & Schuster Canada";
            book1.PackingDate = "25.10.2023";
            book1.Description = "A novel about a crime that never took place, a would-be bank robber who disappears into thin air, " +
                "and eight extremely anxious strangers who find they have more in common than they ever imagined.";

            Books book2 = new Books();
            book2.Name = "Vicious";
            book2.Author = "V.E. Schwab";
            book2.Price = 571;
            book2.Country = "USA";
            book2.NumberOfPages = 366;
            book2.Publisher = "Tor Books";
            book2.PackingDate = "25.10.2023";
            book2.Description = "A masterful tale of ambition, jealousy, and superpowers";

            Books book3 = new Books();
            book3.Name = "Babel";
            book3.Author = "R.F.Kuang";
            book3.Price = 490;
            book3.Country = "USA";
            book3.NumberOfPages = 544;
            book3.Publisher = "Harper Voyager";
            book3.PackingDate = "25.10.2023";
            book3.Description = "Story about student revolutions, colonial resistance, and the use of language and " +
                "translation as the dominating tool of the British empire.";

            List<Books> BooksList = new List<Books> { book1, book2, book3 };

            booksList.ItemsSource = BooksList;

            Goods goods1 = new Goods();
            goods1.Name = "Moisturising face cream";
            goods1.Price = 198;
            goods1.Country = "Ukraine";
            goods1.PackingDate = "28.10.2023";
            goods1.Description = "Face cream";
            goods1.ExpiryDate = "28.10.2028";
            goods1.Quantity = 50;
            goods1.UnitOfMeasurement = "One bottle - 30 ml";

            Goods goods2 = new Goods();
            goods2.Name = "Foam for the face";
            goods2.Price = 178;
            goods2.Country = "Ukraine";
            goods2.PackingDate = "28.10.2023";
            goods2.Description = "Face foam";
            goods2.ExpiryDate = "28.10.2028";
            goods2.Quantity = 30;
            goods2.UnitOfMeasurement = "One bottle - 150 ml";

            Goods goods3 = new Goods();
            goods3.Name = "Hair conditioner balm";
            goods3.Price = 130;
            goods3.Country = "Ukraine";
            goods3.PackingDate = "28.10.2023";
            goods3.Description = "Conditioner balm";
            goods3.ExpiryDate = "28.10.2028";
            goods3.Quantity = 30;
            goods3.UnitOfMeasurement = "One bottle - 500ml";

            List<Goods> GoodsList = new List<Goods> { goods1, goods2, goods3 };
            goodsList.ItemsSource = GoodsList;
        }
        
    }

    internal class Product
    {
        public double Price { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string PackingDate { get; set; }
        public string Description { get; set; }
    }

    internal class Goods : Product
    {
        public string ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
    }

    internal class Books : Product
    {
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
    }
}