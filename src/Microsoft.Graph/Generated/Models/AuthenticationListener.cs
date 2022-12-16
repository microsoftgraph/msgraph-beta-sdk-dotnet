using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the admin singleton.
    /// </summary>
    public class AuthenticationListener : Entity, IParsable {
        /// <summary>The priority of the listener. Determines the order of evaluation when an event has multiple listeners. The priority is evaluated from low to high.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>Filter based on the source of the authentication that is used to determine whether the listener is evaluated. This is currently limited to evaluations based on application the user is authenticating to.</summary>
        public AuthenticationSourceFilter SourceFilter {
            get { return BackingStore?.Get<AuthenticationSourceFilter>("sourceFilter"); }
            set { BackingStore?.Set("sourceFilter", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthenticationListener CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.invokeUserFlowListener" => new InvokeUserFlowListener(),
                _ => new AuthenticationListener(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"sourceFilter", n => { SourceFilter = n.GetObjectValue<AuthenticationSourceFilter>(AuthenticationSourceFilter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("priority", Priority);
            writer.WriteObjectValue<AuthenticationSourceFilter>("sourceFilter", SourceFilter);
        }
    }
}
