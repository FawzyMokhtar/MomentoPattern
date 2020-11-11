namespace MomentoPattern
{
    /// <summary>
    /// Represents a text editor.
    /// </summary>
    public class Editor
    {
        /// <summary>
        /// Gets or sets the current content of the editor.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Creates a new state that holds all information about the current editor state.
        /// </summary>
        /// <returns>The newly created <typeparamref name="EditorState"/>.</returns>
        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        /// <summary>
        /// Restores the editor state to a given state.
        /// </summary>
        /// <param name="editorState">The state that will be used to restore the editor state.</param>
        public void RestoreState(EditorState editorState)
        {
            Content = editorState?.Content;
        }
    }
}