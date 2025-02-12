namespace TaskPlanner.Pages;

public partial class TaskDetailPage : ContentPage
{
    private Models.TaskItem _task;
    private MainPage _mainPage;

    public TaskDetailPage(Models.TaskItem task, MainPage mainPage)
    {
        InitializeComponent();
        _task = task;
        _mainPage = mainPage;

        if (taskNameLabel != null && taskDescriptionLabel != null)
        {
            taskNameLabel.Text = _task.Name;
            taskDescriptionLabel.Text = _task.Description;
        }
    }

    private async void OnDeleteTaskClicked(object sender, EventArgs e)
    {
        _mainPage.Tasks.Remove(_task);
        _mainPage.RefreshTaskList(); // 🟢 Umesto direktnog pristupa `taskListView`

        await Navigation.PopAsync();
    }
}
