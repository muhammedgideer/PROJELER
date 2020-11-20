using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyAraba : IGaleri
    {
        private BTKArabaBilgileri _btkObject;
        private bool LoadRealObject = false;
        private string userInfo = string.Empty;
        private string GetArabaFromBTK()
            {
                try{
                _btkObject = new BTKArabaBilgileri();
                userInfo = _btkObject.GetAraba();
                LoadRealObject = true;
                return userInfo;
                }
                catch
                {
                LoadRealObject = false;
                return "";
                }
            }
        public string GetAraba()
        {
            LoadRealObject = false;
            string result = "";
            if(_btkObject == null)
            {
                result = GetArabaFromBTK();
            }
            if (!LoadRealObject)
                return userInfo;
            else
                return result;
        }
    }
}
