using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TodoSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The isExternalJoinEnabled property</summary>
        public bool? IsExternalJoinEnabled {
            get { return BackingStore?.Get<bool?>("isExternalJoinEnabled"); }
            set { BackingStore?.Set("isExternalJoinEnabled", value); }
        }
        /// <summary>The isExternalShareEnabled property</summary>
        public bool? IsExternalShareEnabled {
            get { return BackingStore?.Get<bool?>("isExternalShareEnabled"); }
            set { BackingStore?.Set("isExternalShareEnabled", value); }
        }
        /// <summary>The isPushNotificationEnabled property</summary>
        public bool? IsPushNotificationEnabled {
            get { return BackingStore?.Get<bool?>("isPushNotificationEnabled"); }
            set { BackingStore?.Set("isPushNotificationEnabled", value); }
        }
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
        /// Instantiates a new TodoSettings and sets the default values.
        /// </summary>
        public TodoSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TodoSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TodoSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isExternalJoinEnabled", n => { IsExternalJoinEnabled = n.GetBoolValue(); } },
                {"isExternalShareEnabled", n => { IsExternalShareEnabled = n.GetBoolValue(); } },
                {"isPushNotificationEnabled", n => { IsPushNotificationEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isExternalJoinEnabled", IsExternalJoinEnabled);
            writer.WriteBoolValue("isExternalShareEnabled", IsExternalShareEnabled);
            writer.WriteBoolValue("isPushNotificationEnabled", IsPushNotificationEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
