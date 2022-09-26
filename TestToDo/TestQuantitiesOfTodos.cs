using TodoList;
using TodoList.Pages;
using TodoList.Containers;

namespace TestToDo
{
    [TestClass]
    public class TestQuantitiesOfTodos
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var todoItemA = new TodoItem();
            var todoItemB = new TodoItem();
            var todoItemC = new TodoItem();
            var todoItemD = new TodoItem();

            var todoItems = new List<TodoItem>();
            todoItems.Add(todoItemA);
            todoItems.Add(todoItemB);
            todoItems.Add(todoItemC);
            todoItems.Add(todoItemD);

            var counter = 0;
            foreach (var todoItem in todoItems)
            {
                todoItem.Title = $"todo{counter++}";
            }


            // Act
            foreach (var todoItem in todoItems)
            {
                TodoList.Containers.ToDoContainer.AddTodo(todoItem.Title);
            }

            // Assert
            Assert.AreEqual(counter, todoItems.Count);

        }
    }
}