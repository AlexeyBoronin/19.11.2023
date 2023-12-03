using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _19._11._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> styles=new List<string>() {"light", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource=styles;
            styleBox.SelectedItem = "dark";
            /*//Button myButton= new Button();
            //myButton.Width = 100;
            //myButton.Height = 30;
            //myButton.Content = "Кнопка";
            //layoutGrid.Children.Add(myButton);

            //Style buttonStyle=new Style();
            //buttonStyle.Setters.Add(new Setter { Property = Control.FontFamilyProperty, Value = new FontFamily("Verdana") });
            //buttonStyle.Setters.Add(new Setter { Property = Control.MarginProperty, Value=new Thickness(10) });
            //buttonStyle.Setters.Add(new Setter { Property = Control.BackgroundProperty, Value = new SolidColorBrush(Colors.Black) });
            //buttonStyle.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Colors.White) });
            //buttonStyle.Setters.Add(new EventSetter { Event = Button.ClickEvent, Handler=new RoutedEventHandler(Button_Click) });

            //button1.Style = buttonStyle;
            //button2.Style = buttonStyle;*/
        }
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            var uri=new Uri(style +".xaml",UriKind.Relative);
            ResourceDictionary resourceDict=Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    string text=textbox1.Text;
        //    if(text !="")
        //        MessageBox.Show(text);
        //}
        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            Button clikedButton=(Button)sender;
            MessageBox.Show(clikedButton.Content.ToString());
        }
    }
}