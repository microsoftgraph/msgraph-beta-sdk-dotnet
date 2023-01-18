using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class HybridAgentUpdaterConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Indicates if updater configuration will be skipped and the agent will receive an update when the next version of the agent is available.</summary>
        public bool? AllowUpdateConfigurationOverride {
            get { return BackingStore?.Get<bool?>("allowUpdateConfigurationOverride"); }
            set { BackingStore?.Set("allowUpdateConfigurationOverride", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DeferUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deferUpdateDateTime"); }
            set { BackingStore?.Set("deferUpdateDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The updateWindow property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.UpdateWindow? UpdateWindow {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UpdateWindow?>("updateWindow"); }
            set { BackingStore?.Set("updateWindow", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.UpdateWindow UpdateWindow {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UpdateWindow>("updateWindow"); }
            set { BackingStore?.Set("updateWindow", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new hybridAgentUpdaterConfiguration and sets the default values.
        /// </summary>
        public HybridAgentUpdaterConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HybridAgentUpdaterConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HybridAgentUpdaterConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowUpdateConfigurationOverride", n => { AllowUpdateConfigurationOverride = n.GetBoolValue(); } },
                {"deferUpdateDateTime", n => { DeferUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"updateWindow", n => { UpdateWindow = n.GetObjectValue<Microsoft.Graph.Beta.Models.UpdateWindow>(Microsoft.Graph.Beta.Models.UpdateWindow.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowUpdateConfigurationOverride", AllowUpdateConfigurationOverride);
            writer.WriteDateTimeOffsetValue("deferUpdateDateTime", DeferUpdateDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UpdateWindow>("updateWindow", UpdateWindow);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
