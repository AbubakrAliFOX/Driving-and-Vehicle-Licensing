using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Global_Classes
{
    internal static class clsGlobal
    {
        public static clsUser LoggedInUser { get; set; }

        public static string ProfileImagesDirectory = "E:\\Downloads\\WebDev\\Projects\\DVL\\Assets\\ProfilePics";
    }
}
