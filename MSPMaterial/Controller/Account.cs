using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPMaterial.Controller
{
    class Account
    {
        private static Account currentUser;
       
        public static void SetUserInfo(int id, string name, string type)
        {
            currentUser = null;
            currentUser = new Account(id,name,type);
        }

        private Account(int id , string name, string type)
        {
            this.id = id;
            this.user = name;
            this.type = type;
        }

        private int id;
        public int ID
        {
            set { this.id = value; }
            get { return this.id; }
        }

        private string type;
        public string Type
        {
            set { this.type = value; }
            get { return this.type; }
        }

        private string user;
        public string User
        {
            set { this.user = value; }
            get { return this.user; }
        }

        public static Account CurrentUser
        {
            get
            { return currentUser; }
        }
    }
}
