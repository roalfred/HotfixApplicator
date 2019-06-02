using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotfix_Applicator
{
    class Validator
    {
        public List<Byte[]> ValidateIP(String address)
        {
            List<Byte[]> octects = new List<byte[]>();
            String[] segments;
            try
            {
                segments = address.Trim().Split('.');
                foreach (String segment in segments)
                {
                    octects.Add(new Byte() { segment });
                }
            }
            catch (Exception)
            {
                octects.Clear();
                throw;
            }
            return octects;
        }
    }
}
