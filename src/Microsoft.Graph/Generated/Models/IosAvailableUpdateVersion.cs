using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>iOS available update version details</summary>
    public class IosAvailableUpdateVersion : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expiration date of the update.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The posting date of the update.</summary>
        public DateTimeOffset? PostingDateTime { get; set; }
        /// <summary>The version of the update.</summary>
        public string ProductVersion { get; set; }
        /// <summary>List of supported devices for the update.</summary>
        public List<string> SupportedDevices { get; set; }
        /// <summary>
        /// Instantiates a new iosAvailableUpdateVersion and sets the default values.
        /// </summary>
        public IosAvailableUpdateVersion() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosAvailableUpdateVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosAvailableUpdateVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expirationDateTime", (o,n) => { (o as IosAvailableUpdateVersion).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"postingDateTime", (o,n) => { (o as IosAvailableUpdateVersion).PostingDateTime = n.GetDateTimeOffsetValue(); } },
                {"productVersion", (o,n) => { (o as IosAvailableUpdateVersion).ProductVersion = n.GetStringValue(); } },
                {"supportedDevices", (o,n) => { (o as IosAvailableUpdateVersion).SupportedDevices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("postingDateTime", PostingDateTime);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDevices", SupportedDevices);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
