using System.Collections.Generic;

namespace MomentoPattern
{
    /// <summary>
    /// The history of the editor states, each change in the editor should be recorded in this history.
    /// </summary>
    public class History
    {
        /// <summary>
        /// The stack in which all changes to the editor state should be stored.
        /// </summary>
        /// <typeparam name="EditorState">The current editor state to be stored.</typeparam>
        private Stack<EditorState> stack = new Stack<EditorState>();

        /// <summary>
        /// Adds a new editor state to the history.
        /// </summary>
        /// <param name="editorState">The new editor state to be added to the change history.</param>
        public void Add(EditorState editorState)
        {
            stack.Push(editorState);
        }

        /// <summary>
        /// Restores the editor history to the last available state.
        /// </summary>
        /// <returns>The last available <typeparamref name="EditorState"/> otherwise, <typeparamref name="null"/>.</returns>
        public EditorState Undo()
        {
            stack.TryPop(out var oldState);
            stack.TryPeek(out var newState);

            return newState;
        }
    }
}