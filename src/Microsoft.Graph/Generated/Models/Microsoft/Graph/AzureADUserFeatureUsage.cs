using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AzureADUserFeatureUsage : Entity, IParsable {
        public List<FeatureUsageDetail> FeatureUsageDetails { get; set; }
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        public AzureADLicenseType? LicenseAssigned { get; set; }
        public AzureADLicenseType? LicenseRecommended { get; set; }
        public string UserDisplayName { get; set; }
        public string UserId { get; set; }
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AzureADUserFeatureUsage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureADUserFeatureUsage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"featureUsageDetails", (o,n) => { (o as AzureADUserFeatureUsage).FeatureUsageDetails = n.GetCollectionOfObjectValues<FeatureUsageDetail>(FeatureUsageDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as AzureADUserFeatureUsage).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"licenseAssigned", (o,n) => { (o as AzureADUserFeatureUsage).LicenseAssigned = n.GetEnumValue<AzureADLicenseType>(); } },
                {"licenseRecommended", (o,n) => { (o as AzureADUserFeatureUsage).LicenseRecommended = n.GetEnumValue<AzureADLicenseType>(); } },
                {"userDisplayName", (o,n) => { (o as AzureADUserFeatureUsage).UserDisplayName = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as AzureADUserFeatureUsage).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as AzureADUserFeatureUsage).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<FeatureUsageDetail>("featureUsageDetails", FeatureUsageDetails);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteEnumValue<AzureADLicenseType>("licenseAssigned", LicenseAssigned);
            writer.WriteEnumValue<AzureADLicenseType>("licenseRecommended", LicenseRecommended);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
