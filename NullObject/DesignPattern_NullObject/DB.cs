namespace DesignPattern_NullObject
{
    public class DB
    {
        public static EmployeeAbstract GetEmployee()
        {
            return EmployeeAbstract.NULL;
        }
    }
}
