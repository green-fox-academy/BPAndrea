import javax.swing.*;
import java.awt.*;

import static java.awt.image.ImageObserver.WIDTH;
import static javax.swing.WindowConstants.EXIT_ON_CLOSE;
import static javax.swing.JFrame.EXIT_ON_CLOSE;

public class EnvelopeStarNr2 {
    public static void mainDraw(Graphics graphics) {
        int steps = 10;

        for (int i = 0; i < 16; i++) {
            graphics.setColor(Color.GREEN);
            graphics.drawLine((WIDTH / 2) + i * steps, HEIGHT / 2, WIDTH / 2, 0 + i * steps);
            graphics.drawLine((WIDTH / 2) - i * steps, HEIGHT / 2, WIDTH / 2, 0 + i * steps);
            graphics.drawLine((WIDTH / 2) - i * steps, HEIGHT / 2, WIDTH / 2, HEIGHT - i * steps);
            graphics.drawLine((WIDTH / 2) + i * steps, HEIGHT / 2, WIDTH / 2, HEIGHT - i * steps);
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



