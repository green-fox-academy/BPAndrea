package main.java.music;
/*We start with a base, abstract class Instrument.

    it reserves (e.g. protected) the name of the instrument
    it should provide a play() method.*/

public abstract class Instrument {
  protected String name;

 public abstract void play();
}
