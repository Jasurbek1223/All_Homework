using N25_HT1.Model;

namespace N25_HT1.Interface;

public interface IOrderServise
{
    bool Order(int id, decimal debitCardBalance);
    bool Order(string orderFilterModel, decimal debitCardBalance);
}
