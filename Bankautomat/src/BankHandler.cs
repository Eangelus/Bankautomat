using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bankautomat.src
{
    // BankHandler wird ein Singleton  Notiz für mich Singleton noch mal lernen
    internal class BankHandler
    {
        // Variablen
        private List<Bankkonto> _bankkontos;
        
        private static BankHandler _instance;
        public string aktiverBenutzer;
        public string aktivesPw;

        // Construktor
        private BankHandler()
        {
            _bankkontos = new List<Bankkonto>();
            _instance = this;
            
        }
        // funktionen
        // singleton funktion 
        public static BankHandler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BankHandler();
            }
            return _instance;
        }

        
        public void CreateKonto(string KontoInhaber, string pw)
        {
            // Lege Konto an
            Bankkonto bankkonto = new Bankkonto();
            // sete KontoInhaber und Pw
            bankkonto.KontoInhaber = KontoInhaber;
            bankkonto.Passwort = pw;
            
            // zu den listen der Bankkonten hinzufügen
            _bankkontos.Add(bankkonto);


        }

        public void Abmelden()
        {

            Bankkonto Konto = (Bankkonto)findeKonto(this.aktiverBenutzer, this.aktivesPw);
            aktiverBenutzer = "";
            aktivesPw = "";

        }

        public object findeKonto(string KontoInhaber, string pw)
        {
            // suche nach KontoInhaber und pw in der Liste der Bankkonten
                foreach (var bankkonto in _bankkontos)
                {

                    if (bankkonto.KontoInhaber == KontoInhaber)
                    {
                        if (pw == bankkonto.Passwort)
                        {

                            ;
                            this.aktiverBenutzer = KontoInhaber;
                            this.aktivesPw = pw;

                            return bankkonto;
                        }
                        else
                        {
                            //passwort stimmt nicht
                            Console.WriteLine("Passwort stimmt nicht!");
                        }
                    }
                    else
                    {
                        //KontoInhaber nicht gefunden

                        Console.WriteLine("Konto nicht gefunden!");
                    }
                }
            return 0;

           
        }
        
        public void KontoEinzahlung(decimal einzahlungsBetrag, string wo)
        {

            DateTime datum = DateTime.Now;
            Bankkonto Konto = (Bankkonto)findeKonto(this.aktiverBenutzer, this.aktivesPw);
            

            Transaktionen trans = new Transaktionen(einzahlungsBetrag, datum, wo);
            Konto.KontoStand = Konto.KontoStand + einzahlungsBetrag;

            
            Konto.ListeTrans.Add(trans);
            Console.WriteLine(Konto.KontoStand.ToString());

        }

        public bool PrüfenObAngemeldet()
        {
            bool result;
            if (String.IsNullOrWhiteSpace(aktiverBenutzer))
            {
                Console.WriteLine("Hier ist kein benutzer");
                result = false;
            }
            if (String.IsNullOrEmpty(aktivesPw))
            {
                Console.WriteLine("Hier ist kein pw");
                result = false;
            }
            else
            {
                result = true;
            }
            
            return result;
        }

        public void Auszahlung(decimal betrag, string wo)
        {
            
            Bankkonto Konto = (Bankkonto)findeKonto(this.aktiverBenutzer, this.aktivesPw);
            
            if (Konto.KontoStand >= betrag)
                {
                   DateTime datum = DateTime.Now;
                
                   Transaktionen trans = new Transaktionen(betrag, datum, wo);

                    Konto.KontoStand = Konto.KontoStand - betrag;

                    Konto.ListeTrans.Add(trans);
                    Console.WriteLine(Konto.KontoStand.ToString()  );
                }
                else
                {
                Console.WriteLine("You dont have many");
                }


        }

        // getter für listen
        internal List<Bankkonto> GetAllKontos()
        {
            return _bankkontos;
        }

        internal List<Transaktionen> GetAllTransaktionen()
        {
            if (PrüfenObAngemeldet())
            {
                Bankkonto Konto = (Bankkonto)findeKonto(this.aktiverBenutzer, this.aktivesPw);
                return Konto.ListeTrans;
            }
            else
            {
                Console.WriteLine("fehlschlag bei GetAllTransAktionen");
            }
            return null;
        }
        // geter für kontostand
        internal decimal GetKontostand()
        {
            Bankkonto Konto = (Bankkonto)findeKonto(this.aktiverBenutzer, this.aktivesPw);
            decimal a = Konto.KontoStand;
            return a;
        }

    }
}
