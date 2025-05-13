using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace Contactos
{
   class AddressBook:SerializableData
   {
       public ArrayList Item = new ArrayList();
       public Address Address()
       {
            Address newAdress = new Address();
           Item.Add(newAdress);
           return newAdress;

        }
    }
}
