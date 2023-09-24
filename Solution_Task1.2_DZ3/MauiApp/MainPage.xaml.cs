namespace MauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            string userInput = numberEntry.Text;
            if (int.TryParse(userInput, out int number))
            {
                Console.WriteLine("You have entered an integer " + number);
            }
            else
            {
                Console.WriteLine("It's not an integer. Please, try again.");
            }
        }
    }
}