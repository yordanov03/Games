using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Blackjack.Models.Common
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum en)
        {
            if (en == null)
                return "<none selected>";

            try
            {
                FieldInfo field = en.GetType().GetField(en.ToString());

                if (field == null)
                    return en.ToString();

                var attributes = (NameAttribute[])field.GetCustomAttributes(typeof(NameAttribute), false);

                if (attributes.Length > 0)
                    return attributes[0].Name;
                else
                    return en.ToString();
            }
            catch
            {
                return en.ToString();
            }
        }
    }
}
