using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace narit_mis_api.Models
{
    public partial class CGI_MISContext : DbContext
    {
        public CGI_MISContext()
        {
        }

        public CGI_MISContext(DbContextOptions<CGI_MISContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BudgetBureauPlan> BudgetBureauPlans { get; set; } = null!;
        public virtual DbSet<BudgetBureauProject> BudgetBureauProjects { get; set; } = null!;
        public virtual DbSet<BudgetBureauStrategy> BudgetBureauStrategies { get; set; } = null!;
        public virtual DbSet<BudgetType> BudgetTypes { get; set; } = null!;
        public virtual DbSet<BudgetType1> BudgetTypes1 { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Department1> Departments1 { get; set; } = null!;
        public virtual DbSet<FundSource> FundSources { get; set; } = null!;
        public virtual DbSet<FundType> FundTypes { get; set; } = null!;
        public virtual DbSet<Mission> Missions { get; set; } = null!;
        public virtual DbSet<PlanType> PlanTypes { get; set; } = null!;
        public virtual DbSet<RequestBudget> RequestBudgets { get; set; } = null!;
        public virtual DbSet<RequestForm> RequestForms { get; set; } = null!;
        public virtual DbSet<RequestFormApprove> RequestFormApproves { get; set; } = null!;
        public virtual DbSet<RequestFormBorrowingMoney> RequestFormBorrowingMoneys { get; set; } = null!;
        public virtual DbSet<RequestFormBudgetType> RequestFormBudgetTypes { get; set; } = null!;
        public virtual DbSet<RequestFormComment> RequestFormComments { get; set; } = null!;
        public virtual DbSet<RequestFormDetail> RequestFormDetails { get; set; } = null!;
        public virtual DbSet<RequestFormExaminerForBudget> RequestFormExaminerForBudgets { get; set; } = null!;
        public virtual DbSet<RequestFormItem> RequestFormItems { get; set; } = null!;
        public virtual DbSet<RequestFormSchedule> RequestFormSchedules { get; set; } = null!;
        public virtual DbSet<ScheduleFisicalYear> ScheduleFisicalYears { get; set; } = null!;
        public virtual DbSet<Strategic> Strategics { get; set; } = null!;
        public virtual DbSet<StrategicIndicator> StrategicIndicators { get; set; } = null!;
        public virtual DbSet<StrategiesBudget> StrategiesBudgets { get; set; } = null!;
        public virtual DbSet<Strategy> Strategies { get; set; } = null!;
        public virtual DbSet<ViewBudgetBureauDetail> ViewBudgetBureauDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.2.176,49176;Database=CGI_MIS;User ID=admin;Password=Aa!12345;Trusted_Connection=false ;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BudgetBureauPlan>(entity =>
            {
                entity.HasIndex(e => e.FiscalYear, "IX_BudgetBureauPlans")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);
            });

            modelBuilder.Entity<BudgetBureauProject>(entity =>
            {
                entity.ToTable("BudgetBureauProject");

                entity.HasIndex(e => e.FiscalYear, "IX_BudgetBureauProject")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BudgetBureauPlansId).HasColumnName("BudgetBureauPlansID");

                entity.Property(e => e.BudgetBureauStrategiesId).HasColumnName("BudgetBureauStrategiesID");

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.HasOne(d => d.BudgetBureauPlans)
                    .WithMany(p => p.BudgetBureauProjects)
                    .HasForeignKey(d => d.BudgetBureauPlansId)
                    .HasConstraintName("FK_BudgetProject_BudgetPlan");

                entity.HasOne(d => d.BudgetBureauStrategies)
                    .WithMany(p => p.BudgetBureauProjects)
                    .HasForeignKey(d => d.BudgetBureauStrategiesId)
                    .HasConstraintName("FK_BudgetBureauProject_BudgetBureauStrategies");
            });

            modelBuilder.Entity<BudgetBureauStrategy>(entity =>
            {
                entity.HasIndex(e => e.FiscalYear, "IX_BudgetBureauStrategies")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);
            });

            modelBuilder.Entity<BudgetType>(entity =>
            {
                entity.ToTable("BudgetType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<BudgetType1>(entity =>
            {
                entity.ToTable("BudgetTypes", "Plan");

                entity.HasIndex(e => e.ParentBudgetTypeId, "IX_FK_BudgetTypeSubBudgetTypes");

                entity.HasOne(d => d.ParentBudgetType)
                    .WithMany(p => p.InverseParentBudgetType)
                    .HasForeignKey(d => d.ParentBudgetTypeId)
                    .HasConstraintName("FK_BudgetTypeSubBudgetTypes");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Department1>(entity =>
            {
                entity.ToTable("Departments", "Plan");

                entity.HasIndex(e => e.ParentDepartmentId, "IX_FK_DepartmentSubDepartments");

                entity.HasOne(d => d.ParentDepartment)
                    .WithMany(p => p.InverseParentDepartment)
                    .HasForeignKey(d => d.ParentDepartmentId)
                    .HasConstraintName("FK_DepartmentSubDepartments");
            });

            modelBuilder.Entity<FundSource>(entity =>
            {
                entity.ToTable("FundSource", "Plan");
            });

            modelBuilder.Entity<FundType>(entity =>
            {
                entity.ToTable("FundTypes", "Plan");

                entity.HasIndex(e => e.ParentFundTypeId, "IX_FK_FundTypeFundType");

                entity.HasOne(d => d.ParentFundType)
                    .WithMany(p => p.InverseParentFundType)
                    .HasForeignKey(d => d.ParentFundTypeId)
                    .HasConstraintName("FK_FundTypeFundType");
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.ToTable("Mission", "Plan");
            });

            modelBuilder.Entity<PlanType>(entity =>
            {
                entity.ToTable("PlanTypes", "Plan");

                entity.HasIndex(e => e.ParentPlanTypeId, "IX_FK_PlanTypeSubPlanTypes");

                entity.Property(e => e.Weight).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.ParentPlanType)
                    .WithMany(p => p.InverseParentPlanType)
                    .HasForeignKey(d => d.ParentPlanTypeId)
                    .HasConstraintName("FK_PlanTypeSubPlanTypes");
            });

            modelBuilder.Entity<RequestBudget>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.DocNo })
                    .HasName("PK_RequestFormBudget");

                entity.ToTable("RequestBudget");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AnotherAction).IsUnicode(false);

                entity.Property(e => e.CalculationDate).HasColumnType("datetime");

                entity.Property(e => e.CreateByStaffId)
                    .IsUnicode(false)
                    .HasColumnName("CreateByStaffID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Descriptions).IsUnicode(false);

                entity.Property(e => e.DocStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.Inform).IsUnicode(false);

                entity.Property(e => e.InspectorId).HasColumnName("InspectorID");

                entity.Property(e => e.InspectorName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Procurement).IsUnicode(false);

                entity.Property(e => e.RelatedRegulation).IsUnicode(false);

                entity.Property(e => e.StatmentName).IsUnicode(false);

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RequestForm>(entity =>
            {
                entity.ToTable("RequestForm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.BudgetTypeId).HasColumnName("BudgetTypeID");

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Descriptions).IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDepartureDate).HasColumnType("datetime");

                entity.Property(e => e.EndPracticalDate).HasColumnType("datetime");

                entity.Property(e => e.Lecturer).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.MakeBy).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objective).IsUnicode(false);

                entity.Property(e => e.PersonRemark).IsUnicode(false);

                entity.Property(e => e.Place).IsUnicode(false);

                entity.Property(e => e.ProjectActivityId).HasColumnName("ProjectActivityID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestBudgetId).HasColumnName("RequestBudgetID");

                entity.Property(e => e.Reward).IsUnicode(false);

                entity.Property(e => e.SkillType).IsUnicode(false);

                entity.Property(e => e.StartDepartureDate).HasColumnType("datetime");

                entity.Property(e => e.StartPracticalDate).HasColumnType("datetime");

                entity.HasOne(d => d.RequestBudget)
                    .WithMany(p => p.RequestForms)
                    .HasForeignKey(d => new { d.RequestBudgetId, d.DocNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFrom_RequestBudget");
            });

            modelBuilder.Entity<RequestFormApprove>(entity =>
            {
                entity.ToTable("RequestFormApprove");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DatetimeApprove).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");

                entity.Property(e => e.RequestBudgetId).HasColumnName("RequestBudgetID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StaffName).IsUnicode(false);

                entity.Property(e => e.StatusApprove).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.RequestBudget)
                    .WithMany(p => p.RequestFormApproves)
                    .HasForeignKey(d => new { d.RequestBudgetId, d.DocNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormApprove_RequestFormApprove");
            });

            modelBuilder.Entity<RequestFormBorrowingMoney>(entity =>
            {
                entity.ToTable("RequestFormBorrowingMoney");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestBudgetId).HasColumnName("RequestBudgetID");

                entity.Property(e => e.RequestLoan).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StaffName).IsUnicode(false);

                entity.HasOne(d => d.RequestBudget)
                    .WithMany(p => p.RequestFormBorrowingMoneys)
                    .HasForeignKey(d => new { d.RequestBudgetId, d.DocNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormBorrowingMoney_RequestBudget");
            });

            modelBuilder.Entity<RequestFormBudgetType>(entity =>
            {
                entity.ToTable("RequestFormBudgetType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RequestFormComment>(entity =>
            {
                entity.ToTable("RequestFormComment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Descriptions).IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestBudgetId).HasColumnName("RequestBudgetID");

                entity.Property(e => e.StaffId)
                    .IsUnicode(false)
                    .HasColumnName("StaffID");

                entity.Property(e => e.StaffName).IsUnicode(false);

                entity.HasOne(d => d.RequestBudget)
                    .WithMany(p => p.RequestFormComments)
                    .HasForeignKey(d => new { d.RequestBudgetId, d.DocNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormComment_RequestBudget");
            });

            modelBuilder.Entity<RequestFormDetail>(entity =>
            {
                entity.ToTable("RequestFormDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AnotherAction).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptions).IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InspectorsId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("InspectorsID");

                entity.Property(e => e.InspectorsName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Procurement).IsUnicode(false);

                entity.Property(e => e.RequestFormId).HasColumnName("RequestFormID");
            });

            modelBuilder.Entity<RequestFormExaminerForBudget>(entity =>
            {
                entity.ToTable("RequestFormExaminerForBudget");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Descriptions).IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExaminerRole).IsUnicode(false);

                entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RebudgetId).HasColumnName("RebudgetID");

                entity.Property(e => e.RequestBudgetId).HasColumnName("RequestBudgetID");

                entity.HasOne(d => d.RequestBudget)
                    .WithMany(p => p.RequestFormExaminerForBudgets)
                    .HasForeignKey(d => new { d.RequestBudgetId, d.DocNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormExaminerForBudget_RequestBudget");
            });

            modelBuilder.Entity<RequestFormItem>(entity =>
            {
                entity.ToTable("RequestFormItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Descriptions).IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LbActivityId).HasColumnName("LB_ActivityID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestBudgetId).HasColumnName("RequestBudgetID");

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.HasOne(d => d.RequestBudget)
                    .WithMany(p => p.RequestFormItems)
                    .HasForeignKey(d => new { d.RequestBudgetId, d.DocNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormItem_RequestBudget");
            });

            modelBuilder.Entity<RequestFormSchedule>(entity =>
            {
                entity.ToTable("RequestFormSchedule");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RequestBudgetId).HasColumnName("RequestBudgetID");

                entity.Property(e => e.RequestLoan).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.RequestBudget)
                    .WithMany(p => p.RequestFormSchedules)
                    .HasForeignKey(d => new { d.RequestBudgetId, d.DocNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormSchedule_RequestBudget");
            });

            modelBuilder.Entity<ScheduleFisicalYear>(entity =>
            {
                entity.ToTable("ScheduleFisicalYear", "Plan");

                entity.HasIndex(e => e.Name, "IX_ScheduleFisicalYear")
                    .IsUnique();

                entity.Property(e => e.AddPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.AddPlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.ApprovePlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.ApprovePlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.DisplayPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.DisplayPlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.EditPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.EditPlanCoreStatusStartDate).IsUnicode(false);
            });

            modelBuilder.Entity<Strategic>(entity =>
            {
                entity.ToTable("Strategic");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.StrategicCode).HasMaxLength(20);
            });

            modelBuilder.Entity<StrategicIndicator>(entity =>
            {
                entity.ToTable("StrategicIndicators", "Plan");

                entity.HasIndex(e => e.ParentStrategicIndicatorId, "IX_FK_ParentStrategicIndicatorSubStrategicIndicator");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.StrategyId).HasComment("");

                entity.Property(e => e.Unit).HasDefaultValueSql("('')");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.ParentStrategicIndicator)
                    .WithMany(p => p.InverseParentStrategicIndicator)
                    .HasForeignKey(d => d.ParentStrategicIndicatorId)
                    .HasConstraintName("FK_ParentStrategicIndicatorSubStrategicIndicator");
            });

            modelBuilder.Entity<StrategiesBudget>(entity =>
            {
                entity.ToTable("StrategiesBudgets", "Plan");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Strategy>(entity =>
            {
                entity.ToTable("Strategies", "Plan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.StrategicId)
                    .HasColumnName("StrategicID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StrategyCode).HasMaxLength(20);
            });

            modelBuilder.Entity<ViewBudgetBureauDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBudgetBureauDetail");

                entity.Property(e => e.BudgetBureauPlansId).HasColumnName("BudgetBureauPlansID");

                entity.Property(e => e.BudgetBureauPlansName).IsUnicode(false);

                entity.Property(e => e.BudgetBureauStrategiesId).HasColumnName("BudgetBureauStrategiesID");

                entity.Property(e => e.BudgetBureauStrategiesName).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
