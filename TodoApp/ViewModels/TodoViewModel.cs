using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public class TodoViewModel 
{
    public ObservableCollection<TodoItem> TodoItems {get; set;} = new();
    public string NewTitle {get; set;} = "";
    public RelayCommand? AddTodoCommand {get; set;}

    public TodoViewModel()
    {
        AddTodoCommand = new RelayCommand(AddTodo);
    }
    private void AddTodo()
    {
        TodoItems.Add(new TodoItem
        {
            Title = NewTitle,
            IsCompleted = false
        });
    }
}