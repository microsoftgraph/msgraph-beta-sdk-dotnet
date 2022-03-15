using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class Settings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies if the user's primary mailbox is hosted in the cloud and is enabled for Microsoft Graph.</summary>
        public bool? HasGraphMailbox { get; set; }
        /// <summary>Specifies if the user has a MyAnalytics license assigned.</summary>
        public bool? HasLicense { get; set; }
        /// <summary>Specifies if the user opted out of MyAnalytics.</summary>
        public bool? HasOptedOut { get; set; }
        /// <summary>
        /// Instantiates a new settings and sets the default values.
        /// </summary>
        public Settings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Settings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Settings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hasGraphMailbox", (o,n) => { (o as Settings).HasGraphMailbox = n.GetBoolValue(); } },
                {"hasLicense", (o,n) => { (o as Settings).HasLicense = n.GetBoolValue(); } },
                {"hasOptedOut", (o,n) => { (o as Settings).HasOptedOut = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hasGraphMailbox", HasGraphMailbox);
            writer.WriteBoolValue("hasLicense", HasLicense);
            writer.WriteBoolValue("hasOptedOut", HasOptedOut);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
