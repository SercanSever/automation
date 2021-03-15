using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Automation.Core.Utilities.File
{
    public static class GetExtension
    {
        public static string GetFileExtension(this HttpPostedFileBase files)
        {
            string extensions = new FileInfo(files.FileName).Extension;
            return extensions;
        }
    }
}
