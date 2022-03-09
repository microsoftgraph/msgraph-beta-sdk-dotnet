using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getLicensesForApp method.</summary>
    public class VppTokenLicenseSummary : IParsable, IAdditionalDataHolder {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appleId", (o,n) => { (o as VppTokenLicenseSummary).AppleId = n.GetStringValue(); } },
                {"availableLicenseCount", (o,n) => { (o as VppTokenLicenseSummary).AvailableLicenseCount = n.GetIntValue(); } },
                {"organizationName", (o,n) => { (o as VppTokenLicenseSummary).OrganizationName = n.GetStringValue(); } },
                {"usedLicenseCount", (o,n) => { (o as VppTokenLicenseSummary).UsedLicenseCount = n.GetIntValue(); } },
                {"vppTokenId", (o,n) => { (o as VppTokenLicenseSummary).VppTokenId = n.GetStringValue(); } },
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
