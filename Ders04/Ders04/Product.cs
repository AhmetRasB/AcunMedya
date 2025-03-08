namespace Ders04;

public class Product:BaseEntity<Guid>
{
    private string _productName;
    // private sadece kendi sınıfı
    // public heryerden
    // internal aynı proje içerisinden
    // protected de sadece kalıtım aldığı sınıf tarafından erişilebilir.


    // property varlık özelliğidir.
    // varlığımızın (Entitymizin) Özelliği, kolonu
    public string Name
    {
        get { return _productName;}
        set
        {
            if (!string.IsNullOrEmpty(value)) // değer boş değilse
            {
                _productName = value;
            }
            else
            {
                Console.WriteLine("Name cannot be empty!");
            }
        } }
    public double UnitPrice { get; set; }

    public Product()
    {
        Id = Guid.NewGuid();
    }
    // { get; set; } get veriyi okur, set veriyi yazar
}