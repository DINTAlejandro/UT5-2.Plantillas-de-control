using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5_1.Plantillas_de_datos
{
    class MainWindowVM : INotifyPropertyChanged
    {
        //realizar en cualquier propiedad que agreguemos en la vista modelo
        private ObservableCollection<Plato> platos;
        public ObservableCollection<Plato> Platos
        {
            get { return platos; }
            set
            {
                platos = value;
                NotifyPropertyChanged("Platos");
            }
        }

        private ObservableCollection<string> tipoPlatos;
        public ObservableCollection<string> TipoPlatos
        {
            get { return tipoPlatos; }
            set
            {
                tipoPlatos = value;
                NotifyPropertyChanged("TipoPlatos");
            }
        }

        private Plato platoActual;
        public Plato PlatoActual
        {
            get { return platoActual; }
            set
            {
                platoActual = value;
                NotifyPropertyChanged("PlatoActual");
            }
        }

        public MainWindowVM()
        {
            Platos = Plato.GetSamples("C:/Users/alumno/source/repos/UT5-1.Plantillas de datos/Images");
            TipoPlatos = new ObservableCollection<string>();

            TipoPlatos.Add("Mexicana");
            TipoPlatos.Add("Americana");
            TipoPlatos.Add("China");
        }

        public void LimpiarPlatoActual()
        {
            PlatoActual = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
