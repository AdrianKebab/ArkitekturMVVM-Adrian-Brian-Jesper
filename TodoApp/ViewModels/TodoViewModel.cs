using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using CommunityToolkit.Mvvm.Input;

public class TodoViewModel
{
    public ObservableCollection<TodoItem> TodoItems { get; set; } = new();
    public ObservableCollection<TodoItem> FilteredTodoItems { get; set; } = new();
    private string _searchText = "";
    public string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            ApplyFilter();
            OnPropertyChanged(nameof(SearchText));
        }
    }
    public string NewTitle { get; set; } = "";
    public RelayCommand? AddTodoCommand { get; set; }
    public RelayCommand<TodoItem> ToggleTodoCommand { get; }

    public TodoViewModel()
    {
        AddTodoCommand = new RelayCommand(AddTodo);
        ToggleTodoCommand = new RelayCommand<TodoItem>(ToggleTodo);
        ApplyFilter();
    }
    private void AddTodo()
    {
        var todoItem = new TodoItem
        {
            Title = NewTitle,
            IsCompleted = false
        };
        TodoItems.Add(todoItem);
        ApplyFilter();
        OnPropertyChanged(nameof(NewTitle));
        LogToFile("Todo skapad:" + todoItem.Title + " - " + (todoItem.IsCompleted ? "Klar" : "Ej klar"));
    }
    private void ApplyFilter()
    {
        FilteredTodoItems.Clear();

        foreach (var item in TodoItems)
        {
            if (string.IsNullOrWhiteSpace(_searchText) ||
                item.Title.Contains(_searchText, StringComparison.OrdinalIgnoreCase))
            {
                FilteredTodoItems.Add(item);
            }
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    private void LogToFile(string text)
    {
        File.AppendAllText("log.txt", "\n" + text);
    }
    private void ToggleTodo(TodoItem item)
    {
        if (item == null) return;
        item.IsCompleted = !item.IsCompleted;

        LogToFile($"\nTodo ändrad: {item.Title} - {(item.IsCompleted ? "Klar" : "Ej klar")}");
    }
}