using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace JappCore.Models
{
    public partial class JappCoreDatabaseContext : DbContext
    {
        public JappCoreDatabaseContext()
        {
        }

        public JappCoreDatabaseContext(DbContextOptions<JappCoreDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<BudgetDeposit> BudgetDeposits { get; set; }
        public virtual DbSet<BudgetExpenseCategory> BudgetExpenseCategories { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<Payee> Payees { get; set; }
        public virtual DbSet<Recurring> Recurrings { get; set; }
        public virtual DbSet<RecurringExpense> RecurringExpenses { get; set; }
        public virtual DbSet<SavingsTarget> SavingsTargets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=JappCoreDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.HasIndex(e => e.UserAccountsId, "IX_Budgets_UserAccountsID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserAccountsId).HasColumnName("UserAccountsID");

                entity.HasOne(d => d.UserAccounts)
                    .WithMany(p => p.Budgets)
                    .HasForeignKey(d => d.UserAccountsId);
            });

            modelBuilder.Entity<BudgetDeposit>(entity =>
            {
                entity.HasKey(e => new { e.BudgetId, e.DepositsId });

                entity.ToTable("BudgetDeposit");

                entity.HasIndex(e => e.DepositsId, "IX_BudgetDeposit_DepositsID");

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.DepositsId).HasColumnName("DepositsID");

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.BudgetDeposits)
                    .HasForeignKey(d => d.BudgetId);

                entity.HasOne(d => d.Deposits)
                    .WithMany(p => p.BudgetDeposits)
                    .HasForeignKey(d => d.DepositsId);
            });

            modelBuilder.Entity<BudgetExpenseCategory>(entity =>
            {
                entity.HasKey(e => e.BudgetId);

                entity.HasIndex(e => e.BudgetId1, "IX_BudgetExpenseCategories_BudgetID1");

                entity.HasIndex(e => e.ExpenseCategoryId, "IX_BudgetExpenseCategories_ExpenseCategoryID");

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.BudgetId1).HasColumnName("BudgetID1");

                entity.Property(e => e.ExpenseCategoryId).HasColumnName("ExpenseCategoryID");

                entity.HasOne(d => d.BudgetId1Navigation)
                    .WithMany(p => p.BudgetExpenseCategories)
                    .HasForeignKey(d => d.BudgetId1);

                entity.HasOne(d => d.ExpenseCategory)
                    .WithMany(p => p.BudgetExpenseCategories)
                    .HasForeignKey(d => d.ExpenseCategoryId);
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.HasIndex(e => e.SavingsTargetsId, "IX_Deposits_SavingsTargetsID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SavingsTargetsId).HasColumnName("SavingsTargetsID");

                entity.HasOne(d => d.SavingsTargets)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.SavingsTargetsId);
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasIndex(e => e.ExpenseCategoriesId, "IX_Expenses_ExpenseCategoriesID");

                entity.HasIndex(e => e.PayeeId, "IX_Expenses_PayeeID");

                entity.HasIndex(e => e.RecurringId, "IX_Expenses_RecurringID");

                entity.HasIndex(e => e.UserAccountId, "IX_Expenses_UserAccountID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExpenseCategoriesId).HasColumnName("ExpenseCategoriesID");

                entity.Property(e => e.PayeeId).HasColumnName("PayeeID");

                entity.Property(e => e.RecurringId).HasColumnName("RecurringID");

                entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

                entity.HasOne(d => d.ExpenseCategories)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.ExpenseCategoriesId);

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.PayeeId);

                entity.HasOne(d => d.Recurring)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.RecurringId);

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.UserAccountId);
            });

            modelBuilder.Entity<ExpenseCategory>(entity =>
            {
                entity.HasIndex(e => e.BudgetId, "IX_ExpenseCategories_BudgetID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.ExpenseCategories)
                    .HasForeignKey(d => d.BudgetId);
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasIndex(e => e.UserAccountId, "IX_Incomes_UserAccountID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.UserAccountId);
            });

            modelBuilder.Entity<Payee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Recurring>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<RecurringExpense>(entity =>
            {
                entity.HasIndex(e => e.ExpenseCategoriesId, "IX_RecurringExpenses_ExpenseCategoriesID");

                entity.HasIndex(e => e.PayeeId, "IX_RecurringExpenses_PayeeID");

                entity.HasIndex(e => e.RecurringId, "IX_RecurringExpenses_RecurringID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpenseCategoriesId).HasColumnName("ExpenseCategoriesID");

                entity.Property(e => e.PayeeId).HasColumnName("PayeeID");

                entity.Property(e => e.RecurringId).HasColumnName("RecurringID");

                entity.HasOne(d => d.ExpenseCategories)
                    .WithMany(p => p.RecurringExpenses)
                    .HasForeignKey(d => d.ExpenseCategoriesId);

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.RecurringExpenses)
                    .HasForeignKey(d => d.PayeeId);

                entity.HasOne(d => d.Recurring)
                    .WithMany(p => p.RecurringExpenses)
                    .HasForeignKey(d => d.RecurringId);
            });

            modelBuilder.Entity<SavingsTarget>(entity =>
            {
                entity.HasIndex(e => e.UserAccountId, "IX_SavingsTargets_UserAccountID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.SavingsTargets)
                    .HasForeignKey(d => d.UserAccountId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
