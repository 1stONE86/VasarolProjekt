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
        public RelayCommand CloseParancs { get; private set; }
        public RelayCommand VegosszegParancs { get; private set; }
        public VasarolViewModel()
        {
            _vasarol = new Vasarol(400, 0, 800, 0, 3000, 0, 500, 0, 3500, 0, 329, 0, 600, 0);
            CloseParancs = new RelayCommand(Execute => Kilepes());
            VegosszegParancs = new RelayCommand(Execute => Szamitas());
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
        public int TejFt
        {
            get
            {
                return _vasarol.TejAr;
            }
            set
            {
                _vasarol.TejAr = 400;
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
        public int KenyerFt
        {
            get
            {
                return _vasarol.KenyerAr;
            }
            set
            {
                _vasarol.KenyerAr = 800;
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
        public int SajtFt
        {
            get
            {
                return _vasarol.SajtAr;
            }
            set
            {
                _vasarol.SajtAr = 3000;
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
        public int KrumpliFt
        {
            get
            {
                return _vasarol.KrumpliAr;
            }
            set
            {
                _vasarol.KrumpliAr = 500;
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
        public int SzalamiFt
        {
            get
            {
                return _vasarol.SzalamiAr;
            }
            set
            {
                _vasarol.SzalamiAr = 3500;
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
        public int CukorFt
        {
            get
            {
                return _vasarol.CukorAr;
            }
            set
            {
                _vasarol.CukorAr = 329;
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
        public int OlajFt
        {
            get
            {
                return _vasarol.OlajAr;
            }
            set
            {
                _vasarol.OlajAr = 600;
            }
        }

        public string Vegosszeg
        {
            get
            {
                return $"A fizetendő összeg {_vasarol.Vegosszeg} Ft";
            }
        }

        public void Szamitas()
        {
            OnPropertyChanged(nameof(Vegosszeg));
        }

    }
}

