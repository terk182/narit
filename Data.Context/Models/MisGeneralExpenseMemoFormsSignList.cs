using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class MisGeneralExpenseMemoFormsSignList
    {
        public int Id { get; set; }
        public int? GeneralExpenseMemoFormsId { get; set; }
        public int? ProjectManagerSignatureId { get; set; }
        public string? ProjectManager { get; set; }
        public DateTime? ProjectManagerSignDate { get; set; }
        public int? ProjectManagerStaffId { get; set; }
        public string? ProjectManagerPosition { get; set; }
        public bool? Active { get; set; }
        public string? Comment { get; set; }
        public string? SignImgPath { get; set; }
        public int? Seq { get; set; }
    }
}
