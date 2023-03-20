using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Cliente> Clientes { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Clientes = new ObservableCollection<Cliente>();
            Clientes.Add(new Cliente { PrimeiroNome = "Maria", SobreNome = "Silva", Telefone = "16-98834-9098" });
            Clientes.Add(new Cliente { PrimeiroNome = "Rodolfo", SobreNome = "Peratello", Telefone = "16-7788-3477" });
            Clientes.Add(new Cliente { PrimeiroNome = "Bianca", SobreNome = "Rohrer", Telefone = "16-98823-3322" });
            Clientes.Add(new Cliente { PrimeiroNome = "Matheus", SobreNome = "Rodrigues", Telefone = "16-99934-9196" });

        }

       
    }
}
