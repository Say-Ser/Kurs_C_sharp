

public abstract class Sweets {
    string name;
    int weight;
    double price;

    public Sweets(string name, int weight, double price) {
        this.name = name;
        this.weight = weight;
        this.price = price;
    }

    public string getName() {
        return name;
    }

    public void setName(string name) {
        this.name = name;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }
  
    public string toString () {
        return name + ": " + weight + " гр, " + price + " руб";
    }

}
