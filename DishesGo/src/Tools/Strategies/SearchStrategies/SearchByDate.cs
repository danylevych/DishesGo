using System;

namespace DishesGo.src.Tools.Strategies.SearchStrategies
{
    public class SearchByDate : SearchStrategy<DateTime>
    {
        protected override void SetValues()
        {
            // TODO: Don't show the user's recipes.
            KeySelector = r => r.posting_date;
        }
    }
}
