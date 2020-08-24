using System;
using System.Collections;
/**
* @author Sayapin S.V.
*/
public class MainNew {
    public static void main() {
        addSweets();
    }
    public static void addSweets() {
        bool flag = false;
        double sumPrice =0, sumWeight =0;
        ArrayList sweets = new ArrayList();
       // ArrayList <Sweets> sweets = new ArrayList();
        while (!flag) {
            Console.Out.WriteLine("Нажмите соответствующую цифру, где: ");
            Console.Out.WriteLine("'1' - Шоколад \"Max Fun\"");
            Console.Out.WriteLine("'2' - Шоколад \"Ritter Sport\"");
            Console.Out.WriteLine("'3' - Шоколад \"Воздушный\"");
            Console.Out.WriteLine("'4' - Мармелад \"Бон-пари\"");
            Console.Out.WriteLine("'5' - Конфеты \"Коровка\"");
            Console.Out.WriteLine("'6' - Конфеты \"Старт\"");
            Console.Out.WriteLine("'7' - Конфеты \"Мишка косолапый\"");
            Console.Out.WriteLine("'8' - Конфеты \"M&Ms\"");
            Console.Out.WriteLine("'0' - Закончить");
            int choice = int.Parse(Console.In.ReadLine());
            int quantity = 0;
            switch (choice) {
                case (1):
                    Chocolate chMaxFun = new Chocolate(" \"Max Fun\"", 300, 70, "Апельсин");
                    sweets.Add(chMaxFun);
                    Console.Out.WriteLine("Введите количество: ");
                    quantity = int.Parse(Console.In.ReadLine());
                    sumPrice += quantity * chMaxFun.getPrice();
                    sumWeight += quantity * chMaxFun.getWeight();
                    Console.Out.WriteLine("Шоколад \"Max Fun\" добавлен в подарок");
                    break;
                case (2):
                    Chocolate chRitSp = new Chocolate(" \"Ritter Sport\"", 400, 100, "Лесной орех");
                    sweets.Add(chRitSp);
                    Console.Out.WriteLine("Введите количество: ");
                    quantity = int.Parse(Console.In.ReadLine());
                    sumPrice += quantity * chRitSp.getPrice();
                    sumWeight += quantity * chRitSp.getWeight();
                    Console.Out.WriteLine("Шоколад \"Ritter Sport\" добавлен в подарок");
                    break;
                case (3):
                    Chocolate chVozd = new Chocolate(" \"Воздушный\"", 125, 230, "Белый Пористый");
                    sweets.Add(chVozd);
                    Console.Out.WriteLine("Введите количество: ");
                    quantity = int.Parse(Console.In.ReadLine());
                    sumPrice += quantity * chVozd.getPrice();
                    sumWeight += quantity * chVozd.getWeight();
                    Console.Out.WriteLine("Шоколад \"Воздушный\" добавлен в подарок");
                    break;
                case (4):
                    Jellybean jellyBon = new Jellybean(" \"Бон-пари\"", 250, 85, "Разноцветный");
                    sweets.Add(jellyBon);
                    Console.Out.WriteLine("Введите количество: ");
                    quantity = int.Parse(Console.In.ReadLine());
                    sumPrice += quantity * jellyBon.getPrice();
                    sumWeight += quantity * jellyBon.getWeight();
                    Console.Out.WriteLine("Мармелад \"Бон-пари\" добавлен в подарок");
                    break;
                case (5):
                    Candy candyCow = new Candy (" \"Коровка\"", 100, 150, "С маком");
                    sweets.Add(candyCow);
                    Console.Out.WriteLine("Введите количество: ");
                    quantity = int.Parse(Console.In.ReadLine());
                    sumPrice += quantity * candyCow.getPrice();
                    sumWeight += quantity * candyCow.getWeight();
                    Console.Out.WriteLine("Конфеты \"Коровка\" добавлен в подарок");
                    break;
                case (6):
                    Candy candyStart = new Candy (" \"Старт\"", 120, 300, "Со сгущенным молоком");
                    sweets.Add(candyStart);
                    Console.Out.WriteLine("Введите количество: ");
                    quantity = int.Parse(Console.In.ReadLine());
                    sumPrice += quantity * candyStart.getPrice();
                    sumWeight += quantity * candyStart.getWeight();
                    Console.Out.WriteLine("Конфеты \"Старт\" добавлен в подарок");
                    break;
                case (7):
                    Candy candyBear = new Candy (" \"Мишка косолапый\"", 400, 550, "темный");
                    sweets.Add(candyBear);
                    Console.Out.WriteLine("Введите количество: ");
                    quantity = int.Parse(Console.In.ReadLine());
                    sumPrice += quantity * candyBear.getPrice();
                    sumWeight += quantity * candyBear.getWeight();
                    Console.Out.WriteLine("Конфеты \"Мишка косолапый\" добавлен в подарок");
                    break;
                case (8):
                    Candy candyMMs = new Candy (" \"M&Ms\"", 350, 250, "C орехом");
                    sweets.Add(candyMMs);
                    Console.Out.WriteLine("Введите количество: ");
                    quantity = int.Parse(Console.In.ReadLine());
                    sumPrice += quantity * candyMMs.getPrice();
                    sumWeight += quantity * candyMMs.getWeight();
                    Console.Out.WriteLine("Конфеты \"M&Ms\" добавлен в подарок");
                    break;
                case (0): flag = true;
                    break;
            }
        }

        int i = 0;
        Console.Out.WriteLine("\nПодарок состоит из:");
        foreach (Sweets sweet in sweets) {
            i++;
            Console.Out.WriteLine(i + ". " + sweet.toString());
        }
        Console.Out.WriteLine("\nВес подарка:"+ sumWeight+" гр.\nОбщая цена подарка: "+sumPrice+" руб." );

    }
}

