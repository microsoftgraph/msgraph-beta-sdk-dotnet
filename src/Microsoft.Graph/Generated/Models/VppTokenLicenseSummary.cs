using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>License summary of a given app in a token.</summary>
    public class VppTokenLicenseSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The Apple Id associated with the given Apple Volume Purchase Program Token.</summary>
        public string AppleId {
            get { return BackingStore?.Get<string>(nameof(AppleId)); }
            set { BackingStore?.Set(nameof(AppleId), value); }
        }
        /// <summary>The number of VPP licenses available.</summary>
        public int? AvailableLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(AvailableLicenseCount)); }
            set { BackingStore?.Set(nameof(AvailableLicenseCount), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The organization associated with the Apple Volume Purchase Program Token.</summary>
        public string OrganizationName {
            get { return BackingStore?.Get<string>(nameof(OrganizationName)); }
            set { BackingStore?.Set(nameof(OrganizationName), value); }
        }
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(UsedLicenseCount)); }
            set { BackingStore?.Set(nameof(UsedLicenseCount), value); }
        }
        /// <summary>Identifier of the VPP token.</summary>
        public string VppTokenId {
            get { return BackingStore?.Get<string>(nameof(VppTokenId)); }
            set { BackingStore?.Set(nameof(VppTokenId), value); }
        }
        /// <summary>
        /// Instantiates a new vppTokenLicenseSummary and sets the default values.
        /// </summary>
        public VppTokenLicenseSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VppTokenLicenseSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppTokenLicenseSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"availableLicenseCount", n => { AvailableLicenseCount = n.GetIntValue(); } },
                {"organizationName", n => { OrganizationName = n.GetStringValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppTokenId", n => { VppTokenId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteIntValue("availableLicenseCount", AvailableLicenseCount);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteStringValue("vppTokenId", VppTokenId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
