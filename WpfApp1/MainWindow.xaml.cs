using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Autor: Yelyzaveta Bohun
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BirthdayViewModel viewModel = new ();
            if (!BirthdatePicker.SelectedDate.HasValue) MessageBox.Show("Please, choose a date", "No date chosen");
            else
            {
                viewModel.Birthdate = BirthdatePicker.SelectedDate.Value;
                int age = viewModel.Age;
                if (age < 0 || age >= 135) MessageBox.Show("Your age must be in range from 0 to 135", "Invalid age input");
                else
                {
                    Age.Visibility = Visibility.Visible;
                    Age.Content = "You are " + age + " years old";
                    WesternZodiacLabel.Visibility = Visibility.Visible;
                    WesternZodiacAnswer.Visibility = Visibility.Visible;
                    WesternZodiacAnswer.Text = viewModel.WesternZodiac;
                    ChineseZodiacLabel.Visibility = Visibility.Visible;
                    ChineseZodiacAnswer.Visibility = Visibility.Visible;
                    ChineseZodiacAnswer.Text = viewModel.ChineseZodiac;
                    if (viewModel.TodayIsClientBirthday) HappyBirthdayGreeting.Visibility = Visibility.Visible;
                    else HappyBirthdayGreeting.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
