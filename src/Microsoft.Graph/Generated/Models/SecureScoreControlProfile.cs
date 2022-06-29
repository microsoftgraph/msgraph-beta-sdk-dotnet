using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class SecureScoreControlProfile : Entity, IParsable {
        /// <summary>Control action type (Config, Review, Behavior).</summary>
        public string ActionType {
            get { return BackingStore?.Get<string>(nameof(ActionType)); }
            set { BackingStore?.Set(nameof(ActionType), value); }
        }
        /// <summary>URL to where the control can be actioned.</summary>
        public string ActionUrl {
            get { return BackingStore?.Get<string>(nameof(ActionUrl)); }
            set { BackingStore?.Set(nameof(ActionUrl), value); }
        }
        /// <summary>GUID string for tenant ID.</summary>
        public string AzureTenantId {
            get { return BackingStore?.Get<string>(nameof(AzureTenantId)); }
            set { BackingStore?.Set(nameof(AzureTenantId), value); }
        }
        /// <summary>The collection of compliance information associated with secure score control</summary>
        public List<Microsoft.Graph.Beta.Models.ComplianceInformation> ComplianceInformation {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ComplianceInformation>>(nameof(ComplianceInformation)); }
            set { BackingStore?.Set(nameof(ComplianceInformation), value); }
        }
        /// <summary>Control action category (Account, Data, Device, Apps, Infrastructure).</summary>
        public string ControlCategory {
            get { return BackingStore?.Get<string>(nameof(ControlCategory)); }
            set { BackingStore?.Set(nameof(ControlCategory), value); }
        }
        /// <summary>Flag to indicate where the tenant has marked a control (ignore, thirdParty, reviewed) (supports update).</summary>
        public List<SecureScoreControlStateUpdate> ControlStateUpdates {
            get { return BackingStore?.Get<List<SecureScoreControlStateUpdate>>(nameof(ControlStateUpdates)); }
            set { BackingStore?.Set(nameof(ControlStateUpdates), value); }
        }
        /// <summary>Flag to indicate if a control is depreciated.</summary>
        public bool? Deprecated {
            get { return BackingStore?.Get<bool?>(nameof(Deprecated)); }
            set { BackingStore?.Set(nameof(Deprecated), value); }
        }
        /// <summary>Resource cost of implemmentating control (low, moderate, high).</summary>
        public string ImplementationCost {
            get { return BackingStore?.Get<string>(nameof(ImplementationCost)); }
            set { BackingStore?.Set(nameof(ImplementationCost), value); }
        }
        /// <summary>Time at which the control profile entity was last modified. The Timestamp type represents date and time</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Current obtained max score on specified date.</summary>
        public double? MaxScore {
            get { return BackingStore?.Get<double?>(nameof(MaxScore)); }
            set { BackingStore?.Set(nameof(MaxScore), value); }
        }
        /// <summary>Microsoft&apos;s stack ranking of control.</summary>
        public int? Rank {
            get { return BackingStore?.Get<int?>(nameof(Rank)); }
            set { BackingStore?.Set(nameof(Rank), value); }
        }
        /// <summary>Description of what the control will help remediate.</summary>
        public string Remediation {
            get { return BackingStore?.Get<string>(nameof(Remediation)); }
            set { BackingStore?.Set(nameof(Remediation), value); }
        }
        /// <summary>Description of the impact on users of the remediation.</summary>
        public string RemediationImpact {
            get { return BackingStore?.Get<string>(nameof(RemediationImpact)); }
            set { BackingStore?.Set(nameof(RemediationImpact), value); }
        }
        /// <summary>Service that owns the control (Exchange, Sharepoint, Azure AD).</summary>
        public string Service {
            get { return BackingStore?.Get<string>(nameof(Service)); }
            set { BackingStore?.Set(nameof(Service), value); }
        }
        /// <summary>List of threats the control mitigates (accountBreach,dataDeletion,dataExfiltration,dataSpillage,elevationOfPrivilege,maliciousInsider,passwordCracking,phishingOrWhaling,spoofing).</summary>
        public List<string> Threats {
            get { return BackingStore?.Get<List<string>>(nameof(Threats)); }
            set { BackingStore?.Set(nameof(Threats), value); }
        }
        /// <summary>Control tier (Core, Defense in Depth, Advanced.)</summary>
        public string Tier {
            get { return BackingStore?.Get<string>(nameof(Tier)); }
            set { BackingStore?.Set(nameof(Tier), value); }
        }
        /// <summary>Title of the control.</summary>
        public string Title {
            get { return BackingStore?.Get<string>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
        }
        /// <summary>User impact of implementing control (low, moderate, high).</summary>
        public string UserImpact {
            get { return BackingStore?.Get<string>(nameof(UserImpact)); }
            set { BackingStore?.Set(nameof(UserImpact), value); }
        }
        /// <summary>The vendorInformation property</summary>
        public SecurityVendorInformation VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation>(nameof(VendorInformation)); }
            set { BackingStore?.Set(nameof(VendorInformation), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SecureScoreControlProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecureScoreControlProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionType", n => { ActionType = n.GetStringValue(); } },
                {"actionUrl", n => { ActionUrl = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"complianceInformation", n => { ComplianceInformation = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ComplianceInformation>(Microsoft.Graph.Beta.Models.ComplianceInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"controlCategory", n => { ControlCategory = n.GetStringValue(); } },
                {"controlStateUpdates", n => { ControlStateUpdates = n.GetCollectionOfObjectValues<SecureScoreControlStateUpdate>(SecureScoreControlStateUpdate.CreateFromDiscriminatorValue).ToList(); } },
                {"deprecated", n => { Deprecated = n.GetBoolValue(); } },
                {"implementationCost", n => { ImplementationCost = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"maxScore", n => { MaxScore = n.GetDoubleValue(); } },
                {"rank", n => { Rank = n.GetIntValue(); } },
                {"remediation", n => { Remediation = n.GetStringValue(); } },
                {"remediationImpact", n => { RemediationImpact = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"threats", n => { Threats = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tier", n => { Tier = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"userImpact", n => { UserImpact = n.GetStringValue(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionType", ActionType);
            writer.WriteStringValue("actionUrl", ActionUrl);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ComplianceInformation>("complianceInformation", ComplianceInformation);
            writer.WriteStringValue("controlCategory", ControlCategory);
            writer.WriteCollectionOfObjectValues<SecureScoreControlStateUpdate>("controlStateUpdates", ControlStateUpdates);
            writer.WriteBoolValue("deprecated", Deprecated);
            writer.WriteStringValue("implementationCost", ImplementationCost);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDoubleValue("maxScore", MaxScore);
            writer.WriteIntValue("rank", Rank);
            writer.WriteStringValue("remediation", Remediation);
            writer.WriteStringValue("remediationImpact", RemediationImpact);
            writer.WriteStringValue("service", Service);
            writer.WriteCollectionOfPrimitiveValues<string>("threats", Threats);
            writer.WriteStringValue("tier", Tier);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("userImpact", UserImpact);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
