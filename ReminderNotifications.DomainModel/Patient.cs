using ReminderNotifications.DomainModel.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderNotifications.DomainModel
{
    public class Patient : IEntity
    {
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
