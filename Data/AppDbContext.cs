using System;
using System.Collections.Generic;
using Invox.Models;
using Microsoft.EntityFrameworkCore;

namespace Invox.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GcCashOpening> GcCashOpenings { get; set; }

    public virtual DbSet<GcCategoryMaster> GcCategoryMasters { get; set; }

    public virtual DbSet<GcCompanyMaster> GcCompanyMasters { get; set; }

    public virtual DbSet<GcCounterMaster> GcCounterMasters { get; set; }

    public virtual DbSet<GcCustomerAddress> GcCustomerAddresses { get; set; }

    public virtual DbSet<GcCustomerMaster> GcCustomerMasters { get; set; }

    public virtual DbSet<GcDayProcess> GcDayProcesses { get; set; }

    public virtual DbSet<GcDeliverySettlement> GcDeliverySettlements { get; set; }

    public virtual DbSet<GcDeliveryboyMaster> GcDeliveryboyMasters { get; set; }

    public virtual DbSet<GcHelp> GcHelps { get; set; }

    public virtual DbSet<GcInvoiceDetl> GcInvoiceDetls { get; set; }

    public virtual DbSet<GcInvoiceHead> GcInvoiceHeads { get; set; }

    public virtual DbSet<GcInvoicePay> GcInvoicePays { get; set; }

    public virtual DbSet<GcItemMaster> GcItemMasters { get; set; }

    public virtual DbSet<GcKitchenMessage> GcKitchenMessages { get; set; }

    public virtual DbSet<GcOnlineCustomer> GcOnlineCustomers { get; set; }

    public virtual DbSet<GcOnlinePricing> GcOnlinePricings { get; set; }

    public virtual DbSet<GcPosUser> GcPosUsers { get; set; }

    public virtual DbSet<GcSetting> GcSettings { get; set; }

    public virtual DbSet<GcStaffMaster> GcStaffMasters { get; set; }

    public virtual DbSet<GcTableMaster> GcTableMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;port=3306;database=invox_db;user=grandChef;password=Login@123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GcCashOpening>(entity =>
        {
            entity.HasKey(e => e.CoId).HasName("PRIMARY");

            entity.ToTable("gc_cash_opening");

            entity.Property(e => e.CoId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("co_id");
            entity.Property(e => e.CoCloseAmt)
                .HasPrecision(17, 3)
                .HasColumnName("co_close_amt");
            entity.Property(e => e.CoCloseYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'")
                .HasColumnName("co_close_yn");
            entity.Property(e => e.CoCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("co_created_by");
            entity.Property(e => e.CoCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("co_created_on");
            entity.Property(e => e.CoDiffAmt)
                .HasPrecision(17, 3)
                .HasColumnName("co_diff_amt");
            entity.Property(e => e.CoInvDate)
                .HasColumnType("date")
                .HasColumnName("co_inv_date");
            entity.Property(e => e.CoOpenAmt)
                .HasPrecision(17, 3)
                .HasColumnName("co_open_amt");
            entity.Property(e => e.CoSales)
                .HasPrecision(17, 3)
                .HasColumnName("co_sales");
            entity.Property(e => e.CoStore)
                .HasColumnType("int(11)")
                .HasColumnName("co_store");
            entity.Property(e => e.CoTransYn)
                .HasColumnType("int(1)")
                .HasColumnName("co_trans_yn");
            entity.Property(e => e.CoUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("co_updated_by");
            entity.Property(e => e.CoUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("co_updated_on");
        });

        modelBuilder.Entity<GcCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.CmId).HasName("PRIMARY");

            entity.ToTable("gc_category_master");

            entity.HasIndex(e => e.CmCatgId, "cm_catg_id_UNIQUE").IsUnique();

            entity.Property(e => e.CmId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("cm_id");
            entity.Property(e => e.CmActive)
                .HasMaxLength(1)
                .HasColumnName("cm_active");
            entity.Property(e => e.CmCatgId)
                .HasColumnType("int(11)")
                .HasColumnName("cm_catg_id");
            entity.Property(e => e.CmCatgName)
                .HasMaxLength(100)
                .HasColumnName("cm_catg_name");
            entity.Property(e => e.CmCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("cm_created_by");
            entity.Property(e => e.CmCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("cm_created_on");
            entity.Property(e => e.CmIdx)
                .HasColumnType("int(11)")
                .HasColumnName("cm_idx");
            entity.Property(e => e.CmParentId)
                .HasColumnType("int(11)")
                .HasColumnName("cm_parent_id");
            entity.Property(e => e.CmShortName)
                .HasMaxLength(50)
                .HasColumnName("cm_short_name");
            entity.Property(e => e.CmTransYn)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("cm_trans_yn");
            entity.Property(e => e.CmUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("cm_updated_by");
            entity.Property(e => e.CmUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("cm_updated_on");
        });

        modelBuilder.Entity<GcCompanyMaster>(entity =>
        {
            entity.HasKey(e => e.LmId).HasName("PRIMARY");

            entity.ToTable("gc_company_master");

            entity.Property(e => e.LmId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("lm_id");
            entity.Property(e => e.ImBillName)
                .HasMaxLength(100)
                .HasColumnName("im_bill_name");
            entity.Property(e => e.ImFooter5)
                .HasMaxLength(100)
                .HasColumnName("im_footer_5");
            entity.Property(e => e.ImLogo)
                .HasMaxLength(100)
                .HasColumnName("im_logo");
            entity.Property(e => e.LmActiveYn)
                .HasMaxLength(10)
                .HasDefaultValueSql("'Y'")
                .HasColumnName("lm_active_YN");
            entity.Property(e => e.LmAddressLine1)
                .HasMaxLength(255)
                .HasColumnName("lm_address_line_1");
            entity.Property(e => e.LmAddressLine2)
                .HasMaxLength(255)
                .HasColumnName("lm_address_line_2");
            entity.Property(e => e.LmArabicName)
                .HasMaxLength(100)
                .HasColumnName("lm_arabic_name");
            entity.Property(e => e.LmArabicShortName)
                .HasMaxLength(50)
                .HasColumnName("lm_arabic_short_name");
            entity.Property(e => e.LmCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("lm_created_by");
            entity.Property(e => e.LmCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("lm_created_on");
            entity.Property(e => e.LmFooter1)
                .HasMaxLength(100)
                .HasColumnName("lm_footer_1");
            entity.Property(e => e.LmFooter2)
                .HasMaxLength(100)
                .HasColumnName("lm_footer_2");
            entity.Property(e => e.LmFooter3)
                .HasMaxLength(100)
                .HasColumnName("lm_footer_3");
            entity.Property(e => e.LmFooter4)
                .HasMaxLength(100)
                .HasColumnName("lm_footer_4");
            entity.Property(e => e.LmMailId)
                .HasMaxLength(60)
                .HasColumnName("lm_mail_id");
            entity.Property(e => e.LmMobile)
                .HasMaxLength(15)
                .HasColumnName("lm_mobile");
            entity.Property(e => e.LmPhone)
                .HasMaxLength(15)
                .HasColumnName("lm_phone");
            entity.Property(e => e.LmShortName)
                .HasMaxLength(50)
                .HasColumnName("lm_short_name");
            entity.Property(e => e.LmStoreId)
                .HasMaxLength(10)
                .HasColumnName("lm_store_id");
            entity.Property(e => e.LmStoreName)
                .HasMaxLength(100)
                .HasColumnName("lm_store_name");
            entity.Property(e => e.LmTaxNo)
                .HasMaxLength(60)
                .HasColumnName("lm_tax_no");
            entity.Property(e => e.LmUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("lm_updated_by");
            entity.Property(e => e.LmUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("lm_updated_on");
        });

        modelBuilder.Entity<GcCounterMaster>(entity =>
        {
            entity.HasKey(e => e.CmId).HasName("PRIMARY");

            entity.ToTable("gc_counter_master");

            entity.Property(e => e.CmId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("cm_id");
            entity.Property(e => e.CmActive)
                .HasMaxLength(1)
                .HasColumnName("cm_active");
            entity.Property(e => e.CmCounterName)
                .HasMaxLength(100)
                .HasColumnName("cm_counter_name");
            entity.Property(e => e.CmCounterNo)
                .HasMaxLength(50)
                .HasColumnName("cm_counter_no");
            entity.Property(e => e.CmCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("cm_created_by");
            entity.Property(e => e.CmCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("cm_created_on");
            entity.Property(e => e.CmInvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("cm_invoice_no");
            entity.Property(e => e.CmPrefix)
                .HasMaxLength(50)
                .HasColumnName("cm_prefix");
            entity.Property(e => e.CmPrinterBill)
                .HasMaxLength(100)
                .HasColumnName("cm_printer_bill");
            entity.Property(e => e.CmPrinterReceipt)
                .HasMaxLength(100)
                .HasColumnName("cm_printer_receipt");
            entity.Property(e => e.CmStore)
                .HasColumnType("int(11)")
                .HasColumnName("cm_store");
            entity.Property(e => e.CmTransYn)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("cm_trans_yn");
            entity.Property(e => e.CmType)
                .HasMaxLength(50)
                .HasColumnName("cm_type");
            entity.Property(e => e.CmUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("cm_updated_by");
            entity.Property(e => e.CmUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("cm_updated_on");
        });

        modelBuilder.Entity<GcCustomerAddress>(entity =>
        {
            entity.HasKey(e => e.CaId).HasName("PRIMARY");

            entity.ToTable("gc_customer_address");

            entity.Property(e => e.CaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("ca_id");
            entity.Property(e => e.CaActiveYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'Y'")
                .HasColumnName("ca_active_yn");
            entity.Property(e => e.CaAddress)
                .HasMaxLength(256)
                .HasColumnName("ca_address");
            entity.Property(e => e.CaArea)
                .HasMaxLength(256)
                .HasColumnName("ca_area");
            entity.Property(e => e.CaBuildingName)
                .HasMaxLength(256)
                .HasColumnName("ca_building_name");
            entity.Property(e => e.CaCode)
                .HasColumnType("bigint(20)")
                .HasColumnName("ca_code");
            entity.Property(e => e.CaCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("ca_created_by");
            entity.Property(e => e.CaCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("ca_created_on");
            entity.Property(e => e.CaCustId)
                .HasColumnType("bigint(20)")
                .HasColumnName("ca_cust_id");
            entity.Property(e => e.CaLandMark)
                .HasMaxLength(256)
                .HasColumnName("ca_land_mark");
            entity.Property(e => e.CaPhone)
                .HasMaxLength(15)
                .HasColumnName("ca_phone");
            entity.Property(e => e.CaStreetName)
                .HasMaxLength(256)
                .HasColumnName("ca_street_name");
            entity.Property(e => e.CaUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("ca_updated_by");
            entity.Property(e => e.CaUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("ca_updated_on");
        });

        modelBuilder.Entity<GcCustomerMaster>(entity =>
        {
            entity.HasKey(e => e.CmId).HasName("PRIMARY");

            entity.ToTable("gc_customer_master");

            entity.Property(e => e.CmId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("cm_id");
            entity.Property(e => e.CmActiveYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'Y'")
                .HasColumnName("cm_active_yn");
            entity.Property(e => e.CmBlackListYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'")
                .HasColumnName("cm_black_list_yn");
            entity.Property(e => e.CmCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("cm_created_by");
            entity.Property(e => e.CmCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("cm_created_on");
            entity.Property(e => e.CmCustCode)
                .HasMaxLength(50)
                .HasColumnName("cm_cust_code");
            entity.Property(e => e.CmCustName)
                .HasMaxLength(100)
                .HasColumnName("cm_cust_name");
            entity.Property(e => e.CmEmail)
                .HasMaxLength(100)
                .HasColumnName("cm_email");
            entity.Property(e => e.CmMobile)
                .HasMaxLength(15)
                .HasColumnName("cm_mobile");
            entity.Property(e => e.CmPrimaryAddress)
                .HasColumnType("bigint(20)")
                .HasColumnName("cm_primary_address");
            entity.Property(e => e.CmSecMobile)
                .HasMaxLength(15)
                .HasColumnName("cm_sec_mobile");
            entity.Property(e => e.CmTransYn)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("cm_trans_yn");
            entity.Property(e => e.CmUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("cm_updated_by");
            entity.Property(e => e.CmUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("cm_updated_on");
        });

        modelBuilder.Entity<GcDayProcess>(entity =>
        {
            entity.HasKey(e => e.DpSlNo).HasName("PRIMARY");

            entity.ToTable("gc_day_process");

            entity.Property(e => e.DpSlNo)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dp_sl_no");
            entity.Property(e => e.DpClosedUser)
                .HasMaxLength(5)
                .HasColumnName("dp_closed_user");
            entity.Property(e => e.DpClosingTime)
                .HasColumnType("datetime")
                .HasColumnName("dp_closing_time");
            entity.Property(e => e.DpDate)
                .HasColumnType("date")
                .HasColumnName("dp_date");
            entity.Property(e => e.DpOpenStatus)
                .HasMaxLength(1)
                .HasColumnName("dp_open_status");
            entity.Property(e => e.DpOpenedUser)
                .HasMaxLength(5)
                .HasColumnName("dp_opened_user");
            entity.Property(e => e.DpOpeningTime)
                .HasColumnType("datetime")
                .HasColumnName("dp_opening_time");
            entity.Property(e => e.DpStore)
                .HasColumnType("int(11)")
                .HasColumnName("dp_store");
            entity.Property(e => e.DpTransYn)
                .HasColumnType("int(1) unsigned")
                .HasColumnName("dp_trans_yn");
        });

        modelBuilder.Entity<GcDeliverySettlement>(entity =>
        {
            entity.HasKey(e => e.DsId).HasName("PRIMARY");

            entity.ToTable("gc_delivery_settlement");

            entity.Property(e => e.DsId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("ds_id");
            entity.Property(e => e.DsCard)
                .HasPrecision(17, 3)
                .HasColumnName("ds_card");
            entity.Property(e => e.DsCash)
                .HasPrecision(17, 3)
                .HasColumnName("ds_cash");
            entity.Property(e => e.DsCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("ds_created_by");
            entity.Property(e => e.DsCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("ds_created_on");
            entity.Property(e => e.DsDeliveryId)
                .HasMaxLength(45)
                .HasColumnName("ds_delivery_id");
            entity.Property(e => e.DsStore)
                .HasColumnType("int(11)")
                .HasColumnName("ds_store");
            entity.Property(e => e.DsUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("ds_updated_by");
            entity.Property(e => e.DsUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("ds_updated_on");
        });

        modelBuilder.Entity<GcDeliveryboyMaster>(entity =>
        {
            entity.HasKey(e => e.DmId).HasName("PRIMARY");

            entity.ToTable("gc_deliveryboy_master");

            entity.Property(e => e.DmId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("dm_id");
            entity.Property(e => e.DmActiveYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'Y'")
                .HasColumnName("dm_active_yn");
            entity.Property(e => e.DmCode)
                .HasMaxLength(50)
                .HasColumnName("dm_code");
            entity.Property(e => e.DmCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("dm_created_by");
            entity.Property(e => e.DmCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("dm_created_on");
            entity.Property(e => e.DmMobile)
                .HasMaxLength(15)
                .HasColumnName("dm_mobile");
            entity.Property(e => e.DmName)
                .HasMaxLength(100)
                .HasColumnName("dm_name");
            entity.Property(e => e.DmStore)
                .HasColumnType("int(11)")
                .HasColumnName("dm_store");
            entity.Property(e => e.DmUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("dm_updated_by");
            entity.Property(e => e.DmUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("dm_updated_on");
        });

        modelBuilder.Entity<GcHelp>(entity =>
        {
            entity.HasKey(e => e.HpId).HasName("PRIMARY");

            entity.ToTable("gc_help");

            entity.Property(e => e.HpId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("hp_id");
            entity.Property(e => e.HpCompany)
                .HasMaxLength(100)
                .HasColumnName("hp_company");
            entity.Property(e => e.HpContactEmail1)
                .HasMaxLength(100)
                .HasColumnName("hp_contact_email_1");
            entity.Property(e => e.HpContactEmail2)
                .HasMaxLength(100)
                .HasColumnName("hp_contact_email_2");
            entity.Property(e => e.HpContactMobile1)
                .HasMaxLength(15)
                .HasColumnName("hp_contact_mobile_1");
            entity.Property(e => e.HpContactMobile2)
                .HasMaxLength(15)
                .HasColumnName("hp_contact_mobile_2");
            entity.Property(e => e.HpContactPerson1)
                .HasMaxLength(100)
                .HasColumnName("hp_contact_person_1");
            entity.Property(e => e.HpContactPerson2)
                .HasMaxLength(100)
                .HasColumnName("hp_contact_person_2");
            entity.Property(e => e.HpCopyright)
                .HasMaxLength(100)
                .HasColumnName("hp_copyright");
            entity.Property(e => e.HpCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("hp_created_by");
            entity.Property(e => e.HpCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("hp_created_on");
            entity.Property(e => e.HpMoreInfo)
                .HasMaxLength(512)
                .HasColumnName("hp_more_info");
            entity.Property(e => e.HpTransYn)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("hp_trans_yn");
            entity.Property(e => e.HpUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("hp_updated_by");
            entity.Property(e => e.HpUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("hp_updated_on");
            entity.Property(e => e.HpWebsite)
                .HasMaxLength(100)
                .HasColumnName("hp_website");
        });

        modelBuilder.Entity<GcInvoiceDetl>(entity =>
        {
            entity.HasKey(e => e.IdId).HasName("PRIMARY");

            entity.ToTable("gc_invoice_detl");

            entity.Property(e => e.IdId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id_id");
            entity.Property(e => e.IdArabicName)
                .HasMaxLength(100)
                .HasColumnName("id_arabic_name");
            entity.Property(e => e.IdBarcode)
                .HasMaxLength(30)
                .HasColumnName("id_barcode");
            entity.Property(e => e.IdCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("id_created_by");
            entity.Property(e => e.IdCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("id_created_on");
            entity.Property(e => e.IdDiscAmt)
                .HasPrecision(17, 3)
                .HasColumnName("id_disc_amt");
            entity.Property(e => e.IdIdx)
                .HasColumnType("int(11)")
                .HasColumnName("id_idx");
            entity.Property(e => e.IdInvNo)
                .HasMaxLength(50)
                .HasColumnName("id_inv_no");
            entity.Property(e => e.IdItemCode)
                .HasColumnType("bigint(20)")
                .HasColumnName("id_item_code");
            entity.Property(e => e.IdKitchenMessage)
                .HasMaxLength(100)
                .HasColumnName("id_kitchen_message");
            entity.Property(e => e.IdKotYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'")
                .HasColumnName("id_kot_yn");
            entity.Property(e => e.IdName)
                .HasMaxLength(100)
                .HasColumnName("id_name");
            entity.Property(e => e.IdNetTotal)
                .HasPrecision(17, 3)
                .HasColumnName("id_net_total");
            entity.Property(e => e.IdPrice)
                .HasPrecision(17, 3)
                .HasColumnName("id_price");
            entity.Property(e => e.IdQuantity)
                .HasPrecision(17, 3)
                .HasColumnName("id_quantity");
            entity.Property(e => e.IdReturnYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'")
                .HasColumnName("id_return_yn");
            entity.Property(e => e.IdStore)
                .HasColumnType("int(11)")
                .HasColumnName("id_store");
            entity.Property(e => e.IdTaxAmt)
                .HasPrecision(17, 3)
                .HasColumnName("id_tax_amt");
            entity.Property(e => e.IdUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("id_updated_by");
            entity.Property(e => e.IdUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("id_updated_on");
        });

        modelBuilder.Entity<GcInvoiceHead>(entity =>
        {
            entity.HasKey(e => e.IhId).HasName("PRIMARY");

            entity.ToTable("gc_invoice_head");

            entity.HasIndex(e => new { e.IhInvNo, e.IhDeliveryId }, "inv_no_del_ix");

            entity.HasIndex(e => new { e.IhInvNo, e.IhStaff }, "inv_no_staff_ix");

            entity.Property(e => e.IhId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("ih_id");
            entity.Property(e => e.CmStore)
                .HasColumnType("int(11)")
                .HasColumnName("cm_store");
            entity.Property(e => e.IhBillPrintCount)
                .HasColumnType("int(11)")
                .HasColumnName("ih_bill_print_count");
            entity.Property(e => e.IhCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("ih_created_by");
            entity.Property(e => e.IhCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("ih_created_on");
            entity.Property(e => e.IhCurCode)
                .HasMaxLength(4)
                .HasDefaultValueSql("'784'")
                .HasColumnName("ih_cur_code");
            entity.Property(e => e.IhCustomer)
                .HasColumnType("bigint(20)")
                .HasColumnName("ih_customer");
            entity.Property(e => e.IhCustomerAddress)
                .HasColumnType("bigint(20)")
                .HasColumnName("ih_customer_address");
            entity.Property(e => e.IhDeliveryId)
                .HasColumnType("bigint(20)")
                .HasColumnName("ih_delivery_id");
            entity.Property(e => e.IhDiscAmt)
                .HasPrecision(17, 3)
                .HasColumnName("ih_disc_amt");
            entity.Property(e => e.IhHoldYn)
                .HasMaxLength(1)
                .HasColumnName("ih_hold_yn");
            entity.Property(e => e.IhInfo)
                .HasMaxLength(246)
                .HasColumnName("ih_info");
            entity.Property(e => e.IhInvDate)
                .HasColumnType("date")
                .HasColumnName("ih_inv_date");
            entity.Property(e => e.IhInvNo)
                .HasMaxLength(50)
                .HasColumnName("ih_inv_no");
            entity.Property(e => e.IhInvoiceBy)
                .HasMaxLength(100)
                .HasColumnName("ih_invoice_by");
            entity.Property(e => e.IhInvoicedOn)
                .HasColumnType("datetime")
                .HasColumnName("ih_invoiced_on");
            entity.Property(e => e.IhItemCount)
                .HasColumnType("int(11)")
                .HasColumnName("ih_item_count");
            entity.Property(e => e.IhKotCount)
                .HasColumnType("int(11)")
                .HasColumnName("ih_kot_count");
            entity.Property(e => e.IhNetAmt)
                .HasPrecision(17, 3)
                .HasColumnName("ih_net_amt");
            entity.Property(e => e.IhOnlineRef)
                .HasMaxLength(50)
                .HasColumnName("ih_online_ref");
            entity.Property(e => e.IhOnlineVendor)
                .HasColumnType("int(11)")
                .HasColumnName("ih_online_vendor");
            entity.Property(e => e.IhPostYn)
                .HasMaxLength(1)
                .HasColumnName("ih_post_yn");
            entity.Property(e => e.IhRemarks)
                .HasMaxLength(100)
                .HasColumnName("ih_remarks");
            entity.Property(e => e.IhReprintCount)
                .HasColumnType("int(11)")
                .HasColumnName("ih_reprint_count");
            entity.Property(e => e.IhReturnYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'")
                .HasColumnName("ih_return_yn");
            entity.Property(e => e.IhStaff)
                .HasColumnType("bigint(20)")
                .HasColumnName("ih_staff");
            entity.Property(e => e.IhTableNo)
                .HasMaxLength(20)
                .HasColumnName("ih_table_no");
            entity.Property(e => e.IhTaxAmt)
                .HasPrecision(17, 3)
                .HasColumnName("ih_tax_amt");
            entity.Property(e => e.IhTotalAmt)
                .HasPrecision(17, 3)
                .HasColumnName("ih_total_amt");
            entity.Property(e => e.IhTransYn)
                .HasMaxLength(1)
                .HasColumnName("ih_trans_yn");
            entity.Property(e => e.IhType)
                .HasMaxLength(20)
                .HasColumnName("ih_type");
            entity.Property(e => e.IhUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("ih_updated_by");
            entity.Property(e => e.IhUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("ih_updated_on");
        });

        modelBuilder.Entity<GcInvoicePay>(entity =>
        {
            entity.HasKey(e => e.IpId).HasName("PRIMARY");

            entity.ToTable("gc_invoice_pay");

            entity.Property(e => e.IpId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("ip_id");
            entity.Property(e => e.IpBalAmt)
                .HasPrecision(17, 3)
                .HasColumnName("ip_bal_amt");
            entity.Property(e => e.IpCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("ip_created_by");
            entity.Property(e => e.IpCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("ip_created_on");
            entity.Property(e => e.IpCustomerCode)
                .HasColumnType("int(11)")
                .HasColumnName("ip_customer_code");
            entity.Property(e => e.IpCustomerName)
                .HasMaxLength(50)
                .HasColumnName("ip_customer_name");
            entity.Property(e => e.IpInvNo)
                .HasMaxLength(50)
                .HasColumnName("ip_inv_no");
            entity.Property(e => e.IpPayMode)
                .HasMaxLength(50)
                .HasColumnName("ip_pay_mode");
            entity.Property(e => e.IpRecAmt)
                .HasPrecision(17, 3)
                .HasColumnName("ip_rec_amt");
            entity.Property(e => e.IpStore)
                .HasColumnType("int(11)")
                .HasColumnName("ip_store");
            entity.Property(e => e.IpUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("ip_updated_by");
            entity.Property(e => e.IpUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("ip_updated_on");
        });

        modelBuilder.Entity<GcItemMaster>(entity =>
        {
            entity.HasKey(e => e.ImSlId).HasName("PRIMARY");

            entity.ToTable("gc_item_master");

            entity.HasIndex(e => e.ImItemCode, "im_item_code_UNIQUE").IsUnique();

            entity.Property(e => e.ImSlId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("im_sl_id");
            entity.Property(e => e.ImActive)
                .HasMaxLength(5)
                .HasColumnName("im_active");
            entity.Property(e => e.ImArabicName)
                .HasMaxLength(50)
                .HasColumnName("im_arabic_name");
            entity.Property(e => e.ImArabicShortName)
                .HasMaxLength(50)
                .HasColumnName("im_arabic_short_name");
            entity.Property(e => e.ImBarcode)
                .HasMaxLength(30)
                .HasColumnName("im_barcode");
            entity.Property(e => e.ImBaseUnit)
                .HasMaxLength(50)
                .HasColumnName("im_base_unit");
            entity.Property(e => e.ImBrandId)
                .HasMaxLength(5)
                .HasColumnName("im_brand_id");
            entity.Property(e => e.ImCatId)
                .HasMaxLength(5)
                .HasColumnName("im_cat_id");
            entity.Property(e => e.ImCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("im_created_by");
            entity.Property(e => e.ImCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("im_created_on");
            entity.Property(e => e.ImDeliveryPrice)
                .HasMaxLength(20)
                .HasColumnName("im_delivery_price");
            entity.Property(e => e.ImFamilyPrice)
                .HasMaxLength(20)
                .HasColumnName("im_family_price");
            entity.Property(e => e.ImFlagActive)
                .HasMaxLength(50)
                .HasColumnName("im_flag_active");
            entity.Property(e => e.ImFlagBarcodeItm)
                .HasMaxLength(50)
                .HasColumnName("im_flag_barcode_itm");
            entity.Property(e => e.ImFlagFastMk)
                .HasMaxLength(50)
                .HasColumnName("im_flag_fast_mk");
            entity.Property(e => e.ImFlagSeasonal)
                .HasMaxLength(50)
                .HasColumnName("im_flag_seasonal");
            entity.Property(e => e.ImFlagSellable)
                .HasMaxLength(50)
                .HasColumnName("im_flag_sellable");
            entity.Property(e => e.ImFlagSpclPrd)
                .HasMaxLength(50)
                .HasColumnName("im_flag_spcl_prd");
            entity.Property(e => e.ImImage)
                .HasMaxLength(50)
                .HasColumnName("im_image");
            entity.Property(e => e.ImItemCode)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("im_item_code");
            entity.Property(e => e.ImItemType)
                .HasMaxLength(50)
                .HasColumnName("im_item_type");
            entity.Property(e => e.ImKotCode)
                .HasColumnType("int(11)")
                .HasColumnName("im_kot_code");
            entity.Property(e => e.ImKotYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'Y'")
                .HasColumnName("im_kot_yn");
            entity.Property(e => e.ImMakingTime)
                .HasMaxLength(50)
                .HasColumnName("im_making_time");
            entity.Property(e => e.ImName)
                .HasMaxLength(50)
                .HasColumnName("im_name");
            entity.Property(e => e.ImNormalPrice)
                .HasMaxLength(20)
                .HasColumnName("im_normal_price");
            entity.Property(e => e.ImOldCode)
                .HasMaxLength(50)
                .HasColumnName("im_old_code");
            entity.Property(e => e.ImOnlinePrice)
                .HasMaxLength(20)
                .HasColumnName("im_online_price");
            entity.Property(e => e.ImParent)
                .HasColumnType("int(11)")
                .HasColumnName("im_parent");
            entity.Property(e => e.ImParentYn)
                .HasMaxLength(1)
                .HasColumnName("im_parent_yn");
            entity.Property(e => e.ImShortName)
                .HasMaxLength(50)
                .HasColumnName("im_short_name");
            entity.Property(e => e.ImSubcatId)
                .HasMaxLength(5)
                .HasColumnName("im_subcat_id");
            entity.Property(e => e.ImTakeawayPrice)
                .HasMaxLength(20)
                .HasColumnName("im_takeaway_price");
            entity.Property(e => e.ImTaxPerc)
                .HasPrecision(10)
                .HasColumnName("im_tax_perc");
            entity.Property(e => e.ImTaxYn)
                .HasMaxLength(1)
                .HasColumnName("im_tax_yn");
            entity.Property(e => e.ImTransYn)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("im_trans_yn");
            entity.Property(e => e.ImUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("im_updated_by");
            entity.Property(e => e.ImUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("im_updated_on");
            entity.Property(e => e.TmOldCode)
                .HasMaxLength(45)
                .HasColumnName("tm_old_code");
        });

        modelBuilder.Entity<GcKitchenMessage>(entity =>
        {
            entity.HasKey(e => e.KmId).HasName("PRIMARY");

            entity.ToTable("gc_kitchen_messages");

            entity.Property(e => e.KmId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("km_id");
            entity.Property(e => e.KmActive)
                .HasMaxLength(1)
                .HasColumnName("km_active");
            entity.Property(e => e.KmCreatedBy)
                .HasMaxLength(50)
                .HasColumnName("km_created_by");
            entity.Property(e => e.KmCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("km_created_on");
            entity.Property(e => e.KmMessage)
                .HasMaxLength(50)
                .HasColumnName("km_message");
            entity.Property(e => e.KmUpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("km_updated_by");
            entity.Property(e => e.KmUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("km_updated_on");
        });

        modelBuilder.Entity<GcOnlineCustomer>(entity =>
        {
            entity.HasKey(e => e.OcId).HasName("PRIMARY");

            entity.ToTable("gc_online_customers");

            entity.Property(e => e.OcId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("oc_id");
            entity.Property(e => e.OcActiveYn)
                .HasMaxLength(1)
                .HasColumnName("oc_active_yn");
            entity.Property(e => e.OcCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("oc_created_by");
            entity.Property(e => e.OcCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("oc_created_on");
            entity.Property(e => e.OcCustomerCode)
                .HasColumnType("int(11)")
                .HasColumnName("oc_customer_code");
            entity.Property(e => e.OcCustomerName)
                .HasMaxLength(100)
                .HasColumnName("oc_customer_name");
            entity.Property(e => e.OcUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("oc_updated_by");
            entity.Property(e => e.OcUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("oc_updated_on");
        });

        modelBuilder.Entity<GcOnlinePricing>(entity =>
        {
            entity.HasKey(e => e.SlId).HasName("PRIMARY");

            entity.ToTable("gc_online_pricing");

            entity.Property(e => e.SlId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sl_id");
            entity.Property(e => e.OpActiveYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'Y'")
                .HasColumnName("op_active_yn");
            entity.Property(e => e.OpCreatedBy)
                .HasMaxLength(45)
                .HasColumnName("op_created_by");
            entity.Property(e => e.OpCreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("op_created_on");
            entity.Property(e => e.OpItemId)
                .HasColumnType("int(11)")
                .HasColumnName("op_item_id");
            entity.Property(e => e.OpPrice)
                .HasPrecision(17, 3)
                .HasColumnName("op_price");
            entity.Property(e => e.OpUpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("op_updated_by");
            entity.Property(e => e.OpUpdatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("op_updated_on");
            entity.Property(e => e.OpVentorId)
                .HasColumnType("int(11)")
                .HasColumnName("op_ventor_id");
        });

        modelBuilder.Entity<GcPosUser>(entity =>
        {
            entity.HasKey(e => e.PuId).HasName("PRIMARY");

            entity.ToTable("gc_pos_user");

            entity.HasIndex(e => e.PuId, "up_id_UNIQUE").IsUnique();

            entity.Property(e => e.PuId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("pu_id");
            entity.Property(e => e.PuCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("pu_created_by");
            entity.Property(e => e.PuCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("pu_created_on");
            entity.Property(e => e.PuEmail)
                .HasMaxLength(100)
                .HasColumnName("pu_email");
            entity.Property(e => e.PuLastLogin)
                .HasColumnType("datetime")
                .HasColumnName("pu_last_login");
            entity.Property(e => e.PuLevel)
                .HasColumnType("int(1)")
                .HasColumnName("pu_level");
            entity.Property(e => e.PuMobile)
                .HasMaxLength(15)
                .HasColumnName("pu_mobile");
            entity.Property(e => e.PuName)
                .HasMaxLength(100)
                .HasColumnName("pu_name");
            entity.Property(e => e.PuPassword)
                .HasMaxLength(100)
                .HasColumnName("pu_password");
            entity.Property(e => e.PuTransYn)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("pu_trans_yn");
            entity.Property(e => e.PuUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("pu_updated_by");
            entity.Property(e => e.PuUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("pu_updated_on");
            entity.Property(e => e.PuUserId)
                .HasMaxLength(100)
                .HasColumnName("pu_user_id");
        });

        modelBuilder.Entity<GcSetting>(entity =>
        {
            entity.HasKey(e => e.SiId).HasName("PRIMARY");

            entity.ToTable("gc_settings");

            entity.HasIndex(e => e.SiName, "si_name_UNIQUE").IsUnique();

            entity.Property(e => e.SiId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("si_id");
            entity.Property(e => e.SiCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("si_created_by");
            entity.Property(e => e.SiCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("si_created_on");
            entity.Property(e => e.SiKey)
                .HasMaxLength(100)
                .HasColumnName("si_key");
            entity.Property(e => e.SiName)
                .HasMaxLength(100)
                .HasColumnName("si_name");
            entity.Property(e => e.SiUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("si_updated_by");
            entity.Property(e => e.SiUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("si_updated_on");
            entity.Property(e => e.SiValue)
                .HasMaxLength(256)
                .HasColumnName("si_value");
        });

        modelBuilder.Entity<GcStaffMaster>(entity =>
        {
            entity.HasKey(e => e.SmId).HasName("PRIMARY");

            entity.ToTable("gc_staff_master");

            entity.Property(e => e.SmId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("sm_id");
            entity.Property(e => e.SmActiveYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'Y'")
                .HasColumnName("sm_active_yn");
            entity.Property(e => e.SmCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("sm_created_by");
            entity.Property(e => e.SmCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("sm_created_on");
            entity.Property(e => e.SmStaffId)
                .HasMaxLength(50)
                .HasColumnName("sm_staff_id");
            entity.Property(e => e.SmStaffName)
                .HasMaxLength(100)
                .HasColumnName("sm_staff_name");
            entity.Property(e => e.SmStore)
                .HasColumnType("int(11)")
                .HasColumnName("sm_store");
            entity.Property(e => e.SmUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("sm_updated_by");
            entity.Property(e => e.SmUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("sm_updated_on");
        });

        modelBuilder.Entity<GcTableMaster>(entity =>
        {
            entity.HasKey(e => e.TmId).HasName("PRIMARY");

            entity.ToTable("gc_table_master");

            entity.Property(e => e.TmId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("tm_id");
            entity.Property(e => e.TmActive)
                .HasMaxLength(1)
                .HasColumnName("tm_active");
            entity.Property(e => e.TmChildId)
                .HasMaxLength(10)
                .HasColumnName("tm_child_id");
            entity.Property(e => e.TmCreatedBy)
                .HasMaxLength(100)
                .HasColumnName("tm_created_by");
            entity.Property(e => e.TmCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("tm_created_on");
            entity.Property(e => e.TmInvocieNo)
                .HasMaxLength(50)
                .HasColumnName("tm_invocie_no");
            entity.Property(e => e.TmNumber)
                .HasMaxLength(10)
                .HasColumnName("tm_number");
            entity.Property(e => e.TmParentYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'")
                .HasColumnName("tm_parent_yn");
            entity.Property(e => e.TmStartTime)
                .HasColumnType("datetime")
                .HasColumnName("tm_start_time");
            entity.Property(e => e.TmStatus)
                .HasMaxLength(30)
                .HasDefaultValueSql("'N'")
                .HasColumnName("tm_status");
            entity.Property(e => e.TmStore)
                .HasColumnType("int(11)")
                .HasColumnName("tm_store");
            entity.Property(e => e.TmTempYn)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'")
                .HasColumnName("tm_temp_yn");
            entity.Property(e => e.TmTransYn)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("tm_trans_yn");
            entity.Property(e => e.TmType)
                .HasMaxLength(50)
                .HasColumnName("tm_type");
            entity.Property(e => e.TmUpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("tm_updated_by");
            entity.Property(e => e.TmUpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("tm_updated_on");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
