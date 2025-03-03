using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace DBWork.Models;

public partial class StaffDbContext : DbContext
{
	public StaffDbContext()
	{
	}

	public StaffDbContext(DbContextOptions<StaffDbContext> options)
		: base(options)
	{
	}

	public virtual DbSet<Department> Departments { get; set; }

	public virtual DbSet<Order> Orders { get; set; }

	public virtual DbSet<Staff> Staff { get; set; }

	public virtual DbSet<StaffOrder> StaffOrders { get; set; }

	public virtual DbSet<User> Users { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{ 
		optionsBuilder.UseSqlServer("Data Source=LAPTOPNOT1C-WIN\\SQLEXPRESS;Initial Catalog=STAFFDBNEW;Integrated Security=True;Encrypt=False");
		optionsBuilder.LogTo(message => Debug.WriteLine(message));
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Department>(entity =>
		{
			entity.ToTable("department");

			entity.Property(e => e.DepartmentId)
				.ValueGeneratedNever()
				.HasColumnName("department_id");
			entity.Property(e => e.DirectorId).HasColumnName("director_id");
			entity.Property(e => e.Name)
				.HasMaxLength(50)
				.HasColumnName("name");

			entity.HasOne(d => d.Director).WithMany(p => p.Departments)
				.HasForeignKey(d => d.DirectorId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_department_staff");
		});

		modelBuilder.Entity<Order>(entity =>
		{
			entity.ToTable("order");

			entity.Property(e => e.OrderId)
				.ValueGeneratedNever()
				.HasColumnName("order_id");
			entity.Property(e => e.Cost).HasColumnName("cost");
			entity.Property(e => e.FullnameClient)
				.HasMaxLength(50)
				.HasColumnName("fullname_client");
			entity.Property(e => e.TimeExecution)
				.HasMaxLength(50)
				.HasColumnName("time_execution");
		});

		modelBuilder.Entity<Staff>(entity =>
		{
			entity.ToTable("staff");

			entity.Property(e => e.StaffId)
				.ValueGeneratedNever()
				.HasColumnName("staff_id");
			entity.Property(e => e.DepartmentId).HasColumnName("department_id");
			entity.Property(e => e.Name)
				.HasMaxLength(50)
				.HasColumnName("name");
			entity.Property(e => e.Patronymic)
				.HasMaxLength(50)
				.HasColumnName("patronymic");
			entity.Property(e => e.Surname)
				.HasMaxLength(50)
				.HasColumnName("surname");
			entity.Property(e => e.Telephone)
				.HasMaxLength(15)
				.HasColumnName("telephone");

			entity.HasOne(d => d.Department).WithMany(p => p.Staff)
				.HasForeignKey(d => d.DepartmentId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_staff_department");
		});

		modelBuilder.Entity<StaffOrder>(entity =>
		{
			entity.HasKey(e => e.OrderStaffId);

			entity.ToTable("staff_order");

			entity.Property(e => e.OrderStaffId)
				.ValueGeneratedNever()
				.HasColumnName("order_staff_id");
			entity.Property(e => e.OrderId).HasColumnName("order_id");
			entity.Property(e => e.StaffId).HasColumnName("staff_id");

			entity.HasOne(d => d.Order).WithMany(p => p.StaffOrders)
				.HasForeignKey(d => d.OrderId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_staff_order_order");

			entity.HasOne(d => d.Staff).WithMany(p => p.StaffOrders)
				.HasForeignKey(d => d.StaffId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_staff_order_staff");
		});

		modelBuilder.Entity<User>(entity =>
		{
			entity.ToTable("user");

			entity.Property(e => e.UserId)
				.ValueGeneratedNever()
				.HasColumnName("user_id");
			entity.Property(e => e.Email)
				.HasMaxLength(30)
				.HasColumnName("email");
			entity.Property(e => e.Password)
				.HasMaxLength(30)
				.HasColumnName("password");

			entity.HasOne(d => d.UserNavigation).WithOne(p => p.User)
				.HasForeignKey<User>(d => d.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_user_staff");
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
