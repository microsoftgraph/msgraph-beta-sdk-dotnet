using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class JoinMeetingIdSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether a passcode is required to join a meeting when using joinMeetingId. Optional.</summary>
        public bool? IsPasscodeRequired {
            get { return BackingStore?.Get<bool?>("isPasscodeRequired"); }
            set { BackingStore?.Set("isPasscodeRequired", value); }
        }
        /// <summary>The meeting ID to be used to join a meeting. Optional. Read-only.</summary>
        public string JoinMeetingId {
            get { return BackingStore?.Get<string>("joinMeetingId"); }
            set { BackingStore?.Set("joinMeetingId", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The passcode to join a meeting.  Optional. Read-only.</summary>
        public string Passcode {
            get { return BackingStore?.Get<string>("passcode"); }
            set { BackingStore?.Set("passcode", value); }
        }
        /// <summary>
        /// Instantiates a new joinMeetingIdSettings and sets the default values.
        /// </summary>
        public JoinMeetingIdSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.joinMeetingIdSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static JoinMeetingIdSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JoinMeetingIdSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isPasscodeRequired", n => { IsPasscodeRequired = n.GetBoolValue(); } },
                {"joinMeetingId", n => { JoinMeetingId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"passcode", n => { Passcode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isPasscodeRequired", IsPasscodeRequired);
            writer.WriteStringValue("joinMeetingId", JoinMeetingId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("passcode", Passcode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
