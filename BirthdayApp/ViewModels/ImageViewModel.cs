using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.ViewModels
{
    public class ImageViewModel
    {
        public int ImageId { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }
    }
}