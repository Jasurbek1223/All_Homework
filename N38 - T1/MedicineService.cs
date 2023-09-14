using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N38___T1;

public class MedicineService : IMedicineService
{
    string path = "filoe.path";

    public MedicineService()
    {
        string result = File.ReadAllText(path);
        if (string.IsNullOrEmpty(result))
        {
            File.WriteAllText(path, "[]");
        }
    }

    public void Create(Medicine medicine)
    {
        string source = File.ReadAllText(path);
        List<Medicine> medicines = JsonConvert.DeserializeObject<List<Medicine>>(source);

        Medicine existMedicine = medicines.FirstOrDefault(m => m.Id.Equals(medicine.Id));

        if(existMedicine != null)
        {
            throw new Exception("Medicine already exists");
        };

        int lastId = medicines.LastOrDefault().Id;

        medicine.Id = lastId + 1;

        medicines.Add(medicine);

        string json = JsonConvert.SerializeObject(medicines, Newtonsoft.Json.Formatting.Indented);

        File.WriteAllText(path, json);
    }


    public bool Delete(int id)
    {
        string source = File.ReadAllText(path);

        List<Medicine> medicines = JsonConvert.DeserializeObject<List<Medicine>>(source);

        Medicine existAirplene = medicines.FirstOrDefault(l => l.Id.Equals(id));
        if(existAirplene is null)
            return false;

        medicines.Remove(existAirplene);
        string json = JsonConvert.SerializeObject(medicines, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(path, json);
        return true;
      
    }

    public List<Medicine> GetAll()
    {
        string source = File.ReadAllText(path);

        List<Medicine> airplenes = JsonConvert.DeserializeObject<List<Medicine>>(source);

        return airplenes.ToList();
      
    }

    public Medicine GetById(int id)
    {
        string source = File.ReadAllText(path);

        List<Medicine> medicines = JsonConvert.DeserializeObject<List<Medicine>>(source);

        Medicine existMedicine = medicines.FirstOrDefault(m => m.Id.Equals(id));

        if(existMedicine is null)
            throw new Exception("Medicine is not found");
        
        return existMedicine;
    }

    public void Update(Medicine medicine)
    {
        string source = File.ReadAllText(path);

        List<Medicine> medicines = JsonConvert.DeserializeObject<List<Medicine>>(source);

        Medicine existMedicine = medicines.FirstOrDefault(l => l.Id.Equals(medicine.Id));

        if (existMedicine is null)
            throw new Exception("Medicine is not found");


        existMedicine.Id = medicine.Id;
        existMedicine.Price = medicine.Price;
        existMedicine.UpdatedAt = medicine.UpdatedAt;
        existMedicine.ExpirationDate = medicine.ExpirationDate;
        existMedicine.Description = medicine.Description;
        existMedicine.LeftCount = medicine.LeftCount;
        existMedicine.Name = medicine.Name;

        string json = JsonConvert.SerializeObject(medicines, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(path, json);
    }
}
