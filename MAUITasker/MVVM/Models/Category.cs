namespace MAUITasker.MVVM.Models;

public class Category : ContentPage
{
	public int Id { get; set; }
	public string CategoryName { get; set; }
	public string Color { get; set; }
	public int PendingTasks { get; set; }
	public float Percentage { get; set; }
	public bool IsSelected { get; set; }
	public Category()
	{
	}
}