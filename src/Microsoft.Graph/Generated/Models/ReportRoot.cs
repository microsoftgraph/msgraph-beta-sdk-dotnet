using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the reportRoot singleton.</summary>
    public class ReportRoot : Entity, IParsable {
        /// <summary>Represents a detailed summary of an application sign-in.</summary>
        public List<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary> ApplicationSignInDetailedSummary {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary>>(nameof(ApplicationSignInDetailedSummary)); }
            set { BackingStore?.Set(nameof(ApplicationSignInDetailedSummary), value); }
        }
        /// <summary>Container for navigation properties for Azure AD authentication methods resources.</summary>
        public AuthenticationMethodsRoot AuthenticationMethods {
            get { return BackingStore?.Get<AuthenticationMethodsRoot>(nameof(AuthenticationMethods)); }
            set { BackingStore?.Set(nameof(AuthenticationMethods), value); }
        }
        /// <summary>Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.</summary>
        public List<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails> CredentialUserRegistrationDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails>>(nameof(CredentialUserRegistrationDetails)); }
            set { BackingStore?.Set(nameof(CredentialUserRegistrationDetails), value); }
        }
        /// <summary>The dailyPrintUsageByPrinter property</summary>
        public List<PrintUsageByPrinter> DailyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>(nameof(DailyPrintUsageByPrinter)); }
            set { BackingStore?.Set(nameof(DailyPrintUsageByPrinter), value); }
        }
        /// <summary>The dailyPrintUsageByUser property</summary>
        public List<PrintUsageByUser> DailyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>(nameof(DailyPrintUsageByUser)); }
            set { BackingStore?.Set(nameof(DailyPrintUsageByUser), value); }
        }
        /// <summary>The dailyPrintUsageSummariesByPrinter property</summary>
        public List<PrintUsageByPrinter> DailyPrintUsageSummariesByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>(nameof(DailyPrintUsageSummariesByPrinter)); }
            set { BackingStore?.Set(nameof(DailyPrintUsageSummariesByPrinter), value); }
        }
        /// <summary>The dailyPrintUsageSummariesByUser property</summary>
        public List<PrintUsageByUser> DailyPrintUsageSummariesByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>(nameof(DailyPrintUsageSummariesByUser)); }
            set { BackingStore?.Set(nameof(DailyPrintUsageSummariesByUser), value); }
        }
        /// <summary>The monthlyPrintUsageByPrinter property</summary>
        public List<PrintUsageByPrinter> MonthlyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>(nameof(MonthlyPrintUsageByPrinter)); }
            set { BackingStore?.Set(nameof(MonthlyPrintUsageByPrinter), value); }
        }
        /// <summary>The monthlyPrintUsageByUser property</summary>
        public List<PrintUsageByUser> MonthlyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>(nameof(MonthlyPrintUsageByUser)); }
            set { BackingStore?.Set(nameof(MonthlyPrintUsageByUser), value); }
        }
        /// <summary>The monthlyPrintUsageSummariesByPrinter property</summary>
        public List<PrintUsageByPrinter> MonthlyPrintUsageSummariesByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>(nameof(MonthlyPrintUsageSummariesByPrinter)); }
            set { BackingStore?.Set(nameof(MonthlyPrintUsageSummariesByPrinter), value); }
        }
        /// <summary>The monthlyPrintUsageSummariesByUser property</summary>
        public List<PrintUsageByUser> MonthlyPrintUsageSummariesByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>(nameof(MonthlyPrintUsageSummariesByUser)); }
            set { BackingStore?.Set(nameof(MonthlyPrintUsageSummariesByUser), value); }
        }
        /// <summary>Represents the self-service password reset (SSPR) usage for a given tenant.</summary>
        public List<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails> UserCredentialUsageDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails>>(nameof(UserCredentialUsageDetails)); }
            set { BackingStore?.Set(nameof(UserCredentialUsageDetails), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationSignInDetailedSummary", n => { ApplicationSignInDetailedSummary = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary>(Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationMethods", n => { AuthenticationMethods = n.GetObjectValue<AuthenticationMethodsRoot>(AuthenticationMethodsRoot.CreateFromDiscriminatorValue); } },
                {"credentialUserRegistrationDetails", n => { CredentialUserRegistrationDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails>(Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageByPrinter", n => { DailyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageByUser", n => { DailyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageSummariesByPrinter", n => { DailyPrintUsageSummariesByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageSummariesByUser", n => { DailyPrintUsageSummariesByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageByPrinter", n => { MonthlyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageByUser", n => { MonthlyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageSummariesByPrinter", n => { MonthlyPrintUsageSummariesByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageSummariesByUser", n => { MonthlyPrintUsageSummariesByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"userCredentialUsageDetails", n => { UserCredentialUsageDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails>(Microsoft.Graph.Beta.Models.UserCredentialUsageDetails.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary>("applicationSignInDetailedSummary", ApplicationSignInDetailedSummary);
            writer.WriteObjectValue<AuthenticationMethodsRoot>("authenticationMethods", AuthenticationMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CredentialUserRegistrationDetails>("credentialUserRegistrationDetails", CredentialUserRegistrationDetails);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageByPrinter", DailyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageByUser", DailyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageSummariesByPrinter", DailyPrintUsageSummariesByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageSummariesByUser", DailyPrintUsageSummariesByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageByPrinter", MonthlyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageByUser", MonthlyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageSummariesByPrinter", MonthlyPrintUsageSummariesByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageSummariesByUser", MonthlyPrintUsageSummariesByUser);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserCredentialUsageDetails>("userCredentialUsageDetails", UserCredentialUsageDetails);
        }
    }
}
