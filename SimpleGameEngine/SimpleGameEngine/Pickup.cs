using System;

public class Pickup{
    private int maxX; //the maximum x position for our pickup
    private int maxY; //the maximum y position for our pickup
    private int x; //the current x position for our pickup
    private int y; //the current y position for our pickup
    private Random r = new Random();

    public Pickup(int maxX, int maxY){

        this.maxX = maxX;
        this.maxY = maxY;
        SetPosition();
        /*  ------------------------------------------
            3.1
            ------------------------------------------   
            Initialize the maxX and maxY fields 
            using the values passed to the constructor

            Call the SetPosition method.
        */
    }

    public int X {
        get { return x; }
    }

    public int Y {
        get { return y; }
    }

    public void SetPosition(){

        x = r.Next(0, maxX);
        y = r.Next(0, maxY);
        /*  ------------------------------------------
            3.2
            ------------------------------------------   
            SetPosition should set x to a random value 
            between 0 and maxX, and y to a random value 
            between 0 maxY.
        */
    }
}