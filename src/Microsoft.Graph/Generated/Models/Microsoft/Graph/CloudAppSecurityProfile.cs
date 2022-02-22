using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CloudAppSecurityProfile : Entity, IParsable {
        public string AzureSubscriptionId { get; set; }
        public string AzureTenantId { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string DeploymentPackageUrl { get; set; }
        public string DestinationServiceName { get; set; }
        public bool? IsSigned { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Manifest { get; set; }
        public string Name { get; set; }
        public ApplicationPermissionsRequired? PermissionsRequired { get; set; }
        public string Platform { get; set; }
        public string PolicyName { get; set; }
        public string Publisher { get; set; }
        public string RiskScore { get; set; }
        public List<string> Tags { get; set; }
        public string Type { get; set; }
        public SecurityVendorInformation VendorInformation { get; set; }
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
                {"vendorInformation", (o,n) => { (o as CloudAppSecurityProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(); } },
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
