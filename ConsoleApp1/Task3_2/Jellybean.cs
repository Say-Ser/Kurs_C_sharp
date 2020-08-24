
public class Jellybean : Sweets{

    string color;
    public Jellybean(string name, int weight, double price, string color): base(name, weight, price) {
        this.color = color;
    }

    public string getColor() {
        return color;
    }

    public void setColor(string color) {
        this.color = color;
    }
    public new string toString () {
        return "Мармелад " + base.toString() + ", цвет: " + color;
    }
}
