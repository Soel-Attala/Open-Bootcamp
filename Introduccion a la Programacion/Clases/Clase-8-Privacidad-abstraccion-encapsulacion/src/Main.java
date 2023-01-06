public class Main {
    public static void main(String[] args) {
        // definiremos cuando usamos variables publicas, privadas y protegidas.
        Vehiculo coche = new Vehiculo();
        coche.setTipo("Fiat Uno");
        System.out.println(coche.tipo);
        //String tipo = coche.getTipo();
        //System.out.println(tipo);
        Vehiculo moto = new Vehiculo();
        moto.setTipo("Honda");
        System.out.println(moto.tipo);



//podemos accceder al tipo vehiculo por que es de clase publico, ahora, si lo ponemos privado no nos dejara acceder.

    }
}

class Vehiculo {
   String tipo;
   public void setTipo(String tipo){
       this.tipo = tipo;
   }
   public String getTipo(){
       return this.tipo;
   }



}