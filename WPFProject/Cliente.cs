using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFProject
{
    public class Cliente : INotifyPropertyChanged
    {
        public string primeiroNome;
        public string sobreNome;
        public string telefone;

        public event PropertyChangedEventHandler PropertyChanged;

        public string PrimeiroNome
        {
            get => primeiroNome;
            set
            {
                if(primeiroNome != value)
                {
                    primeiroNome = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string SobreNome
        {
            get => sobreNome;
            set
            {
                if (sobreNome != value)
                {
                    sobreNome = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Telefone
        {
            get => telefone;
            set
            {
                if (telefone != value)
                {
                    telefone = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void NotifyPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }



    }
}
