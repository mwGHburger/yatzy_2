using System.Collections.Generic;
using Xunit;

namespace Yatzy.Tests
{
    public class CategoryTests
    {
         [Theory]
         [InlineData("yatzy")]
         public void ShouldRemoveCategoryForCategoriesCollection(string categoryName)
         {
            var category = new Category();
            category.CreateCategories();
            category.RemoveCategory(categoryName);

            Assert.False(category.Categories.ContainsKey(categoryName));
            Assert.True(category.Categories.ContainsKey("full house"));
         }

         [Fact]
         public void ShouldCreateCategoriesList()
         {
             var category = new Category();
             category.CreateCategories();

             Assert.True(category.Categories.Count > 0);
         }

    }
}