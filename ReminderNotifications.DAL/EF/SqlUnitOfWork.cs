using System.Linq;
using System.Configuration;
using System.Data.Objects;
using ReminderNotifications.DomainModel;
using ReminderNotifications.DomainModel.EF;

namespace ReminderNotifications.DAL.EF
{

    public class SqlUnitOfWork : IUnitOfWork {
        public SqlUnitOfWork() {
            var connectionString =
                ConfigurationManager
                    .ConnectionStrings[ConnectionStringName]
                    .ConnectionString;

            _context = new ObjectContext(connectionString);
            _context.ContextOptions.LazyLoadingEnabled = true;
        }

        public IObjectSet<Patient> Patients {
            get { return _context.CreateObjectSet<Patient>(); }
        }

        //public IObjectSet<TimeCard> TimeCards {
        //    get { return _context.CreateObjectSet<TimeCard>(); }
        //}

        public void Commit() {
            _context.SaveChanges();
        }

        readonly ObjectContext _context;
        const string ConnectionStringName = "EmployeeDataModelContainer";
    }

}