using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Presence : Entity, IParsable {
        /// <summary>The supplemental information to a user&apos;s availability. Possible values are Available, Away, BeRightBack, Busy, DoNotDisturb, InACall, InAConferenceCall, Inactive,InAMeeting, Offline, OffWork,OutOfOffice, PresenceUnknown,Presenting, UrgentInterruptionsOnly.</summary>
        public string Activity {
            get { return BackingStore?.Get<string>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
        /// <summary>The base presence information for a user. Possible values are Available, AvailableIdle,  Away, BeRightBack, Busy, BusyIdle, DoNotDisturb, Offline, PresenceUnknown</summary>
        public string Availability {
            get { return BackingStore?.Get<string>("availability"); }
            set { BackingStore?.Set("availability", value); }
        }
        /// <summary>The out of office settings for a user.</summary>
        public Microsoft.Graph.Beta.Models.OutOfOfficeSettings OutOfOfficeSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OutOfOfficeSettings>("outOfOfficeSettings"); }
            set { BackingStore?.Set("outOfOfficeSettings", value); }
        }
        /// <summary>The presence status message of a user.</summary>
        public PresenceStatusMessage StatusMessage {
            get { return BackingStore?.Get<PresenceStatusMessage>("statusMessage"); }
            set { BackingStore?.Set("statusMessage", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Presence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Presence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetStringValue(); } },
                {"availability", n => { Availability = n.GetStringValue(); } },
                {"outOfOfficeSettings", n => { OutOfOfficeSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.OutOfOfficeSettings>(Microsoft.Graph.Beta.Models.OutOfOfficeSettings.CreateFromDiscriminatorValue); } },
                {"statusMessage", n => { StatusMessage = n.GetObjectValue<PresenceStatusMessage>(PresenceStatusMessage.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activity", Activity);
            writer.WriteStringValue("availability", Availability);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.OutOfOfficeSettings>("outOfOfficeSettings", OutOfOfficeSettings);
            writer.WriteObjectValue<PresenceStatusMessage>("statusMessage", StatusMessage);
        }
    }
}
