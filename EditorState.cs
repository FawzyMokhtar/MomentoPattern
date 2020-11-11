namespace MomentoPattern
{
    /// <summary>
    /// The state that holds all editor information in a specific state.
    /// </summary>
    public class EditorState
    {
        /// <summary>
        /// The content of the editor.
        /// </summary>
        private readonly string content;

        /// <summary>
        /// Gets the content of the current editor state.
        /// </summary>
        public string Content { get { return content; } }

        /// <summary>
        /// Creates a new instance of EditorState with the provided editor information.
        /// </summary>
        /// <param name="content">The content of the editor</param>
        public EditorState(string content)
        {
            this.content = content;
        }
    }
}