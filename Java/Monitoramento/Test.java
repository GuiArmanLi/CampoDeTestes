public class Test {
    public static void main(String[] args) throws InterruptedException {
        Thread.sleep(10000);
        somar(1, 2);

    }

    private static Integer somar(Integer a, Integer b) {
        return a + b;
    }
}
