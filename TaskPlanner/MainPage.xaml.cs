namespace TaskPlanner;

public partial class MainPage : ContentPage
{
    public List<Models.TaskItem> Tasks { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();
        taskListView.ItemsSource = Tasks;
    }
    public void RefreshTaskList()
    {
        taskListView.ItemsSource = null;
        taskListView.ItemsSource = Tasks;
    }

    private async void OnAddTaskClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.AddTaskPage(this));
    }

    private async void OnTaskSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Models.TaskItem selectedTask)
        {
            await Navigation.PushAsync(new Pages.TaskDetailPage(selectedTask, this));
        }
    }
}
