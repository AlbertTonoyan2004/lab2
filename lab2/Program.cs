using System;
/// <summary>
/// задача 1
/// </summary>
class Pupil // класс ученик 
{
    public virtual void Study() // метод void Study()
    {
        Console.WriteLine("Ученик учится");
    }

    public virtual void Read() // метод void Read()
    {
        Console.WriteLine("Ученик читает");
    }

    public virtual void Write() // метод void Write()
    {
        Console.WriteLine("Ученик пишет");
    }

    public virtual void Relax() // метод void Relax()
    {
        Console.WriteLine("Ученик отдыхает");
    }
}

class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отличник учится");
    }

    public override void Read()
    {
        Console.WriteLine("Отличник читает");
    }

    public override void Write()
    {
        Console.WriteLine("Отличник пишет");
    }

    public override void Relax()
    {
        Console.WriteLine("Отличник отдыхает");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хорошист учится");
    }

    public override void Read()
    {
        Console.WriteLine("Хорошист читает");
    }

    public override void Write()
    {
        Console.WriteLine("Хорошист пишет");
    }

    public override void Relax()
    {
        Console.WriteLine("Хорошист отдыхает");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Двоечник учится");
    }

    public override void Read()
    {
        Console.WriteLine("Двоечник читает");
    }

    public override void Write()
    {
        Console.WriteLine("Двоечник пишет");
    }

    public override void Relax()
    {
        Console.WriteLine("Двоечник отдыхает");
    }
}

class ClassRoom // класс аудитория
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length > 4)
        {
            Console.WriteLine("Ошибка: в классе не может быть более 4 учеников. Будут выбраны первые 4 ученика.");
            Array.Resize(ref pupils, 4);
        }

        this.pupils = pupils;
    }

    public void PrintClassInfo()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine("Ученик " + (i + 1) + ":");
            pupils[i].Study();
            pupils[i].Read();
            pupils[i].Write();
            pupils[i].Relax();
            Console.WriteLine();
        }
    }
}

/// <summary>
/// конец задачи 1
/// </summary




/// Задача 2


class Vehicle
{
    private double[] coordinates;
    private double price;
    private double speed;
    private int year;

    public Vehicle(double[] coordinates, double price, double speed, int year)
    {
        this.coordinates = coordinates;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Coordinates: {string.Join(", ", coordinates)}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Speed: {speed} km/h");
        Console.WriteLine($"Year: {year}");
    }
}

class Plane : Vehicle
{
    private double altitude;
    private int passengerCount;

    public Plane(double[] coordinates, double price, double speed, int year, double altitude, int passengerCount)
        : base(coordinates, price, speed, year)
    {
        this.altitude = altitude;
        this.passengerCount = passengerCount;
    }

    public new void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Altitude: {altitude} km");
        Console.WriteLine($"Passenger count: {passengerCount}");
    }
}

class Car : Vehicle
{
    public Car(double[] coordinates, double price, double speed, int year)
        : base(coordinates, price, speed, year)
    {
    }
}

class Ship : Vehicle
{
    private int passengerCount;
    private string homePort;

    public Ship(double[] coordinates, double price, double speed, int year, int passengerCount, string homePort)
        : base(coordinates, price, speed, year)
    {
        this.passengerCount = passengerCount;
        this.homePort = homePort;
    }

    public new void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Passenger count: {passengerCount}");
        Console.WriteLine($"Home port: {homePort}");
    }
}

/// <summary>
/// Конец задачи 2
/// </summary>






/// Задача 3


class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}
















class Program
{
    static void Main(string[] args)
    {
        Pupil pupil1 = new ExcellentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new ExcellentPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.PrintClassInfo();
        
        
        Console.WriteLine("/////////////////// ЗАДАЧА2 ///////////////////");
        Console.WriteLine();
        
        
        
        double[] vehicleCoordinates = { 0, 0 };

        Vehicle vehicle = new Vehicle(vehicleCoordinates, 50000, 200, 2020);
        Console.WriteLine("Vehicle Information:");
        vehicle.PrintInfo();

        Console.WriteLine();

        double[] planeCoordinates = { 100, 200, 300 };
        Plane plane = new Plane(planeCoordinates, 1000000, 900, 2015, 10000, 200);
        Console.WriteLine("Plane Information:");
        plane.PrintInfo();

        Console.WriteLine();

        double[] carCoordinates = { -50, 100 };
        Car car = new Car(carCoordinates, 25000, 180, 2022);
        Console.WriteLine("Car Information:");
        car.PrintInfo();

        Console.WriteLine();

        double[] shipCoordinates = { -300, -500 };
        Ship ship = new Ship(shipCoordinates, 800000, 40, 2018, 1000, "New York");
        Console.WriteLine("Ship Information:");
        ship.PrintInfo();
        
        
        Console.WriteLine("/////////////////// ЗАДАЧА3 ///////////////////");
        Console.WriteLine();
        
        Console.WriteLine("Введите номер ключа доступа (pro/exp):");
        string key = Console.ReadLine();

        DocumentWorker documentWorker;

        if (key == "pro")
        {
            documentWorker = new ProDocumentWorker();
        }
        else if (key == "exp")
        {
            documentWorker = new ExpertDocumentWorker();
        }
        else
        {
            documentWorker = new DocumentWorker();
        }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();

        Console.ReadLine();
        
    }
}

