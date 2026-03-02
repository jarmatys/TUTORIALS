using ClassVsObject;

#region Tworzenie obiektów — konkretna instancja klasy

// Obiekt tworzymy słowem kluczowym "new" — dopiero wtedy pamięć jest przydzielana.
// Każdy obiekt to osobny egzemplarz klasy z własnym stanem.

// Tworzymy pierwszy obiekt klasy Car — "new" przydziela pamięć i wywołuje konstruktor
var myCar = new Car("BMW", 2022);

// Tworzymy drugi obiekt tej samej klasy — to zupełnie inny egzemplarz
var anotherCar = new Car("Audi", 2020);

// Oba obiekty są instancjami klasy Car, ale każdy ma własne dane
Console.WriteLine($"  Obiekt 1: {myCar.GetInfo()}");
Console.WriteLine($"  Obiekt 2: {anotherCar.GetInfo()}");

#endregion

#region Metody — zachowania obiektu

// Console.WriteLine("\n=== METODY ===\n");

// Wywołujemy metodę Start() na każdym obiekcie — każdy działa niezależnie
myCar.Start();
anotherCar.Start();

#endregion

#region Stan obiektu — każdy obiekt ma własny

// Jedziemy tylko pierwszym samochodem — drugi pozostaje bez zmian
myCar.Drive(150);
myCar.Drive(80);

// Sprawdzamy stan obu obiektów — tylko myCar ma zmieniony przebieg
Console.WriteLine($"  myCar:      {myCar.GetInfo()}");
Console.WriteLine($"  anotherCar: {anotherCar.GetInfo()}");

// Każdy obiekt ma własny stan — zmiana jednego nie wpływa na drugi.

#endregion

#region Referencje — zmienna to adres, nie kopia

// Zmienna "carCopy" NIE tworzy nowego obiektu — wskazuje na ten sam obiekt co "myCar"
var carCopy = myCar;

// Modyfikujemy obiekt przez zmienną "carCopy"
carCopy.Drive(200);

// "myCar" też widzi zmianę — bo obie zmienne wskazują na TEN SAM obiekt w pamięci
Console.WriteLine($"  carCopy: {carCopy.GetInfo()}");
Console.WriteLine($"  myCar:   {myCar.GetInfo()}");

// Sprawdzamy czy zmienne wskazują na ten sam obiekt
Console.WriteLine($"  carCopy == myCar? '{ReferenceEquals(carCopy, myCar)}'  (ta sama referencja — ten sam obiekt)");
Console.WriteLine($"  myCar == anotherCar? '{ReferenceEquals(myCar, anotherCar)}'  (różne referencje — różne obiekty)");

#endregion

# region Podsumowanie

// Klasa    = szablon / definicja / typ
// Obiekt   = konkretna instancja klasy, żyje w pamięci, ma własny stan
// new      = tworzy obiekt na stercie i zwraca referencję
// Zmienna  = przechowuje referencję (adres), nie sam obiekt

# endregion
