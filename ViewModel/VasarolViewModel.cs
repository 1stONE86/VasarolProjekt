using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VasarolProjekt.Model;
using VasarolProjekt.ViewModel.BaseClass;

namespace VasarolProjekt.ViewModel
{
    public class VasarolViewModel : ViewModelBase
    {
        private Vasarol _vasarol;
        public RelayCommand CloseCommand { get; private set; }
        public RelayCommand VegosszegCommand { get; private set; }
        public VasarolViewModel()
        {
            _vasarol = new Vasarol(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            CloseCommand = new RelayCommand(Execute => Kilepes());
            VegosszegCommand = new RelayCommand(Execute => Szamitas());
        }

        private void Kilepes()
        {
            Application.Current.Windows[0].Close();
        }

        public int Tej
        {
            get
            {
                return _vasarol.TejDb;
            }
            set
            {
                _vasarol.TejDb = value;
            }
        }
        public int Kenyer
        {
            get
            {
                return _vasarol.KenyerDb;
            }
            set
            {
                _vasarol.KenyerDb = value;
            }
        }
        public int Sajt
        {
            get
            {
                return _vasarol.SajtDb;
            }
            set
            {
                _vasarol.SajtDb = value;
            }
        }
        public int Krumpli
        {
            get
            {
                return _vasarol.KrumpliDb;
            }
            set
            {
                _vasarol.KrumpliDb = value;
            }
        }
        public int Szalami
        {
            get
            {
                return _vasarol.SzalamiDb;
            }
            set
            {
                _vasarol.SzalamiDb = value;
            }
        }
        public int Cukor
        {
            get
            {
                return _vasarol.CukorDb;
            }
            set
            {
                _vasarol.CukorDb = value;
            }
        }
        public int Olaj
        {
            get
            {
                return _vasarol.OlajDb;
            }
            set
            {
                _vasarol.OlajDb = value;
            }
        }

        public string Vegosszeg
        {
            get
            {
                return $"A fizetendő összeg{_vasarol.Vegosszeg} Ft";
            }
        }

        public void Szamitas()
        {
            OnPropertyChanged(nameof(Vegosszeg));
        }

    }
}

