using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasarolProjekt.Model
{
    public class Vasarol
    {
        private int _ertekTej;
        private int _tejDb;

        private int _ertekKenyer;
        private int _kenyerDb;

        private int _ertekSajt;
        private int _sajtDb;

        private int _ertekKrumpli;
        private int _krumpliDb;

        private int _ertekSzalami;
        private int _szalamiDb;

        private int _ertekCukor;
        private int _cukorDb;

        private int _ertekOlaj;
        private int _olajDb;

        public Vasarol(int ertekTej, int tejDb, int ertekKenyer, int kenyerDb, int ertekSajt, int sajtDb, int ertekKrumpli, int krumpliDb, int ertekSzalami, int szalamiDb, int ertekCukor, int cukorDb, int ertekOlaj, int olajDb)
        {
            _ertekTej = ertekTej;
            _tejDb = tejDb;

            _ertekKenyer = ertekKenyer;
            _kenyerDb = kenyerDb;

            _ertekSajt = ertekSajt;
            _sajtDb = sajtDb;

            _ertekKrumpli = ertekKrumpli;
            _krumpliDb = krumpliDb;

            _ertekSzalami = ertekSzalami;
            _szalamiDb = szalamiDb;

            _ertekCukor = ertekCukor;
            _cukorDb = cukorDb;

            _ertekOlaj = ertekOlaj;
            _olajDb = olajDb;

        }

        public int TejAr
        {
            get { return _ertekTej; }
            set { _ertekTej = 400; }
        }

        public int TejDb
        {
            get { return _tejDb; }
            set { _tejDb = value; }
        }

        public int KenyerAr
        {
            get { return _ertekKenyer; }
            set { _ertekKenyer = 800; }
        }

        public int KenyerDb
        {
            get { return _kenyerDb; }
            set { _kenyerDb = value; }
        }

        public int SajtAr
        {
            get { return _ertekSajt; }
            set { _ertekSajt = 3000; }
        }

        public int SajtDb
        {
            get { return _sajtDb; }
            set { _sajtDb = value; }
        }

        public int KrumpliAr
        {
            get { return _ertekKrumpli; }
            set { _ertekKrumpli = 500; }
        }

        public int KrumpliDb
        {
            get { return _krumpliDb; }
            set { _krumpliDb = value; }
        }

        public int SzalamiAr
        {
            get { return _ertekSzalami; }
            set { _ertekSzalami = 3500; }
        }

        public int SzalamiDb
        {
            get { return _szalamiDb; }
            set { _szalamiDb = value; }
        }

        public int CukorAr
        {
            get { return _ertekCukor; }
            set { _ertekCukor = 329; }
        }

        public int CukorDb
        {
            get { return _cukorDb; }
            set { _cukorDb = value; }
        }

        public int OlajAr
        {
            get { return _ertekOlaj; }
            set { _ertekOlaj = 329; }
        }

        public int OlajDb
        {
            get { return _olajDb; }
            set { _olajDb = value; }
        }

        public int Vegosszeg
        {
            get { return this._ertekTej * this._tejDb + this._ertekKenyer * this._kenyerDb + this._ertekSajt * this._sajtDb + this._ertekKrumpli * this._krumpliDb + this._ertekSzalami * this._szalamiDb + this._ertekCukor * this._cukorDb + this._ertekOlaj * this._olajDb; }
        }
    }
}
