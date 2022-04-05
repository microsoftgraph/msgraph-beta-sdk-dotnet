using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudAppSecurityProfile : Entity, IParsable {
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId { get; set; }
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId { get; set; }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The deploymentPackageUrl property</summary>
        public string DeploymentPackageUrl { get; set; }
        /// <summary>The destinationServiceName property</summary>
        public string DestinationServiceName { get; set; }
        /// <summary>The isSigned property</summary>
        public bool? IsSigned { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The manifest property</summary>
        public string Manifest { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The permissionsRequired property</summary>
        public ApplicationPermissionsRequired? PermissionsRequired { get; set; }
        /// <summary>The platform property</summary>
        public string Platform { get; set; }
        /// <summary>The policyName property</summary>
        public string PolicyName { get; set; }
        /// <summary>The publisher property</summary>
        public string Publisher { get; set; }
        /// <summary>The riskScore property</summary>
        public string RiskScore { get; set; }
        /// <summary>The tags property</summary>
        public List<string> Tags { get; set; }
        /// <summary>The type property</summary>
        public string Type { get; set; }
        /// <summary>The vendorInformation property</summary>
        public SecurityVendorInformation VendorInformation { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"azureSubscriptionId", (o,n) => { (o as CloudAppSecurityProfile).AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as CloudAppSecurityProfile).AzureTenantId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as CloudAppSecurityProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentPackageUrl", (o,n) => { (o as CloudAppSecurityProfile).DeploymentPackageUrl = n.GetStringValue(); } },
                {"destinationServiceName", (o,n) => { (o as CloudAppSecurityProfile).DestinationServiceName = n.GetStringValue(); } },
                {"isSigned", (o,n) => { (o as CloudAppSecurityProfile).IsSigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as CloudAppSecurityProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"manifest", (o,n) => { (o as CloudAppSecurityProfile).Manifest = n.GetStringValue(); } },
                {"name", (o,n) => { (o as CloudAppSecurityProfile).Name = n.GetStringValue(); } },
                {"permissionsRequired", (o,n) => { (o as CloudAppSecurityProfile).PermissionsRequired = n.GetEnumValue<ApplicationPermissionsRequired>(); } },
                {"platform", (o,n) => { (o as CloudAppSecurityProfile).Platform = n.GetStringValue(); } },
                {"policyName", (o,n) => { (o as CloudAppSecurityProfile).PolicyName = n.GetStringValue(); } },
                {"publisher", (o,n) => { (o as CloudAppSecurityProfile).Publisher = n.GetStringValue(); } },
                {"riskScore", (o,n) => { (o as CloudAppSecurityProfile).RiskScore = n.GetStringValue(); } },
                {"tags", (o,n) => { (o as CloudAppSecurityProfile).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"type", (o,n) => { (o as CloudAppSecurityProfile).Type = n.GetStringValue(); } },
                {"vendorInformation", (o,n) => { (o as CloudAppSecurityProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
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
