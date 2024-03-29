﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class DataContext : DbContext
    {

        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }      
        public DbSet<ApplyFor> ApplyFor { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Collect> Collect { get; set; }
        public DbSet<CommodityDetails> CommodityDetails { get; set; }
        public DbSet<DetailInformation> DetailInformation { get; set; }
        public DbSet<Evaluate> Evaluate { get; set; }
        public DbSet<Examine> Examine { get; set; }
        public DbSet<HotSearch> HotSearch { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<InformationType> InformationType { get; set; }
        public DbSet<Master> Master { get; set; }
        public DbSet<MyBalance> MyBalance { get; set; }
        public DbSet<MyIntegral> MyIntegral { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ProductIntroduction> ProductIntroduction { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Trade> Trade { get; set; }
        public DbSet<Model.Type> Type { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<EquipmentRentals> EquipmentRentals { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Integral> Integral { get; set; }
        public DbSet<Origin> Origin { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Style> Style { get; set; }
        public DbSet<TryOut> TryOut { get; set; }
        public DbSet<VideoActivities> VideoActivities { get; set; }
        public DbSet<VisitorsTApplay> VisitorsTApplay { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=10.31.54.13;Initial Catalog=videoplatform;User ID=zzh;pwd=123");
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
