using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion03_1
{
    internal abstract class Medarbejder : IharAdresse
    {
        public CprNr cprNr { get; }
        private string medarbejdernummer;
        private string name;
        private const int timerPrUge = 37;
        Adresse AdresseProperty { get; set; }

        public Medarbejder(CprNr cpr, string medarbejdernummer, string name, Adresse adresse)
        {
            this.medarbejdernummer = medarbejdernummer;
            this.cprNr = cpr;
            this.name = name;
            this.AdresseProperty = adresse;
        }

        public abstract double BeregnUgeLoen(); // Abstract method without implementation

        public int TimerPrUge
        {
            get { return timerPrUge; }
        }

        

        public override string ToString()
        {
            return medarbejdernummer + " - " + name + " - " + AdresseProperty + " - " + this.cprNr.SequenceNumber + " - " + cprNr.BirthDate;
        }
    }

    class MedarbejderListe<TKey>
    {
        private readonly Dictionary<string, IharAdresse> _collection = new Dictionary<string, IharAdresse>();

        public void AddElement(IharAdresse item)
        {
            if (_collection.ContainsKey(item.AdresseProperty.vejNavn))
            {
                throw new Exception("Key already exists");
            }
            _collection.Add(item.AdresseProperty.vejNavn, item);
        }

        public IharAdresse GetItem(string key)
        {
            if (!_collection.ContainsKey(key))
            {
                return null;
            } 

            return _collection[key];
        }

        public int ListSize()
        {
            return _collection.Count;
        }
    }
}
