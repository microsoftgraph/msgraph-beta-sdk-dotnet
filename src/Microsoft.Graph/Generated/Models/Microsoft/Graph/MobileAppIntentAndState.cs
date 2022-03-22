using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MobileAppIntentAndState : Entity, IParsable {
        /// <summary>Device identifier created or collected by Intune.</summary>
        public string ManagedDeviceIdentifier { get; set; }
        /// <summary>The list of payload intents and states for the tenant.</summary>
        public List<MobileAppIntentAndStateDetail> MobileAppList { get; set; }
        /// <summary>Identifier for the user that tried to enroll the device.</summary>
        public string UserId { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"managedDeviceIdentifier", (o,n) => { (o as MobileAppIntentAndState).ManagedDeviceIdentifier = n.GetStringValue(); } },
                {"mobileAppList", (o,n) => { (o as MobileAppIntentAndState).MobileAppList = n.GetCollectionOfObjectValues<MobileAppIntentAndStateDetail>(MobileAppIntentAndStateDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"userId", (o,n) => { (o as MobileAppIntentAndState).UserId = n.GetStringValue(); } },
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
