using System;
using System.Collections.Generic;
using System.Text;
using NetRube.Data;
namespace HFCMS.Entity
{
    [TableName("CAdviceFeedback")]
    [PrimaryKey("Id")]
    public class CAdviceFeedback
    {
        public Int32? Id { get;set; }
        public Int32? UserId { get;set; }
        public String UserName { get;set; }
        public String QQ { get;set; }
        public String Email { get;set; }
        public String Telphone { get;set; }
        public String Content { get;set; }
        public String Remark { get;set; }
        public Int32? IsRead { get;set; }
        public DateTime? CreateTime { get;set; }
        public Int32? CreateId { get;set; }
    }
}