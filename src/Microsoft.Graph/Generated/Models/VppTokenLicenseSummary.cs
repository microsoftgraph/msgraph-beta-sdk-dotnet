using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>License summary of a given app in a token.</summary>
    public class VppTokenLicenseSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Apple Id associated with the given Apple Volume Purchase Program Token.</summary>
        public string AppleId { get; set; }
        /// <summary>The number of VPP licenses available.</summary>
        public int? AvailableLicenseCount { get; set; }
        /// <summary>The organization associated with the Apple Volume Purchase Program Token.</summary>
        public string OrganizationName { get; set; }
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount { get; set; }
        /// <summary>Identifier of the VPP token.</summary>
        public string VppTokenId { get; set; }
        /// <summary>
        /// Instantiates a new vppTokenLicenseSummary and sets the default values.
        /// </summary>
        public VppTokenLicenseSummary() {
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
