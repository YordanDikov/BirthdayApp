using BirthdayApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApp.Controllers
{
    public class CategoriesController : BaseController
    {
        public ActionResult Friends()
        {
            return GetViewByCategoryName("Friends");
        }

        public ActionResult Family()
        {
            return GetViewByCategoryName("Family");
        }

        private ActionResult GetViewByCategoryName(string category)
        {
            var categoryModel = this.data.Categories.All().Select(x => new CategoryViewModel()
                                    {
                                        Name = x.Name,
                                        CategoryId = x.CategoryId,
                                        Images = x.Images.Select(img => new ImageViewModel()
                                        {
                                            ImageId = img.ImageId,
                                            Url = img.Url,
                                            Description = img.Description
                                        })
                                    }).FirstOrDefault(x => x.Name == category);
            if (categoryModel == null)
            {
                throw new NullReferenceException();
            }
            return View("Details", categoryModel);
        }

    }
}
