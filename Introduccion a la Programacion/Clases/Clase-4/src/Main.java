public class Main {

    //CLASE 4.1 IF AND ELSE
    public static void main(String[] args) {
       String estacion = "otoño";
       if(estacion == "primavera"){
           System.out.println("es primavera");
       } else if (estacion == "verano") {
           System.out.println("es verano");
       }else {
           System.out.println("es otra estacion...");
       }

        //CLASE 4.2 CICLOS WHILE Y DO WHILE

        int contador = 10;
       //en el bucle se produce una iteracion, quiere decir que cuando termina de recorrer,
        //vuelve a revisar el codigo arriba

        System.out.println("ciclo while");

        while (contador > 10){
            System.out.println(contador);
            contador = contador -1; //es lo mismo que contador--;
            // para restar numeros mayores a uno contador -= 5; que es lo mismo que contador = contador -5;
        }

        //bucle do while - se representa como haz esto mientras la condicion se cumpla
        // por ejemplo, resta uno a contador si es mayor a 10;
        //diferencia con el while, es que el while primero analiza y luego ejecuta las acciones.
        //el do while ejecuta primero y luego analiza.

        System.out.println("ciclo do while");

        do{
            System.out.println(contador);
            contador = contador -1;
        } while (contador > 10);


        //CLASE 4.3 CICLO FOR

        // bucle For, generalmente tiene 3 partes:
        // 1. declaracion o inicializacion
        // 2. comparacion
        // 3. accion
        // For ( initiation; comparison; action)
        // For(...; counter > 10; counter = counter - 1); Es lo mismo que arriba a modo de ejemplo

        System.out.println("Ciclo For");

        for(int counter = 1; counter <=10; counter = counter +1){
            System.out.println(counter);
        }

        System.out.println("While = For");

        //ese for seria igual que lo siguiente:
        int counter = 1;
        while(counter<=10){
            System.out.println(counter);
            counter = counter +1; //es lo mismo counter--;
        }

        //generalmente el for se utiliza para recorrer arrays o tipos de datos compuestos.
        //el while podemos usarlo simplemente para verificar comparaciones V o F.
        //Ejemplo while: si la temperatura es menor a 15 grados entonces ponerse abrigo.
        // temp < 15; usar abrigo


        //Ejemplo for con un array
        System.out.println("Recorremos array values");
        int values[] = {10, 20, 30, 40, 50};
        for(int i = 0; i<values.length; i++){
            System.out.println(values[i] + " CUMPLE");
        }
        System.out.println("Finalizado, ya no cumple");

        //funcionamiento del for
        // 0<5 CUMPLE
        // 1<5 CUMPLE
        // 2<5 CUMPLE
        // 3<5 CUMPLE
        // 4<5 CUMPLE
        // 5<5 ESTE NO CUMPLE


        //CLASE 4.4 SWITCH
        //FUNCIONAMIENTO

        // var estacion = "verano";
        // switch = dicierne (estacion)
        // caso verano = imprime verano
        // caso invierno = imprime invierno
        // otro caso = devuelve la estacion actual.


        System.out.println("Realizamos el ejemplo de switch");
        var station = "winter";
        switch (station){
            case "summer":
                System.out.println("Is summer");
                break;
            case "winter":
                System.out.println("Is winter");
                break;
            default:
                System.out.println("Is another station");
        }

        System.out.println("Ejemplo switch dias laborales:");
        var Hoy_es = "Miercoles";
        switch(Hoy_es){
            case "Lunes":
            case "Martes":
            case "Miercoles":
            case "Jueves":
            case "Viernes":
                System.out.println("Hoy es un dia laboral");
                break;
            default:
                System.out.println("Hoy no es dia laboral");
        }

    }
}