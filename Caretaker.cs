public class Caretaker
{

    public void addMemento(List<Memento> history, List<Memento> redoList, List<Shape> emoticon)
    { //Redo
        Memento redo = redoList.Last();
        history.Add(redo);
        Shape redoS = redo.getData(); //Converts to string
        emoticon.Add(redoS);
        redoList.RemoveAt(redoList.Count - 1);
    }

    public void removeMemento(List<Memento> history, List<Memento> redoList, List<Shape> emoticon)
    { //Undo
        Memento undo = history.Last();
        redoList.Add(undo);
        history.RemoveAt(history.Count - 1);
        emoticon.RemoveAt(emoticon.Count - 1);
    }
}