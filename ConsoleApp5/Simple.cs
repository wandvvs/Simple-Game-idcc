class Car
{
    public string name;
    public int id;
    public int date;
    
    public Car(string name, int id, int date)
    {
        this.name = name;
        this.id = id;
        this.date = date;
    }
    public void Print() => Console.WriteLine($"Имя машины: {name}\nСпециальный номер машины: {id}\nДата выпуска машины: {date}\n");
    
}
class Plane
{
    public string name;
    public int health;
    public int damage;
    

    public Plane(string name, int health, int damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
    }

    public void Shot()
    {
        Console.WriteLine($"Самолет {name} нанёс {damage} урона.");
    }

    public void War()
    {
        int lastHP = health - damage;
        
        if(damage > 1800)
        {
            Console.WriteLine($"КРИТИЧЕСКИЙ УРОН {damage}. Вы убили врага!");
            
        }
        else if(damage < 1800)
        {
            if (lastHP > 0)
            {
                Console.WriteLine($"Вы выстрелили на {damage} урона. У врага осталось {lastHP}");
            }
            else if (lastHP < 0)
            {
                Console.WriteLine($"Вы убили врага! Ваш урон был {damage}");
            }
        }
    }
}
