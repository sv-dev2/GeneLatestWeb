
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Generic;


namespace Insurance.Domain
{
    // ############################################################################
    // #
    // #        ---==>  T H I S  F I L E  W A S  G E N E R A T E D  <==---
    // #
    // # This file was generated by PRO Spark, C# Edition, Version 4.5
    // # Generated on 10/11/2016 9:10:49 AM
    // #
    // # Edits to this file may cause incorrect behavior and will be lost
    // # if the code is regenerated.
    // #
    // ############################################################################

    // Insurance Context. hosts all repositories

    public static class InsuranceContext
    {
        static Db db = new InsuranceDb();
        public static SystemUsers SystemUsers { get { return new SystemUsers(); } }
        public static ReceiptAndPayments ReceiptAndPayments { get { return new ReceiptAndPayments(); } }

        // entity specific repositories
        public static string ConnectionString { get { return db.connectionString; } }
        public static Currencies Currencies { get { return new Currencies(); } }
        public static AgentCommissions AgentCommissions { get { return new AgentCommissions(); } }
        public static BusinessSources BusinessSources { get { return new BusinessSources(); } }
        public static CoverTypes CoverTypes { get { return new CoverTypes(); } }
        public static Customers Customers { get { return new Customers(); } }
        public static LicenseDeliveries LicenseDeliveries { get { return new LicenseDeliveries(); } }
        public static LoyaltyDetails LoyaltyDetails { get { return new LoyaltyDetails(); } }
        public static PaymentMethods PaymentMethods { get { return new PaymentMethods(); } }
        public static PaymentTerms PaymentTerms { get { return new PaymentTerms(); } }
        public static PolicyDetails PolicyDetails { get { return new PolicyDetails(); } }
        public static PolicyStatuses PolicyStatuses { get { return new PolicyStatuses(); } }
        public static SummaryDetails SummaryDetails { get { return new SummaryDetails(); } }
        public static VehicleDetails VehicleDetails { get { return new VehicleDetails(); } }
        public static VehicleMakes VehicleMakes { get { return new VehicleMakes(); } }
        public static VehicleModels VehicleModels { get { return new VehicleModels(); } }
        public static BasicExcesses BasicExcesses { get { return new BasicExcesses(); } }
        public static AgeExcesses AgeExcesses { get { return new AgeExcesses(); } }
        public static SpecificExcesses SpecificExcesses { get { return new SpecificExcesses(); } }

        public static ReceiptModuleHistorys ReceiptHistorys { get { return new ReceiptModuleHistorys(); } }

        public static QRCodes QRCodes { get { return new QRCodes(); } }
        public static Reinsurances Reinsurances { get { return new Reinsurances(); } }
        public static ReinsuranceBrokers ReinsuranceBrokers { get { return new ReinsuranceBrokers(); } }
        public static ReinsuranceTransactions ReinsuranceTransactions { get { return new ReinsuranceTransactions(); } }
        public static ReinsurerDetails ReinsurerDetails { get { return new ReinsurerDetails(); } }
        public static Products Products { get { return new Products(); } }
        public static PolicyInsurers PolicyInsurers { get { return new PolicyInsurers(); } }
        public static VehicleCoverTypes VehicleCoverTypes { get { return new VehicleCoverTypes(); } }
        public static VehicleUsages VehicleUsages { get { return new VehicleUsages(); } }
        public static SmsLogs SmsLogs { get { return new SmsLogs(); } }
        public static Settings Settings { get { return new Settings(); } }
        public static PaymentInformations PaymentInformations { get { return new PaymentInformations(); } }
        public static UserManagementViews UserManagementViews { get { return new UserManagementViews(); } }
        public static SummaryVehicleDetails SummaryVehicleDetails { get { return new SummaryVehicleDetails(); } }
        public static LicenceTickets LicenceTickets { get { return new LicenceTickets(); } }
        public static PolicyDocuments PolicyDocuments { get { return new PolicyDocuments(); } }
        public static PolicyRenewReminderSettings PolicyRenewReminderSettings { get { return new PolicyRenewReminderSettings(); } }
        public static ReminderFaileds ReminderFaileds { get { return new ReminderFaileds(); } }
        public static LicenceDiskDeliveryAddresses LicenceDiskDeliveryAddresses { get { return new LicenceDiskDeliveryAddresses(); } }
       public static UniqueCustomers UniqueCustomers { get { return new UniqueCustomers(); } }
       public static BirthdayMessages BirthdayMessages { get { return new BirthdayMessages(); } }

        public static Cities Cities  { get { return new Cities(); } }
        public static EndorsementVehicleDetails EndorsementVehicleDetails { get { return new EndorsementVehicleDetails(); } }
        public static EndorsementSummaryDetails EndorsementSummaryDetails { get { return new EndorsementSummaryDetails(); } }
        public static EndorsementSummaryVehicleDetails EndorsementSummaryVehicleDetails { get { return new EndorsementSummaryVehicleDetails(); } }

        public static EndorsementCustomers EndorsementCustomers { get { return new EndorsementCustomers(); } }
        public static EndorsementPolicyDetails EndorsementPolicyDetails { get { return new EndorsementPolicyDetails(); } }
        public static EndorsementPaymentInformations EndorsementPaymentInformations { get { return new EndorsementPaymentInformations(); } }
        //Second Phase Work

