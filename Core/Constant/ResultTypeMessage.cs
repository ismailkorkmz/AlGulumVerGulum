using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Constant
{
    public static class ResultTypeMessage
    {
        public static string Add()
        {
            return "Ekleme Başarılı";
        }
        public static string Warning()
        {
            return "Beklenmedik Bir Hata";
        }
        public static string Error(Exception ex)
        {
            return "Error:" + ex.ToInnest().Message;
        }
    }
}
