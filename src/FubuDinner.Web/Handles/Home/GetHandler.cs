using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FubuDinner.Web.Handles.Home
{
    public class GetHandler
    {
        public HomeViewModel Execute()
        {
            return new HomeViewModel() { HelloMsg = "Hello Workshop!" };
        }
    }
}