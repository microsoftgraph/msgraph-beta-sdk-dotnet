using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class ForwardingProfile : Profile, IParsable {
        /// <summary>Specifies the users, groups, devices, and branch locations whose traffic is associated with the given traffic forwarding profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Association>? Associations {
            get { return BackingStore?.Get<List<Association>?>("associations"); }
            set { BackingStore?.Set("associations", value); }
        }
#nullable restore
#else
        public List<Association> Associations {
            get { return BackingStore?.Get<List<Association>>("associations"); }
            set { BackingStore?.Set("associations", value); }
        }
#endif
        /// <summary>Profile priority.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>The trafficForwardingType property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.TrafficForwardingType? TrafficForwardingType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TrafficForwardingType?>("trafficForwardingType"); }
            set { BackingStore?.Set("trafficForwardingType", value); }
        }
        /// <summary>
        /// Instantiates a new forwardingProfile and sets the default values.
        /// </summary>
        public ForwardingProfile() : base() {
            OdataType = "#microsoft.graph.networkaccess.forwardingProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ForwardingProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ForwardingProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associations", n => { Associations = n.GetCollectionOfObjectValues<Association>(Association.CreateFromDiscriminatorValue)?.ToList(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"trafficForwardingType", n => { TrafficForwardingType = n.GetEnumValue<TrafficForwardingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Association>("associations", Associations);
            writer.WriteIntValue("priority", Priority);
            writer.WriteEnumValue<TrafficForwardingType>("trafficForwardingType", TrafficForwardingType);
        }
    }
}
