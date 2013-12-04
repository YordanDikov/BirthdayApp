using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public IEnumerable<ImageViewModel> Images { get; set; }

        public CategoryViewModel()
        {
            this.Images = new List<ImageViewModel>();
        }
    }
}