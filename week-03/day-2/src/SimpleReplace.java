public class SimpleReplace {
    public static void main(String[] args) {
        String example = "In a dishwasher far far away";


        // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
        // Please fix it for me!
        // Expected output: In a galaxy far far away

        //Megjegyzés: Ha a későbbiekben szükség van rá, és le kell menteni a tartalmát, akkor új stringbe kell menteni:
        // String example2=example.replace("dishwasher", "galaxy");

        System.out.println(example.replace("dishwasher", "galaxy"));
    }
}