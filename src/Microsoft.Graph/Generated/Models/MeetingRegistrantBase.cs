using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class MeetingRegistrantBase : Entity, IParsable {
        /// <summary>A unique web URL for the registrant to join the meeting. Read-only.</summary>
        public string JoinWebUrl {
            get { return BackingStore?.Get<string>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
        /// <summary>
        /// Instantiates a new meetingRegistrantBase and sets the default values.
        /// </summary>
        public MeetingRegistrantBase() : base() {
            OdataType = "#microsoft.graph.meetingRegistrantBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MeetingRegistrantBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.externalMeetingRegistrant" => new ExternalMeetingRegistrant(),
                "#microsoft.graph.meetingRegistrant" => new MeetingRegistrant(),
                _ => new MeetingRegistrantBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
        }
    }
}
