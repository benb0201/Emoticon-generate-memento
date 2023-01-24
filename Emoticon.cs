public class Emoticon //Canvas class
{
    List<Shape> emoticon; // List of Shape objects 
    // List<string> emoticonSVG = drawSVG(); // List of
    List<Memento> history = new List<Memento>();
    List<Memento> redoList = new List<Memento>();
    public Emoticon()
    {
        emoticon = new List<Shape>(); //resets canvas when created
    }

    //Adds a shape object to the canvas object list
    public void AddShape(Shape shape)
    {
        emoticon.Add(shape);
    }
    public void AddMemento(Shape shape)
    {
        Memento newShape = new Memento(shape);
        history.Add(newShape);
    }


    public void RemoveShape(Type type)
    {
        emoticon.RemoveAll(x => x.GetType() == type);
    }
    public void Undo()
    {
        if (history.Count <= 0) //Prevents code from crashing
        {
            return;
        }
        else
        {
            Caretaker caretake = new Caretaker();
            caretake.removeMemento(history, redoList, emoticon);
        }
    }

    public void Redo()
    {
        if (redoList.Count <= 0) //Prevents code from crashing
        {
            return;
        }
        else
        {
            Caretaker caretake = new Caretaker();
            caretake.addMemento(history, redoList, emoticon);
        }

    }
    // .Contains constructor for helping make sure there are no duplicate features
    public bool Contains(Type type)
    {
        foreach (var shape in emoticon)
        {
            if ((shape.GetType()).Equals(type)) return true;
        }
        return false;
    }

    public void Move(Shape shape, int direction, int value)
    {
        if (direction == 1)
        {
            shape.data = shape.data.Replace(" />", " transform=\"translate(0, -" + value + ")\" >");
        }
        else if (direction == 2)
        {
            shape.data = shape.data.Replace(" />", " transform=\"translate(0, " + value + ")\" >");
        }
        else if (direction == 3)
        {
            shape.data = shape.data.Replace(" />", " transform=\"translate(-" + value + ", 0)\" >");
        }
        else if (direction == 4)
        {
            shape.data = shape.data.Replace(" />", " transform=\"translate(" + value + ", 0)\" >");
        }
    }

    public void Rotate(Shape shape, int direction, int degrees)
    {
        string transform = "";
        if (direction == 1)
        {
            transform = "rotate(" + degrees + " 0 0)";
        }
        else if (direction == 2)
        {
            transform = "rotate(" + -degrees + " 0 0)";
        }

        shape.data = shape.data.Replace(" />", " transform='" + transform + "' />");
    }


    public void Display() //Display canvas to terminal
    {
        int indx = 0;
        foreach (var shape in emoticon) //Prints out all strings in canvas with their index and shape name
        {
            Console.WriteLine(indx + ": " + shape + " [" + shape.getString() + "]");
            // int index = shape.data.IndexOf(">");
            // Console.WriteLine(shape.data.Substring(0, index - 1));
            indx++;
        }
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    public List<string> drawSVG()
    {
        List<string> emoticonSVG = new List<string>();
        emoticonSVG.Add("<svg viewBox=\"0 0 400 200\" xmlns=\"http://www.w3.org/2000/svg\">");
        foreach (var shape in emoticon)
        {
            emoticonSVG.Add(shape.getString());
        }
        emoticonSVG.Add("</svg>");
        return emoticonSVG;
    }

    public void ToSVG() //Makes an svg file
    {
        File.WriteAllLines("C:/Users/bened/OneDrive/Documents/CS264/coding-assignment/shapes.svg", drawSVG());
    }
}















// public void Move(Righteye shape, int direction, int value)
// {
//     if (direction == 1)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(0, -" + value + ")\" >");
//     }
//     else if (direction == 2)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(0, " + value + ")\" >");
//     }
//     else if (direction == 3)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(-" + value + ", 0)\" >");
//     }
//     else if (direction == 4)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(" + value + ", 0)\" >");
//     }
// }
// public void Move(Leftbrow shape, int direction, int value)
// {
//     if (direction == 1)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(0, -" + value + ")\" >");
//     }
//     else if (direction == 2)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(0, " + value + ")\" >");
//     }
//     else if (direction == 3)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(-" + value + ", 0)\" >");
//     }
//     else if (direction == 4)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(" + value + ", 0)\" >");
//     }
// }
// public void Move(Rightbrow shape, int direction, int value)
// {
//     if (direction == 1)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(0, -" + value + ")\" >");
//     }
//     else if (direction == 2)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(0, " + value + ")\" >");
//     }
//     else if (direction == 3)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(-" + value + ", 0)\" >");
//     }
//     else if (direction == 4)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(" + value + ", 0)\" >");
//     }
// }
// public void Move(Mouth shape, int direction, int value)
// {
//     if (direction == 1)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(0, -" + value + ")\" >");
//     }
//     else if (direction == 2)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(0, " + value + ")\" >");
//     }
//     else if (direction == 3)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(-" + value + ", 0)\" >");
//     }
//     else if (direction == 4)
//     {
//         shape.data = shape.data.Replace(" />", " transform=\"translate(" + value + ", 0)\" >");
//     }
// }
// public void Move(Shape shape, int direction, int value)
// {
//     int x = 0, y = 0;
//     if (direction == 1) y = -value;
//     else if (direction == 2) y = value;
//     else if (direction == 3) x = -value;
//     else if (direction == 4) x = value;

//     if (shape is Lefteye)
//     {
//         Lefteye lefteye = (Lefteye)shape;
//         lefteye.x += x;
//         lefteye.y += y;
//     }
//     else if (shape is Righteye)
//     {
//         Righteye righteye = (Righteye)shape;
//         righteye.x += x;
//         righteye.y += y;
//     }
//     else if (shape is Leftbrow)
//     {
//         Leftbrow leftbrow = (Leftbrow)shape;
//         string[] coords = shape.data.Split(new string[] { "M", "Q", " " }, StringSplitOptions.RemoveEmptyEntries);
//         int x2 = Int32.Parse(coords[0]);
//         int y2 = Int32.Parse(coords[1]);

//         if (direction == 1)
//         {
//             y2 -= value;
//         }
//         else if (direction == 2)
//         {
//             y2 += value;
//         }
//         else if (direction == 3)
//         {
//             x2 -= value;
//         }
//         else if (direction == 4)
//         {
//             x2 += value;
//         }
//         shape.data = "<path d=\"M" + x2 + " " + y2 + " " + "Q" + coords[2] + " " + coords[3] + " " + coords[4] + " " + coords[5] + "\" stroke=" + "black" + " stroke-width=" + 2 + " fill=" + "black" + " />";
//     }
//     else if (shape is Rightbrow)
//     {
//         Rightbrow rightbrow = (Rightbrow)shape;
//         string[] coords = shape.data.Split(new string[] { "M", "Q", " " }, StringSplitOptions.RemoveEmptyEntries);
//         int x2 = Int32.Parse(coords[0]);
//         int y2 = Int32.Parse(coords[1]);

//         if (direction == 1)
//         {
//             y2 -= value;
//         }
//         else if (direction == 2)
//         {
//             y2 += value;
//         }
//         else if (direction == 3)
//         {
//             x2 -= value;
//         }
//         else if (direction == 4)
//         {
//             x2 += value;
//         }
//         shape.data = "<path d=\"M" + x2 + " " + y2 + " " + "Q" + coords[2] + " " + coords[3] + " " + coords[4] + " " + coords[5] + "\" stroke=" + "black" + " stroke-width=" + 2 + " fill=" + "black" + " />";
//     }
//     else if (shape is Mouth)
//     {
//         Mouth mouth = (Mouth)shape;

//         if (direction == 1)
//         {
//             shape.y1 -= value;
//             shape.y2 -= value;
//             shape.data = "<line x1=" + shape.x1 + " y1=" + shape.y1 + " x2=" + shape.x2 + " y2=" + shape.y2 + " style=stroke:" + shape.stroke + ";" + "stroke-width:" + shape.strokeW + ";" + " />";
//         }
//         else if (direction == 2)
//         {
//             shape.y1 += value;
//             shape.y2 += value;
//             shape.data = "<line x1=" + shape.x1 + " y1=" + shape.y1 + " x2=" + shape.x2 + " y2=" + shape.y2 + " style=stroke:" + shape.stroke + ";" + "stroke-width:" + shape.strokeW + ";" + " />";
//         }
//         else if (direction == 3)
//         {
//             shape.x1 -= value;
//             shape.x2 -= value;
//             shape.data = "<line x1=" + shape.x1 + " y1=" + shape.y1 + " x2=" + shape.x2 + " y2=" + shape.y2 + " style=stroke:" + shape.stroke + ";" + "stroke-width:" + shape.strokeW + ";" + " />";
//         }
//         else if (direction == 4)
//         {
//             shape.x1 += value;
//             shape.x2 += value;
//             shape.data = "<line x1=" + shape.x1 + " y1=" + shape.y1 + " x2=" + shape.x2 + " y2=" + shape.y2 + " style=stroke:" + shape.stroke + ";" + "stroke-width:" + shape.strokeW + ";" + " />";
//         }
//     }
// }