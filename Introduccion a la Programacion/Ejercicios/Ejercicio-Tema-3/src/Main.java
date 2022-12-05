public class Main {
    public static void main(String[] args) {
        Car myCar = new Car();
        myCar.AddDoors();
        System.out.println(myCar.doors);

        var result = suma(10,20,5);
        System.out.println(result);
    }

    public static int suma(int a, int b, int c){
       return a+b+c;
    }



}
class Car{
    public int doors = 3;
    public void AddDoors(){
        this.doors++;
    }
}