using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityLayer.Entities
{
    public partial class SyStoreContext : DbContext
    {
        public SyStoreContext()
        {
        }

        public SyStoreContext(DbContextOptions<SyStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Favori> Favoris { get; set; } = null!;
        public virtual DbSet<Kategori> Kategoris { get; set; } = null!;
        public virtual DbSet<Marka> Markas { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<Sepet> Sepets { get; set; } = null!;
        public virtual DbSet<SepetUyeMap> SepetUyeMaps { get; set; } = null!;
        public virtual DbSet<Sipari> Siparis { get; set; } = null!;
        public virtual DbSet<SiparisDurumTbl> SiparisDurumTbls { get; set; } = null!;
        public virtual DbSet<Urun> Uruns { get; set; } = null!;
        public virtual DbSet<UrunCokluResim> UrunCokluResims { get; set; } = null!;
        public virtual DbSet<UrunVaryantDeger> UrunVaryantDegers { get; set; } = null!;
        public virtual DbSet<Uye> Uyes { get; set; } = null!;
        public virtual DbSet<Varyant> Varyants { get; set; } = null!;
        public virtual DbSet<VaryantDeger> VaryantDegers { get; set; } = null!;
        public virtual DbSet<VaryantDegerMap> VaryantDegerMaps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SAMET,1433;Database=SyStore;Data Source=SAMET;Initial Catalog=SyStore;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favori>(entity =>
            {
                entity.ToTable("Favori");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Favoris)
                    .HasForeignKey(d => d.UrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favori_Urun");

                entity.HasOne(d => d.Uye)
                    .WithMany(p => p.Favoris)
                    .HasForeignKey(d => d.UyeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favori_Uye");
            });

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.ToTable("Kategori");

                entity.Property(e => e.KategoriAciklamasi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KategoriAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KategoriResim)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.KategoriSlug)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.ToTable("Marka");

                entity.Property(e => e.MarkaAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.MenuAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.RolAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sepet>(entity =>
            {
                entity.ToTable("Sepet");

                entity.Property(e => e.Adet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Sepets)
                    .HasForeignKey(d => d.UrunId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Sepet_Urun");

                entity.HasOne(d => d.Uye)
                    .WithMany(p => p.Sepets)
                    .HasForeignKey(d => d.UyeId)
                    .HasConstraintName("FK_Sepet_Uye");
            });

            modelBuilder.Entity<SepetUyeMap>(entity =>
            {
                entity.ToTable("SepetUyeMap");

                entity.HasOne(d => d.Uye)
                    .WithMany(p => p.SepetUyeMaps)
                    .HasForeignKey(d => d.UyeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepetUyeMap_Uye");
            });

            modelBuilder.Entity<Sipari>(entity =>
            {
                entity.Property(e => e.AdSoyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MailAdresi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiparisNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiparisTarih)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToplamFiyat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Uye)
                    .WithMany(p => p.Siparis)
                    .HasForeignKey(d => d.UyeId)
                    .HasConstraintName("FK_Siparis_Uye");
            });

            modelBuilder.Entity<SiparisDurumTbl>(entity =>
            {
                entity.ToTable("SiparisDurumTbl");

                entity.Property(e => e.SiparisDurum)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Urun>(entity =>
            {
                entity.ToTable("Urun");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BarkodNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndirimMiktari)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndirimOrani)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kdv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SabitFiyat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stok)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrunAciklamasi)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UrunAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrunFiyati)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrunIndirimliFiyati)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrunResim)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Uruns)
                    .HasForeignKey(d => d.KategoriId)
                    .HasConstraintName("FK_Urun_Kategori");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Uruns)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Urun_Marka");
            });

            modelBuilder.Entity<UrunCokluResim>(entity =>
            {
                entity.ToTable("UrunCokluResim");

                entity.Property(e => e.UrunResim)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.UrunCokluResims)
                    .HasForeignKey(d => d.Urunid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UrunCokluResim_Urun");
            });

            modelBuilder.Entity<UrunVaryantDeger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UrunVaryantDeger");

                entity.Property(e => e.VaryantAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VaryantDegerAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_UrunVaryantDeger_Urun");
            });

            modelBuilder.Entity<Uye>(entity =>
            {
                entity.ToTable("Uye");

                entity.Property(e => e.Isim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KullaniciAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoyIsim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UyeResim)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Varyant>(entity =>
            {
                entity.ToTable("Varyant");

                entity.Property(e => e.VaryantAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VaryantDeger>(entity =>
            {
                entity.ToTable("VaryantDeger");

                entity.Property(e => e.VaryantDegerAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VaryantDegerResim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Varyant)
                    .WithMany(p => p.VaryantDegers)
                    .HasForeignKey(d => d.Varyantid)
                    .HasConstraintName("FK_VaryantDeger_Varyant");
            });

            modelBuilder.Entity<VaryantDegerMap>(entity =>
            {
                entity.ToTable("VaryantDegerMap");

                entity.HasOne(d => d.VaryantDeger)
                    .WithMany(p => p.VaryantDegerMaps)
                    .HasForeignKey(d => d.VaryantDegerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VaryantDegerMap_VaryantDeger");

                entity.HasOne(d => d.Varyant)
                    .WithMany(p => p.VaryantDegerMaps)
                    .HasForeignKey(d => d.VaryantId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VaryantDegerMap_Varyant");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
