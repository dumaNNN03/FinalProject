using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules 
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var rule in logics)
            {
                if (rule.Success == false)
                {
                    return rule;
                }
            }
            return null;
        }
    }
}
