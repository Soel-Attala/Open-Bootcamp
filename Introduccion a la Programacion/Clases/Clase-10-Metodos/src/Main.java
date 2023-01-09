public class Main {
    public static void main(String[] args) {
       Coupe coupe = new Coupe();
       coupe.Acelerar(50);
       coupe.Frenar(25);
       EjecutarAcelerar(coupe);



    }
    public static void EjecutarAcelerar(Cars cars){
        cars.Acelerar(15);
    }
}

interface Cars{
    void Acelerar(int cuantaVelocidad);
    void Frenar(int cuantaVelocidad);
}
class Coupe implements Cars{
    public void Acelerar(int cuantaVelocidad){
        System.out.println("Coupe() --> Acelerar()");
    }
    public void Frenar(int cuantaVelocidad){

    }
}