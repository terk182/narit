using App.SEC.Dtos;
using App.SEC.Models;
using App.SEC.Responses;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC
{
    public class SecServices : ISecServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public SecServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }

        public SecBaseResponse AddPlanCrudpolicy(PlanCrudpolicy policy)
        {
            _database.Entry(policy).State = policy.Id == 0 ? EntityState.Added :EntityState.Modified;
            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true: false;
            response.Messsage = result > 0 ? "success" : "error";
            return response;
        }

        public SecBaseResponse AddUpdatePlanCrudpolicy(PlanCrudpolicy policy)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentDto> DepartmentGetByFiscalYear(int FiscalYear)
        {
            var response = new List<DepartmentDto>();
            var department = new List<DepartmentDto>();
            var department_Parent = new List<DepartmentDto>();
            var result = _database.Departments.Where(x => x.FiscalYear == FiscalYear && x.Active).OrderBy(x => x.Name).ToList();
            foreach(var item in result)
            {
                // department.Id = item.ParentDepartment;
                
                foreach (var sub_department in item.InverseParentDepartment)
                {
                    
                    
                            foreach (var sub1_department in sub_department.InverseParentDepartment)
                            {
                                department_Parent.Add(new DepartmentDto
                                {
                                    Id = sub1_department.Id,
                                    Name = sub1_department.Name,
                                    FiscalYear = sub1_department.FiscalYear,
                                    Active = sub1_department.Active,
                                    ReferenceOldId = sub1_department.ReferenceOldId,
                                    ParentDepartmentId = sub1_department.ParentDepartmentId,
                                });
                            }


                        department.Add(new DepartmentDto
                        {
                                Id = sub_department.Id,
                                Name = sub_department.Name,
                                FiscalYear = sub_department.FiscalYear,
                                Active = sub_department.Active,
                                ReferenceOldId = sub_department.ReferenceOldId,
                                ParentDepartmentId = sub_department.ParentDepartmentId,
                                Department = department_Parent,
                                }
                        );
                    
                }
                response.Add(new DepartmentDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ReferenceOldId = item.ReferenceOldId,
                    ParentDepartmentId = item.ParentDepartmentId,
                    Department = department
                });
       
            }
             return response;
        }

        public List<BudgetType> GetByFiscalYear(int FiscalYear)
        {
            return _database.BudgetTypes.Where(x => x.FiscalYear == FiscalYear ).ToList();

        }

        public List<ViewPlanForActivityByDepartmentTable> GetById(int departmentId)
        {
            decimal _TotalBudgetCache = 0;
            decimal _TotalAmount = 0;
            decimal _NetAmount = 0;
            decimal ll = 0;
            var loop1 = new List<PlanItem>();
            var _datalist = new List<ViewPlanForActivityByDepartmentTable>();
            var _datalist_sub = new List<ViewPlanForActivityByDepartmentTable>();
            var data = _database.Departments.Where(x => x.ParentDepartmentId == departmentId && x.Active ).Include(x => x.PlanActivities).Include(x=> x.PlanCores).ToList();
            foreach (var department in data)
            {
                foreach(var item in department.PlanActivities)
                {
                    _TotalBudgetCache = 0;
                    _TotalAmount = 0;
                    _NetAmount = 0;
                    var planItem_list = _database.PlanItems.Where(x => x.PlanActivityId == item.Id).Include(x => x.MonthlyForecasts).Include(x => x.BudgetTransferInwardPlanItems).Include(x => x.BudgetTransferOutwardPlanItems).ToList();
                    foreach (var _MonthlyForecasts in planItem_list)
                    {
                        _TotalBudgetCache +=  _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount * x.BudgetPerPiece);
                        _TotalAmount += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount );
                        _NetAmount += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount);
                    }
                    _datalist_sub.Add(new ViewPlanForActivityByDepartmentTable
                    {
                        Name = item.Name,
                        TotalBudget = _TotalBudgetCache,
                       
                        


                    });


                }


                _datalist.Add(new ViewPlanForActivityByDepartmentTable
                {
                    Name = department.Name,
                    TotalBudget = _TotalBudgetCache,
                    subdata = _datalist_sub


                });

            }
           // var table_data = _database.Departments.Where(x => x.FiscalYear == data[0].FiscalYear).ToList();
            return _datalist;
        }

        public PlanCrudpolicy GetPolicy(int year)
        {
            return _database.PlanCrudpolicies.Where(x => x.FiscalYear == year && x.Active).OrderBy(x => x.Name).FirstOrDefault();
          
        }

        
    }
}
