using System;
using System.Linq;
using System.Threading.Tasks;

using RecipeApp.Core.Models;
using RecipeApp.Core.Services;
using RecipeApp.Helpers;

namespace RecipeApp.ViewModels
{
    public class RecipesDetailViewModel : Observable
    {
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public RecipesDetailViewModel()
        {
        }

        public async Task InitializeAsync(long orderID)
        {
            var data = await SampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }
}
