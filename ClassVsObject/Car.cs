// --- KLASA — szablon, definicja typu ---
// Klasa to tylko opis: jakie dane przechowuje obiekt i co potrafi robić.
// Sama w sobie nie zajmuje miejsca w pamięci — to jak pusty formularz.

namespace ClassVsObject;

public class Car
{
    #region Konstruktor — wywoływany przy tworzeniu obiektu przez "new"

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
        _mileage = 0;
    }

    #endregion

    #region Właściwości — kontrolowany dostęp do danych obiektu

    // public vs private vs protected vs internal
    
    private int _mileage;
    
    public string Brand { get; set; }
    public int Year { get; set; }

    #endregion

    #region Metoda — zachowanie obiektu, co potrafi zrobić

    public void Start()
    {
        Console.WriteLine($"  {Brand} ({Year}) uruchamia silnik.");
    }

    #endregion

    #region Metoda zmieniająca stan obiektu — przebieg rośnie

    public void Drive(int km)
    {
        _mileage += km;
        Console.WriteLine($"  {Brand} przejechał {km} km. Łączny przebieg: {_mileage} km.");
    }

    #endregion

    #region Metoda zwracająca informacje o obiekcie

    public string GetInfo()
    {
        return $"{Brand} ({Year}), przebieg: {_mileage} km";
    }

    #endregion
}
