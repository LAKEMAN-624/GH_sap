using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace gh_sap
{
    public class gh_sapInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "ghsap";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("1f9d256d-951d-4320-9746-aece91d2cbfc");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
