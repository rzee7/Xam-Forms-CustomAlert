using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAlert
{
    public class Constants
    {
        public const string SuccessImage = "success";
        public const string FailImage = "fail";
        public const string InfoImage = "info";

        public static string GetImage(AlertTypes type)
        {
            string fileName = string.Empty;
            switch (type)
            {
                case AlertTypes.Success:
                    fileName = SuccessImage; ;
                    break;
                case AlertTypes.Error:
                    fileName = FailImage;
                    break;
                case AlertTypes.Info:
                    fileName = InfoImage;
                    break;
                default:
                    break;
            }
            return string.Format("{0}.{1}.png", typeof(Constants).GetTypeInfo().Assembly.GetName(), fileName);
        }
    }
    public enum AlertTypes
    {
        Success,
        Error,
        Info
    }
}
