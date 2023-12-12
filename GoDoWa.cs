using System;
namespace broodwar.lib
{
    public class GoDoWa
    {
        public string ReturnReturn(string[] x)
        {
            string strTemp = string.Empty;
            try
            {
                strTemp = x[0] + x[1];
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return strTemp;
        }
    }
}
