

using System;

public class Chocolate : Sweets {
    string taste;
    public Chocolate(string name, int weight, double price, string taste) : base(name, weight, price) {
        this.taste = taste;
    }

    public string getTaste() {
        return taste;
    }

    public void setTaste(string taste) {
        this.taste = taste;
    }
    public new string toString () {
        return "Шоколад " + base.toString() + ", со вкусом " + taste;
    }
}
