namespace rpg;

class Program
{
    static void Main(string[] args)
    {
        var pepa = new PlayerCharacter("Pepa", 100, new Position(1, 2, 3));
    }
}

struct Position
{
    public int x;
    public int y;
    public int z;

    public Position (int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}


abstract class Character
{
    public string name;
    public int maxHealth;
    public int currentHealth;
    public Inventory inventory;
    public Position currentPosition;

    public Character (string name, int maxHealth, Position position)
    {
        this.name = name;
        this.maxHealth = this.currentHealth = maxHealth;
        this.currentPosition = position;
    }

    public virtual void heal(int gain)
    {
        this.currentHealth += gain;
    }
}

class NonPlayableCharacter : Character 
{
    public int monsterType;
    public NonPlayableCharacter(string name, int maxHealth, Position position, int monsterType) : base(name, maxHealth, position)
    {
        this.monsterType = monsterType;
    }
    public override void heal(int gain)
    {
        base.heal(gain);
        base.heal(gain);
    }
}

class PlayerCharacter : Character
{
    public PlayerCharacter(string name, int maxHealth, Position position) : base(name, maxHealth, position)
    {
        
    }
}

class Inventory
{
    private List<Item> items;

}

abstract class Item
{
    public int weight;
    public float price;
    public string name;

}

class Weapon : Item
{
    public int damage;
}

class ItemOnGround
{
    public Item item;
    public Position position;
}

class Chest
{
    public Inventory inventory;
    public Position position;
}