using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public class ParticipantEndpoint : Endpoint, IParsable {
        /// <summary>The feedback provided by the user of this endpoint about the quality of the session.</summary>
        public UserFeedback Feedback {
            get { return BackingStore?.Get<UserFeedback>(nameof(Feedback)); }
            set { BackingStore?.Set(nameof(Feedback), value); }
        }
        /// <summary>Identity associated with the endpoint.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet Identity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(Identity)); }
            set { BackingStore?.Set(nameof(Identity), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ParticipantEndpoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParticipantEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"feedback", n => { Feedback = n.GetObjectValue<UserFeedback>(UserFeedback.CreateFromDiscriminatorValue); } },
                {"identity", n => { Identity = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserFeedback>("feedback", Feedback);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("identity", Identity);
        }
    }
}
