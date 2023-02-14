using System;
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
        public virtual DbSet<AnnualBudget> AnnualBudgets { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BusinessType> BusinessTypes { get; set; } = null!;
        public virtual DbSet<ChartAcc> ChartAccs { get; set; } = null!;
        public virtual DbSet<ChartDetail> ChartDetails { get; set; } = null!;
        public virtual DbSet<ChartHeader> ChartHeaders { get; set; } = null!;
        public virtual DbSet<ChartMajor> ChartMajors { get; set; } = null!;
        public virtual DbSet<ChartMinor> ChartMinors { get; set; } = null!;
        public virtual DbSet<ChartMinorOld> ChartMinorOlds { get; set; } = null!;
        public virtual DbSet<ChartSubHeader> ChartSubHeaders { get; set; } = null!;
        public virtual DbSet<ChartSubMajor> ChartSubMajors { get; set; } = null!;
        public virtual DbSet<ContactAcc> ContactAccs { get; set; } = null!;
        public virtual DbSet<ContactBank> ContactBanks { get; set; } = null!;
        public virtual DbSet<ContactMain> ContactMains { get; set; } = null!;
        public virtual DbSet<ContactPerson> ContactPeople { get; set; } = null!;
        public virtual DbSet<ContactRef> ContactRefs { get; set; } = null!;
        public virtual DbSet<ContactSubtype> ContactSubtypes { get; set; } = null!;
        public virtual DbSet<Creditor> Creditors { get; set; } = null!;
        public virtual DbSet<CreditorType> CreditorTypes { get; set; } = null!;
        public virtual DbSet<Debtor> Debtors { get; set; } = null!;
        public virtual DbSet<DebtorType> DebtorTypes { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public virtual DbSet<FundsType> FundsTypes { get; set; } = null!;
        public virtual DbSet<Journal> Journals { get; set; } = null!;
        public virtual DbSet<JournalForm> JournalForms { get; set; } = null!;
        public virtual DbSet<PaymentDueType> PaymentDueTypes { get; set; } = null!;
        public virtual DbSet<PersonType> PersonTypes { get; set; } = null!;
        public virtual DbSet<SubAnnualBudget> SubAnnualBudgets { get; set; } = null!;
        public virtual DbSet<SubJournal> SubJournals { get; set; } = null!;
        public virtual DbSet<TaxType> TaxTypes { get; set; } = null!;
        public virtual DbSet<Transection> Transections { get; set; } = null!;
        public virtual DbSet<TransectionType> TransectionTypes { get; set; } = null!;
        public virtual DbSet<View1> View1s { get; set; } = null!;

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

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocCreator)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FundTypeId).HasColumnName("FundTypeID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefDocDate).HasColumnType("date");

                entity.Property(e => e.RefDocNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.SubjournalId).HasColumnName("SubjournalID");

                entity.Property(e => e.SubjournalNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.FundType)
                    .WithMany(p => p.Accountings)
                    .HasForeignKey(d => d.FundTypeId)
                    .HasConstraintName("FK_Accounting_FundsType");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.Accountings)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("FK_Accounting_Journal");

                entity.HasOne(d => d.Subjournal)
                    .WithMany(p => p.Accountings)
                    .HasForeignKey(d => d.SubjournalId)
                    .HasConstraintName("FK_Accounting_SubJournal");
            });

            modelBuilder.Entity<AnnualBudget>(entity =>
            {
                entity.ToTable("AnnualBudget");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessType>(entity =>
            {
                entity.ToTable("BusinessType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactTypeId)
                    .HasColumnName("ContactTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChartAcc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChartACC");

                entity.Property(e => e.ChartHeaderAccTypeId).HasColumnName("ChartHeaderAccTypeID");

                entity.Property(e => e.ChartHeaderId).HasColumnName("ChartHeaderID");

                entity.Property(e => e.ChartHeaderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartMajorAccTypeId).HasColumnName("ChartMajorAccTypeID");

                entity.Property(e => e.ChartMajorId).HasColumnName("ChartMajorID");

                entity.Property(e => e.ChartMajorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartSubHeaderAccTypeId).HasColumnName("ChartSubHeaderAccTypeID");

                entity.Property(e => e.ChartSubHeaderId).HasColumnName("ChartSubHeaderID");

                entity.Property(e => e.ChartSubHeaderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChartSubMajorId).HasColumnName("ChartSubMajorID");

                entity.Property(e => e.ChartSubMajorName)
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
                    .HasConstraintName("FK_AccTypeID_ChartSubMinor_ChartSubMinor");

                entity.HasOne(d => d.ChartSubMajor)
                    .WithMany(p => p.ChartMinors)
                    .HasForeignKey(d => d.ChartSubMajorId)
                    .HasConstraintName("FK_ChartSubMinor_ChartMinor");
            });

            modelBuilder.Entity<ChartMinorOld>(entity =>
            {
                entity.ToTable("ChartMinorOld");

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
                    .WithMany(p => p.ChartMinorOlds)
                    .HasForeignKey(d => d.AccTypeId)
                    .HasConstraintName("FK_AccTypeID_ChartMinor_AccountType");

                entity.HasOne(d => d.ChartSubMajor)
                    .WithMany(p => p.ChartMinorOlds)
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

            modelBuilder.Entity<ContactAcc>(entity =>
            {
                entity.ToTable("ContactACC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreditorTypeId).HasColumnName("CreditorTypeID");

                entity.Property(e => e.DebtorTypeId).HasColumnName("DebtorTypeID");

                entity.Property(e => e.PaymentDueTypeId).HasColumnName("PaymentDueTypeID");
            });

            modelBuilder.Entity<ContactBank>(entity =>
            {
                entity.ToTable("ContactBank");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BankBranch)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");
            });

            modelBuilder.Entity<ContactMain>(entity =>
            {
                entity.ToTable("ContactMain");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactSubTypeId).HasColumnName("ContactSubTypeID");

                entity.Property(e => e.ContactSurname)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.ContactWebsite)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredDistrict)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredProvince)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredSubdistrict)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContactSubType)
                    .WithMany(p => p.ContactMains)
                    .HasForeignKey(d => d.ContactSubTypeId)
                    .HasConstraintName("FK_ContactMain_ContactSubtype");
            });

            modelBuilder.Entity<ContactPerson>(entity =>
            {
                entity.ToTable("ContactPerson");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.PersonDepartment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonJobPosition)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonNickname)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonSurname)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactRef>(entity =>
            {
                entity.ToTable("ContactRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDistrict)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryProvince)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverySubdistrict)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactSubtype>(entity =>
            {
                entity.ToTable("ContactSubtype");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
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

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Debtor>(entity =>
            {
                entity.ToTable("Debtor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Branch)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");

                entity.Property(e => e.ContactDate)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorCode)
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

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChartMinorId).HasColumnName("ChartMinorID");

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

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChartMinor)
                    .WithMany(p => p.DebtorTypes)
                    .HasForeignKey(d => d.ChartMinorId)
                    .HasConstraintName("FK_AccountReceivableType_AccountType");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Characters)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialCharacters)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubJournalId)
                    .HasColumnName("SubJournalID")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_DocumentType");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("FK_Document_Journal");

                entity.HasOne(d => d.SubJournal)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.SubJournalId)
                    .HasConstraintName("FK_Document_SubJournal");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("DocumentType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Name_EN");

                entity.Property(e => e.NameTh)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Name_TH");
            });

            modelBuilder.Entity<FundsType>(entity =>
            {
                entity.ToTable("FundsType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.ToTable("Journal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
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

            modelBuilder.Entity<PaymentDueType>(entity =>
            {
                entity.ToTable("PaymentDueType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonType>(entity =>
            {
                entity.ToTable("PersonType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactTypeId)
                    .HasColumnName("ContactTypeID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubAnnualBudget>(entity =>
            {
                entity.ToTable("SubAnnualBudget");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnnualBudgetId).HasColumnName("AnnualBudgetID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AnnualBudget)
                    .WithMany(p => p.SubAnnualBudgets)
                    .HasForeignKey(d => d.AnnualBudgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubAnnualBudget_AnnualBudget");
            });

            modelBuilder.Entity<SubJournal>(entity =>
            {
                entity.ToTable("SubJournal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.Month)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Number).HasDefaultValueSql("((0))");

                entity.Property(e => e.Year)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.SubJournals)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("FK_SubJournal_Journal");
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

                entity.Property(e => e.DebtorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorTypeId).HasColumnName("DebtorTypeID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDate).HasColumnType("date");

                entity.Property(e => e.DetailName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FundsTypeId).HasColumnName("FundsTypeID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubAnnualBudgetId).HasColumnName("SubAnnualBudgetID");

                entity.Property(e => e.SubJournalId).HasColumnName("SubJournalID");

                entity.Property(e => e.TransectionTypeId).HasColumnName("TransectionTypeID");

                entity.HasOne(d => d.CreditNavigation)
                    .WithMany(p => p.TransectionCreditNavigations)
                    .HasForeignKey(d => d.Credit)
                    .HasConstraintName("FK_Transection_ChartSubMinor");

                entity.HasOne(d => d.DebitNavigation)
                    .WithMany(p => p.TransectionDebitNavigations)
                    .HasForeignKey(d => d.Debit)
                    .HasConstraintName("FK_Transection_ChartSubMinor1");

                entity.HasOne(d => d.FundsType)
                    .WithMany(p => p.Transections)
                    .HasForeignKey(d => d.FundsTypeId)
                    .HasConstraintName("FK_Transection_FundsType");

                entity.HasOne(d => d.SubAnnualBudget)
                    .WithMany(p => p.Transections)
                    .HasForeignKey(d => d.SubAnnualBudgetId)
                    .HasConstraintName("FK_Transection_SubAnnualBudget");

                entity.HasOne(d => d.SubJournal)
                    .WithMany(p => p.Transections)
                    .HasForeignKey(d => d.SubJournalId)
                    .HasConstraintName("FK_Transection_SubJournal");
            });

            modelBuilder.Entity<TransectionType>(entity =>
            {
                entity.ToTable("TransectionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChartMinorId).HasColumnName("ChartMinorID");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TransectionGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChartMinor)
                    .WithMany(p => p.TransectionTypes)
                    .HasForeignKey(d => d.ChartMinorId)
                    .HasConstraintName("FK_TransectionType_ChartSubMinor");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreateDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Expr2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
