using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFindBL
{
    public class UFile    {
        static List<University> universities = new List<University>();

        public static University SearchUniversity(string type)
        {
            University foundUniversity = null;

            foreach (University univer in universities)
            {
                if (univer.type.Contains(type))
                {
                    foundUniversity = univer;
                    break;
                }
            }
            return foundUniversity;
        }


    }

}
