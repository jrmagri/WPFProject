using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFProject
{
    public class ClienteController : INotifyPropertyChanged
    {
        public ClienteController()
        {
            Clientes = new ObservableCollection<Cliente>();
        }
        private ObservableCollection<Cliente> clientes;

        public ObservableCollection<Cliente> Clientes
        {
            get
            {
                return clientes;
            }

            set
            {
                clientes = value; NotifyPropertyChanged("PrimeiroNome");
            }
        }
        private Cliente clienteSelecionado;      

        public Cliente ClienteSelecionado
        {
            get
            {
                return clienteSelecionado;
            }

            set
            {
                clienteSelecionado = value; NotifyPropertyChanged("ClienteSelecionado");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName]string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
