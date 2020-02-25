using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PersonDal
    {
        private PersonDbEntities pd;
        public PersonDal()
        {
             pd = new PersonDbEntities();
        }
        public Custom AddUser(UserBusinessobject obj)
        {
            Custom c = new Custom();
            Person m = new Person() {
                Name = m.Name,
                Email=m.Email,
                PhoneNumber=m.PhoneNumber,
                Address=m.Address
                 
            };
            pd.People.Add(m);
            int val=pd.SaveChanges();
            if(val>0)
            {
                c.CustomMessage = "Success";
                c.CustomMessageNumber = val;

            }
            else
            {
                c.CustomMessage = "Success";
                c.CustomMessageNumber = val;
            }
        }
    }
}
