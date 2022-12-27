using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class AuthenticationEventListener : Entity, IParsable {
        /// <summary>The authenticationEventsFlowId property</summary>
        public string AuthenticationEventsFlowId {
            get { return BackingStore?.Get<string>("authenticationEventsFlowId"); }
            set { BackingStore?.Set("authenticationEventsFlowId", value); }
        }
        /// <summary>The conditions property</summary>
        public AuthenticationConditions Conditions {
            get { return BackingStore?.Get<AuthenticationConditions>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
        /// <summary>The priority property</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>The tags property</summary>
        public List<KeyValuePair> Tags {
            get { return BackingStore?.Get<List<KeyValuePair>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthenticationEventListener CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.onTokenIssuanceStartListener" => new OnTokenIssuanceStartListener(),
                _ => new AuthenticationEventListener(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationEventsFlowId", n => { AuthenticationEventsFlowId = n.GetStringValue(); } },
                {"conditions", n => { Conditions = n.GetObjectValue<AuthenticationConditions>(AuthenticationConditions.CreateFromDiscriminatorValue); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("authenticationEventsFlowId", AuthenticationEventsFlowId);
            writer.WriteObjectValue<AuthenticationConditions>("conditions", Conditions);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("tags", Tags);
        }
    }
}
