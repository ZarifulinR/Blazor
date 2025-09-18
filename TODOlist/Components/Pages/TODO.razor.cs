namespace TODOlist.Components.Pages
{
    public partial class TODO
    {
        private  List<TODOItem> tasks = [];
        private string task;
        private void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(new TODOItem { Title = task });
                task = string.Empty;
            }
        }
    }
}
