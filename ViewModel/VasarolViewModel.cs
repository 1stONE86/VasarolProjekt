using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VasarolProjekt.Model;

namespace VasarolProjekt.ViewModel
{
    public class VasarolViewModel
    {
        private Vasarol vasarol;
        public RelayCommand CloseCommand { get; private set; }
        public RelayCommand Vegosszeg { get; private set; }
        public VasarolViewModel()
        {
            vasarol = new Vasarol(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        

        public int Tej
        {
            get
            {
                return vasarol.TejDb;
            }
            set
            {
                _tejDb.TejDb = value;
            }
        }
        public int Kenyer
        {
            get
            {
                return vasarol.KenyerDb;
            }
            set
            {
                _kenyerDb.KenyerDb = value;
            }
        }
        public int Sajt
        {
            get
            {
                return vasarol.SajtDb;
            }
            set
            {
                _sajt.SajtDb = value;
            }
        }
        public int Krumpli
        {
            get
            {
                return vasarol.KrumpliDb;
            }
            set
            {
                _krmpliDb.KrumpliDb = value;
            }
        }
        public int Szalami
        {
            get
            {
                return vasarol.SzalamiDb;
            }
            set
            {
                _szalamiDb.SzalamiDb = value;
            }
        }
        public int Cukor
        {
            get
            {
                return vasarol.CukorDb;
            }
            set
            {
                _cukorDb.CukorDb = value;
            }
        }
        public int Olaj
        {
            get
            {
                return vasarol.OlajDb;
            }
            set
            {
                _olajDb.OlajDb = value;
            }
        }
    
    }
}
