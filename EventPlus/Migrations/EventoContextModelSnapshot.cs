﻿// <auto-generated />
using System;
using EventPlus.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventPlus.Migrations
{
    [DbContext(typeof(EventoContext))]
    partial class EventoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventPlus.Domains.ComentarioEventos", b =>
                {
                    b.Property<Guid>("IdComentarioEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<bool>("Exibe")
                        .HasColumnType("BIT");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdComentarioEvento");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ComentariosEventos");
                });

            modelBuilder.Entity("EventPlus.Domains.Eventos", b =>
                {
                    b.Property<Guid>("EventoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("DATE");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("InstituicaoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeEvento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid>("TipoEventoID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventoID");

                    b.HasIndex("InstituicaoID");

                    b.HasIndex("TipoEventoID");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("EventPlus.Domains.Instituicao", b =>
                {
                    b.Property<Guid>("IdInstutuicao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdInstutuicao");

                    b.HasIndex("CNPJ")
                        .IsUnique();

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("EventPlus.Domains.PresencaEventos", b =>
                {
                    b.Property<Guid>("IdPresencaEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEvento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Situacao")
                        .HasColumnType("BIT");

                    b.HasKey("IdPresencaEvento");

                    b.HasIndex("IdEvento")
                        .IsUnique();

                    b.HasIndex("IdUsuario");

                    b.ToTable("PresencasEventos");
                });

            modelBuilder.Entity("EventPlus.Domains.TipoEventos", b =>
                {
                    b.Property<Guid>("TipoEventosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TituloTipoEvento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("TipoEventosId");

                    b.ToTable("TipoEventos");
                });

            modelBuilder.Entity("EventPlus.Domains.TiposUsuarios", b =>
                {
                    b.Property<Guid>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TituloTipoUsuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdTipoUsuario");

                    b.ToTable("TiposUsuarios");
                });

            modelBuilder.Entity("EventPlus.Domains.Usuarios", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<Guid>("IdTipoUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdTipoUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EventPlus.Domains.ComentarioEventos", b =>
                {
                    b.HasOne("EventPlus.Domains.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EventPlus.Domains.Eventos", b =>
                {
                    b.HasOne("EventPlus.Domains.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("InstituicaoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventPlus.Domains.TipoEventos", "TipoEvento")
                        .WithMany()
                        .HasForeignKey("TipoEventoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");

                    b.Navigation("TipoEvento");
                });

            modelBuilder.Entity("EventPlus.Domains.PresencaEventos", b =>
                {
                    b.HasOne("EventPlus.Domains.Eventos", "evento")
                        .WithOne("Presenca")
                        .HasForeignKey("EventPlus.Domains.PresencaEventos", "IdEvento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventPlus.Domains.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");

                    b.Navigation("evento");
                });

            modelBuilder.Entity("EventPlus.Domains.Usuarios", b =>
                {
                    b.HasOne("EventPlus.Domains.TiposUsuarios", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("IdTipoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("EventPlus.Domains.Eventos", b =>
                {
                    b.Navigation("Presenca");
                });
#pragma warning restore 612, 618
        }
    }
}
