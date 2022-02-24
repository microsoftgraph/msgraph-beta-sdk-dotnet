using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ReportRoot : Entity, IParsable {
        /// <summary>Represents a detailed summary of an application sign-in.</summary>
        public List<ApplicationSignInDetailedSummary> ApplicationSignInDetailedSummary { get; set; }
        /// <summary>Container for navigation properties for Azure AD authentication methods resources.</summary>
        public AuthenticationMethodsRoot AuthenticationMethods { get; set; }
        /// <summary>Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.</summary>
        public List<CredentialUserRegistrationDetails> CredentialUserRegistrationDetails { get; set; }
        public List<PrintUsageByPrinter> DailyPrintUsageByPrinter { get; set; }
        public List<PrintUsageByUser> DailyPrintUsageByUser { get; set; }
        public List<PrintUsageByPrinter> DailyPrintUsageSummariesByPrinter { get; set; }
        public List<PrintUsageByUser> DailyPrintUsageSummariesByUser { get; set; }
        public List<PrintUsageByPrinter> MonthlyPrintUsageByPrinter { get; set; }
        public List<PrintUsageByUser> MonthlyPrintUsageByUser { get; set; }
        public List<PrintUsageByPrinter> MonthlyPrintUsageSummariesByPrinter { get; set; }
        public List<PrintUsageByUser> MonthlyPrintUsageSummariesByUser { get; set; }
        /// <summary>Represents the self-service password reset (SSPR) usage for a given tenant.</summary>
        public List<UserCredentialUsageDetails> UserCredentialUsageDetails { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationSignInDetailedSummary", (o,n) => { (o as ReportRoot).ApplicationSignInDetailedSummary = n.GetCollectionOfObjectValues<ApplicationSignInDetailedSummary>().ToList(); } },
                {"authenticationMethods", (o,n) => { (o as ReportRoot).AuthenticationMethods = n.GetObjectValue<AuthenticationMethodsRoot>(); } },
                {"credentialUserRegistrationDetails", (o,n) => { (o as ReportRoot).CredentialUserRegistrationDetails = n.GetCollectionOfObjectValues<CredentialUserRegistrationDetails>().ToList(); } },
                {"dailyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).DailyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>().ToList(); } },
                {"dailyPrintUsageByUser", (o,n) => { (o as ReportRoot).DailyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>().ToList(); } },
                {"dailyPrintUsageSummariesByPrinter", (o,n) => { (o as ReportRoot).DailyPrintUsageSummariesByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>().ToList(); } },
                {"dailyPrintUsageSummariesByUser", (o,n) => { (o as ReportRoot).DailyPrintUsageSummariesByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>().ToList(); } },
                {"monthlyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>().ToList(); } },
                {"monthlyPrintUsageByUser", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>().ToList(); } },
                {"monthlyPrintUsageSummariesByPrinter", (o,n) => { (o as ReportRoot).MonthlyPrintUsageSummariesByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>().ToList(); } },
                {"monthlyPrintUsageSummariesByUser", (o,n) => { (o as ReportRoot).MonthlyPrintUsageSummariesByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>().ToList(); } },
                {"userCredentialUsageDetails", (o,n) => { (o as ReportRoot).UserCredentialUsageDetails = n.GetCollectionOfObjectValues<UserCredentialUsageDetails>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApplicationSignInDetailedSummary>("applicationSignInDetailedSummary", ApplicationSignInDetailedSummary);
            writer.WriteObjectValue<AuthenticationMethodsRoot>("authenticationMethods", AuthenticationMethods);
            writer.WriteCollectionOfObjectValues<CredentialUserRegistrationDetails>("credentialUserRegistrationDetails", CredentialUserRegistrationDetails);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageByPrinter", DailyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageByUser", DailyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageSummariesByPrinter", DailyPrintUsageSummariesByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageSummariesByUser", DailyPrintUsageSummariesByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageByPrinter", MonthlyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageByUser", MonthlyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageSummariesByPrinter", MonthlyPrintUsageSummariesByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageSummariesByUser", MonthlyPrintUsageSummariesByUser);
            writer.WriteCollectionOfObjectValues<UserCredentialUsageDetails>("userCredentialUsageDetails", UserCredentialUsageDetails);
        }
    }
}
