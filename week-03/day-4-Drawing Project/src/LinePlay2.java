import javax.swing.*;
import java.awt.*;

import static java.awt.image.ImageObserver.WIDTH;
import static javax.swing.WindowConstants.EXIT_ON_CLOSE;
import static javax.swing.JFrame.EXIT_ON_CLOSE;

public class LinePlay2 {
    public static void mainDraw(Graphics graphics) {

        int step = 20;
        for (int i = 1; i < 16; i++) {
            graphics.setColor(Color.GREEN);
            graphics.drawLine(0 + i * step, HEIGHT, 0, 0 + i * step);

            graphics.setColor(Color.MAGENTA);
            graphics.drawLine(WIDTH - i * step, 0, WIDTH, HEIGHT - i * step);
        }
    }

   
    // Don't touch the code below
    static int WIDTH = 320;
    static int HEIGHT = 320;

    public static void main(String[] args) {
        JFrame jFrame = new JFrame("Drawing");
        jFrame.setDefaultCloseOperation(EXIT_ON_CLOSE);
        ImagePanel panel = new ImagePanel();
        panel.setPreferredSize(new Dimension(WIDTH, HEIGHT));
        jFrame.add(panel);
        jFrame.setLocationRelativeTo(null);
        jFrame.setVisible(true);
        jFrame.pack();
    }

    static class ImagePanel extends JPanel {
        @Override
        protected void paintComponent(Graphics graphics) {
            super.paintComponent(graphics);
            mainDraw(graphics);
        }
    }
}
