public class Main {
    public static void main(String[] args) {

        //Clase-7 - Introduccion a la programacion orientada a objetos

        //la programacion orientada a objetos nos permite tener un codigo limpio y segmentado.
        // Que es un objeto?
        // es una entidad que pretendemos que represente a algo del mundo real
        // los objetos tienen propiedaddes, tienen metodos(por ejemplo un auto, tiene metodo de abrir puertas, cerrarlas)
        // los objetos los creamos mediante clases, esas clases tienen propiedades que son variables.

        Coche coche = new Coche(2,90);

        coche.acelerar();
        System.out.println(coche.velocidadActual);
        System.out.println(coche.numeroDePuertas);
        System.out.println(coche.velocidadMaxima);

    }

}
//Ejemplo 1
class Coche{
    int numeroDePuertas;
    int velocidadMaxima;
    float velocidadActual;

    //creamos un cosntructor:
    //un constructor se ejecuta cuando instanciamos la clase

    public Coche(int numeroDePuertas, int velocidadMaxima){
        this.numeroDePuertas = numeroDePuertas;
        this.velocidadMaxima = velocidadMaxima;
    }

    public void acelerar(){
        velocidadActual += 15;
    };

    //como podemos tener entonces un objeto de clase coche?
    // bueno, debemos instanciarlo. Significa que creamos una zona en la memoria con una variable.
    // y esa zona tendra las mismas propiedades que la clase coche. es decir creamos un objeto de clase coche





}