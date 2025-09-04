using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using backend_dotnet.Models;

namespace backend_dotnet.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AclRecord> AclRecords { get; set; }

    public virtual DbSet<ActivityLog> ActivityLogs { get; set; }

    public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Affiliate> Affiliates { get; set; }

    public virtual DbSet<BackInStockSubscription> BackInStockSubscriptions { get; set; }

    public virtual DbSet<BckTblProductDetail> BckTblProductDetails { get; set; }

    public virtual DbSet<BlogComment> BlogComments { get; set; }

    public virtual DbSet<BlogPost> BlogPosts { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }

    public virtual DbSet<ChartOfAccount> ChartOfAccounts { get; set; }

    public virtual DbSet<CheckoutAttribute> CheckoutAttributes { get; set; }

    public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValues { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Courier> Couriers { get; set; }

    public virtual DbSet<CourierDetail> CourierDetails { get; set; }

    public virtual DbSet<CourierType> CourierTypes { get; set; }

    public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }

    public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }

    public virtual DbSet<CustomerBackupRecord> CustomerBackupRecords { get; set; }

    public virtual DbSet<CustomerCustomerRoleMapping> CustomerCustomerRoleMappings { get; set; }

    public virtual DbSet<CustomerRole> CustomerRoles { get; set; }

    public virtual DbSet<DeliveryDate> DeliveryDates { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<DiscountAppliedToCategory> DiscountAppliedToCategories { get; set; }

    public virtual DbSet<DiscountAppliedToProduct> DiscountAppliedToProducts { get; set; }

    public virtual DbSet<DiscountRequirement> DiscountRequirements { get; set; }

    public virtual DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }

    public virtual DbSet<Download> Downloads { get; set; }

    public virtual DbSet<EmailAccount> EmailAccounts { get; set; }

    public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }

    public virtual DbSet<ForumsForum> ForumsForums { get; set; }

    public virtual DbSet<ForumsGroup> ForumsGroups { get; set; }

    public virtual DbSet<ForumsPost> ForumsPosts { get; set; }

    public virtual DbSet<ForumsPrivateMessage> ForumsPrivateMessages { get; set; }

    public virtual DbSet<ForumsSubscription> ForumsSubscriptions { get; set; }

    public virtual DbSet<ForumsTopic> ForumsTopics { get; set; }

    public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }

    public virtual DbSet<GiftCard> GiftCards { get; set; }

    public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; }

    public virtual DbSet<GoogleProduct> GoogleProducts { get; set; }

    public virtual DbSet<InvoicePaymentDetail> InvoicePaymentDetails { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }

    public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }

    public virtual DbSet<MeasureDimension> MeasureDimensions { get; set; }

    public virtual DbSet<MeasureWeight> MeasureWeights { get; set; }

    public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsComment> NewsComments { get; set; }

    public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }

    public virtual DbSet<NewsLetterTemplate> NewsLetterTemplates { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderNote> OrderNotes { get; set; }

    public virtual DbSet<Page> Pages { get; set; }

    public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }

    public virtual DbSet<PermissionRecordRoleMapping> PermissionRecordRoleMappings { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<Poll> Polls { get; set; }

    public virtual DbSet<PollAnswer> PollAnswers { get; set; }

    public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }

    public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }

    public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }

    public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }

    public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }

    public virtual DbSet<ProductProductTagMapping> ProductProductTagMappings { get; set; }

    public virtual DbSet<ProductReview> ProductReviews { get; set; }

    public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }

    public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }

    public virtual DbSet<ProductVariantAttributeCombination> ProductVariantAttributeCombinations { get; set; }

    public virtual DbSet<ProductVariantAttributeValue> ProductVariantAttributeValues { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }

    public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }

    public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistories { get; set; }

    public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }

    public virtual DbSet<ReturnRequest> ReturnRequests { get; set; }

    public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }

    public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }

    public virtual DbSet<SearchTerm> SearchTerms { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }

    public virtual DbSet<ShippingByWeight> ShippingByWeights { get; set; }

    public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }

    public virtual DbSet<ShippingMethodRestriction> ShippingMethodRestrictions { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public virtual DbSet<Smsconfig> Smsconfigs { get; set; }

    public virtual DbSet<SpecificationAttribute> SpecificationAttributes { get; set; }

    public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }

    public virtual DbSet<StateProvince> StateProvinces { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreMapping> StoreMappings { get; set; }

    public virtual DbSet<TaxCategory> TaxCategories { get; set; }

    public virtual DbSet<TaxRate> TaxRates { get; set; }

    public virtual DbSet<TblAdvanceSalaryLoan> TblAdvanceSalaryLoans { get; set; }

    public virtual DbSet<TblAttendance> TblAttendances { get; set; }

    public virtual DbSet<TblAttendanceParam> TblAttendanceParams { get; set; }

    public virtual DbSet<TblBank> TblBanks { get; set; }

    public virtual DbSet<TblBankAccount> TblBankAccounts { get; set; }

    public virtual DbSet<TblBankLedger> TblBankLedgers { get; set; }

    public virtual DbSet<TblBonu> TblBonus { get; set; }

    public virtual DbSet<TblBonusDetail> TblBonusDetails { get; set; }

    public virtual DbSet<TblBranch> TblBranches { get; set; }

    public virtual DbSet<TblBranchExpense> TblBranchExpenses { get; set; }

    public virtual DbSet<TblBranchInventoryRequest> TblBranchInventoryRequests { get; set; }

    public virtual DbSet<TblBranchUserInfo> TblBranchUserInfos { get; set; }

    public virtual DbSet<TblBudget> TblBudgets { get; set; }

    public virtual DbSet<TblCashPayment> TblCashPayments { get; set; }

    public virtual DbSet<TblCategory> TblCategories { get; set; }

    public virtual DbSet<TblCity> TblCities { get; set; }

    public virtual DbSet<TblClearingAgent> TblClearingAgents { get; set; }

    public virtual DbSet<TblClearingAgentFreightForwarder> TblClearingAgentFreightForwarders { get; set; }

    public virtual DbSet<TblClearingAgentFreightForwarderInvoice> TblClearingAgentFreightForwarderInvoices { get; set; }

    public virtual DbSet<TblClearingAgentFreightForwarderLedger> TblClearingAgentFreightForwarderLedgers { get; set; }

    public virtual DbSet<TblClearingAgentFreightForwarderPayment> TblClearingAgentFreightForwarderPayments { get; set; }

    public virtual DbSet<TblCompany> TblCompanies { get; set; }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

    public virtual DbSet<TblCriticalValuesRecord> TblCriticalValuesRecords { get; set; }

    public virtual DbSet<TblCurrency> TblCurrencies { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblCustomerPayment> TblCustomerPayments { get; set; }

    public virtual DbSet<TblCustomersBackup> TblCustomersBackups { get; set; }

    public virtual DbSet<TblCustomersNtn> TblCustomersNtns { get; set; }

    public virtual DbSet<TblDcSendTransferRecord> TblDcSendTransferRecords { get; set; }

    public virtual DbSet<TblDeliveryChalan> TblDeliveryChalans { get; set; }

    public virtual DbSet<TblDeliveryChalanDetail> TblDeliveryChalanDetails { get; set; }

    public virtual DbSet<TblDesignation> TblDesignations { get; set; }

    public virtual DbSet<TblExpense> TblExpenses { get; set; }

    public virtual DbSet<TblExpensesMode> TblExpensesModes { get; set; }

    public virtual DbSet<TblFreightForwarder> TblFreightForwarders { get; set; }

    public virtual DbSet<TblHoliday> TblHolidays { get; set; }

    public virtual DbSet<TblIndustry> TblIndustries { get; set; }

    public virtual DbSet<TblInventoryHistory> TblInventoryHistories { get; set; }

    public virtual DbSet<TblInvoiceType> TblInvoiceTypes { get; set; }

    public virtual DbSet<TblLogin> TblLogins { get; set; }

    public virtual DbSet<TblManufacturer> TblManufacturers { get; set; }

    public virtual DbSet<TblMissingItem> TblMissingItems { get; set; }

    public virtual DbSet<TblMoneyChanger> TblMoneyChangers { get; set; }

    public virtual DbSet<TblMoneychangerLedger> TblMoneychangerLedgers { get; set; }

    public virtual DbSet<TblMoneychangerPayment> TblMoneychangerPayments { get; set; }

    public virtual DbSet<TblOrder> TblOrders { get; set; }

    public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }

    public virtual DbSet<TblOrderStatus> TblOrderStatuses { get; set; }

    public virtual DbSet<TblOtherPayment> TblOtherPayments { get; set; }

    public virtual DbSet<TblPayRoll> TblPayRolls { get; set; }

    public virtual DbSet<TblPerforma> TblPerformas { get; set; }

    public virtual DbSet<TblPerformaParam> TblPerformaParams { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductDetail> TblProductDetails { get; set; }

    public virtual DbSet<TblProductsPrice> TblProductsPrices { get; set; }

    public virtual DbSet<TblProductsPricing> TblProductsPricings { get; set; }

    public virtual DbSet<TblPurchaseOrder> TblPurchaseOrders { get; set; }

    public virtual DbSet<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; }

    public virtual DbSet<TblReturnProduct> TblReturnProducts { get; set; }

    public virtual DbSet<TblRma> TblRmas { get; set; }

    public virtual DbSet<TblSampleDetail> TblSampleDetails { get; set; }

    public virtual DbSet<TblSampleMaster> TblSampleMasters { get; set; }

    public virtual DbSet<TblSm> TblSms { get; set; }

    public virtual DbSet<TblSmsgsm> TblSmsgsms { get; set; }

    public virtual DbSet<TblTemplate> TblTemplates { get; set; }

    public virtual DbSet<TblVendor> TblVendors { get; set; }

    public virtual DbSet<TblVendorLedger> TblVendorLedgers { get; set; }

    public virtual DbSet<TblVendorPayment> TblVendorPayments { get; set; }

    public virtual DbSet<TblWarrantyMode> TblWarrantyModes { get; set; }

    public virtual DbSet<TierPrice> TierPrices { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<UrlRecord> UrlRecords { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserRolePage> UserRolePages { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<ViewDcNew> ViewDcNews { get; set; }

    public virtual DbSet<ViewMonthWiseExpense> ViewMonthWiseExpenses { get; set; }

    public virtual DbSet<ViewOrder> ViewOrders { get; set; }

    public virtual DbSet<ViewOrderProduct> ViewOrderProducts { get; set; }

    public virtual DbSet<ViewOrderReturn> ViewOrderReturns { get; set; }

    public virtual DbSet<VwAdvanceSalaryLoan> VwAdvanceSalaryLoans { get; set; }

    public virtual DbSet<VwBank> VwBanks { get; set; }

    public virtual DbSet<VwBankAccount> VwBankAccounts { get; set; }

    public virtual DbSet<VwBonu> VwBonus { get; set; }

    public virtual DbSet<VwBranch> VwBranches { get; set; }

    public virtual DbSet<VwBranchInventoryRequest> VwBranchInventoryRequests { get; set; }

    public virtual DbSet<VwCategory> VwCategories { get; set; }

    public virtual DbSet<VwChartOfAccount> VwChartOfAccounts { get; set; }

    public virtual DbSet<VwClearingAgentFreightForwarderLedger> VwClearingAgentFreightForwarderLedgers { get; set; }

    public virtual DbSet<VwCompany> VwCompanies { get; set; }

    public virtual DbSet<VwCountryCity> VwCountryCities { get; set; }

    public virtual DbSet<VwCustomer> VwCustomers { get; set; }

    public virtual DbSet<VwCustomerLedger> VwCustomerLedgers { get; set; }

    public virtual DbSet<VwCustomerPayment> VwCustomerPayments { get; set; }

    public virtual DbSet<VwCustomers2> VwCustomers2s { get; set; }

    public virtual DbSet<VwDc> VwDcs { get; set; }

    public virtual DbSet<VwDcsummary> VwDcsummaries { get; set; }

    public virtual DbSet<VwExpense> VwExpenses { get; set; }

    public virtual DbSet<VwIndustry> VwIndustries { get; set; }

    public virtual DbSet<VwInventoryHistory> VwInventoryHistories { get; set; }

    public virtual DbSet<VwManufacturer> VwManufacturers { get; set; }

    public virtual DbSet<VwManufacturerCategory> VwManufacturerCategories { get; set; }

    public virtual DbSet<VwMissingItem> VwMissingItems { get; set; }

    public virtual DbSet<VwMoneyChangerLedger> VwMoneyChangerLedgers { get; set; }

    public virtual DbSet<VwOrder> VwOrders { get; set; }

    public virtual DbSet<VwOrderDetail> VwOrderDetails { get; set; }

    public virtual DbSet<VwOtherPayment> VwOtherPayments { get; set; }

    public virtual DbSet<VwPayRoll> VwPayRolls { get; set; }

    public virtual DbSet<VwProduct> VwProducts { get; set; }

    public virtual DbSet<VwProductDetail> VwProductDetails { get; set; }

    public virtual DbSet<VwProductDetailAll> VwProductDetailAlls { get; set; }

    public virtual DbSet<VwProductPicture> VwProductPictures { get; set; }

    public virtual DbSet<VwProductSaleDetail> VwProductSaleDetails { get; set; }

    public virtual DbSet<VwProductTag> VwProductTags { get; set; }

    public virtual DbSet<VwPurchaseOrder> VwPurchaseOrders { get; set; }

    public virtual DbSet<VwReplacedItem> VwReplacedItems { get; set; }

    public virtual DbSet<VwReturnProduct> VwReturnProducts { get; set; }

    public virtual DbSet<VwSampleItem> VwSampleItems { get; set; }

    public virtual DbSet<VwSm> VwSms { get; set; }

    public virtual DbSet<VwSmsconfig> VwSmsconfigs { get; set; }

    public virtual DbSet<VwTestOrder> VwTestOrders { get; set; }

    public virtual DbSet<VwVendorLedger> VwVendorLedgers { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=103.134.239.26;Database=dreamsnw_2020;User ID=DreamsNetwork;Password=welcome123;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AclRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AclRecor__3214EC07A2F996DB");

            entity.ToTable("AclRecord");

            entity.Property(e => e.EntityName).HasMaxLength(400);
        });

        modelBuilder.Entity<ActivityLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Activity__3214EC07C8DE27F1");

            entity.ToTable("ActivityLog");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ActivityLogType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Activity__3214EC079058FF91");

            entity.ToTable("ActivityLogType");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Address__3214EC07A34AFFC9");

            entity.ToTable("Address");

            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Province).HasMaxLength(500);
            entity.Property(e => e.Username).HasMaxLength(500);
        });

        modelBuilder.Entity<Affiliate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Affiliat__3214EC07FAE18716");

            entity.ToTable("Affiliate");
        });

        modelBuilder.Entity<BackInStockSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BackInSt__3214EC07CD9A1A65");

            entity.ToTable("BackInStockSubscription");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<BckTblProductDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bck_tblProductDetail");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CostingPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InventoryReqId).HasColumnName("InventoryReqID");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MissingItemsDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MissingItemsId).HasColumnName("MissingItemsID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.ProductDetailIdReplaced).HasColumnName("ProductDetailID_Replaced");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReplacePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReplacedDeviceCreated)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceRecieved)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceSent)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Replacement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RevertId).HasColumnName("RevertID");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.WarrantyModeId).HasColumnName("WarrantyModeID");
            entity.Property(e => e.WarrantyStartDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BlogComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BlogComm__3214EC078F892FF6");

            entity.ToTable("BlogComment");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<BlogPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BlogPost__3214EC0770DEF934");

            entity.ToTable("BlogPost");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.EndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.StartDateUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<Campaign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Campaign__3214EC0778223C62");

            entity.ToTable("Campaign");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC07A53A0129");

            entity.ToTable("Category");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceRanges).HasMaxLength(400);
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<CategoryTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC0765836C1E");

            entity.ToTable("CategoryTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<ChartOfAccount>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountCode).HasMaxLength(150);
            entity.Property(e => e.AccountType).HasMaxLength(100);
            entity.Property(e => e.ClosingBalance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DebitorOrCreditor).HasMaxLength(10);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.OpeningBalance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ParentAccountCode).HasMaxLength(100);
            entity.Property(e => e.TopParentOfSameType).HasMaxLength(100);
        });

        modelBuilder.Entity<CheckoutAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Checkout__3214EC076F9BD4CF");

            entity.ToTable("CheckoutAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<CheckoutAttributeValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Checkout__3214EC0747BC4946");

            entity.ToTable("CheckoutAttributeValue");

            entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Country__3214EC07DB9D5AA1");

            entity.ToTable("Country");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);
            entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
        });

        modelBuilder.Entity<Courier>(entity =>
        {
            entity.HasKey(e => e.Orderid).HasName("PK_Courier_1");

            entity.ToTable("Courier");

            entity.Property(e => e.Orderid).ValueGeneratedNever();
            entity.Property(e => e.CourierName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tag)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CourierDetail>(entity =>
        {
            entity.ToTable("CourierDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourierNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CourierTypeId).HasColumnName("CourierTypeID");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
        });

        modelBuilder.Entity<CourierType>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CrossSellProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrossSel__3214EC072060E6FA");

            entity.ToTable("CrossSellProduct");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Currency__3214EC07C7736C3F");

            entity.ToTable("Currency");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CurrencyCode).HasMaxLength(5);
            entity.Property(e => e.CustomFormatting).HasMaxLength(50);
            entity.Property(e => e.DisplayLocale).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.HasIndex(e => e.BillingAddressId, "in_Customer_BillingAddress_Id");

            entity.HasIndex(e => e.CompanyId, "in_Customer_CompanyID");

            entity.HasIndex(e => e.BranchId, "in_Customer_Customer");

            entity.HasIndex(e => e.UserRole, "in_Customer_UserRole");

            entity.Property(e => e.AdminComment).HasDefaultValue("");
            entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");
            entity.Property(e => e.BranchId)
                .HasDefaultValue(0)
                .HasColumnName("BranchID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(1000);
            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            entity.Property(e => e.IsApproved)
                .HasDefaultValue(false)
                .HasColumnName("isApproved");
            entity.Property(e => e.LastActivityDateUtc).HasColumnType("datetime");
            entity.Property(e => e.LastIpAddress).HasDefaultValue("");
            entity.Property(e => e.LastLoginDateUtc).HasColumnType("datetime");
            entity.Property(e => e.PasswordSalt).HasDefaultValue("");
            entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");
            entity.Property(e => e.SystemName).HasDefaultValue("");
            entity.Property(e => e.UserRole).HasDefaultValue(0);
            entity.Property(e => e.UserRoleText)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Username).HasMaxLength(1000);
        });

        modelBuilder.Entity<CustomerAddress>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.AddressId }).HasName("PK__Customer__3C8958229765086D");

            entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");
            entity.Property(e => e.AddressId).HasColumnName("Address_Id");
        });

        modelBuilder.Entity<CustomerAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07A29DF7F5");

            entity.ToTable("CustomerAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<CustomerAttributeValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC070EF8D755");

            entity.ToTable("CustomerAttributeValue");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<CustomerBackupRecord>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(1000);
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.LastActivityDateUtc).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDateUtc).HasColumnType("datetime");
            entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");
            entity.Property(e => e.UserRoleText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(1000);
        });

        modelBuilder.Entity<CustomerCustomerRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.CustomerRoleId }).HasName("PK__Customer__ABACF0F7F2B72F3F");

            entity.ToTable("Customer_CustomerRole_Mapping");

            entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");
            entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");
        });

        modelBuilder.Entity<CustomerRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07080E71F3");

            entity.ToTable("CustomerRole");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);
        });

        modelBuilder.Entity<DeliveryDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Delivery__3214EC07A7E2AE9C");

            entity.ToTable("DeliveryDate");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Discount__3214EC077C6BAFA8");

            entity.ToTable("Discount");

            entity.Property(e => e.CouponCode).HasMaxLength(100);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.StartDateUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<DiscountAppliedToCategory>(entity =>
        {
            entity.HasKey(e => new { e.DiscountId, e.CategoryId }).HasName("PK__Discount__9AC84AD24D12343E");

            entity.ToTable("Discount_AppliedToCategories");

            entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");
            entity.Property(e => e.CategoryId).HasColumnName("Category_Id");
        });

        modelBuilder.Entity<DiscountAppliedToProduct>(entity =>
        {
            entity.HasKey(e => new { e.DiscountId, e.ProductId }).HasName("PK__Discount__D5903DBF0F4D73DA");

            entity.ToTable("Discount_AppliedToProducts");

            entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");
            entity.Property(e => e.ProductId).HasColumnName("Product_Id");
        });

        modelBuilder.Entity<DiscountRequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Discount__3214EC074F7F3EA3");

            entity.ToTable("DiscountRequirement");
        });

        modelBuilder.Entity<DiscountUsageHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Discount__3214EC072DD14011");

            entity.ToTable("DiscountUsageHistory");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<Download>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Download__3214EC0779D1AC08");

            entity.ToTable("Download");
        });

        modelBuilder.Entity<EmailAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EmailAcc__3214EC07B369A19A");

            entity.ToTable("EmailAccount");

            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Host).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__External__3214EC071C9B14DE");

            entity.ToTable("ExternalAuthenticationRecord");

            entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");
            entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");
        });

        modelBuilder.Entity<ForumsForum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forums_F__3214EC0758BDD1FE");

            entity.ToTable("Forums_Forum");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.LastPostTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ForumsGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forums_G__3214EC077A8BFE48");

            entity.ToTable("Forums_Group");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ForumsPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forums_P__3214EC07FA04B582");

            entity.ToTable("Forums_Post");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(100)
                .HasColumnName("IPAddress");
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ForumsPrivateMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forums_P__3214EC0741E601ED");

            entity.ToTable("Forums_PrivateMessage");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(450);
        });

        modelBuilder.Entity<ForumsSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forums_S__3214EC07A732C351");

            entity.ToTable("Forums_Subscription");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ForumsTopic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forums_T__3214EC07D8772DF7");

            entity.ToTable("Forums_Topic");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.LastPostTime).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(450);
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<GenericAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GenericA__3214EC07F8122F75");

            entity.ToTable("GenericAttribute");

            entity.Property(e => e.Key).HasMaxLength(400);
            entity.Property(e => e.KeyGroup).HasMaxLength(400);
        });

        modelBuilder.Entity<GiftCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GiftCard__3214EC076EF9362A");

            entity.ToTable("GiftCard");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<GiftCardUsageHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GiftCard__3214EC07FDE3DF5C");

            entity.ToTable("GiftCardUsageHistory");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.UsedValue).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<GoogleProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GooglePr__3214EC07FAF3BB8A");

            entity.ToTable("GoogleProduct");
        });

        modelBuilder.Entity<InvoicePaymentDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceP__3214EC07A47C84C8");

            entity.HasIndex(e => new { e.OrderId, e.IsActive }, "IX_InvoicePaymentDetails_OrderID_Active");

            entity.HasIndex(e => e.OrderId, "InvoicePaymentDetails_OrderID");

            entity.HasIndex(e => e.PaymentId, "InvoicePaymentDetails_PaymentID");

            entity.Property(e => e.ActualAmountPaid)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Actual_Amount_Paid");
            entity.Property(e => e.AmountUsedForInvoice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Amount_Used_For_Invoice");
            entity.Property(e => e.BalanceInvoiceAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Balance_Invoice_Amount");
            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.InvoiceAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Invoice_Amount");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Invoice_Number");
            entity.Property(e => e.InvoiceSerial).HasColumnName("Invoice_Serial");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("Is_Active");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("Is_Deleted");
            entity.Property(e => e.IsTemproryRecord)
                .HasDefaultValue(false)
                .HasColumnName("Is_Temprory_Record");
            entity.Property(e => e.OrderId).HasColumnName("Order_ID");
            entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Language__3214EC075947F479");

            entity.ToTable("Language");

            entity.Property(e => e.FlagImageFileName).HasMaxLength(50);
            entity.Property(e => e.LanguageCulture).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
        });

        modelBuilder.Entity<LocaleStringResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LocaleSt__3214EC07BB1459EE");

            entity.ToTable("LocaleStringResource");

            entity.Property(e => e.ResourceName).HasMaxLength(200);
        });

        modelBuilder.Entity<LocalizedProperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Localize__3214EC07C04BD412");

            entity.ToTable("LocalizedProperty");

            entity.Property(e => e.LocaleKey).HasMaxLength(400);
            entity.Property(e => e.LocaleKeyGroup).HasMaxLength(400);
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Log__3214EC07E558D17D");

            entity.ToTable("Log");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.IpAddress).HasMaxLength(200);
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Manufact__3214EC078ADD16D9");

            entity.ToTable("Manufacturer");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceRanges).HasMaxLength(400);
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ManufacturerTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Manufact__3214EC072708C997");

            entity.ToTable("ManufacturerTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<MeasureDimension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MeasureD__3214EC07FBFE0ED2");

            entity.ToTable("MeasureDimension");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<MeasureWeight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MeasureW__3214EC0740AB77AF");

            entity.ToTable("MeasureWeight");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<MessageTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MessageT__3214EC073805D6C8");

            entity.ToTable("MessageTemplate");

            entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Subject).HasMaxLength(1000);
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__News__3214EC07226ED440");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.EndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.StartDateUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<NewsComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NewsComm__3214EC076820AB1A");

            entity.ToTable("NewsComment");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.IsViewed)
                .HasDefaultValue(0)
                .HasColumnName("isViewed");
        });

        modelBuilder.Entity<NewsLetterSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NewsLett__3214EC0709C0526F");

            entity.ToTable("NewsLetterSubscription");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
        });

        modelBuilder.Entity<NewsLetterTemplate>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(500);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order");

            entity.HasIndex(e => e.Id, "IX_Order_Id");

            entity.HasIndex(e => e.InvoiceType, "in_Customer_InvoiceType");

            entity.HasIndex(e => e.OrderDate, "in_Customer_OrderDate");

            entity.HasIndex(e => e.BranchId, "in_Order_BranchID");

            entity.HasIndex(e => e.CompanyId, "in_Order_CompanyID");

            entity.HasIndex(e => e.CustomerId, "in_Order_CustomerID");

            entity.HasIndex(e => e.Status, "in_Order_Status");

            entity.Property(e => e.AcceptedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizationTransactionCode).HasDefaultValue("");
            entity.Property(e => e.AuthorizationTransactionId).HasDefaultValue("");
            entity.Property(e => e.AuthorizationTransactionResult).HasDefaultValue("");
            entity.Property(e => e.BillingMonth).HasMaxLength(100);
            entity.Property(e => e.BranchId)
                .HasDefaultValue(0)
                .HasColumnName("BranchID");
            entity.Property(e => e.CaptureTransactionId).HasDefaultValue("");
            entity.Property(e => e.CaptureTransactionResult).HasDefaultValue("");
            entity.Property(e => e.CardCvv2).HasDefaultValue("");
            entity.Property(e => e.CardExpirationMonth).HasDefaultValue("");
            entity.Property(e => e.CardExpirationYear).HasDefaultValue("");
            entity.Property(e => e.CardName).HasDefaultValue("");
            entity.Property(e => e.CardNumber).HasDefaultValue("");
            entity.Property(e => e.CardType).HasDefaultValue("");
            entity.Property(e => e.CheckoutAttributeDescription).HasDefaultValue("");
            entity.Property(e => e.CheckoutAttributesXml).HasDefaultValue("");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Courier)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.CustomValuesXml).HasDefaultValue("");
            entity.Property(e => e.CustomerCurrencyCode).HasDefaultValue("");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerIp).HasDefaultValue("");
            entity.Property(e => e.DueDays).HasDefaultValue(0);
            entity.Property(e => e.IncomeTax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 5)");
            entity.Property(e => e.IncomeTaxForNotImportedItems)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceSerial).HasDefaultValue(0);
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsDueDaysSmsSent)
                .HasDefaultValue(0)
                .HasColumnName("isDueDaysSmsSent");
            entity.Property(e => e.MaskedCreditCardNumber).HasDefaultValue("");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NoteHeading)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NtnNo)
                .HasDefaultValue(0)
                .HasColumnName("NTN_No");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OtherAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmountDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaidDateUtc).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentMethodSystemName).HasDefaultValue("");
            entity.Property(e => e.ProformaUid).HasColumnName("ProformaUID");
            entity.Property(e => e.ProformaUidsalesTax).HasColumnName("ProformaUIDSalesTax");
            entity.Property(e => e.PurchaseOrderImageRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseOrderNumber).HasDefaultValue("");
            entity.Property(e => e.PurchaseOrderRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReturnFileImgRef).HasMaxLength(150);
            entity.Property(e => e.ReturnFileMonth).HasMaxLength(100);
            entity.Property(e => e.SalesTax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 5)");
            entity.Property(e => e.SalesTaxOneFifthDeduction)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SalesTax_OneFifth_Deduction");
            entity.Property(e => e.SalespersonId).HasColumnName("SalespersonID");
            entity.Property(e => e.ShippingAddressId).HasDefaultValue(0);
            entity.Property(e => e.ShippingMethod).HasDefaultValue("");
            entity.Property(e => e.ShippingRateComputationMethodSystemName).HasDefaultValue("");
            entity.Property(e => e.SignedDeliveryNoteImageRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SrtnNo)
                .HasDefaultValue(0)
                .HasColumnName("SRTN_No");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.SubscriptionTransactionId).HasDefaultValue("");
            entity.Property(e => e.TaxRates).HasDefaultValue("");
            entity.Property(e => e.ValueAddedTax17per)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_17Per");
            entity.Property(e => e.ValueAddedTax1per)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_1Per");
            entity.Property(e => e.VatNumber).HasDefaultValue("");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.ToTable("OrderItem");

            entity.HasIndex(e => new { e.OrderId, e.Quantity, e.Price }, "IX_OrderItem_OrderID");

            entity.HasIndex(e => e.OrderId, "in_OrderItem_OrderID");

            entity.HasIndex(e => e.ProductId, "in_OrderItem_ProductID");

            entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OriginalProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Price)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SalespersonId).HasColumnName("SalespersonID");
            entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<OrderNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderNot__3214EC07B8674EB1");

            entity.ToTable("OrderNote");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<Page>(entity =>
        {
            entity.HasKey(e => e.PageId).HasName("PK__Pages__D36DED57AA64925C");

            entity.Property(e => e.PageId).HasColumnName("Page_ID");
            entity.Property(e => e.ImagePath).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.IsAdhoc).HasColumnName("Is_Adhoc");
            entity.Property(e => e.IsPage).HasColumnName("Is_Page");
            entity.Property(e => e.Link).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("Parent_ID");
        });

        modelBuilder.Entity<PermissionRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permissi__3214EC0702773972");

            entity.ToTable("PermissionRecord");

            entity.Property(e => e.Category).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);
        });

        modelBuilder.Entity<PermissionRecordRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.PermissionRecordId, e.CustomerRoleId }).HasName("PK__Permissi__4804FB26A84D4541");

            entity.ToTable("PermissionRecord_Role_Mapping");

            entity.Property(e => e.PermissionRecordId).HasColumnName("PermissionRecord_Id");
            entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Picture__3214EC07283A2AD1");

            entity.ToTable("Picture");

            entity.Property(e => e.MimeType).HasMaxLength(40);
            entity.Property(e => e.SeoFilename).HasMaxLength(300);
        });

        modelBuilder.Entity<Poll>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Poll__3214EC07610791FE");

            entity.ToTable("Poll");

            entity.Property(e => e.EndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.StartDateUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<PollAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PollAnsw__3214EC07043B631E");

            entity.ToTable("PollAnswer");
        });

        modelBuilder.Entity<PollVotingRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PollVoti__3214EC0777AEF7C0");

            entity.ToTable("PollVotingRecord");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC07257E3E59");

            entity.ToTable("Product");

            entity.HasIndex(e => e.Name, "in_Product_Name");

            entity.HasIndex(e => e.ProductCode, "in_Product_ProductCode");

            entity.HasIndex(e => e.ProductTypeId, "in_Product_ProductTypeId");

            entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);
            entity.Property(e => e.AvailableEndDateTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.AvailableStartDateTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Gtin).HasMaxLength(400);
            entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IsCustomUrl).HasColumnName("IsCustomURL");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MacAddRequired).HasColumnName("MacAdd_Required");
            entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);
            entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PreOrderAvailabilityStartDateTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);
            entity.Property(e => e.Sku).HasMaxLength(400);
            entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SpecialPriceEndDateTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.SpecialPriceStartDateTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.VideoUrl).HasColumnName("VideoURL");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ProductAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductA__3214EC07C71228F7");

            entity.ToTable("ProductAttribute");
        });

        modelBuilder.Entity<ProductCategoryMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product___3214EC07911E54E7");

            entity.ToTable("Product_Category_Mapping");
        });

        modelBuilder.Entity<ProductManufacturerMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product___3214EC0773D82060");

            entity.ToTable("Product_Manufacturer_Mapping");
        });

        modelBuilder.Entity<ProductPictureMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product___3214EC0750BC3C9D");

            entity.ToTable("Product_Picture_Mapping");
        });

        modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product___3214EC07E4EB6BF5");

            entity.ToTable("Product_ProductAttribute_Mapping");
        });

        modelBuilder.Entity<ProductProductTagMapping>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.ProductTagId }).HasName("PK__Product___F62CEB09E7837B7E");

            entity.ToTable("Product_ProductTag_Mapping");

            entity.Property(e => e.ProductId).HasColumnName("Product_Id");
            entity.Property(e => e.ProductTagId).HasColumnName("ProductTag_Id");
        });

        modelBuilder.Entity<ProductReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductR__3214EC0743D136E0");

            entity.ToTable("ProductReview");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductR__3214EC0701A0FC10");

            entity.ToTable("ProductReviewHelpfulness");
        });

        modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product___3214EC076ECD3891");

            entity.ToTable("Product_SpecificationAttribute_Mapping");

            entity.Property(e => e.CustomValue).HasMaxLength(4000);
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductT__3214EC07668B9516");

            entity.ToTable("ProductTag");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductT__3214EC07C32E0375");

            entity.ToTable("ProductTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductVariantAttributeCombination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductV__3214EC07928051E9");

            entity.ToTable("ProductVariantAttributeCombination");

            entity.Property(e => e.Gtin).HasMaxLength(400);
            entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);
            entity.Property(e => e.OverriddenPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sku).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductVariantAttributeValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductV__3214EC07DBC3F80E");

            entity.ToTable("ProductVariantAttributeValue");

            entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QueuedEmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QueuedEm__3214EC07C59BBB03");

            entity.ToTable("QueuedEmail");

            entity.Property(e => e.Bcc).HasMaxLength(500);
            entity.Property(e => e.Cc)
                .HasMaxLength(500)
                .HasColumnName("CC");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.From).HasMaxLength(500);
            entity.Property(e => e.FromName).HasMaxLength(500);
            entity.Property(e => e.ReplyTo).HasMaxLength(500);
            entity.Property(e => e.ReplyToName).HasMaxLength(500);
            entity.Property(e => e.SentOnUtc).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(1000);
            entity.Property(e => e.To).HasMaxLength(500);
            entity.Property(e => e.ToName).HasMaxLength(500);
        });

        modelBuilder.Entity<RecurringPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recurrin__3214EC073CF1BDE4");

            entity.ToTable("RecurringPayment");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.StartDateUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<RecurringPaymentHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recurrin__3214EC07CE44141C");

            entity.ToTable("RecurringPaymentHistory");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<RelatedProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RelatedP__3214EC07E4C45947");

            entity.ToTable("RelatedProduct");
        });

        modelBuilder.Entity<ReturnRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReturnRe__3214EC0752FBFA2E");

            entity.ToTable("ReturnRequest");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<RewardPointsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RewardPo__3214EC070B3D1FF1");

            entity.ToTable("RewardPointsHistory");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UsedWithOrderId).HasColumnName("UsedWithOrder_Id");
        });

        modelBuilder.Entity<ScheduleTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schedule__3214EC07CC55A2F4");

            entity.ToTable("ScheduleTask");

            entity.Property(e => e.LastEndUtc).HasColumnType("datetime");
            entity.Property(e => e.LastStartUtc).HasColumnType("datetime");
            entity.Property(e => e.LastSuccessUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<SearchTerm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SearchTe__3214EC07068CC808");

            entity.ToTable("SearchTerm");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Setting__3214EC078E897E2C");

            entity.ToTable("Setting");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Value).HasMaxLength(2000);
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shipment__3214EC071AFBE430");

            entity.ToTable("Shipment");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDateUtc).HasColumnType("datetime");
            entity.Property(e => e.ShippedDateUtc).HasColumnType("datetime");
            entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ShipmentItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shipment__3214EC07A8DE760F");

            entity.ToTable("ShipmentItem");
        });

        modelBuilder.Entity<ShippingByWeight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shipping__3214EC07F72856DA");

            entity.ToTable("ShippingByWeight");

            entity.Property(e => e.AdditionalFixedCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.From).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LowerWeightLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PercentageRateOfSubtotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RatePerWeightUnit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.To).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Zip).HasMaxLength(400);
        });

        modelBuilder.Entity<ShippingMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shipping__3214EC071E2E0A07");

            entity.ToTable("ShippingMethod");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ShippingMethodRestriction>(entity =>
        {
            entity.HasKey(e => new { e.ShippingMethodId, e.CountryId }).HasName("PK__Shipping__9CE6B8E16C82D34F");

            entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethod_Id");
            entity.Property(e => e.CountryId).HasColumnName("Country_Id");
        });

        modelBuilder.Entity<ShoppingCartItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shopping__3214EC0721E4F141");

            entity.ToTable("ShoppingCartItem");

            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<Smsconfig>(entity =>
        {
            entity.ToTable("SMSConfig");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GsmDeviceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("GSM_DeviceName");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UrlGlobalPk)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL_GlobalPk");
            entity.Property(e => e.UrlWebApi)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL_WebAPI");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpecificationAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Specific__3214EC077903D1FD");

            entity.ToTable("SpecificationAttribute");
        });

        modelBuilder.Entity<SpecificationAttributeOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Specific__3214EC07DF77A646");

            entity.ToTable("SpecificationAttributeOption");
        });

        modelBuilder.Entity<StateProvince>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatePro__3214EC07DCE7C8B3");

            entity.ToTable("StateProvince");

            entity.Property(e => e.Abbreviation).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Store__3214EC079A68BA4A");

            entity.ToTable("Store");

            entity.Property(e => e.CompanyAddress).HasMaxLength(1000);
            entity.Property(e => e.CompanyName).HasMaxLength(1000);
            entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);
            entity.Property(e => e.CompanyVat).HasMaxLength(1000);
            entity.Property(e => e.Hosts).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.SecureUrl).HasMaxLength(400);
            entity.Property(e => e.Url).HasMaxLength(400);
        });

        modelBuilder.Entity<StoreMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StoreMap__3214EC07768088CA");

            entity.ToTable("StoreMapping");

            entity.Property(e => e.EntityName).HasMaxLength(400);
        });

        modelBuilder.Entity<TaxCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxCateg__3214EC078475F6FF");

            entity.ToTable("TaxCategory");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<TaxRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaxRate__3214EC07BC483D90");

            entity.ToTable("TaxRate");

            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<TblAdvanceSalaryLoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblAdvanceSalary");

            entity.ToTable("tblAdvanceSalary_Loan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdvanceAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdvanceDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClearingDate).HasColumnType("datetime");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.PayRollId).HasColumnName("PayRollID");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReturnAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReturnDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SubmitProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VoucherProof)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAttendance>(entity =>
        {
            entity.ToTable("tblAttendance");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CheckIn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckOut)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Leave)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAttendanceParam>(entity =>
        {
            entity.ToTable("tblAttendanceParam");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllowLeaves)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LateValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OffTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OnTime)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBank>(entity =>
        {
            entity.ToTable("tblBank");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBankAccount>(entity =>
        {
            entity.ToTable("tblBankAccount");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountTitle)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BranchCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblBankLedger>(entity =>
        {
            entity.ToTable("tblBankLedger");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Type)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<TblBonu>(entity =>
        {
            entity.ToTable("tblBonus");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BonusMonth)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBonusDetail>(entity =>
        {
            entity.ToTable("tblBonusDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BonusAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BonusId).HasColumnName("BonusID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
        });

        modelBuilder.Entity<TblBranch>(entity =>
        {
            entity.ToTable("tblBranches");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBranchExpense>(entity =>
        {
            entity.ToTable("tblBranchExpenses");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");
        });

        modelBuilder.Entity<TblBranchInventoryRequest>(entity =>
        {
            entity.ToTable("tblBranchInventoryRequest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AvailableQty).HasDefaultValue(0);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.IssueDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IssueQty).HasDefaultValue(0);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RequestDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RequestQty).HasDefaultValue(0);
            entity.Property(e => e.RevertDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RevertQty).HasDefaultValue(0);
            entity.Property(e => e.Status).HasDefaultValue(1);
        });

        modelBuilder.Entity<TblBranchUserInfo>(entity =>
        {
            entity.ToTable("tblBranchUserInfo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BasicSalary)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConveyanceAllowance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EducationAllowance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.HouseRentAllowance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MedicalAllowance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MobileAllowance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblBudget>(entity =>
        {
            entity.ToTable("tblBudget");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCashPayment>(entity =>
        {
            entity.ToTable("tblCashPayment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCategory>(entity =>
        {
            entity.ToTable("tblCategories");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCity>(entity =>
        {
            entity.ToTable("tblCity");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<TblClearingAgent>(entity =>
        {
            entity.ToTable("tblClearingAgent");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblClearingAgentFreightForwarder>(entity =>
        {
            entity.ToTable("tblClearingAgent_FreightForwarder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblClearingAgentFreightForwarderInvoice>(entity =>
        {
            entity.ToTable("tblClearingAgent_FreightForwarderInvoice");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Number)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblClearingAgentFreightForwarderLedger>(entity =>
        {
            entity.ToTable("tblClearingAgent_FreightForwarderLedger");
        });

        modelBuilder.Entity<TblClearingAgentFreightForwarderPayment>(entity =>
        {
            entity.ToTable("tblClearingAgent_FreightForwarderPayment");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClearingDate).HasColumnType("datetime");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OtherAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.SubmitProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCompany>(entity =>
        {
            entity.ToTable("tblCompanies");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FaxNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FybeginingYear)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FYBeginingYear");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ntn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.Srtn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SRTN");
            entity.Property(e => e.TeleNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblCount__3214EC076AE54E82");

            entity.ToTable("tblCountry");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<TblCriticalValuesRecord>(entity =>
        {
            entity.ToTable("tblCriticalValuesRecord");

            entity.Property(e => e.CriticalDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCurrency>(entity =>
        {
            entity.ToTable("tblCurrency");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Symbol)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.ToTable("tblCustomers");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserRoleText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zipcode)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCustomerPayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK_tblPayments");

            entity.ToTable("tblCustomerPayments");

            entity.HasIndex(e => e.OrderId, "IX_tblCustomerPayments_OrderID");

            entity.HasIndex(e => new { e.OrderId, e.IsAdvancePayment, e.CustomerId }, "IX_tblCustomerPayments_OrderID_Advance_CustomerID");

            entity.HasIndex(e => e.BankAccountId, "tblCustomerPayments_BankAccountID");

            entity.HasIndex(e => e.CustomerId, "tblCustomerPayments_CustomerID");

            entity.HasIndex(e => e.OrderId, "tblCustomerPayments_OrderID");

            entity.HasIndex(e => e.PaymentId, "tblCustomerPayments_PaymentID");

            entity.HasIndex(e => new { e.OrderId, e.PaymentType }, "uq_tblcustomerpayments")
                .IsUnique()
                .HasFilter("([PaymentId]>(54366) AND [PaymentType]='Accept Order')");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.BankAccountId)
                .HasDefaultValue(0)
                .HasColumnName("BankAccountID");
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.ClearingDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasDefaultValue(0)
                .HasColumnName("CompanyID");
            entity.Property(e => e.ConfirmDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId)
                .HasDefaultValue(0)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsAdvancePayment)
                .HasDefaultValue(false)
                .HasColumnName("Is_Advance_Payment");
            entity.Property(e => e.IsDeduction)
                .HasDefaultValue(0)
                .HasColumnName("isDeduction");
            entity.Property(e => e.IsPartialPayment)
                .HasDefaultValue(false)
                .HasColumnName("Is_Partial_Payment");
            entity.Property(e => e.IsUpdated)
                .HasDefaultValue(0)
                .HasColumnName("isUpdated");
            entity.Property(e => e.OrderAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderId)
                .HasDefaultValue(0)
                .HasColumnName("OrderID");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentIdDeduction)
                .HasDefaultValue(0)
                .HasColumnName("PaymentID_Deduction");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RemainingBalance)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Remaining_Balance");
            entity.Property(e => e.SubmitDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCustomersBackup>(entity =>
        {
            entity.ToTable("tblCustomersBackup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserRoleText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zipcode)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCustomersNtn>(entity =>
        {
            entity.ToTable("tblCustomersNTN");

            entity.HasIndex(e => e.Id, "IDX_CustomersNTN_ID");

            entity.HasIndex(e => e.CustomerId, "in_CustomersNTN_CustomerID");

            entity.HasIndex(e => e.Type, "in_CustomersNTN_Type");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblDcSendTransferRecord>(entity =>
        {
            entity.ToTable("tblDC_SendTransferRecord");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DcRecieved)
                .HasDefaultValue(0)
                .HasColumnName("DC_Recieved");
            entity.Property(e => e.DcSent)
                .HasDefaultValue(0)
                .HasColumnName("DC_Sent");
            entity.Property(e => e.ProductId).HasDefaultValue(0);
            entity.Property(e => e.Quantity).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblDeliveryChalan>(entity =>
        {
            entity.ToTable("tblDeliveryChalan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchIdTo).HasColumnName("BranchID_To");
            entity.Property(e => e.CommentsApp)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CommentsReq)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDeliveryChalanDetail>(entity =>
        {
            entity.ToTable("tblDeliveryChalanDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
        });

        modelBuilder.Entity<TblDesignation>(entity =>
        {
            entity.ToTable("tblDesignation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblExpense>(entity =>
        {
            entity.ToTable("tblExpenses");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClearingDate).HasColumnType("datetime");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DailyMonthly)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Daily_Monthly");
            entity.Property(e => e.DailyMonthlyOther)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Daily_Monthly_Other");
            entity.Property(e => e.DailyMonthlyTypes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Daily_MonthlyTypes");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.OfficeWareHouse)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Office_WareHouse");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmitProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblExpensesMode>(entity =>
        {
            entity.ToTable("tblExpensesModes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mode)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ParentExpenseId).HasColumnName("ParentExpenseID");
            entity.Property(e => e.Types)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblFreightForwarder>(entity =>
        {
            entity.ToTable("tblFreightForwarder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblHoliday>(entity =>
        {
            entity.ToTable("tblHolidays");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateFrom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateTo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HolidayName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblIndustry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblIndustry");

            entity.ToTable("tblIndustries");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblInventoryHistory>(entity =>
        {
            entity.ToTable("tblInventoryHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AvailableGoodsClosing).HasDefaultValue(0L);
            entity.Property(e => e.AvailableGoodsClosingCosting)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AvailableGoodsOpening).HasDefaultValue(0L);
            entity.Property(e => e.AvailableGoodsOpeningCosting)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GeneratedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblInvoiceType>(entity =>
        {
            entity.ToTable("tblInvoiceTypes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DisplayTitle)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_login");

            entity.ToTable("tblLogin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<TblManufacturer>(entity =>
        {
            entity.ToTable("tblManufacturer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMissingItem>(entity =>
        {
            entity.ToTable("tblMissingItems");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<TblMoneyChanger>(entity =>
        {
            entity.ToTable("tblMoneyChanger");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMoneychangerLedger>(entity =>
        {
            entity.ToTable("tblMoneychangerLedger");
        });

        modelBuilder.Entity<TblMoneychangerPayment>(entity =>
        {
            entity.ToTable("tblMoneychangerPayment");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AmountDescriptionText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClearingDate).HasColumnType("datetime");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmountText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.SubmitProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity.ToTable("tblOrder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcceptedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Courier)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DueDays).HasDefaultValue(0);
            entity.Property(e => e.IncomeTax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTaxForNotImportedItems)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceSerial).HasDefaultValue(1);
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsDueDaysSmsSent)
                .HasDefaultValue(0)
                .HasColumnName("isDueDaysSmsSent");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NoteHeading)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NtnNo)
                .HasDefaultValue(0)
                .HasColumnName("NTN_No");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OtherAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmountDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProformaUid).HasColumnName("ProformaUID");
            entity.Property(e => e.ProformaUidsalesTax).HasColumnName("ProformaUIDSalesTax");
            entity.Property(e => e.SalesTax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalesTaxOneFifthDeduction)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SalesTax_OneFifth_Deduction");
            entity.Property(e => e.SrtnNo)
                .HasDefaultValue(0)
                .HasColumnName("SRTN_No");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.ValueAddedTax17per)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_17Per");
            entity.Property(e => e.ValueAddedTax1per)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_1Per");
        });

        modelBuilder.Entity<TblOrderDetail>(entity =>
        {
            entity.ToTable("tblOrderDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Price)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<TblOrderStatus>(entity =>
        {
            entity.ToTable("tblOrderStatus");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblOtherPayment>(entity =>
        {
            entity.ToTable("tblOtherPayments");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ClearingDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Comments)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CompanyId)
                .HasDefaultValue(0)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Credit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Debit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FromBankAccountId)
                .HasDefaultValue(0)
                .HasColumnName("FromBankAccountID");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.OtherPaymentId)
                .HasDefaultValue(0)
                .HasColumnName("OtherPaymentID");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PayrollNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Payroll_No");
            entity.Property(e => e.SubmitDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ToBankAccountId)
                .HasDefaultValue(0)
                .HasColumnName("ToBankAccountID");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TypeDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<TblPayRoll>(entity =>
        {
            entity.ToTable("tblPayRoll");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Advance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdvanceSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Date)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.GeneratedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsIncomeTaxPaid).HasColumnName("Is_IncomeTax_Paid");
            entity.Property(e => e.IsSalaryPaid).HasColumnName("Is_Salary_Paid");
            entity.Property(e => e.Loan).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LoanTaken).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherDeduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherDeductionDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaidSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PayrollNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Payroll_No");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TotalAllowances).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblPerforma>(entity =>
        {
            entity.ToTable("tblPerforma");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommissioningOfService)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CommissioningOfServiceTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EquipmentWarrantyTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ForceMajeure)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ForceMajeureTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GenderTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTitle1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTitle2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfDelivery)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfDeliveryTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfPaymentTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Para01)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Para02)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SubjectTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Taxes)
                .HasMaxLength(505)
                .IsUnicode(false);
            entity.Property(e => e.TaxesTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Validity)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ValidityTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblPerformaParam>(entity =>
        {
            entity.ToTable("tblPerformaParam");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommissioningOfService)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ForceMajeure)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTitle1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTitle2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Para01)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Para02)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Taxes)
                .HasMaxLength(505)
                .IsUnicode(false);
            entity.Property(e => e.Validity)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.ToTable("tblProducts");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MacAddRequired).HasColumnName("MacAdd_Required");
            entity.Property(e => e.MiniPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ProductCode)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblProductDetail>(entity =>
        {
            entity.ToTable("tblProductDetail");

            entity.HasIndex(e => e.Poid, "NonClusteredIndex-20170123-164349");

            entity.HasIndex(e => e.ProductId, "NonClusteredIndex-20170123-164404");

            entity.HasIndex(e => e.BranchId, "NonClusteredIndex-20170123-164416");

            entity.HasIndex(e => e.OrderId, "NonClusteredIndex-20170123-164427");

            entity.HasIndex(e => e.Replacement, "NonClusteredIndex-20170123-164437");

            entity.HasIndex(e => e.CreatedDate, "NonClusteredIndex-20170123-164506");

            entity.HasIndex(e => e.UpdatedDate, "NonClusteredIndex-20170123-164551");

            entity.HasIndex(e => e.InventoryReqId, "NonClusteredIndex-20170123-164602");

            entity.HasIndex(e => e.Dcid, "NonClusteredIndex-20170123-164617");

            entity.HasIndex(e => e.RevertId, "NonClusteredIndex-20170123-164643");

            entity.HasIndex(e => e.MissingItemsId, "NonClusteredIndex-20170123-164655");

            entity.HasIndex(e => e.MissingItems, "NonClusteredIndex-20170123-175107");

            entity.HasIndex(e => new { e.Poid, e.ProductId }, "NonClusteredIndex-20170317-152847-POID-ProductID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CostingPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Dcid)
                .HasDefaultValue(0)
                .HasColumnName("DCID");
            entity.Property(e => e.InventoryReqId)
                .HasDefaultValue(0)
                .HasColumnName("InventoryReqID");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MissingItems).HasDefaultValue(0);
            entity.Property(e => e.MissingItemsDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MissingItemsId)
                .HasDefaultValue(0)
                .HasColumnName("MissingItemsID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.ProductDetailIdReplaced)
                .HasDefaultValue(0)
                .HasColumnName("ProductDetailID_Replaced");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReplacePrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReplacedDeviceCreated)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceRecieved)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceSent)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Replacement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RevertId)
                .HasDefaultValue(0)
                .HasColumnName("RevertID");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.WarrantyModeId).HasColumnName("WarrantyModeID");
            entity.Property(e => e.WarrantyStartDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblProductsPrice>(entity =>
        {
            entity.HasKey(e => e.PriceId);

            entity.ToTable("tblProducts_Prices");

            entity.Property(e => e.PriceId).HasColumnName("PriceID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.MiniPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RetailPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblProductsPricing>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__tblProdu__B40CC6CD941C5D57");

            entity.ToTable("tblProductsPricing");

            entity.Property(e => e.Brand).HasMaxLength(100);
            entity.Property(e => e.BulkDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MinimumSalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.PromotionalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Website).IsUnicode(false);
        });

        modelBuilder.Entity<TblPurchaseOrder>(entity =>
        {
            entity.ToTable("tblPurchaseOrder");

            entity.Property(e => e.AddSalesTaxMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cessmaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CESSMaster");
            entity.Property(e => e.ClearingAgentCustomDuties)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClearingChargesMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomMiscMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DochargesMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DOChargesMaster");
            entity.Property(e => e.EtochargesMaster)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ETOChargesMaster");
            entity.Property(e => e.ExchangeRate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FreightChargesMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FreightForwarderAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTaxMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InsuranceChargesMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LandingChargesMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherChargesImportValueMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OtherCharges_ImportValueMaster");
            entity.Property(e => e.OtherChargesMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherChargesText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.OtherExpenses)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherText1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherText2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherText3)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherText4)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherVendorCharges1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherVendorCharges2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherVendorCharges3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherVendorChargesText1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherVendorChargesText2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherVendorChargesText3)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PenaltyChargesMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Podate)
                .HasColumnType("datetime")
                .HasColumnName("PODate");
            entity.Property(e => e.Poimage)
                .HasMaxLength(500)
                .HasColumnName("POImage");
            entity.Property(e => e.SalesTaxMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SupplierInvoiceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.WharfageMaster)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblPurchaseOrderDetail>(entity =>
        {
            entity.ToTable("tblPurchaseOrderDetail");

            entity.HasIndex(e => e.ProductId, "NonClusteredIndex-20170317-151831-ProductId");

            entity.HasIndex(e => e.Poid, "NonClusteredIndex-20170317-151852-POID");

            entity.HasIndex(e => new { e.Poid, e.ProductId }, "NonClusteredIndex-20170317-152821-POID-ProductId");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddSalesTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AddSalesTaxIsManual)
                .HasDefaultValue(0)
                .HasColumnName("AddSalesTax_IsManual");
            entity.Property(e => e.AddedQuantity).HasDefaultValue(0);
            entity.Property(e => e.CostingPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomDuties).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTaxIsManual)
                .HasDefaultValue(0)
                .HasColumnName("IncomeTax_IsManual");
            entity.Property(e => e.PerUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.Price)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SalesTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalesTaxIsManual)
                .HasDefaultValue(0)
                .HasColumnName("SalesTax_IsManual");
            entity.Property(e => e.UnitCostDollar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitCostPkr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UnitCostPKR");
            entity.Property(e => e.UnitCostPkrIsManual)
                .HasDefaultValue(0)
                .HasColumnName("UnitCostPKR_IsManual");
        });

        modelBuilder.Entity<TblReturnProduct>(entity =>
        {
            entity.ToTable("tblReturnProducts");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductDetailId).HasColumnName("ProductDetailID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReturnDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblRma>(entity =>
        {
            entity.ToTable("tblRMA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchComments).HasMaxLength(500);
            entity.Property(e => e.Charges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comments).HasMaxLength(500);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RepairedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSampleDetail>(entity =>
        {
            entity.ToTable("tblSampleDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SampleId).HasColumnName("SampleID");
        });

        modelBuilder.Entity<TblSampleMaster>(entity =>
        {
            entity.ToTable("tblSampleMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SampleDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSm>(entity =>
        {
            entity.ToTable("tblSMS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dated)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Delivered).HasDefaultValue(false);
            entity.Property(e => e.Message)
                .HasMaxLength(160)
                .IsUnicode(false);
            entity.Property(e => e.Number)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Retries).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblSmsgsm>(entity =>
        {
            entity.ToTable("tblSMSGSM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(0)
                .HasColumnName("isValid");
            entity.Property(e => e.OriginatingAddress)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Sctimestamp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SCTimestamp");
        });

        modelBuilder.Entity<TblTemplate>(entity =>
        {
            entity.ToTable("tblTemplates");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsEmail).HasColumnName("isEmail");
            entity.Property(e => e.IsReportEmail).HasColumnName("isReportEmail");
            entity.Property(e => e.IsReportSms).HasColumnName("isReportSms");
            entity.Property(e => e.IsSms).HasColumnName("isSms");
            entity.Property(e => e.SmsDomain)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Smstemplate)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SMSTemplate");
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<TblVendor>(entity =>
        {
            entity.ToTable("tblVendor");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblVendorLedger>(entity =>
        {
            entity.ToTable("tblVendorLedger");

            entity.Property(e => e.Poid).HasColumnName("POId");
        });

        modelBuilder.Entity<TblVendorPayment>(entity =>
        {
            entity.ToTable("tblVendorPayment");

            entity.Property(e => e.BankCharges)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");
            entity.Property(e => e.ConfirmationProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransferAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblWarrantyMode>(entity =>
        {
            entity.ToTable("tblWarrantyModes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TierPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TierPric__3214EC073FFA7668");

            entity.ToTable("TierPrice");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Topic__3214EC075D69E170");

            entity.ToTable("Topic");

            entity.Property(e => e.DisplayTitle)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UrlRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UrlRecor__3214EC07465EA4F9");

            entity.ToTable("UrlRecord");

            entity.Property(e => e.EntityName).HasMaxLength(400);
            entity.Property(e => e.Slug).HasMaxLength(400);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId).HasName("PK__UserRole__BCDA352F138B2FD4");

            entity.Property(e => e.UserRoleId).HasColumnName("UserRole_ID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.IsPage).HasColumnName("Is_Page");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserRolePage>(entity =>
        {
            entity.HasKey(e => e.UserRolePageId).HasName("PK__UserRole__483827409C87A51E");

            entity.ToTable("UserRole_Pages");

            entity.Property(e => e.UserRolePageId).HasColumnName("UserRole_Page_ID");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.IsAdmin).HasColumnName("Is_Admin");
            entity.Property(e => e.PageId).HasColumnName("Page_ID");
            entity.Property(e => e.UserRoleId).HasColumnName("UserRole_ID");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vendor__3214EC07B04B7E57");

            entity.ToTable("Vendor");

            entity.Property(e => e.Email).HasMaxLength(400);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
        });

        modelBuilder.Entity<ViewDcNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewDC_New");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchIdTo).HasColumnName("BranchID_To");
            entity.Property(e => e.CommentsApp)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CommentsReq)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewMonthWiseExpense>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewMonthWiseExpense");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DailyMonthly)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Daily_Monthly");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<ViewOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewOrder");

            entity.Property(e => e.AcceptedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Courier).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTaxForNotImportedItems).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsDueDaysSmsSent).HasColumnName("isDueDaysSmsSent");
            entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NoteHeading)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NtnNo).HasColumnName("NTN_No");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OriginalProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OtherAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmountDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaidDateUtc).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProformaUid).HasColumnName("ProformaUID");
            entity.Property(e => e.ProformaUidsalesTax).HasColumnName("ProformaUIDSalesTax");
            entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalesTaxOneFifthDeduction)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SalesTax_OneFifth_Deduction");
            entity.Property(e => e.SrtnNo).HasColumnName("SRTN_No");
            entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ValueAddedTax17per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_17Per");
            entity.Property(e => e.ValueAddedTax1per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_1Per");
        });

        modelBuilder.Entity<ViewOrderProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewOrderProduct");

            entity.Property(e => e.AcceptedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CostingPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Courier).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTaxForNotImportedItems).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InventoryReqId).HasColumnName("InventoryReqID");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsDueDaysSmsSent).HasColumnName("isDueDaysSmsSent");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MissingItemsDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MissingItemsId).HasColumnName("MissingItemsID");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NoteHeading)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NtnNo).HasColumnName("NTN_No");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OtherAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmountDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaidDateUtc).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.ProductDetailIdReplaced).HasColumnName("ProductDetailID_Replaced");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProformaUid).HasColumnName("ProformaUID");
            entity.Property(e => e.ProformaUidsalesTax).HasColumnName("ProformaUIDSalesTax");
            entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReplacePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReplacedDeviceCreated)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceRecieved)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceSent)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Replacement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RevertId).HasColumnName("RevertID");
            entity.Property(e => e.SalesTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalesTaxOneFifthDeduction)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SalesTax_OneFifth_Deduction");
            entity.Property(e => e.SrtnNo).HasColumnName("SRTN_No");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ValueAddedTax17per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_17Per");
            entity.Property(e => e.ValueAddedTax1per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_1Per");
            entity.Property(e => e.WarrantyModeId).HasColumnName("WarrantyModeID");
            entity.Property(e => e.WarrantyStartDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewOrderReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewOrderReturn");

            entity.Property(e => e.AcceptedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Courier).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTaxForNotImportedItems).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsDueDaysSmsSent).HasColumnName("isDueDaysSmsSent");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NoteHeading)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NtnNo).HasColumnName("NTN_No");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OtherAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmountDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaidDateUtc).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductDetailId).HasColumnName("ProductDetailID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProformaUid).HasColumnName("ProformaUID");
            entity.Property(e => e.ProformaUidsalesTax).HasColumnName("ProformaUIDSalesTax");
            entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReturnDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SalesTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalesTaxOneFifthDeduction)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SalesTax_OneFifth_Deduction");
            entity.Property(e => e.SrtnNo).HasColumnName("SRTN_No");
            entity.Property(e => e.ValueAddedTax17per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_17Per");
            entity.Property(e => e.ValueAddedTax1per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_1Per");
        });

        modelBuilder.Entity<VwAdvanceSalaryLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAdvanceSalary_Loan");

            entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdvanceDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClearingDate).HasColumnType("datetime");
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PayRollId).HasColumnName("PayRollID");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReturnDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SubmitProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VoucherProof)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBank");

            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<VwBankAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBankAccount");

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountNumberDisplay)
                .HasMaxLength(501)
                .IsUnicode(false);
            entity.Property(e => e.AccountTitle)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BranchCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VwBonu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBonus");

            entity.Property(e => e.BonusAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BonusMonth)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBranch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBranch");

            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BranchId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BranchID");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBranchInventoryRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBranchInventoryRequest");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<VwCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCategory");

            entity.Property(e => e.Category).HasMaxLength(400);
            entity.Property(e => e.Image).HasMaxLength(351);
            entity.Property(e => e.Manufacturer).HasMaxLength(400);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.PriceRanges).HasMaxLength(400);
            entity.Property(e => e.Slug).HasMaxLength(400);
        });

        modelBuilder.Entity<VwChartOfAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwChartOfAccount");

            entity.Property(e => e.AccountCode).HasMaxLength(150);
            entity.Property(e => e.AccountType).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.ParentAccountCode).HasMaxLength(100);
        });

        modelBuilder.Entity<VwClearingAgentFreightForwarderLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwClearingAgent_FreightForwarderLedger");

            entity.Property(e => e.Amount).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(232)
                .IsUnicode(false);
            entity.Property(e => e.Mode)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCompanies");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FaxNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FybeginingYear)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FYBeginingYear");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ids).HasColumnName("IDs");
            entity.Property(e => e.IdsInvoiceType)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("IDs_InvoiceType");
            entity.Property(e => e.InvoiceTypeCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ntn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NTN");
            entity.Property(e => e.Srtn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SRTN");
            entity.Property(e => e.TeleNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCountryCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCountryCity");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
        });

        modelBuilder.Entity<VwCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomers");

            entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasMaxLength(4000);
            entity.Property(e => e.CreatedDateFull).HasColumnType("datetime");
            entity.Property(e => e.CreatedDateTime).HasMaxLength(4000);
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DesignationView)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(1000);
            entity.Property(e => e.InvoiceTypeCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.Province).HasMaxLength(500);
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserRoleText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwCustomerLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomer_Ledger");

            entity.Property(e => e.BankName).HasMaxLength(616);
            entity.Property(e => e.BankNameOld)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.ClearingDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ConfirmDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Courier).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(27)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTypeCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.OrderAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OtherAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType).HasMaxLength(93);
            entity.Property(e => e.PaymentTypeOrignal)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCustomerPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomerPayments");

            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankNameOld)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.ClearingDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ConfirmDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.EmailAddress).HasMaxLength(1000);
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTypeCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsAdvancePayment).HasColumnName("Is_Advance_Payment");
            entity.Property(e => e.IsPartialPayment).HasColumnName("Is_Partial_Payment");
            entity.Property(e => e.OrderAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.PaymentIdDeduction).HasColumnName("PaymentID_Deduction");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RemainingBalance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Remaining_Balance");
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalOrderAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalPaidAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Username).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwCustomers2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomers2");

            entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasMaxLength(4000);
            entity.Property(e => e.CreatedDateFull).HasColumnType("datetime");
            entity.Property(e => e.CreatedDateTime).HasMaxLength(4000);
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DesignationView)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(1000);
            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            entity.Property(e => e.IndustryName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTypeCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IshortName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("IShortName");
            entity.Property(e => e.Province).HasMaxLength(500);
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserRoleText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwDc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDC");

            entity.Property(e => e.BranchIdrecieved).HasColumnName("BranchIDRecieved");
            entity.Property(e => e.BranchIdtransfered).HasColumnName("BranchIDTransfered");
            entity.Property(e => e.BranchRecieved)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchTransfered)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CommentsApp)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CommentsReq)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductName).HasMaxLength(400);
            entity.Property(e => e.ShortNameRecieved)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ShortNameTransfered)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDcsummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDCSummary");

            entity.Property(e => e.Branch)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.ProductName).HasMaxLength(400);
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwExpense>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwExpenses");

            entity.Property(e => e.AccountTitle)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClearingDate).HasColumnType("datetime");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DailyMonthly)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Daily_Monthly");
            entity.Property(e => e.DailyMonthlyOther)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Daily_Monthly_Other");
            entity.Property(e => e.DailyMonthlyTypesOld)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Daily_MonthlyTypesOld");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Date2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OfficeWareHouse)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Office_WareHouse");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmitProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.Types)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TypesView)
                .HasMaxLength(505)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwIndustry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwIndustry");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TeleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwInventoryHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInventoryHistory");

            entity.Property(e => e.AvailableGoodsClosingCosting).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AvailableGoodsOpeningCosting).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwManufacturer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwManufacturer");

            entity.Property(e => e.Image).HasMaxLength(351);
            entity.Property(e => e.Manufacturer).HasMaxLength(400);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.PriceRanges).HasMaxLength(400);
            entity.Property(e => e.Slug).HasMaxLength(400);
        });

        modelBuilder.Entity<VwManufacturerCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwManufacturer_Category");

            entity.Property(e => e.Category).HasMaxLength(400);
            entity.Property(e => e.EntityName).HasMaxLength(400);
            entity.Property(e => e.Image).HasMaxLength(351);
            entity.Property(e => e.Manufacturer).HasMaxLength(400);
            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.PriceRanges).HasMaxLength(400);
            entity.Property(e => e.Slug).HasMaxLength(400);
        });

        modelBuilder.Entity<VwMissingItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMissingItems");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(351);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(400);
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMoneyChangerLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMoneyChangerLedger");

            entity.Property(e => e.BankCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ConfirmationProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.Mode)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.MoneyChanger)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SubmitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SubmitProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Symbol)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransferAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vendor)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrder");

            entity.Property(e => e.AcceptedDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AcceptedDate1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AcceptedDate3)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BillingMonth).HasMaxLength(100);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Courier).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(1000);
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.IncomeTaxForNotImportedItems).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(27)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTypeCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsDueDaysSmsSent).HasColumnName("isDueDaysSmsSent");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NoteHeading)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NtnNo).HasColumnName("NTN_No");
            entity.Property(e => e.OrderCreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate3)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OtherAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherAmountDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProformaUid).HasColumnName("ProformaUID");
            entity.Property(e => e.ProformaUidsalesTax).HasColumnName("ProformaUIDSalesTax");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseOrderImageRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseOrderRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReturnFileImgRef).HasMaxLength(150);
            entity.Property(e => e.ReturnFileMonth).HasMaxLength(100);
            entity.Property(e => e.SalesTax).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.SalesTaxOneFifthDeduction)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SalesTax_OneFifth_Deduction");
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SignedDeliveryNoteImageRef)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SrtnNo).HasColumnName("SRTN_No");
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SystemGeneratedInoviceNo)
                .HasMaxLength(50)
                .HasColumnName("System_Generated_Inovice_No");
            entity.Property(e => e.ValueAddedTax17per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_17Per");
            entity.Property(e => e.ValueAddedTax1per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValueAddedTax_1Per");
        });

        modelBuilder.Entity<VwOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrderDetail");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<VwOtherPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOtherPayments");

            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.BankCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClearingDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FromBankAccount)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FromBankAccountId).HasColumnName("FromBankAccountID");
            entity.Property(e => e.FromBankAccountTitle)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FromBankId).HasColumnName("FromBankID");
            entity.Property(e => e.FromBankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OtherPaymentId).HasColumnName("OtherPaymentID");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ToBankAccount)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ToBankAccountId).HasColumnName("ToBankAccountID");
            entity.Property(e => e.ToBankAccountTitle)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ToBankId).HasColumnName("ToBankID");
            entity.Property(e => e.ToBankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TypeView)
                .HasMaxLength(153)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPayRoll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPayRoll");

            entity.Property(e => e.ActualSalary).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.Advance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.GeneratedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsIncomeTaxPaid).HasColumnName("Is_IncomeTax_Paid");
            entity.Property(e => e.Loan).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherDeduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherDeductionDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaidSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PayrollNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Payroll_No");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProducts");

            entity.Property(e => e.Category).HasMaxLength(400);
            entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Image).HasMaxLength(351);
            entity.Property(e => e.IsCustomUrl).HasColumnName("IsCustomURL");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MacAddRequired).HasColumnName("MacAdd_Required");
            entity.Property(e => e.MacAddRequired2).HasColumnName("MacAdd_Required2");
            entity.Property(e => e.Manufacturer).HasMaxLength(400);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductCategoryMappingId).HasColumnName("Product_Category_MappingId");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductName).HasMaxLength(400);
            entity.Property(e => e.Slug).HasMaxLength(400);
            entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SpecialPriceEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.SpecialPriceStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.VideoUrl).HasColumnName("VideoURL");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VwProductDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProductDetail");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchNameShort)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CostingPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InventoryReqId).HasColumnName("InventoryReqID");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Manufacturer).HasMaxLength(400);
            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.ProductDetailIdReplaced).HasColumnName("ProductDetailID_Replaced");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(400);
            entity.Property(e => e.ReplacedDeviceCreated)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceRecieved)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceSent)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Replacement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RevertId).HasColumnName("RevertID");
            entity.Property(e => e.WarrantyModeId).HasColumnName("WarrantyModeID");
            entity.Property(e => e.WarrantyStartDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwProductDetailAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProductDetailAll");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CostingPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InventoryReqId).HasColumnName("InventoryReqID");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("PONumber");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(400);
            entity.Property(e => e.ReplacedDeviceCreated)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceRecieved)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceSent)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedDeviceStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Replacement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RevertId).HasColumnName("RevertID");
            entity.Property(e => e.WarrantyModeId).HasColumnName("WarrantyModeID");
        });

        modelBuilder.Entity<VwProductPicture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProductPictures");

            entity.Property(e => e.Image).HasMaxLength(351);
            entity.Property(e => e.MimeType).HasMaxLength(40);
            entity.Property(e => e.SeoFilename).HasMaxLength(300);
        });

        modelBuilder.Entity<VwProductSaleDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProductSaleDetail");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchNameShort)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CostingPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(27)
                .IsUnicode(false);
            entity.Property(e => e.Manufacturer).HasMaxLength(400);
            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrignalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(400);
            entity.Property(e => e.Profit).HasColumnType("decimal(19, 2)");
        });

        modelBuilder.Entity<VwProductTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProductTags");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ProductTagId).HasColumnName("ProductTag_Id");
        });

        modelBuilder.Entity<VwPurchaseOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPurchaseOrder");

            entity.Property(e => e.AddSalesTaxMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cessmaster)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CESSMaster");
            entity.Property(e => e.ClearingChargesMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomMiscMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DochargesMaster)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DOChargesMaster");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FreightChargesMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncomeTaxMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InsuranceChargesMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LandingChargesMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherChargesImportValueMaster)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OtherCharges_ImportValueMaster");
            entity.Property(e => e.OtherChargesMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherChargesText)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherVendorCharges1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherVendorCharges2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherVendorCharges3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherVendorChargesText1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherVendorChargesText2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherVendorChargesText3)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtherVendorChargesTotal).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.PenaltyChargesMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Poamount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("POAmount");
            entity.Property(e => e.Podate)
                .HasColumnType("datetime")
                .HasColumnName("PODate");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.Poimage)
                .HasMaxLength(500)
                .HasColumnName("POImage");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("PONumber");
            entity.Property(e => e.SalesTaxMaster).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SupplierInvoiceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Vendor)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VendorId).HasColumnName("VendorID");
            entity.Property(e => e.WharfageMaster).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VwReplacedItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwReplacedItems");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchNameShort)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductDetailIdReplaced).HasColumnName("ProductDetailID_Replaced");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReplacePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Replaced).HasMaxLength(400);
            entity.Property(e => e.ReplacedMacAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedWith).HasMaxLength(400);
            entity.Property(e => e.ReplacedWithMacAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ReplacedWithProductId).HasColumnName("ReplacedWithProductID");
            entity.Property(e => e.ReplacedWithReplacement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Replacement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Username).HasMaxLength(1000);
        });

        modelBuilder.Entity<VwReturnProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwReturnProducts");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(400);
        });

        modelBuilder.Entity<VwSampleItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSampleItems");

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(351);
            entity.Property(e => e.MacAddRequired).HasColumnName("MacAdd_Required");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductIdString)
                .HasMaxLength(553)
                .HasColumnName("ProductID_String");
            entity.Property(e => e.ProductName).HasMaxLength(400);
            entity.Property(e => e.ReturnDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SampleDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SampleId).HasColumnName("SampleID");
            entity.Property(e => e.ShortName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSMS");

            entity.Property(e => e.Api).HasColumnName("API");
            entity.Property(e => e.Gsm).HasColumnName("GSM");
            entity.Property(e => e.GsmDeviceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("GSM_DeviceName");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Message)
                .HasMaxLength(160)
                .IsUnicode(false);
            entity.Property(e => e.Number)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UrlGlobalPk)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL_GlobalPk");
            entity.Property(e => e.UrlWebApi)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL_WebAPI");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSmsconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSMSConfig");

            entity.Property(e => e.Api).HasColumnName("API");
            entity.Property(e => e.Gsm).HasColumnName("GSM");
            entity.Property(e => e.GsmDeviceName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("GSM_DeviceName");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UrlGlobalPk)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL_GlobalPk");
            entity.Property(e => e.UrlWebApi)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL_WebAPI");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTestOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTestOrder");

            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.ClearingDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfirmDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Count1).HasColumnName("count1");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceUid).HasColumnName("InvoiceUID");
            entity.Property(e => e.IsDeduction).HasColumnName("isDeduction");
            entity.Property(e => e.IsUpdated).HasColumnName("isUpdated");
            entity.Property(e => e.OrderAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PaymentID");
            entity.Property(e => e.PaymentIdDeduction).HasColumnName("PaymentID_Deduction");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwVendorLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwVendorLedger");

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ConfirmationProof)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Expr1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Mode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModeFull)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.MoneyChanger)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Poamount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("POAmount");
            entity.Property(e => e.Poimage)
                .HasMaxLength(500)
                .HasColumnName("POImage");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("PONumber");
            entity.Property(e => e.PovendorId).HasColumnName("POVendorId");
            entity.Property(e => e.SupplierInvoiceNo)
                .HasMaxLength(119)
                .IsUnicode(false);
            entity.Property(e => e.TransferAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransferAmountDollar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vendor)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Warehous__3214EC0788CF43E2");

            entity.ToTable("Warehouse");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
