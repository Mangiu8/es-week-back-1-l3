using System;

namespace ConsoleApp3
{
    internal class ContoCorrente
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _surname;
        public string Surname { get { return _surname; } set { _surname = value; } }

        private decimal _amount;
        public decimal Amount { get { return _amount; } set { _amount = value; } }

        private bool _serviceActive;
        public bool ServiceActive { get { return _serviceActive; } set { _serviceActive = value; } }

        public ContoCorrente() { }
        public ContoCorrente(string Name, string Surname, decimal Amount, bool ServiceActive)
        {
            this._name = Name;
            this._surname = Surname;
            this._amount = Amount;
            this._serviceActive = ServiceActive;
        }
        public void StartMenu()
        {
            Console.WriteLine("BENVENUTO IN BUDDYBANK");
            Console.WriteLine("\n");
            Console.WriteLine("Scegli l'operazione da effettuare");
            Console.WriteLine("1. Apri un nuovo conto");
            Console.WriteLine("2. Effettua un versamento");
            Console.WriteLine("3. Effettua un bonifico/prelievo");
            Console.WriteLine("4. Logout");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    OpenNewAccount();
                    break;
                case 2:
                    Versamento();
                    break;
                case 3:
                    Prelievo();
                    break;
                case 4:
                    Console.WriteLine("Premere Invio per chiudere"); Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opzione non valida, per favore riprovare");
                    Console.WriteLine("===========================");
                    StartMenu();
                    break;
            }

        }
        private void OpenNewAccount()
        {
            Console.WriteLine("Nome: ");
            _name = Console.ReadLine();

            Console.WriteLine("Cognome: ");
            _surname = Console.ReadLine();

            Console.WriteLine("Attiva il servizio");
            _serviceActive = true;

            StartMenu();
        }

        private void Versamento()
        {
            if (_serviceActive == false)
            {
                Console.WriteLine("Non esiste alcun conto, siamo spiacenti.");
                Console.WriteLine("===========================");
                StartMenu();
            }
            else
            {
                Console.WriteLine("Inserisci l'importo desiderato: ");
                decimal value = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Versamento effettuato con successo");
                Console.WriteLine("===========================");
                _amount += value;
                Console.WriteLine($"Saldo attuale: {_amount}");

            }

        }

        private void Prelievo()
        {
            if (_serviceActive == false)
            {
                Console.WriteLine("Non esiste alcun conto, siamo spiacenti.");
                Console.WriteLine("===========================");
                StartMenu();
            }
            else
            {
                Console.WriteLine("Inserisci l'importo che desideri prelevare: ");
                decimal total = decimal.Parse(Console.ReadLine());

                if (total > _amount)
                {
                    Console.WriteLine("Non ti bastano i soldi bro, preleva di meno");
                    Console.WriteLine("===========================");
                }
                else
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine("Prelievo effettuato con successo");
                    _amount -= total;
                    Console.WriteLine($"Saldo attuale: {_amount}");
                }

          
            }
        }
    }
}

