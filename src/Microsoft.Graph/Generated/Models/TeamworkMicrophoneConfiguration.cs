using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkMicrophoneConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The defaultMicrophone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkPeripheral? DefaultMicrophone {
            get { return BackingStore?.Get<TeamworkPeripheral?>("defaultMicrophone"); }
            set { BackingStore?.Set("defaultMicrophone", value); }
        }
#nullable restore
#else
        public TeamworkPeripheral DefaultMicrophone {
            get { return BackingStore?.Get<TeamworkPeripheral>("defaultMicrophone"); }
            set { BackingStore?.Set("defaultMicrophone", value); }
        }
#endif
        /// <summary>True if the configured microphone is optional. False if the microphone is not optional and the health state of the device should be computed.</summary>
        public bool? IsMicrophoneOptional {
            get { return BackingStore?.Get<bool?>("isMicrophoneOptional"); }
            set { BackingStore?.Set("isMicrophoneOptional", value); }
        }
        /// <summary>The microphones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkPeripheral>? Microphones {
            get { return BackingStore?.Get<List<TeamworkPeripheral>?>("microphones"); }
            set { BackingStore?.Set("microphones", value); }
        }
#nullable restore
#else
        public List<TeamworkPeripheral> Microphones {
            get { return BackingStore?.Get<List<TeamworkPeripheral>>("microphones"); }
            set { BackingStore?.Set("microphones", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamworkMicrophoneConfiguration and sets the default values.
        /// </summary>
        public TeamworkMicrophoneConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkMicrophoneConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkMicrophoneConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultMicrophone", n => { DefaultMicrophone = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"isMicrophoneOptional", n => { IsMicrophoneOptional = n.GetBoolValue(); } },
                {"microphones", n => { Microphones = n.GetCollectionOfObjectValues<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheral>("defaultMicrophone", DefaultMicrophone);
            writer.WriteBoolValue("isMicrophoneOptional", IsMicrophoneOptional);
            writer.WriteCollectionOfObjectValues<TeamworkPeripheral>("microphones", Microphones);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
