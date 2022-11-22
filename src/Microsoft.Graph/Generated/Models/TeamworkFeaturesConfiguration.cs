using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkFeaturesConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Email address to send logs and feedback.</summary>
        public string EmailToSendLogsAndFeedback {
            get { return BackingStore?.Get<string>("emailToSendLogsAndFeedback"); }
            set { BackingStore?.Set("emailToSendLogsAndFeedback", value); }
        }
        /// <summary>True if auto screen shared is enabled.</summary>
        public bool? IsAutoScreenShareEnabled {
            get { return BackingStore?.Get<bool?>("isAutoScreenShareEnabled"); }
            set { BackingStore?.Set("isAutoScreenShareEnabled", value); }
        }
        /// <summary>True if Bluetooth beaconing is enabled.</summary>
        public bool? IsBluetoothBeaconingEnabled {
            get { return BackingStore?.Get<bool?>("isBluetoothBeaconingEnabled"); }
            set { BackingStore?.Set("isBluetoothBeaconingEnabled", value); }
        }
        /// <summary>True if hiding meeting names is enabled.</summary>
        public bool? IsHideMeetingNamesEnabled {
            get { return BackingStore?.Get<bool?>("isHideMeetingNamesEnabled"); }
            set { BackingStore?.Set("isHideMeetingNamesEnabled", value); }
        }
        /// <summary>True if sending logs and feedback is enabled.</summary>
        public bool? IsSendLogsAndFeedbackEnabled {
            get { return BackingStore?.Get<bool?>("isSendLogsAndFeedbackEnabled"); }
            set { BackingStore?.Set("isSendLogsAndFeedbackEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkFeaturesConfiguration and sets the default values.
        /// </summary>
        public TeamworkFeaturesConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkFeaturesConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkFeaturesConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"emailToSendLogsAndFeedback", n => { EmailToSendLogsAndFeedback = n.GetStringValue(); } },
                {"isAutoScreenShareEnabled", n => { IsAutoScreenShareEnabled = n.GetBoolValue(); } },
                {"isBluetoothBeaconingEnabled", n => { IsBluetoothBeaconingEnabled = n.GetBoolValue(); } },
                {"isHideMeetingNamesEnabled", n => { IsHideMeetingNamesEnabled = n.GetBoolValue(); } },
                {"isSendLogsAndFeedbackEnabled", n => { IsSendLogsAndFeedbackEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("emailToSendLogsAndFeedback", EmailToSendLogsAndFeedback);
            writer.WriteBoolValue("isAutoScreenShareEnabled", IsAutoScreenShareEnabled);
            writer.WriteBoolValue("isBluetoothBeaconingEnabled", IsBluetoothBeaconingEnabled);
            writer.WriteBoolValue("isHideMeetingNamesEnabled", IsHideMeetingNamesEnabled);
            writer.WriteBoolValue("isSendLogsAndFeedbackEnabled", IsSendLogsAndFeedbackEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
