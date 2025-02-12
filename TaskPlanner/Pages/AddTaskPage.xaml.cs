namespace TaskPlanner.Pages;

public partial class AddTaskPage : ContentPage
{
    private MainPage mainPage;

    public AddTaskPage(MainPage page)
    {
        InitializeComponent();
        mainPage = page;
    }

    private void OnSaveTaskClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(taskNameEntry.Text) && !string.IsNullOrWhiteSpace(taskDescriptionEntry.Text))
        {
            var newTask = new Models.TaskItem
            {
                Name = taskNameEntry.Text,
                Description = taskDescriptionEntry.Text
            };

            mainPage.Tasks.Add(newTask);
            mainPage.RefreshTaskList();

            Navigation.PopAsync();
        }
    }
}
