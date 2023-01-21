﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace narit_acc_api.Models
{
    public partial class CGI_ACCContext : DbContext
    {
        public CGI_ACCContext()
        {
        }

        public CGI_ACCContext(DbContextOptions<CGI_ACCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountForm> AccountForms { get; set; } = null!;
        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        public virtual DbSet<Accounting> Accountings { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BusinessType> BusinessTypes { get; set; } = null!;
        public virtual DbSet<ChartAcc> ChartAccs { get; set; } = null!;
        public virtual DbSet<ChartDetail> ChartDetails { get; set; } = null!;
        public virtual DbSet<ChartHeader> ChartHeaders { get; set; } = null!;
        public virtual DbSet<ChartMajor> ChartMajors { get; set; } = null!;
        public virtual DbSet<ChartMinor> ChartMinors { get; set; } = null!;
        public virtual DbSet<ChartSubHeader> ChartSubHeaders { get; set; } = null!;
        public virtual DbSet<ChartSubMajor> ChartSubMajors { get; set; } = null!;
        public virtual DbSet<ChartSubMinor> ChartSubMinors { get; set; } = null!;
        public virtual DbSet<Creditor> Creditors { get; set; } = null!;
        public virtual DbSet<CreditorType> CreditorTypes { get; set; } = null!;
        public virtual DbSet<Debtor> Debtors { get; set; } = null!;
        public virtual DbSet<DebtorType> DebtorTypes { get; set; } = null!;
        public virtual DbSet<JournalForm> JournalForms { get; set; } = null!;
        public virtual DbSet<TaxType> TaxTypes { get; set; } = null!;
        public virtual DbSet<Transection> Transections { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.2.176,49176;Database=CGI_ACC;User ID=admin;Password=Aa!12345;Trusted_Connection=false ;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountForm>(entity =>
            {
                entity.ToTable("AccountForm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountFromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AccountFromCODE");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PrintForm).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("AccountType");

                entity.HasIndex(e => e.TypeCode, "IX_AccountType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Accounting>(entity =>
            {
                entity.ToTable("Accounting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountBook)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillId).HasColumnName("BillID");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DescId).HasColumnName("DescID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessType>(entity =>
            {
                entity.ToTable("BusinessType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EngName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChartAcc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChartACC");

                entity.Property(e => e.ChartHeaderId).HasColumnName("ChartHeaderID");

                entity.Property(e => e.ChartHeaderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartMajorId).HasColumnName("ChartMajorID");

                entity.Property(e => e.ChartMajorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartMinorId).HasColumnName("ChartMinorID");

                entity.Property(e => e.ChartMinorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartSubHeaderId).HasColumnName("ChartSubHeaderID");

                entity.Property(e => e.ChartSubHeaderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartSubMajorId).HasColumnName("ChartSubMajorID");

                entity.Property(e => e.ChartSubMajorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartSubMinorId).HasColumnName("ChartSubMinorID");

                entity.Property(e => e.ChartSubMinorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChartDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChartDetail");

                entity.Property(e => e.ChartHeaderId).HasColumnName("ChartHeaderID");

                entity.Property(e => e.ChartHeaderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartMajorId).HasColumnName("ChartMajorID");

                entity.Property(e => e.ChartMajorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartMinorId).HasColumnName("ChartMinorID");

                entity.Property(e => e.ChartMinorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartSubId).HasColumnName("ChartSubID");

                entity.Property(e => e.ChartSubName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChartHeader>(entity =>
            {
                entity.ToTable("ChartHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccTypeId).HasColumnName("AccTypeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChartHeaderCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ChartHeaderCODE");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccType)
                    .WithMany(p => p.ChartHeaders)
                    .HasForeignKey(d => d.AccTypeId)
                    .HasConstraintName("FK_AccTypeID_ChartHeader_AccountType");
            });

            modelBuilder.Entity<ChartMajor>(entity =>
            {
                entity.ToTable("ChartMajor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccTypeId).HasColumnName("AccTypeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChartMajorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ChartMajorCODE");

                entity.Property(e => e.ChartSubHeaderId).HasColumnName("ChartSubHeaderID");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((3))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccType)
                    .WithMany(p => p.ChartMajors)
                    .HasForeignKey(d => d.AccTypeId)
                    .HasConstraintName("FK_AccTypeID_ChartMajor_AccountType");

                entity.HasOne(d => d.ChartSubHeader)
                    .WithMany(p => p.ChartMajors)
                    .HasForeignKey(d => d.ChartSubHeaderId)
                    .HasConstraintName("FK_ChartMajor_ChartSubHeader");
            });

            modelBuilder.Entity<ChartMinor>(entity =>
            {
                entity.ToTable("ChartMinor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccTypeId).HasColumnName("AccTypeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChartMinorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ChartMinorCODE");

                entity.Property(e => e.ChartSubMajorId).HasColumnName("ChartSubMajorID");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((5))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccType)
                    .WithMany(p => p.ChartMinors)
                    .HasForeignKey(d => d.AccTypeId)
                    .HasConstraintName("FK_AccTypeID_ChartMinor_AccountType");

                entity.HasOne(d => d.ChartSubMajor)
                    .WithMany(p => p.ChartMinors)
                    .HasForeignKey(d => d.ChartSubMajorId)
                    .HasConstraintName("FK_ChartMinor_ChartSubMajor");
            });

            modelBuilder.Entity<ChartSubHeader>(entity =>
            {
                entity.ToTable("ChartSubHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccTypeId).HasColumnName("AccTypeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChartHeaderId).HasColumnName("ChartHeaderID");

                entity.Property(e => e.ChartSubHeaderCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ChartSubHeaderCODE");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((2))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccType)
                    .WithMany(p => p.ChartSubHeaders)
                    .HasForeignKey(d => d.AccTypeId)
                    .HasConstraintName("FK_AccTypeID_ChartSubHeader_AccountType");

                entity.HasOne(d => d.ChartHeader)
                    .WithMany(p => p.ChartSubHeaders)
                    .HasForeignKey(d => d.ChartHeaderId)
                    .HasConstraintName("FK_ChartSubHeader_ChartHeader");
            });

            modelBuilder.Entity<ChartSubMajor>(entity =>
            {
                entity.ToTable("ChartSubMajor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccTypeId).HasColumnName("AccTypeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChartMajorId).HasColumnName("ChartMajorID");

                entity.Property(e => e.ChartSubMajorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ChartSubMajorCODE");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((4))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccType)
                    .WithMany(p => p.ChartSubMajors)
                    .HasForeignKey(d => d.AccTypeId)
                    .HasConstraintName("FK_AccTypeID_ChartSubMajor_AccountType");

                entity.HasOne(d => d.ChartMajor)
                    .WithMany(p => p.ChartSubMajors)
                    .HasForeignKey(d => d.ChartMajorId)
                    .HasConstraintName("FK_ChartSubMajor_ChartMajor");
            });

            modelBuilder.Entity<ChartSubMinor>(entity =>
            {
                entity.ToTable("ChartSubMinor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccTypeId).HasColumnName("AccTypeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChartMinorId).HasColumnName("ChartMinorID");

                entity.Property(e => e.ChartSubMinorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ChartSubMinorCODE");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((6))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccType)
                    .WithMany(p => p.ChartSubMinors)
                    .HasForeignKey(d => d.AccTypeId)
                    .HasConstraintName("FK_AccTypeID_ChartSubMinor_ChartSubMinor");

                entity.HasOne(d => d.ChartMinor)
                    .WithMany(p => p.ChartSubMinors)
                    .HasForeignKey(d => d.ChartMinorId)
                    .HasConstraintName("FK_ChartSubMinor_ChartMinor");
            });

            modelBuilder.Entity<Creditor>(entity =>
            {
                entity.ToTable("Creditor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Branch)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");

                entity.Property(e => e.CertificateOfPartnershipDate).HasColumnType("date");

                entity.Property(e => e.ContactDate).HasColumnType("datetime");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreditorTypeId).HasColumnName("CreditorTypeID");

                entity.Property(e => e.District)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubDistrict)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CreditorType>(entity =>
            {
                entity.ToTable("CreditorType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.CreditorTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CreditorTypeCODE");

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.CreditorTypes)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("FK_AccountPayableType_AccountType");
            });

            modelBuilder.Entity<Debtor>(entity =>
            {
                entity.ToTable("Debtor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Branch)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");

                entity.Property(e => e.ContactDate)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorTypeId).HasColumnName("DebtorTypeID");

                entity.Property(e => e.District)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubDistrict)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DebtorType>(entity =>
            {
                entity.ToTable("DebtorType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChartSubMinorId).HasColumnName("ChartSubMinorID");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DebtorTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DebtorTypeCODE");

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChartSubMinor)
                    .WithMany(p => p.DebtorTypes)
                    .HasForeignKey(d => d.ChartSubMinorId)
                    .HasConstraintName("FK_AccountReceivableType_AccountType");
            });

            modelBuilder.Entity<JournalForm>(entity =>
            {
                entity.ToTable("JournalForm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountFormId).HasColumnName("AccountFormID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Index).HasDefaultValueSql("((1))");

                entity.Property(e => e.JournalFormCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JournalFormCODE");

                entity.Property(e => e.NameEng)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NameTh)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountForm)
                    .WithMany(p => p.JournalForms)
                    .HasForeignKey(d => d.AccountFormId)
                    .HasConstraintName("FK_JournalForm_JournalForm");
            });

            modelBuilder.Entity<TaxType>(entity =>
            {
                entity.ToTable("TaxType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transection>(entity =>
            {
                entity.ToTable("Transection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DebtorTypeId).HasColumnName("DebtorTypeID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransectionTypeId).HasColumnName("TransectionTypeID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
