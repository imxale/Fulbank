using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Fulbank.Model;

namespace Fulbank
{
    public class Person
    {
        private int idPerson;
        private int idRole;
        private string name;
        private string fname;
        private DateTime birth;
        private string mail;
        private string address;
        private string city;
        private int postal;
        private string user;
        private string password;
        private DateTime creationDate = DateTime.Now.Date;
        private bool isValid;

        //Méthode d'insertion
        public int InsertUser()
        {
            PersonModel unepersonne = new PersonModel();
            return unepersonne.insertUser(this); //La méthode d'insertion retourne un entier
        }

        public DataTable SelectPersonName()
        {
            PersonModel unepersonne = new PersonModel();
            return unepersonne.selectPersonName();
        }

        public DataTable SelectPerson()
        {
            PersonModel unepersonne = new PersonModel();
            return unepersonne.selectPerson(this.user);
        }

        public DataTable SelectPersonAdmin()
        {
            PersonModel unepersonne = new PersonModel();
            return unepersonne.selectPersonAdmin();
        }

        public DataTable SelectCurrentAccount()
        {
            PersonModel unepersonne = new PersonModel();
            return unepersonne.selectCurrentAccount(this.idPerson);
        }

        public DataTable SelectSavingAccount()
        {
            PersonModel unepersonne = new PersonModel();
            return unepersonne.selectSavingAccount(this.idPerson);
        }

        public DataTable SelectHomeloanplan()
        {
            PersonModel unepersonne = new PersonModel();
            return unepersonne.selectHomeloanplan(this.idPerson);
        }

        public int UpdatePerson()
        {
            PersonModel unepersonne = new PersonModel();
            return unepersonne.updatePerson(this);
        }

        public int IdPerson
        {
            get => this.idPerson;
            set => this.idPerson = value;
        }        

        
        public int IdRole
        {
            get => this.idRole;
            set => this.idRole = value;
        }
       	
        
        public string Name
        {
            get => this.name;
            set => this.name = value.ToUpper();
        }

        
        public string Fname
        {
            get => this.fname;
            set => this.fname = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower();
        }

        public DateTime Birth
        {
            get => this.birth;
            set => this.birth = value;
        }

        public string Mail
        {
            get => this.mail;
            set => this.mail = value;
        }

        public string Address
        {
            get => this.address;
            set => this.address = value;
        }

        public string City
        {
            get => this.city;
            set => this.city = value;
        }

        public int Postal
        {
            get => this.postal;
            set => this.postal = value;
        }

        public string User
        {
            get => this.user;
            set => this.user = value;
        }

        public string Password
        {
            get => this.password;
            set => this.password = value;
        }

        public DateTime CreationDate 
        {
            get => this.creationDate;
            set => this.creationDate = value;
        }

        public bool IsValid
        {
            get => this.isValid;
            set => this.isValid = value;
        }
    }
}