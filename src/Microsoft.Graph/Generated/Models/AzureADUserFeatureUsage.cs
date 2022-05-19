using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the getAzureADUserFeatureUsage method.</summary>
    public class AzureADUserFeatureUsage : Entity, IParsable {
        /// <summary>The featureUsageDetails property</summary>
        public List<FeatureUsageDetail> FeatureUsageDetails {
            get { return BackingStore?.Get<List<FeatureUsageDetail>>(nameof(FeatureUsageDetails)); }
            set { BackingStore?.Set(nameof(FeatureUsageDetails), value); }
        }
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdatedDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdatedDateTime), value); }
        }
        /// <summary>The licenseAssigned property</summary>
        public AzureADLicenseType? LicenseAssigned {
            get { return BackingStore?.Get<AzureADLicenseType?>(nameof(LicenseAssigned)); }
            set { BackingStore?.Set(nameof(LicenseAssigned), value); }
        }
        /// <summary>The licenseRecommended property</summary>
        public AzureADLicenseType? LicenseRecommended {
            get { return BackingStore?.Get<AzureADLicenseType?>(nameof(LicenseRecommended)); }
            set { BackingStore?.Set(nameof(LicenseRecommended), value); }
        }
        /// <summary>The userDisplayName property</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
        }
        /// <summary>The userId property</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"featureUsageDetails", n => { FeatureUsageDetails = n.GetCollectionOfObjectValues<FeatureUsageDetail>(FeatureUsageDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"licenseAssigned", n => { LicenseAssigned = n.GetEnumValue<AzureADLicenseType>(); } },
                {"licenseRecommended", n => { LicenseRecommended = n.GetEnumValue<AzureADLicenseType>(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
