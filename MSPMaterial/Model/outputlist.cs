//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSPMaterial.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class outputlist
    {
        public string ID { get; set; }
        public System.DateTime Time { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Material_Name { get; set; }
        public string User_Name { get; set; }
        public string Material_ID { get; set; }
        public string Update_User { get; set; }
        public Nullable<System.DateTime> Update_Time { get; set; }
    }
}