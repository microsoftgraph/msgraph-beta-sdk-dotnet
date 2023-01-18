using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EventMessageRequest : EventMessage, IParsable {
        /// <summary>True if the meeting organizer allows invitees to propose a new time when responding, false otherwise. Optional. Default is true.</summary>
        public bool? AllowNewTimeProposals {
            get { return BackingStore?.Get<bool?>("allowNewTimeProposals"); }
            set { BackingStore?.Set("allowNewTimeProposals", value); }
        }
        /// <summary>If the meeting update changes the meeting end time, this property specifies the previous meeting end time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DateTimeTimeZone? PreviousEndDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("previousEndDateTime"); }
            set { BackingStore?.Set("previousEndDateTime", value); }
        }
#else
        public DateTimeTimeZone PreviousEndDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("previousEndDateTime"); }
            set { BackingStore?.Set("previousEndDateTime", value); }
        }
#endif
        /// <summary>If the meeting update changes the meeting location, this property specifies the previous meeting location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Location? PreviousLocation {
            get { return BackingStore?.Get<Location?>("previousLocation"); }
            set { BackingStore?.Set("previousLocation", value); }
        }
#else
        public Location PreviousLocation {
            get { return BackingStore?.Get<Location>("previousLocation"); }
            set { BackingStore?.Set("previousLocation", value); }
        }
#endif
        /// <summary>If the meeting update changes the meeting start time, this property specifies the previous meeting start time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DateTimeTimeZone? PreviousStartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("previousStartDateTime"); }
            set { BackingStore?.Set("previousStartDateTime", value); }
        }
#else
        public DateTimeTimeZone PreviousStartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("previousStartDateTime"); }
            set { BackingStore?.Set("previousStartDateTime", value); }
        }
#endif
        /// <summary>Set to true if the sender would like the invitee to send a response to the requested meeting.</summary>
        public bool? ResponseRequested {
            get { return BackingStore?.Get<bool?>("responseRequested"); }
            set { BackingStore?.Set("responseRequested", value); }
        }
        /// <summary>
        /// Instantiates a new EventMessageRequest and sets the default values.
        /// </summary>
        public EventMessageRequest() : base() {
            OdataType = "#microsoft.graph.eventMessageRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EventMessageRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EventMessageRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowNewTimeProposals", n => { AllowNewTimeProposals = n.GetBoolValue(); } },
                {"previousEndDateTime", n => { PreviousEndDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"previousLocation", n => { PreviousLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"previousStartDateTime", n => { PreviousStartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"responseRequested", n => { ResponseRequested = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowNewTimeProposals", AllowNewTimeProposals);
            writer.WriteObjectValue<DateTimeTimeZone>("previousEndDateTime", PreviousEndDateTime);
            writer.WriteObjectValue<Location>("previousLocation", PreviousLocation);
            writer.WriteObjectValue<DateTimeTimeZone>("previousStartDateTime", PreviousStartDateTime);
            writer.WriteBoolValue("responseRequested", ResponseRequested);
        }
    }
}
