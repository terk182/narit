using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Dtos
{
    public class RequestApproveOrderCheckformDto
    {
        //internal class RequestDto
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; } = null!;
        //    public bool Active { get; set; }
        //}
            //public int RequestDtoId { get; set; }
            //public string RequestDtoName { get; set; } = null!;
            //public bool RequestDtoActive { get; set; }
            //public DateTime? RequestDtoWriteDate { get; set; }
            //public string RequestDtoDocumentNumber { get; set; } = null!;
            //public string RequestDtoDepartmentName { get; set; } = null!;
            //public decimal? RequestDtoMedianPrice { get; set; }
        public List<RequestForm>? requestForms { get; set; }

            
    }
}
