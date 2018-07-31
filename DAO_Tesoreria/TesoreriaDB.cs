using System.Data.Linq.Mapping;
using System.Reflection;
using System;

namespace DAO_Tesoreria
{
    partial class TesoreriaDBDataContext
    {

        [Function(Name = "GetDate", IsComposable = true)]
        public DateTime GetSystemDate()
        {
            MethodInfo mi = MethodBase.GetCurrentMethod() as MethodInfo;
            return (DateTime)this.ExecuteMethodCall(this, mi, new object[] { }).ReturnValue;
        }
    }

    
}
