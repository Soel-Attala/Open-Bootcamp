public class Main {
    public static void main(String[] args) {
        Persona persona1 = new Persona();
        persona1.setNombre("Soel Antonio Attala");
        persona1.setEdad(26);
        persona1.setTelefono(154306032);
        String name = persona1.getNombre();
        System.out.println(name);
        int age = persona1.getEdad();
        System.out.println(age);
        int phone = persona1.getTelefono();
        System.out.println(phone);

    }

}
class Persona{
    //variables
private int edad;
private int telefono;
private String nombre;

//Setter

public void setEdad(int edad){
this.edad = edad;
}
public void setTelefono(int telefono){
    this.telefono = telefono;
}
public void setNombre(String nombre){
    this.nombre = nombre;
}

//getter
public int getEdad(){
    return this.edad;
}
public int getTelefono(){
    return this.telefono;
}
public String getNombre(){
    return this.nombre;
}



}