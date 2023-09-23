using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcProject2.Models
{
    public class CustomerIdViewModel
    {
        public int Id { get; set; }


        public readonly List<SelectListItem> CustomerIdSelectedList;
        public CustomerIdViewModel(List<string> customerIds)
        {
            CustomerIdSelectedList = new List<SelectListItem>();
            foreach (var no in customerIds)
            {
                CustomerIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}
