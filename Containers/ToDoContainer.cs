namespace TodoList.Containers
{
    public static class ToDoContainer
    {

        public static List<TodoItem> Todos { get; set; } = new List<TodoItem>();

        public static void AddTodo(string newTodo)
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                Todos.Add(new TodoItem { Title = newTodo });
            }
        }
    }
}
