namespace N38___T1;

internal interface IMedicineService
{
    void Create(Medicine medicine);
    void Update(Medicine medicine);
    bool Delete(int id);
    List<Medicine> GetAll();
    Medicine GetById(int id);
}
