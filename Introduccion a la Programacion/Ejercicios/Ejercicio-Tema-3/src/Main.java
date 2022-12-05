public class Main {
    public static void main(String[] args) {
        Car myCar = new Car();
        myCar.AddDoors();
        System.out.println(myCar.doors);
    }



}
class Car{
    public int doors = 3;
    public void AddDoors(){
        this.doors++;
    }
}