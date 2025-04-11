/*9. ------------------ - Нова пошта
Створити програму для імітації роботи Нової пошти. У програмі передбачити наступні сервіси
	Вивід послуг пошти
	Доповнення(редагування, видалення ) послуги
    Прийом замовлення про пересилку товару(друк квитанції, прийом товару, оплата, реєстрація про замовлення у базі) 
	Відмітка про виконання замовлення(доставку товарів)
	Зберігати та завантажувати у(з) файлі(у) замовлені послуги
	Виконані послуги зберігати у іншому файлі
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("==========Welcome to our poshta==========="!);
Console.WriteLine("/t1.Posulku:");
Console.WriteLine("1. Otrumatu");
Console.WriteLine("2. Vidpravutu");
Console.WriteLine("3. Pokazatu vsi posulku");
Console.WriteLine("4. Dryk kvutanwzii");
Console.WriteLine("5. Oplata");
Console.WriteLine("6. Vidstejutu");
Console.WriteLine("7. Save to file");
Console.WriteLine("8. Load from file");

Console.Write("Your choice: ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        var posulku = new Posulku();

        Console.Write("Enter Posulku sender phone number:");
        posulku.senderPhone = Console.ReadLine();

        Console.Write("Enter Posulku weight:");
        posulku.weight = double.Parse(Console.ReadLine());

        Console.Write("Enter Posulku size:");
        posulku.size = int.Parse(Console.ReadLine());

        Console.Write("Enter Posulku adress:");
        posulku.adress = Console.ReadLine();

        Console.Write("Enter Posulku reciver:");
        posulku.reciver = Console.ReadLine();
        break;
    
    case 4:
       //...
       break;
}

public class Posulku
{
    public int size;
    public double weight;
    public string adress;
    public string reciver;
    public string senderPhone;
}
