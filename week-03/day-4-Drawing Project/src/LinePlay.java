import javax.swing.*;
import java.awt.*;

import static java.awt.image.ImageObserver.WIDTH;
import static javax.swing.WindowConstants.EXIT_ON_CLOSE;
import static javax.swing.JFrame.EXIT_ON_CLOSE;

public class LinePlay {
    public static void mainDraw(Graphics graphics) {
        for (int i = 0; i < 15; i++) {

            graphics.setColor(Color.MAGENTA);
            graphics.drawLine((WIDTH / 2) - i * (WIDTH / 16), 0, WIDTH, (HEIGHT / 2) - i * (WIDTH / 16));
            graphics.drawLine((WIDTH / 2) + i * (WIDTH / 16), 0, WIDTH, (HEIGHT / 2) + i * (WIDTH / 16));
            graphics.setColor(Color.GREEN);
            graphics.drawLine(0, (WIDTH / 2) + i * (WIDTH / 16), (WIDTH / 2) + i * (WIDTH / 16), WIDTH);
            graphics.drawLine(0, (WIDTH / 2) - i * (WIDTH / 16), (WIDTH / 2) - i * (WIDTH / 16), WIDTH);
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

