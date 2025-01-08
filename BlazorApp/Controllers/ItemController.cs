using BlazorApp.Client;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    [HttpGet]
    public LoadResult GetItems(DataSourceLoadOptions loadOptions)
    {
        return DataSourceLoader.Load(
            new List<Item>
            {
                new Item{Id = 1, Text1 = "Item 1 Text1", Text2 = "Item 1 Text2", Value1 = 1, Value2 = 4, Value3 = 7},
                new Item{Id = 2, Text1 = "Item 2 Text1", Text2 = "Item 2 Text2", Value1 = 2, Value2 = 5, Value3 = 8},
                new Item{Id = 3, Text1 = "Item 3 Text1", Text2 = "Item 3 Text2", Value1 = 3, Value2 = 6, Value3 = 9},
            }
            , loadOptions);
    }
}
