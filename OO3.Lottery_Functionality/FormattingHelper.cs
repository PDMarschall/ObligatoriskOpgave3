using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality
{
    public static class FormattingHelper
    {
        public static string CenterString(string input, int spaces)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(new String(' ', spaces)); //insert correct amount of spaces for centering
            builder.Append(input);

            return builder.ToString();
        }
    }
}
