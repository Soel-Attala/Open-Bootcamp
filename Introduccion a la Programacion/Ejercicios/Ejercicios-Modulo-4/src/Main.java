public class Main {
    public static void main(String[] args) {
        //Ejercicio 1: Usando un if, crear una condición que compare si la variable numeroIf es:
        // positivo, negativo, o 0.

        System.out.println("Exercise-1: if-else. ");

        int numberIf = 0;
        if(numberIf > 0){
            System.out.println("The number is Positive");
        } else if (numberIf < 0) {
            System.out.println("The number is negative");
        }else{
            System.out.println("The number is 0");
        }

        //Ejercicio 2: Crear un bucle while:
        //Este bucle tendrá que tener como condición que la variable numeroWhile sea inferior a 3.
        //El bloque de código que tendrá el bucle deberá:
        //Incrementar el valor de la variable en uno cada vez que se ejecute.
        //Mostrarlo por pantalla cada vez que se ejecute.

        System.out.println("Exercise-2: While-Cycle. ");
        int numberWhile = 0;
        while(numberWhile <3){
            System.out.println(numberWhile);
            numberWhile++;
        }


        //Ejercicio-3: Do-While.
        //Para el bucle Do While, deberás crear la misma estructura que en el While,
        // pero solo se debe ejecutar una vez.
        System.out.println("Exercise-3: Do-While-Cycle");
        int doWhileNumber = 3;
        do{
            System.out.println(doWhileNumber);
            doWhileNumber = doWhileNumber +1;
        }while (doWhileNumber<3);


        //Ejercicio-3: Ciclo For.
        //Para el bucle For, crea una variable numeroFor, esta variable tendrá como valor 0.
        // Su condición será que la variable sea igual o menor que 3.
        // Se irá incrementando en 1 su valor cada vez que se ejecute y deberá mostrarse por pantalla.

        System.out.println("Exercise-4: For-Cycle");
        for (int value = 0; value <= 3; value++){
            System.out.println(value);
        }

        //Ejercicio-5: Switch.
        //Por último, para el Switch:
        // Deberás crear la variable estacion, y distintos case para las cuatro estaciones del año.
        // Dependiendo del valor de la variable estacion se deberá mandar un mensaje por consola
        // informando de la estación en la que está.
        // También habrá que poner un default para cuando el valor de la variable no sea una estación.

        System.out.println("Exercise-5: Switch");
        var station = "Spring";
        switch (station){
            case "Summer":
                System.out.println("Is summer.");
                break;
            case "Autumn":
                System.out.println("Is autumn.");
                break;
            case "Winter":
                System.out.println("Is winter.");
                break;
            case "Spring":
                System.out.println("Is Spring.");
                break;
            default:
                System.out.println("The variable is not a station");
        }

    }
}