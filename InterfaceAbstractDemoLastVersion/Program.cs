using InterfaceAbstractDemoLastVersion.Abstract;
using InterfaceAbstractDemoLastVersion.Adapters;
using InterfaceAbstractDemoLastVersion.Concrete;
using InterfaceAbstractDemoLastVersion.Entities;

namespace InterfaceAbstractDemoLastVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1985,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" });
        }
    }
}
