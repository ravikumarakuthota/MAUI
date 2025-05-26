namespace MAUITasker.MVVM.Models;

public class MyTask : ContentPage
{
	public string TaskName { get; set; }
	public bool Completed { get; set; }
	public int CategoryId { get; set; }
	public string TaskColor { get; set; }

	public MyTask()
	{
	}
}