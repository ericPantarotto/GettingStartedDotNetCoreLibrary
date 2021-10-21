namespace DataLibraryRepo.Models
{
    public interface IFoodModel
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
    }
}
