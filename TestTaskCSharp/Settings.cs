using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskCSharp
{
    static class Settings
    {
        private static bool deletePunctuation = false;
        private static int minLength = 0;

        public static bool DeletePunctuation
        {
            get
            {
                return deletePunctuation;
            }
            set
            {
                deletePunctuation = value;
            }
        }
        public static int MinLength
        {
            get
            {
                return minLength;
            }
            set
            {
                minLength = value;
            }
        }

        public static void ShowDialog()
        {
            EditParamsForm editParams = new EditParamsForm();
        }
    }
}