        public static ClaimNotifications ClaimNotifications { get { return new ClaimNotifications(); } }
        public static ServiceProviders ServiceProviders { get { return new ServiceProviders(); } }
        public static ServiceProviderTypes ServiceProviderTypes { get { return new ServiceProviderTypes(); } }
        public static ClaimRegistrations ClaimRegistrations { get { return new ClaimRegistrations(); } }

        public static ClaimAdjustments ClaimAdjustments { get { return new ClaimAdjustments(); } }
        public static ClaimDocuments ClaimDocuments { get { return new ClaimDocuments(); } }
        public static ClaimStatuss ClaimStatuss { get { return new ClaimStatuss(); } }
        public static Checklists Checklists { get { return new Checklists(); } }
        public static ClaimDetailsProviders ClaimDetailsProviders { get { return new ClaimDetailsProviders(); } }
        public static ClaimSettings ClaimSettings { get { return new ClaimSettings(); } }

        public static SourceDetails SourceDetails { get { return new SourceDetails(); } }
        public static AspNetUsersUpdates AspNetUsersUpdates { get { return new AspNetUsersUpdates(); } }

        //public static VehicleLicenses VehicleLicenses { get { return new VehicleLicenses(); } }

        //public static RiskCoverItems RiskCoverItems { get { return new RiskCoverItems(); } }


        public static RegistrationDocuments RegistrationDocuments { get { return new RegistrationDocuments(); } }
        public static ClaimRegistrationProviderDetials ClaimRegistrationProviderDetials { get { return new ClaimRegistrationProviderDetials(); } }

        public static ServiceProviderPaymentHistories ServiceProviderPaymentHistories { get { return new ServiceProviderPaymentHistories(); } }

        public static UniqeTransactions UniqeTransactions { get { return new UniqeTransactions(); } }


        public static VehicleTaxClasses VehicleTaxClasses { get { return new VehicleTaxClasses(); } }

        public static Branches Branches { get { return new Branches(); } }

        public static MachineBranches MachineBranches { get { return new MachineBranches(); } }

        public static AgentLogos AgentLogos { get { return new AgentLogos(); } }

        public static RefundPolicies RefundPolicies { get { return new RefundPolicies(); } }

        public static BannerImages BannerImages { get { return new BannerImages(); } }

        public static TokenRequests TokenRequests { get { return new TokenRequests(); } }

        public static PartialPayments PartialPayments { get { return new PartialPayments(); } }

        public static LogDetailTbls LogDetailTbls { get { return new LogDetailTbls(); } }

        public static Domestic_Products Domestic_Products { get { return new Domestic_Products(); } }

        public static Domestic_RiskCovers Domestic_RiskCovers { get { return new Domestic_RiskCovers(); } }

        public static Domestic_RiskItems Domestic_RiskItems { get { return new Domestic_RiskItems(); } }

        public static Domestic_Vehicles Domestic_Vehicles { get { return new Domestic_Vehicles(); } }

        public static DomesticSummaryDetails DomesticSummaryDetails { get { return new DomesticSummaryDetails(); } }

        public static DomesticVehicleSummaries DomesticVehicleSummaries { get { return new DomesticVehicleSummaries(); } }

        public static DomesticPayments DomesticPayments { get { return new DomesticPayments(); } }

        public static InflationFactors InflationFactors { get { return new InflationFactors(); } }

        public static CertSerialNoDetails CertSerialNoDetails { get { return new CertSerialNoDetails(); } }

        public static WorkTypes WorkTypes { get { return new WorkTypes(); } }

        public static AccountPolices AccountPolices { get { return new AccountPolices(); } }

        public static Partners Partners { get { return new Partners(); } }

        public static PartnerCommissions PartnerCommissions { get { return new PartnerCommissions(); } }

        public static CommissionPeriods CommissionPeriods { get { return new CommissionPeriods(); } }

        public static PosInitializations PosInitializations { get { return new PosInitializations(); } }

        public static USDConverters USDConverters { get { return new USDConverters(); } }

        public static ALMRePrints ALMRePrints { get { return new ALMRePrints(); } }

        //17/03/2020
        public static AspNetUsersDetails AspNetUsersDetails { get { return new AspNetUsersDetails(); } }

        public static UniquePolicyNumbers UniquePolicyNumbers { get { return new UniquePolicyNumbers(); } }

        
        // DomesticPayments
        // general purpose operations

        public static void Execute(string sql, params object[] parms) { db.Execute(sql, parms); }
        public static IEnumerable<dynamic> Query(string sql, params object[] parms) { return db.Query(sql, parms); }
        public static object Scalar(string sql, params object[] parms) { return db.Scalar(sql, parms); }

        public static DataSet GetDataSet(string sql, params object[] parms) { return db.GetDataSet(sql, parms); }
        public static DataTable GetDataTable(string sql, params object[] parms) { return db.GetDataTable(sql, parms); }
        public static DataRow GetDataRow(string sql, params object[] parms) { return db.GetDataRow(sql, parms); }
       

    }
}