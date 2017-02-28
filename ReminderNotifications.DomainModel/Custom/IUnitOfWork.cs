namespace ReminderNotifications.DomainModel.Custom

{

    public interface IUnitOfWork
    {
        IRepository<Patient> Patients { get; }
        //IRepository<Employee> Employees{ get; }
        void Commit();
    }

}