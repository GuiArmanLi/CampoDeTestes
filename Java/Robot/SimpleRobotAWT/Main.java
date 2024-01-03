import java.awt.*;
import java.awt.datatransfer.Clipboard;
import java.awt.datatransfer.StringSelection;
import java.awt.event.KeyEvent;

public class Main {
    private static final String message = "Bom dia!";

    public static void main(String[] args) throws AWTException, InterruptedException {
        Robot robot = new Robot();

        StringSelection ss = new StringSelection(message);
        Clipboard c = Toolkit.getDefaultToolkit().getSystemClipboard();
        c.setContents(ss, null);

        for (int i = 0; i < 15; i++) {

            Thread.sleep(50);
            robot.keyPress(KeyEvent.VK_CONTROL);
            robot.keyPress(KeyEvent.VK_V);

            robot.keyRelease(KeyEvent.VK_CONTROL);
            robot.keyRelease(KeyEvent.VK_V);

            robot.keyPress(KeyEvent.VK_ENTER);
            robot.keyRelease(KeyEvent.VK_ENTER);
        }
    }
}