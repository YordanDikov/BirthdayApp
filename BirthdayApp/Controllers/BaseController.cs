using BirthdayApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApp.Controllers
{
    public class BaseController : Controller
    {
        protected IUnitOfWork data = new UnitOfWork();
    }
}
