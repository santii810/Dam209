using System;

public class Card
{
    public bool isFaceUp = false;
    public bool isMatched = false;
    public String image;
    public int id;

    public Card(string img, int id)
    {
        image = img;
        this.id = id;
    }
}
