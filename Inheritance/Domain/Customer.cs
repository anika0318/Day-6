using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Domain
{
     class Customer
    {
        private string _id;
        private string _name;
        private string _location;


        public Customer(string id,string name):this(id,name,"Noida")//we are envoking the constructor
        {

        }
        public Customer(string id,string name,string location)
        {
            _id = id;
            _name = name;
            this._location = location;//showing instance _location is changed as per the location
        }public string id
        {
            get { return _id; }
        }
        public string name
        {
            get { return _name; }
        }
        public string location
        {
            get { return _location; }
        }
        public override string ToString()
        {
            return $"id: {_id} , name: {_name} , location:{_location} ";
        }
        public override bool Equals(object second)
        {
            Customer c=second as Customer;
            return(this._id==c._id);
        }
    }
}
