using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysApplication.Menu
{
    class KnownValueCalc
    {
        public static IEnumerable<menuObject> GetKnownValues()
        {
            try
            {

            } catch (Exception e)
            {
                throw new Exception("not yet implemented {0}", e);
            }
            yield return new menuObject() { Name = "blah", Marked =  false };
        }
    }
}
