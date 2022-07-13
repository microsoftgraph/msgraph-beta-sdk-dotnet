using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class FeatureUsageDetail : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The featureName property</summary>
        public string FeatureName {
            get { return BackingStore?.Get<string>("featureName"); }
            set { BackingStore?.Set("featureName", value); }
        }
        /// <summary>The lastConfiguredDateTime property</summary>
        public DateTimeOffset? LastConfiguredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastConfiguredDateTime"); }
            set { BackingStore?.Set("lastConfiguredDateTime", value); }
        }
        /// <summary>The lastUsedDateTime property</summary>
        public DateTimeOffset? LastUsedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUsedDateTime"); }
            set { BackingStore?.Set("lastUsedDateTime", value); }
        }
        /// <summary>The licenseAssigned property</summary>
        public AzureADLicenseType? LicenseAssigned {
            get { return BackingStore?.Get<AzureADLicenseType?>("licenseAssigned"); }
            set { BackingStore?.Set("licenseAssigned", value); }
        }
        /// <summary>The licenseRequired property</summary>
        public AzureADLicenseType? LicenseRequired {
            get { return BackingStore?.Get<AzureADLicenseType?>("licenseRequired"); }
            set { BackingStore?.Set("licenseRequired", value); }
        }
        /// <summary>
        /// Instantiates a new featureUsageDetail and sets the default values.
        /// </summary>
        public FeatureUsageDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static FeatureUsageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FeatureUsageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"featureName", n => { FeatureName = n.GetStringValue(); } },
                {"lastConfiguredDateTime", n => { LastConfiguredDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUsedDateTime", n => { LastUsedDateTime = n.GetDateTimeOffsetValue(); } },
                {"licenseAssigned", n => { LicenseAssigned = n.GetEnumValue<AzureADLicenseType>(); } },
                {"licenseRequired", n => { LicenseRequired = n.GetEnumValue<AzureADLicenseType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("featureName", FeatureName);
            writer.WriteDateTimeOffsetValue("lastConfiguredDateTime", LastConfiguredDateTime);
            writer.WriteDateTimeOffsetValue("lastUsedDateTime", LastUsedDateTime);
            writer.WriteEnumValue<AzureADLicenseType>("licenseAssigned", LicenseAssigned);
            writer.WriteEnumValue<AzureADLicenseType>("licenseRequired", LicenseRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
