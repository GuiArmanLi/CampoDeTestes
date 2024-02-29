import java.util.UUID;

public class Employee {
    private UUID id;
    private String name;
    private int age;

    public Employee() {
        this.id = UUID.randomUUID();
    }

    public Employee(String name, int age) {
        this.id = UUID.randomUUID();
        this.name = name;
        this.age = age;
    }

    public UUID getId() {
        return id;
    }

    public void setId(UUID id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    @Override
    public String toString() {
        return "Employee [id=" + id + ", name=" + name + ", age=" + age + "]";
    }

    public String show() {
        return this.toString();
    }

    public String showNextId() {
        return "Example: " + UUID.randomUUID().toString();
    }

    public static void main(String[] args) {
        Employee maria = new Employee("maria", 14);
        System.out.println(maria.show());
        System.out.println(maria.showNextId());
        maria = null;

        System.gc(); // or
        // Runtime.getRuntime().gc();
    }
}
