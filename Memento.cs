public class Memento
{
    Shape data;

    public Memento(Shape shape)
    {
        this.data = shape;
    }

    public Shape getData() //getter for string conversion
    {
        return this.data;
    }
}