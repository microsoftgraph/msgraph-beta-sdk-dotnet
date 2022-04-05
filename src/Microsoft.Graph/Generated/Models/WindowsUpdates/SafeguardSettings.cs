using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class SafeguardSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of safeguards to ignore per device.</summary>
        public List<SafeguardProfile> DisabledSafeguardProfiles { get; set; }
        /// <summary>
        /// Instantiates a new safeguardSettings and sets the default values.
        /// </summary>
        public SafeguardSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SafeguardSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SafeguardSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"disabledSafeguardProfiles", (o,n) => { (o as SafeguardSettings).DisabledSafeguardProfiles = n.GetCollectionOfObjectValues<SafeguardProfile>(SafeguardProfile.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SafeguardProfile>("disabledSafeguardProfiles", DisabledSafeguardProfiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
