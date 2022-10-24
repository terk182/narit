using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.SEC.enums
{
    public enum GovExpenseType
    {

        [Display(Name = "ไม่ระบุ")]
        [Description("ไม่ระบุ")]
        type1 = 0,
        [Display(Name = "รายจ่ายประจำ")]
        [Description("10")]
        type2 = 10,
        [Display(Name = "รายจ่ายลงทุน")]
        [Description("20")]
        type3 = 10,

    }
}
