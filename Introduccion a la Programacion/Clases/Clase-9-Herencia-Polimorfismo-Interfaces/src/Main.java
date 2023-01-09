public class Main {
    public static void main(String[] args) {
        Coche coche = new Coche();
        coche.velocidadMaxima = 10;
        coche.matricula = "mgp250";
        coche.tipoGasolina = "Nafta";
        Moto moto = new Moto();


        coche.setSonido("BRUUMMM");
        moto.setSonido("Brummm");
        System.out.println(coche.getSonido());
        System.out.println(moto.getSonido());
        coche.diHola();

    }
}
//las clases abstractas no pueden ser instanciadas
abstract class Vehiculo{
    int velocidadMaxima;
    String tipoGasolina;
    String matricula;
    String sonido;


    public void diHola(){
        System.out.println("Hola");
    }
/*
    public boolean compruebaMatricula(String matricula){
        if(matricula == "XXX") {
            return true;
        }
            return false;
    }


    //creamos un constructor
    public Vehiculo(){
        System.out.println("Estoy en el constructor de Vehiculo");
    }
    /*
    public String getSonido(){
        return this.sonido;
    }

    public void setSonido(String sonido){
        this.sonido = sonido;
    }
*/

    abstract public String getSonido();
    abstract public void setSonido(String sonido);
}


//en otros lenguajes se usa inherits en lugar de extends
// usamos la final class para que no se pueda heredar nada de coche.
class Coche extends Vehiculo{
    public String getSonido(){
        return "soy un super sonido: " + this.sonido;
    }
    public void setSonido(String sonido){
        this.sonido = sonido;
    }

    /*
    public void diHola(){
        System.out.println("soy un coche");
    }

     */

}
class Moto extends Vehiculo{
    public String getSonido(){
       return "soy un sonido de moto: " + this.sonido;

    }
    public void setSonido(String sonido){
        this.sonido = sonido;
    }


}

//jerarquia de clases:
/*
clase A
    CLASE B HEREDA DE A
        CLASE 1 HEREDA DE B
        CLASE 2 HEREDA DE B
    CLASE C HEREDA DE A
        CLASE PERRO HEREDA DE C
        CLASE GATO HEREDA DE C
    CLASE D HEREDA DE A
        CLASE COCHE HEREDA DE D
        CLASE MOTO HEREDA DE D
 */


//POLIMORFISMO
//las clases hijas implementan los mismos metodos pero hacen distintas cosas.
//basicamente tomamos la funcion de la clase padre, la heredamos y cambiamos su uso.
//si borramos la funcion o la comentamos en la clase hijo. usara la funcion de la clase padre.


//INTERFASE
// es una forma de expresar o indicar que cuando implementamos una clase debeemos utilizar los metodos
//definidos en la interfaz.


//declaremos una interfaz

interface Autitos{
  void Acelerar(int cuantaVelocidad);
  void Frenar(int cuantaVelocidad);
}

class Hotwheels implements Autitos{
    public void Acelerar(int cuantaVelocidad){

    }
    public void Frenar(int cuantaVelocidad){

    }
}
