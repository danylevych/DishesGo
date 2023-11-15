namespace DishesGo.src.Tools.Strategies.SearchStrategies
{
    public class SearchByLikes : SearchStrategy<int>
    {
        protected override void SetValues()
        {
            // TODO: Don't show the user's recipes.
            KeySelector = r => r.Likes.Count;
        }
    }
}
