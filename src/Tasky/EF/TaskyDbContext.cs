﻿using MyCompanyName.MyProjectName.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MyCompanyName.MyProjectName.EF;

public class TaskyDbContext : AbpDbContext<TaskyDbContext>
{
    public DbSet<TaskyItem> Taskys { get; set; }
    
    public TaskyDbContext(DbContextOptions<TaskyDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ConfigureTaskyItem();
    }
}