using System;

namespace MomentoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.Add(editor.CreateState());

            editor.Content = "b";
            history.Add(editor.CreateState());

            editor.Content = "c";
            history.Add(editor.CreateState());
            Console.WriteLine($"Before Undo: {editor.Content}");

            editor.RestoreState(history.Undo());
            Console.WriteLine($"After Undo: {editor.Content}");

            editor.RestoreState(history.Undo());
            Console.WriteLine($"After Undo: {editor.Content}");

            editor.RestoreState(history.Undo());
            Console.WriteLine($"After Undo: {editor.Content}");
        }
    }
}
