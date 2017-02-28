using System;
using System.Configuration;
using System.Data.Objects;
using ReminderNotifications.DomainModel;
using ReminderNotifications.DomainModel.Custom;

namespace ReminderNotifications.DAL.Custom
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

        public IRepository<Patient> Patients{
            get {
                if (_patients == null) {
                    _patients = new SqlRepository<Patient>(_context);
                }
                return _patients;
            }
        }

        //public IRepository<TimeCard> TimeCards {
        //    get {
        //        if (_timeCards == null) {
        //            _timeCards = new SqlRepository<TimeCard>(_context);
        //        }
        //        return _timeCards;
        //    }
        //}

        public void Commit() {
            _context.SaveChanges();
        }

        SqlRepository<Patient> _patients = null;
        //SqlRepository<TimeCard> _timeCards = null;
        readonly ObjectContext _context;
        const string ConnectionStringName = "EmployeeDataModelContainer";
    }
}