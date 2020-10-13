using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UMSTestJS.Extentions
{
    public static class IEnumerableExtention
    {
        public static IEnumerable<SelectListItem> ToSelectListItems<T> (this IEnumerable<T> items, int selectedValue)
        {
            return from item in items 
                select new SelectListItem
                {
                    Text = item.GetPropertyValue("Name"),
                    Value = item.GetPropertyValue("Id"),
                    Selected = item.GetPropertyValue("Id").Equals(selectedValue.ToString())
                };
        }
    }
}