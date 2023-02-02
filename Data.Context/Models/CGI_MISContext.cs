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

        public virtual DbSet<BudgetType> BudgetTypes { get; set; } = null!;
        public virtual DbSet<BudgetType1> BudgetTypes1 { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Department1> Departments1 { get; set; } = null!;
        public virtual DbSet<FundSource> FundSources { get; set; } = null!;
        public virtual DbSet<FundSource1> FundSources1 { get; set; } = null!;
        public virtual DbSet<FundType> FundTypes { get; set; } = null!;
        public virtual DbSet<Mission> Missions { get; set; } = null!;
        public virtual DbSet<Mission1> Missions1 { get; set; } = null!;
        public virtual DbSet<PlanBudget> PlanBudgets { get; set; } = null!;
        public virtual DbSet<PlanType> PlanTypes { get; set; } = null!;
        public virtual DbSet<PlanType1> PlanTypes1 { get; set; } = null!;
        public virtual DbSet<ProjectBudget> ProjectBudgets { get; set; } = null!;
        public virtual DbSet<ScheduleFisicalYear> ScheduleFisicalYears { get; set; } = null!;
        public virtual DbSet<StrategicIndicator> StrategicIndicators { get; set; } = null!;
        public virtual DbSet<StrategiesBudget> StrategiesBudgets { get; set; } = null!;
        public virtual DbSet<StrategiesBudget1> StrategiesBudgets1 { get; set; } = null!;
        public virtual DbSet<Strategy> Strategies { get; set; } = null!;
        public virtual DbSet<Strategy1> Strategies1 { get; set; } = null!;
        public virtual DbSet<ViewUserShowDetail> ViewUserShowDetails { get; set; } = null!;

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
            modelBuilder.Entity<BudgetType1>(entity =>
            {
                entity.ToTable("BudgetTypes", "Plan");

                entity.HasIndex(e => e.ParentBudgetTypeId, "IX_FK_BudgetTypeSubBudgetTypes");

                entity.HasOne(d => d.ParentBudgetType)
                    .WithMany(p => p.InverseParentBudgetType)
                    .HasForeignKey(d => d.ParentBudgetTypeId)
                    .HasConstraintName("FK_BudgetTypeSubBudgetTypes");
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
                entity.ToTable("FundSource");
            });

            modelBuilder.Entity<FundSource1>(entity =>
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
                entity.ToTable("Mission");
            });

            modelBuilder.Entity<Mission1>(entity =>
            {
                entity.ToTable("Mission", "Plan");
            });

            modelBuilder.Entity<PlanBudget>(entity =>
            {
                entity.ToTable("PlanBudget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<PlanType>(entity =>
            {
                entity.ToTable("PlanType");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(7, 4)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PlanType1>(entity =>
            {
                entity.ToTable("PlanTypes", "Plan");

                entity.HasIndex(e => e.ParentPlanTypeId, "IX_FK_PlanTypeSubPlanTypes");

                entity.Property(e => e.Weight).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.ParentPlanType)
                    .WithMany(p => p.InverseParentPlanType)
                    .HasForeignKey(d => d.ParentPlanTypeId)
                    .HasConstraintName("FK_PlanTypeSubPlanTypes");
            });

            modelBuilder.Entity<ProjectBudget>(entity =>
            {
                entity.ToTable("ProjectBudget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BudgetPlanId).HasColumnName("BudgetPlanID");

                entity.Property(e => e.BudgetStrategyId).HasColumnName("BudgetStrategyID");

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.BudgetPlan)
                    .WithMany(p => p.ProjectBudgets)
                    .HasForeignKey(d => d.BudgetPlanId)
                    .HasConstraintName("FK_BudgetProject_BudgetPlan");
            });

            modelBuilder.Entity<ScheduleFisicalYear>(entity =>
            {
                entity.ToTable("ScheduleFisicalYear", "Plan");

                entity.Property(e => e.AddPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.AddPlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.ApprovePlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.ApprovePlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.DisplayPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.DisplayPlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.EditPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.EditPlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
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
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<StrategiesBudget1>(entity =>
            {
                entity.ToTable("StrategiesBudgets", "Plan");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Strategy>(entity =>
            {
                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Strategy1>(entity =>
            {
                entity.ToTable("Strategies", "Plan");

                entity.HasIndex(e => e.ParentStrategyId, "IX_FK_StrategySubStrategies");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ParentStrategy)
                    .WithMany(p => p.InverseParentStrategy)
                    .HasForeignKey(d => d.ParentStrategyId)
                    .HasConstraintName("FK_StrategySubStrategies");
            });

            modelBuilder.Entity<ViewUserShowDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewUserShowDetail");

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.Emailaddress).IsUnicode(false);

                entity.Property(e => e.ImageUrl).IsUnicode(false);

                entity.Property(e => e.IsPdpa).HasColumnName("isPDPA");

                entity.Property(e => e.JobPositionName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Surname).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.Uuid).HasColumnName("UUID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
