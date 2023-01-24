using System;
class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory(); //Used factory to create shapes where not visible by client. It is also more efficient
        Emoticon emo = new Emoticon();
        //first add default face
        Base face = new Base();
        emo.AddShape(face);
        bool exit = false;
        while (exit == false)
        {
            Console.Clear(); //clears whatever is in the console
            Console.WriteLine("Choose a command below");
            Console.WriteLine("----------------------");
            Console.WriteLine("1): add");//{ left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}
            Console.WriteLine("2): remove");//{	left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}
            Console.WriteLine("3): move");//{ left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}	{up	|	down	|	left	|	right	}	value (units)
            Console.WriteLine("4): rotate");//{	left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}	{	clockwise	|	anticlockwise	}	degrees
            Console.WriteLine("5): style");//{	left-eye	|	right-eye	|	left-brow	|	right-brow	|	mouth}	{	A	|	B	|	C}
            Console.WriteLine("6): save(svg)");//{	<file>		}
            Console.WriteLine("7): draw");
            Console.WriteLine("8): undo");
            Console.WriteLine("9): redo");
            Console.WriteLine("10): help");
            Console.WriteLine("0): quit");
            // Console.WriteLine("21): display");

            int choice = Int16.Parse(Console.ReadLine());
            //declaring outside if statement so we can change coordinate values for moving if(choice == 3).
            var lefteye = new Lefteye();
            var righteye = new Righteye();
            var leftbrow = new Leftbrow();
            var rightbrow = new Rightbrow();
            var mouth = new Mouth();
            if (choice == 0) exit = true;
            else if (choice == 1)
            {
                //add
                Console.WriteLine("Choose a feature to add below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int add = Int16.Parse(Console.ReadLine());
                if (add == 1)
                {
                    if (emo.Contains(typeof(Lefteye)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        // lefteye = createLefteye();
                        lefteye = factory.CreateShape("Lefteye") as Lefteye;
                        emo.AddShape(lefteye);
                        emo.AddMemento(lefteye);
                    }
                }
                else if (add == 2)
                {
                    if (emo.Contains(typeof(Righteye)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        // righteye = createRighteye();
                        righteye = factory.CreateShape("Righteye") as Righteye;
                        emo.AddShape(righteye);
                        emo.AddMemento(righteye);
                    }
                }
                else if (add == 3)
                {
                    if (emo.Contains(typeof(Leftbrow)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        // leftbrow = createLeftbrow();
                        leftbrow = factory.CreateShape("Leftbrow") as Leftbrow;
                        emo.AddShape(leftbrow);
                        emo.AddMemento(leftbrow);
                    }
                }
                else if (add == 4)
                {
                    if (emo.Contains(typeof(Rightbrow)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        // rightbrow = createRightbrow();
                        rightbrow = factory.CreateShape("Rightbrow") as Rightbrow;
                        emo.AddShape(rightbrow);
                        emo.AddMemento(rightbrow);
                    }
                }
                else if (add == 5)
                {
                    if (emo.Contains(typeof(Mouth)))
                    {
                        Console.WriteLine("Emoticon already contains identical feature");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        // mouth = createMouth();
                        mouth = factory.CreateShape("Mouth") as Mouth;
                        emo.AddShape(mouth);
                        emo.AddMemento(mouth);
                    }
                }
            }
            else if (choice == 2)
            {
                //remove
                Console.WriteLine("Choose a feature to remove below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int remove = Int16.Parse(Console.ReadLine());
                if (remove == 1)
                {
                    emo.RemoveShape(typeof(Lefteye));
                }
                else if (remove == 2)
                {
                    emo.RemoveShape(typeof(Righteye));
                }
                else if (remove == 3)
                {
                    emo.RemoveShape(typeof(Leftbrow));
                }
                else if (remove == 4)
                {
                    emo.RemoveShape(typeof(Rightbrow));
                }
                else if (remove == 5)
                {
                    emo.RemoveShape(typeof(Mouth));
                }
            }

            else if (choice == 3)
            {
                //move
                Console.WriteLine("Choose a feature to move below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int move = Int16.Parse(Console.ReadLine());

                if (move == 1)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(lefteye as Lefteye, direction, value);
                }
                if (move == 2)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(righteye as Righteye, direction, value);
                }
                if (move == 3)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(leftbrow, direction, value);
                }
                if (move == 4)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(rightbrow, direction, value);
                }
                if (move == 5)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): up");
                    Console.WriteLine("2): down");
                    Console.WriteLine("3): left");
                    Console.WriteLine("4): right");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int value = Int16.Parse(Console.ReadLine());

                    emo.Move(mouth, direction, value);
                }
            }

            else if (choice == 4)
            {
                //rotate
                Console.WriteLine("Choose a feature to rotate below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int rotate = Int16.Parse(Console.ReadLine());

                if (rotate == 1)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(lefteye, direction, degrees);
                }
                if (rotate == 2)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(righteye, direction, degrees);
                }
                if (rotate == 3)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(leftbrow, direction, degrees);
                }
                if (rotate == 4)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(rightbrow, direction, degrees);
                }
                if (rotate == 5)
                {
                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): clockwise");
                    Console.WriteLine("2): anticlockwise");
                    int direction = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter value");
                    int degrees = Int16.Parse(Console.ReadLine());

                    emo.Rotate(mouth, direction, degrees);
                }
            }

            else if (choice == 5)
            {
                //style
                Console.WriteLine("Choose a feature to change style below");
                Console.WriteLine("----------------------");
                Console.WriteLine("1): left-eye");
                Console.WriteLine("2): right-eye");
                Console.WriteLine("3): left-brow");
                Console.WriteLine("4): right-brow");
                Console.WriteLine("5): mouth");
                int change = Int16.Parse(Console.ReadLine());

                if (change == 1)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        lefteye = factory.CreateShape("Lefteye", "A") as Lefteye;
                    }
                    else if (style == 2)
                    {
                        lefteye = factory.CreateShape("Lefteye", "B") as Lefteye;
                    }
                    else if (style == 3)
                    {
                        lefteye = factory.CreateShape("Lefteye", "C") as Lefteye;
                    }
                }
                else if (change == 2)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        righteye = factory.CreateShape("Righteye", "A") as Righteye;
                    }
                    else if (style == 2)
                    {
                        righteye = factory.CreateShape("Righteye", "B") as Righteye;
                    }
                    else if (style == 3)
                    {
                        righteye = factory.CreateShape("Righteye", "C") as Righteye;
                    }
                }
                else if (change == 3)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        leftbrow = factory.CreateShape("Leftbrow", "A") as Leftbrow;
                    }
                    else if (style == 2)
                    {
                        leftbrow = factory.CreateShape("Leftbrow", "B") as Leftbrow;
                    }
                    else if (style == 3)
                    {
                        leftbrow = factory.CreateShape("Leftbrow", "C") as Leftbrow;
                    }
                }
                else if (change == 4)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        rightbrow = factory.CreateShape("Rightbrow", "A") as Rightbrow;
                    }
                    else if (style == 2)
                    {
                        rightbrow = factory.CreateShape("Rightbrow", "B") as Rightbrow;
                    }
                    else if (style == 3)
                    {
                        rightbrow = factory.CreateShape("Rightbrow", "C") as Rightbrow;
                    }
                }
                else if (change == 5)
                {
                    Console.WriteLine("Select style from below");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1): A");
                    Console.WriteLine("2): B");
                    Console.WriteLine("3): C");
                    int style = Int16.Parse(Console.ReadLine());

                    if (style == 1)
                    {
                        mouth = factory.CreateShape("Mouth", "A") as Mouth;
                    }
                    else if (style == 2)
                    {
                        mouth = factory.CreateShape("Mouth", "B") as Mouth;
                    }
                    else if (style == 3)
                    {
                        mouth = factory.CreateShape("Mouth", "C") as Mouth;
                    }
                }
            }
            else if (choice == 6)
            {
                //save
                emo.ToSVG();
            }
            else if (choice == 7)
            {
                //draw
                emo.drawSVG();
            }
            else if (choice == 8)
            {
                //Undo
                emo.Undo();
            }
            else if (choice == 9)
            {
                //Redo
                emo.Redo();
            }
            else if (choice == 10)
            {
                //help
                Console.WriteLine("-----------------------------------------------Command-List--------------------------------------------------");
                Console.WriteLine(" 1. add	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }");
                Console.WriteLine(" 2. remove   { left-eye | right-eye	| left-brow	| right-brow | mouth }");
                Console.WriteLine(" 3. move	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }	{ up | down	| left | right } value");
                Console.WriteLine(" 4. rotate	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }");
                Console.WriteLine(" 5. style	 { left-eye	| right-eye	| left-brow	| right-brow | mouth }	{ A	| B	| C }");
                Console.WriteLine(" 6. save	 <file>");
                Console.WriteLine(" 7. draw");
                Console.WriteLine(" 8. undo");
                Console.WriteLine(" 9 redo");
                Console.WriteLine(" 10. help");
                Console.WriteLine(" 0. quit");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            // else if (choice == 21)
            // {
            //     emo.Display();
            // }
        }
    }


    // public static Lefteye createLefteye()
    // {
    //     return new Lefteye();
    // }
    // public static Lefteye createLefteye(String style) //Method overloading
    // {
    //     return new Lefteye(style);
    // }

    // public static Righteye createRighteye()
    // {
    //     return new Righteye();
    // }
    // public static Righteye createRighteye(String style)
    // {
    //     return new Righteye(style);
    // }

    // public static Leftbrow createLeftbrow()
    // {
    //     return new Leftbrow();
    // }
    // public static Leftbrow createLeftbrow(String style)
    // {
    //     return new Leftbrow(style);
    // }

    // public static Rightbrow createRightbrow()
    // {
    //     return new Rightbrow();
    // }
    // public static Rightbrow createRightbrow(String style)
    // {
    //     return new Rightbrow(style);
    // }

    // public static Mouth createMouth()
    // {
    //     return new Mouth();
    // }
    // public static Mouth createMouth(String style)
    // {
    //     return new Mouth(style);
    // }








    // else if (choice == 1)
    //             {
    //                 Console.WriteLine("Choose a feature to add below");
    //                 Console.WriteLine("----------------------");
    //                 Console.WriteLine("1): left-eye");
    //                 Console.WriteLine("2): right-eye");
    //                 Console.WriteLine("3): left-brow");
    //                 Console.WriteLine("4): right-brow");
    //                 Console.WriteLine("5): mouth");
    //                 // Console.WriteLine("6): left-eye (default)");
    //                 // Console.WriteLine("7): right-eye (default)");
    //                 // Console.WriteLine("8): left-brow (default)");
    //                 // Console.WriteLine("9): right-brow (default)");
    //                 // Console.WriteLine("0): mouth (default)");
    //                 int choice2 = Int16.Parse(Console.ReadLine());
    //                 if (choice2 == 1)
    //                 {
    //                     var lefteye = createLefteye();
    //                     emo.AddShape(lefteye);
    //                 }
    //                 else if (choice2 == 2)
    //                 {
    //                     var righteye = createRighteye();
    //                     emo.AddShape(righteye);
    //                 }
    //             }



    // public static Lefteye createLefteye(int choice2)
    // {
    //     if (choice2 == 6)
    //         return new Lefteye();
    //     else
    //     {
    //         Console.Write("Enter X coordinate: ");
    //         int x = int.Parse(Console.ReadLine());
    //         Console.Write("Enter Y coordinate: ");
    //         int y = int.Parse(Console.ReadLine());
    //         Console.Write("Enter Radius: ");
    //         int radius = int.Parse(Console.ReadLine());
    //         Console.Write("Enter stroke: ");
    //         string stroke = Console.ReadLine();
    //         Console.Write("Enter strokeWidth: ");
    //         int strokeW = int.Parse(Console.ReadLine());
    //         Console.Write("Enter fill colour: ");
    //         string fill = Console.ReadLine();
    //         Lefteye lefteye = new Lefteye(x, y, radius, stroke, strokeW, fill);
    //         return lefteye;
    //     }
    // }

    // public static Righteye createRighteye(int choice2)
    // {
    //     if (choice2 == 7)
    //         return new Righteye();
    //     else
    //     {
    //         Console.Write("Enter X coordinate: ");
    //         int x = int.Parse(Console.ReadLine());
    //         Console.Write("Enter Y coordinate: ");
    //         int y = int.Parse(Console.ReadLine());
    //         Console.Write("Enter Radius: ");
    //         int radius = int.Parse(Console.ReadLine());
    //         Console.Write("Enter stroke: ");
    //         string stroke = Console.ReadLine();
    //         Console.Write("Enter strokeWidth: ");
    //         int strokeW = int.Parse(Console.ReadLine());
    //         Console.Write("Enter fill colour: ");
    //         string fill = Console.ReadLine();
    //         return new Righteye(x, y, radius, stroke, strokeW, fill);
    //     }
    // }
}