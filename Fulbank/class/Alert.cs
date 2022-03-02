using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank
{
    class Alert
    {

        private int id;
        private string typeAlert;
        private DateTime dateAlert;
        private string content;
        private bool isValid;

        public Alert(string aTypeAlert, DateTime aDateAlert, string aContent)
        {
            this.typeAlert = aTypeAlert;
            this.dateAlert = aDateAlert;
            this.content = aContent;
            this.isValid = false;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }

        public string TypeAlert
        {
            get => this.typeAlert;
            set => this.typeAlert = value;
        }

        public DateTime DateAlert
        {
            get => this.dateAlert;
            set => this.dateAlert = value;
        }

        public string Content
        {
            get => this.content;
            set => this.content = value;
        }

        public bool IsValid
        {
            get => this.isValid;
            set => this.isValid = value;
        }


    }
}
