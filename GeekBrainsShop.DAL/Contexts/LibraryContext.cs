﻿namespace GeekBrainsShop.DAL.Employees
{
    using GeekBrainsShop.Domain.Employees;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        // Контекст настроен для использования строки подключения "LibraryContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "GeekBrainsShop.DAL.Employees.LibraryContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "LibraryContext" 
        // в файле конфигурации приложения.
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Footwear> Footwear { get; set; }
        public virtual DbSet<Trademark> Trademark { get; set; }
        public virtual DbSet<Season> Season { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FootwearConfiguration());
            modelBuilder.Configurations.Add(new TrademarkConfiguration());
            modelBuilder.Configurations.Add(new SeasonConfiguration());
        }
    }

}