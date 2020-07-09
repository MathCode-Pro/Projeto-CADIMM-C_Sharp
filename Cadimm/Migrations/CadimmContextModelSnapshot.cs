﻿// <auto-generated />
using System;
using Cadimm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cadimm.Migrations
{
    [DbContext(typeof(CadimmContext))]
    partial class CadimmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Cadimm.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("Cadimm.Models.Conjugue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MembroId")
                        .IsUnique();

                    b.ToTable("Conjugue");
                });

            modelBuilder.Entity("Cadimm.Models.DadosEleitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<int>("Secao")
                        .HasColumnType("int");

                    b.Property<int>("Titulo")
                        .HasColumnType("int");

                    b.Property<int>("Zona")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MembroId")
                        .IsUnique();

                    b.ToTable("DadosEleitor");
                });

            modelBuilder.Entity("Cadimm.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .HasColumnType("text");

                    b.Property<string>("Setor")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Cadimm.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("Cadimm.Models.Filiacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConsagAtual")
                        .HasColumnType("text");

                    b.Property<string>("ConsagPretendida")
                        .HasColumnType("text");

                    b.Property<string>("FiliadoEm")
                        .HasColumnType("text");

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.Property<bool>("seraConsagrado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MembroId")
                        .IsUnique();

                    b.ToTable("Filiacao");
                });

            modelBuilder.Entity("Cadimm.Models.Membro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Escolaridade")
                        .HasColumnType("text");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("text");

                    b.Property<bool>("Filiado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("NomeMae")
                        .HasColumnType("text");

                    b.Property<string>("NomePai")
                        .HasColumnType("text");

                    b.Property<int>("Rg")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Membro");
                });

            modelBuilder.Entity("Cadimm.Models.Telefone", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ConjugueId")
                        .HasColumnType("int");

                    b.Property<int>("MembroId")
                        .HasColumnType("int");

                    b.HasKey("Numero");

                    b.HasIndex("ConjugueId");

                    b.HasIndex("MembroId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("Cadimm.Models.Cidade", b =>
                {
                    b.HasOne("Cadimm.Models.Estado", "Estado")
                        .WithMany("Cidade")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cadimm.Models.Conjugue", b =>
                {
                    b.HasOne("Cadimm.Models.Membro", "Membro")
                        .WithOne("Conjugue")
                        .HasForeignKey("Cadimm.Models.Conjugue", "MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cadimm.Models.DadosEleitor", b =>
                {
                    b.HasOne("Cadimm.Models.Membro", "Membro")
                        .WithOne("DadosEleitor")
                        .HasForeignKey("Cadimm.Models.DadosEleitor", "MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cadimm.Models.Endereco", b =>
                {
                    b.HasOne("Cadimm.Models.Membro", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cadimm.Models.Filiacao", b =>
                {
                    b.HasOne("Cadimm.Models.Membro", null)
                        .WithOne("Filiacao")
                        .HasForeignKey("Cadimm.Models.Filiacao", "MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cadimm.Models.Telefone", b =>
                {
                    b.HasOne("Cadimm.Models.Conjugue", null)
                        .WithMany("Telefones")
                        .HasForeignKey("ConjugueId");

                    b.HasOne("Cadimm.Models.Membro", null)
                        .WithMany("Telefones")
                        .HasForeignKey("MembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
