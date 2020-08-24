

public class Candy : Sweets {

    string type; 
    public Candy(string name, int weight, double price, string type): base(name, weight, price){
        this.type = type;
    }

    public string getType() {
        return type;
    }

    public void setType(string type) {
        this.type = type;
    }

    public new string toString () {
        return "Конфеты " + base.toString() + ", вид: " + type;
    }
}
