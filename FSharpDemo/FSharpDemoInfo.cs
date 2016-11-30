using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace FSharpDemo
{
    public class FSharpDemoInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "FSharpDemo";
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
                return new Guid("93546d4b-cd7b-446c-b18b-0d639eb160d9");
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
