using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.Common.enums
{
    public enum ActionTypeEnum
    {
        [Display(Name = "อ่าน")]
        [Description("5")]
        A,
        [Display(Name = "e-mail")]
        [Description("7")]
        B,
        [Display(Name = "e-mail แจ้งเตือนการคืนเงินเหลือจ่าย")]
        [Description("8")]
        C,
        [Display(Name = "พิมพ์")]
        [Description("15")]
        D,
        [Display(Name = "บันทึกข้อมูล")]
        [Description("20")]
        E,
        [Display(Name = "ลบข้อมูล")]
        [Description("30")]
        F,
        [Display(Name = "ส่งดำเนินการ")]
        [Description("35")]
        G,
        [Display(Name = "ส่งคืนแก้งบ")]
        [Description("40")]
        H,
        [Display(Name = "ผู้ตรวจสอบ(หอดูดาว)รับเอกสาร")]
        [Description("200")]
        I,
        [Display(Name = "ผู้ตรวจสอบ(หอดูดาว)ตีกลับเอกสาร")]
        [Description("210")]
        J,
        [Display(Name = "ไม่เห็นชอบโดยผู้ตรวจสอบ(หอดูดาว)")]
        [Description("220")]
        K,
        [Display(Name = "เห็นชอบโดยผู้ตรวจสอบ(หอดูดาว)")]
        [Description("230")]
        L,
        [Display(Name = "หัวหน้างานรับเอกสาร")]
        [Description("300")]
        M,
        [Display(Name = "หัวหน้างานตีกลับเอกสาร")]
        [Description("310")]
        N,
        [Display(Name = "ไม่เห็นชอบโดยหัวหน้างาน")]
        [Description("320")]
        O,
        [Display(Name = "เห็นชอบโดยหัวหน้างาน")]
        [Description("330")]
        P,
        [Display(Name = "เจ้าของงบรับเอกสาร")]
        [Description("400")]
        Q,
        [Display(Name = "เจ้าของงบตีกลับเอกสาร")]
        [Description("410")]
        R,
        [Display(Name = "ไม่เห็นชอบโดยเจ้าของงบ")]
        [Description("420")]
        S,
        [Display(Name = "เห็นชอบโดยเจ้าของงบ")]
        [Description("430")]
        T,
        [Display(Name = "งานบุคคลรับเอกสาร")]
        [Description("500")]
        U,
        [Display(Name = "งานบุคคลตีกลับเอกสาร")]
        [Description("510")]
        V,
        [Display(Name = "ไม่เห็นชอบโดยงานบุคคล")]
        [Description("520")]
        W,
        [Display(Name = "เห็นชอบโดยงานบุคคล")]
        [Description("530")]
        X,
        [Display(Name = "งานพัสดุรับเอกสาร")]
        [Description("600")]
        Y,
        [Display(Name = "งานพัสดุตีกลับเอกสาร")]
        [Description("610")]
        Z,
        [Display(Name = "ไม่เห็นชอบโดยงานพัสดุ")]
        [Description("620")]
        AA,
        [Display(Name = "เห็นชอบโดยงานพัสดุ")]
        [Description("630")]
        AB,
        [Display(Name = "งานการเงินรับเอกสาร")]
        [Description("700")]
        AC,
        [Display(Name = "งานการเงินตีกลับเอกสาร")]
        [Description("710")]
        AD,
        [Display(Name = "ไม่เห็นชอบโดยงานการเงิน")]
        [Description("720")]
        AE,
        [Display(Name = "เห็นชอบโดยงานการเงิน")]
        [Description("730")]
        AF,
        [Display(Name = "รับเอกสาร(ตัดงบ)")]
        [Description("800")]
        AG,
        [Display(Name = "ตีกลับเอกสาร(ตัดงบ)")]
        [Description("810")]
        AH,
        [Display(Name = "ไม่เห็นชอบ(ตัดงบ)")]
        [Description("820")]
        AI,
        [Display(Name = "เห็นชอบ(ตัดงบ)")]
        [Description("830")]
        AJ,
        [Display(Name = "หน.การเงินรับเอกสาร")]
        [Description("900")]
        AK,
        [Display(Name = "หน.การเงินตีกลับเอกสาร")]
        [Description("910")]
        AL,
        [Display(Name = "ไม่เห็นชอบโดยหน.การเงิน")]
        [Description("920")]
        AM,
        [Display(Name = "เห็นชอบโดยหน.การเงิน")]
        [Description("930")]
        AN,
        [Display(Name = "เลขารับเอกสาร")]
        [Description("950")]
        AO,
        [Display(Name = "เลขาตีกลับเอกสาร")]
        [Description("960")]
        AP,
        [Display(Name = "ไม่เห็นชอบโดยเลขา")]
        [Description("970")]
        AQ,
        [Display(Name = "เห็นชอบโดยเลขา")]
        [Description("980")]
        AR,
        [Display(Name = "ผู้อนุมัติรับเอกสาร")]
        [Description("1000")]
        AS,
        [Display(Name = "ผู้อนุมัติตีกลับเอกสาร")]
        [Description("1000")]
        AT,
        [Display(Name = "ผู้อนุมัติตีกลับเอกสาร")]
        [Description("1010")]
        AU,
        [Display(Name = "ไม่อนุมัติโดยผู้อนุมัติ")]
        [Description("1020")]
        AV,
        [Display(Name = "อนุมัติโดยผู้อนุมัติ")]
        [Description("1030")]
        AW,
 

    }

}
