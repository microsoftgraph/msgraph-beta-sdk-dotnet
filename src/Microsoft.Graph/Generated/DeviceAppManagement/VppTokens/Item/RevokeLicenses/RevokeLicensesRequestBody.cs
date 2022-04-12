using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceAppManagement.VppTokens.Item.RevokeLicenses {
    /// <summary>Provides operations to call the revokeLicenses method.</summary>
    public class RevokeLicensesRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The notifyManagedDevices property</summary>
        public bool? NotifyManagedDevices { get; set; }
        /// <summary>The revokeUntrackedLicenses property</summary>
        public bool? RevokeUntrackedLicenses { get; set; }
        /// <summary>
        /// Instantiates a new revokeLicensesRequestBody and sets the default values.
        /// </summary>
        public RevokeLicensesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RevokeLicensesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RevokeLicensesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"notifyManagedDevices", n => { NotifyManagedDevices = n.GetBoolValue(); } },
                {"revokeUntrackedLicenses", n => { RevokeUntrackedLicenses = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("notifyManagedDevices", NotifyManagedDevices);
            writer.WriteBoolValue("revokeUntrackedLicenses", RevokeUntrackedLicenses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
