using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>MobileApp Intent and Install State for a given device.</summary>
    public class MobileAppIntentAndState : Entity, IParsable {
        /// <summary>Device identifier created or collected by Intune.</summary>
        public string ManagedDeviceIdentifier {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceIdentifier)); }
            set { BackingStore?.Set(nameof(ManagedDeviceIdentifier), value); }
        }
        /// <summary>The list of payload intents and states for the tenant.</summary>
        public List<MobileAppIntentAndStateDetail> MobileAppList {
            get { return BackingStore?.Get<List<MobileAppIntentAndStateDetail>>(nameof(MobileAppList)); }
            set { BackingStore?.Set(nameof(MobileAppList), value); }
        }
        /// <summary>Identifier for the user that tried to enroll the device.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppIntentAndState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppIntentAndState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"managedDeviceIdentifier", n => { ManagedDeviceIdentifier = n.GetStringValue(); } },
                {"mobileAppList", n => { MobileAppList = n.GetCollectionOfObjectValues<MobileAppIntentAndStateDetail>(MobileAppIntentAndStateDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("managedDeviceIdentifier", ManagedDeviceIdentifier);
            writer.WriteCollectionOfObjectValues<MobileAppIntentAndStateDetail>("mobileAppList", MobileAppList);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
