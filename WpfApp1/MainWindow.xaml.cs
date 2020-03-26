using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ClassA myClassA { get; set; } = new ClassA();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            ClassA.myLabel = "更改绑定静态字符";
            myClassA.myString = "更改绑定非静态字符串";
        }
    }
}
