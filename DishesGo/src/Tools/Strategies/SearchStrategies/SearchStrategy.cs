using DishesGo.Data;
using System;
using System.Linq.Expressions;

namespace DishesGo.src.Tools.Strategies.SearchStrategies
{
    public abstract class SearchStrategy<TKey>
    {
        public Expression<Func<Recipes, bool>> Predicat { get; protected set; } = r => r.recipe_id == r.recipe_id;
        public Expression<Func<Recipes, TKey>> KeySelector {  get; protected set; }

        public SearchStrategy()
        {
            SetValues();
        }

        protected abstract void SetValues();
    }
}
