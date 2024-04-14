using System.Runtime.CompilerServices;

Console.WriteLine("Информация о первом объекте");
Phone phone1 = new Phone();

Console.WriteLine("Информация о втором объекте");
Phone phone2 = new Phone("+7888545693", "Samsung");

Console.WriteLine("Информация о третьем объекте");
Phone phone3 = new Phone("+78856941236", "samsung", 500.0);


phone1.receiveCall("Иван");
phone2.receiveCall("Юрий", phone2.getNumber());

phone3.sendMessage(phone3.getNumber(), phone2.getNumber());
class Phone
{
    string number;
    string model;
    double weight;

    public Phone()
    {
        this.number = "+79859390444";
        this.model = "iPhone";
        this.weight = 200;
        Console.WriteLine($"Номер телефона {number},\nМодель телефона {model},\nВес телефона: {weight}");
    }
    public Phone(string _number, string _model)
    {
        this.number = _number;
        this.model = _model;
        Console.WriteLine($"Номер телефона {number},\nМодель телефона {model}");
    }
    public string getNumber()
    {
        return number;
    }
    public Phone(string _num, string _mod, double _weight) : this(_num, _mod)
    {
        _weight = weight;
        Console.WriteLine($"Вес телефона: {weight}");
    }
    public void receiveCall(string name)
    {
        Console.WriteLine($"Звонит {name}");
    }


    public void receiveCall(string name, string numberCall)
    {
        Console.WriteLine($"Звонит {name}, Номер телефона: {numberCall}");
    }

    public void sendMessage(string _phNumber1, string _phNumber2)
    {
        Console.WriteLine($"Сообщение будет отправлено на номера: {_phNumber1}, {_phNumber2} ");
    }
}