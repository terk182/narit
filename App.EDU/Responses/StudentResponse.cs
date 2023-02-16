using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EDU.Responses
{
    public class StudentResponse
    {
        public List<Datum>? data { get; set; }
        public int totalRecords { get; set; }
        public int pageCount { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public List<OrderBy>? orderBy { get; set; }
    }
    public class Curriculumn
    {
        public int ID { get; set; }
        public string? Code { get; set; }
        public string? Department { get; set; }
        public string? Title { get; set; }
        public string? TitleEn { get; set; }
        public int StartYear { get; set; }
        public object? ChangeYear { get; set; }
        public object? RefID { get; set; }
        public string? Degree { get; set; }
        public string? DegreeEn { get; set; }
        public string? DegreeShot { get; set; }
        public string? DegreeShotEn { get; set; }
        public object? Major { get; set; }
        public int Credit { get; set; }
        public object? Plo { get; set; }
        public object? Ylo { get; set; }
        public object? ApprovedAt { get; set; }
        public object? AcceptedCheco_at { get; set; }
    }

    public class Datum
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string? Code { get; set; }
        public string? Prefix { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? PrefixEn { get; set; }
        public string? FnameEn { get; set; }
        public string? LnameEn { get; set; }
        public object? Picture { get; set; }
        public string? Country { get; set; }
        public int StartYear { get; set; }
        public int FinishYear { get; set; }
        public int LevelID { get; set; }
        public object? Phone { get; set; }
        public string? Email { get; set; }
        public object? Line { get; set; }
        public object? Facebook { get; set; }
        public object? Instargram { get; set; }
        public object? Twitter { get; set; }
        public int Status { get; set; }
        public int CurrID { get; set; }
        public int DepartID { get; set; }
        public int? ScholarShipID { get; set; }
        public object? CreatedAt { get; set; }
        public object? UpdatedAt { get; set; }
        public object? DeletedAt { get; set; }
        public DateTime? ScholarShipApprovedAt { get; set; }
        public int? ScholarShipApprovedBy { get; set; }
        public Curriculumn? Curriculumn { get; set; }
        public Department? Department { get; set; }
        public List<TakeTerm>? TakeTerm { get; set; }
    }

    public class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }

    public class OrderBy
    {
        public string? ID { get; set; }
    }

   

    public class TakeTerm
    {
        public int ID { get; set; }
        public int Year { get; set; }
        public int Term { get; set; }
        public int Status { get; set; }
        public int isPay { get; set; }
        public int UserID { get; set; }
        public object? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public object? DeletedAt { get; set; }
        public DateTime UsetSubmitAt { get; set; }
    }

}
