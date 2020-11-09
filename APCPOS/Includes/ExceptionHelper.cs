using System;

namespace APCPOS.Includes
{
    public static class ExceptionHelper
    {
        public static int LineNumber(this Exception e)
        {
            int linenum = 0;
            try
            {
                linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(":line", StringComparison.Ordinal) + 5));
            }
            catch
            {
                //Stack trace is not available!
            }
            return linenum;
        }
        
    }
}
