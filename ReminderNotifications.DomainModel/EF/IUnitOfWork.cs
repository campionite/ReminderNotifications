using System.Data.Objects;

namespace ReminderNotifications.DomainModel.EF
{
    public interface IUnitOfWork
    {
        IObjectSet<Patient> Patients{ get; }
        //IObjectSet<TimeCard> TimeCards { get; }
        void Commit();
    }
}