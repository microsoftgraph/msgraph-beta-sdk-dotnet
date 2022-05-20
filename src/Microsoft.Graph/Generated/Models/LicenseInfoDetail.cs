using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class LicenseInfoDetail : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The licenseType property</summary>
        public AzureADLicenseType? LicenseType {
            get { return BackingStore?.Get<AzureADLicenseType?>(nameof(LicenseType)); }
            set { BackingStore?.Set(nameof(LicenseType), value); }
        }
        /// <summary>The totalAssignedCount property</summary>
        public int? TotalAssignedCount {
            get { return BackingStore?.Get<int?>(nameof(TotalAssignedCount)); }
            set { BackingStore?.Set(nameof(TotalAssignedCount), value); }
        }
        /// <summary>The totalLicenseCount property</summary>
        public int? TotalLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(TotalLicenseCount)); }
            set { BackingStore?.Set(nameof(TotalLicenseCount), value); }
        }
        /// <summary>The totalUsageCount property</summary>
        public int? TotalUsageCount {
            get { return BackingStore?.Get<int?>(nameof(TotalUsageCount)); }
            set { BackingStore?.Set(nameof(TotalUsageCount), value); }
        }
        /// <summary>
        /// Instantiates a new licenseInfoDetail and sets the default values.
        /// </summary>
        public LicenseInfoDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LicenseInfoDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LicenseInfoDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"licenseType", n => { LicenseType = n.GetEnumValue<AzureADLicenseType>(); } },
                {"totalAssignedCount", n => { TotalAssignedCount = n.GetIntValue(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"totalUsageCount", n => { TotalUsageCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AzureADLicenseType>("licenseType", LicenseType);
            writer.WriteIntValue("totalAssignedCount", TotalAssignedCount);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("totalUsageCount", TotalUsageCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
