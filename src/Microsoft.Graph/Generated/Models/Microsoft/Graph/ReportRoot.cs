using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public class ReportRoot : Entity, IParsable {
        /// <summary>Represents a detailed summary of an application sign-in.</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.ApplicationSignInDetailedSummary> ApplicationSignInDetailedSummary { get; set; }
        /// <summary>Container for navigation properties for Azure AD authentication methods resources.</summary>
        public AuthenticationMethodsRoot AuthenticationMethods { get; set; }
        /// <summary>Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.CredentialUserRegistrationDetails> CredentialUserRegistrationDetails { get; set; }
        public List<PrintUsageByPrinter> DailyPrintUsageByPrinter { get; set; }
        public List<PrintUsageByUser> DailyPrintUsageByUser { get; set; }
        public List<PrintUsageByPrinter> DailyPrintUsageSummariesByPrinter { get; set; }
        public List<PrintUsageByUser> DailyPrintUsageSummariesByUser { get; set; }
        public List<PrintUsageByPrinter> MonthlyPrintUsageByPrinter { get; set; }
        public List<PrintUsageByUser> MonthlyPrintUsageByUser { get; set; }
        public List<PrintUsageByPrinter> MonthlyPrintUsageSummariesByPrinter { get; set; }
        public List<PrintUsageByUser> MonthlyPrintUsageSummariesByUser { get; set; }
        /// <summary>Represents the self-service password reset (SSPR) usage for a given tenant.</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.UserCredentialUsageDetails> UserCredentialUsageDetails { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ReportRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReportRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationSignInDetailedSummary", (o,n) => { (o as ReportRoot).ApplicationSignInDetailedSummary = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.ApplicationSignInDetailedSummary>(MicrosoftGraphSdk.Models.Microsoft.Graph.ApplicationSignInDetailedSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationMethods", (o,n) => { (o as ReportRoot).AuthenticationMethods = n.GetObjectValue<AuthenticationMethodsRoot>(AuthenticationMethodsRoot.CreateFromDiscriminatorValue); } },
                {"credentialUserRegistrationDetails", (o,n) => { (o as ReportRoot).CredentialUserRegistrationDetails = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.CredentialUserRegistrationDetails>(MicrosoftGraphSdk.Models.Microsoft.Graph.CredentialUserRegistrationDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).DailyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageByUser", (o,n) => { (o as ReportRoot).DailyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageSummariesByPrinter", (o,n) => { (o as ReportRoot).DailyPrintUsageSummariesByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageSummariesByUser", (o,n) => { (o as ReportRoot).DailyPrintUsageSummariesByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageByUser", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageSummariesByPrinter", (o,n) => { (o as ReportRoot).MonthlyPrintUsageSummariesByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageSummariesByUser", (o,n) => { (o as ReportRoot).MonthlyPrintUsageSummariesByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"userCredentialUsageDetails", (o,n) => { (o as ReportRoot).UserCredentialUsageDetails = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.UserCredentialUsageDetails>(MicrosoftGraphSdk.Models.Microsoft.Graph.UserCredentialUsageDetails.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.ApplicationSignInDetailedSummary>("applicationSignInDetailedSummary", ApplicationSignInDetailedSummary);
            writer.WriteObjectValue<AuthenticationMethodsRoot>("authenticationMethods", AuthenticationMethods);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.CredentialUserRegistrationDetails>("credentialUserRegistrationDetails", CredentialUserRegistrationDetails);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageByPrinter", DailyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageByUser", DailyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageSummariesByPrinter", DailyPrintUsageSummariesByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageSummariesByUser", DailyPrintUsageSummariesByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageByPrinter", MonthlyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageByUser", MonthlyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageSummariesByPrinter", MonthlyPrintUsageSummariesByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageSummariesByUser", MonthlyPrintUsageSummariesByUser);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.UserCredentialUsageDetails>("userCredentialUsageDetails", UserCredentialUsageDetails);
        }
    }
}
