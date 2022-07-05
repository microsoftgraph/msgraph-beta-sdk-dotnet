using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class CloudAppSecurityProfile : Entity, IParsable {
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>(nameof(AzureSubscriptionId)); }
            set { BackingStore?.Set(nameof(AzureSubscriptionId), value); }
        }
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId {
            get { return BackingStore?.Get<string>(nameof(AzureTenantId)); }
            set { BackingStore?.Set(nameof(AzureTenantId), value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The deploymentPackageUrl property</summary>
        public string DeploymentPackageUrl {
            get { return BackingStore?.Get<string>(nameof(DeploymentPackageUrl)); }
            set { BackingStore?.Set(nameof(DeploymentPackageUrl), value); }
        }
        /// <summary>The destinationServiceName property</summary>
        public string DestinationServiceName {
            get { return BackingStore?.Get<string>(nameof(DestinationServiceName)); }
            set { BackingStore?.Set(nameof(DestinationServiceName), value); }
        }
        /// <summary>The isSigned property</summary>
        public bool? IsSigned {
            get { return BackingStore?.Get<bool?>(nameof(IsSigned)); }
            set { BackingStore?.Set(nameof(IsSigned), value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The manifest property</summary>
        public string Manifest {
            get { return BackingStore?.Get<string>(nameof(Manifest)); }
            set { BackingStore?.Set(nameof(Manifest), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The permissionsRequired property</summary>
        public ApplicationPermissionsRequired? PermissionsRequired {
            get { return BackingStore?.Get<ApplicationPermissionsRequired?>(nameof(PermissionsRequired)); }
            set { BackingStore?.Set(nameof(PermissionsRequired), value); }
        }
        /// <summary>The platform property</summary>
        public string Platform {
            get { return BackingStore?.Get<string>(nameof(Platform)); }
            set { BackingStore?.Set(nameof(Platform), value); }
        }
        /// <summary>The policyName property</summary>
        public string PolicyName {
            get { return BackingStore?.Get<string>(nameof(PolicyName)); }
            set { BackingStore?.Set(nameof(PolicyName), value); }
        }
        /// <summary>The publisher property</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>(nameof(Publisher)); }
            set { BackingStore?.Set(nameof(Publisher), value); }
        }
        /// <summary>The riskScore property</summary>
        public string RiskScore {
            get { return BackingStore?.Get<string>(nameof(RiskScore)); }
            set { BackingStore?.Set(nameof(RiskScore), value); }
        }
        /// <summary>The tags property</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>The type property</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
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
        public static new CloudAppSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudAppSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentPackageUrl", n => { DeploymentPackageUrl = n.GetStringValue(); } },
                {"destinationServiceName", n => { DestinationServiceName = n.GetStringValue(); } },
                {"isSigned", n => { IsSigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"manifest", n => { Manifest = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"permissionsRequired", n => { PermissionsRequired = n.GetEnumValue<ApplicationPermissionsRequired>(); } },
                {"platform", n => { Platform = n.GetStringValue(); } },
                {"policyName", n => { PolicyName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"type", n => { Type = n.GetStringValue(); } },
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
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deploymentPackageUrl", DeploymentPackageUrl);
            writer.WriteStringValue("destinationServiceName", DestinationServiceName);
            writer.WriteBoolValue("isSigned", IsSigned);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("manifest", Manifest);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<ApplicationPermissionsRequired>("permissionsRequired", PermissionsRequired);
            writer.WriteStringValue("platform", Platform);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("type", Type);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
