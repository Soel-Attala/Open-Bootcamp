public class Main {
    public static void main(String[] args) {
        //Client
        Client client = new Client();
        client.setName("Soel Attala");
        client.setAge(26);
        client.setPhone(154306032);
        client.setCredit(25000);
        System.out.println(client.getName());
        System.out.println(client.getAge());
        System.out.println(client.getPhone());
        System.out.println("your credit is: " + client.getCredit());

        System.out.println("-----------------------------------");

        //Worker
        Worker worker = new Worker();
        worker.setName("Luciano");
        worker.setAge(27);
        worker.setPhone(154306032);
        worker.setSalary(300000);
        System.out.println(worker.getName());
        System.out.println(worker.getAge());
        System.out.println(worker.getPhone());
        System.out.println("your salary is: " + worker.getSalary());

    }
}

class Person{
    int age;
    String name;
    int phone;
    public int getAge(){
        return this.age;
    }
    public String getName(){
        return this.name;
    }
    public int getPhone(){
        return this.phone;
    }
    public void setName(String name){
        this.name = name;
    }
    public void setAge(int age){
        this.age = age;
    }
    public void setPhone(int phone){
        this.phone = phone;
    }
}

class Client extends Person{
    private int credit;
    public int getCredit(){
        return this.credit;
    }
    public void setCredit(int credit){
        this.credit = credit;
    }
}

class Worker extends Person{
    private int salary;
    public int getSalary(){
        return this.salary;
    }
    public void setSalary(int salary){
        this.salary = salary;
    }
}