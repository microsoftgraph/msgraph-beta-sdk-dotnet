using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftTunnelHealthThreshold : Entity, IParsable {
        /// <summary>The default threshold for being healthy</summary>
        public long? DefaultHealthyThreshold {
            get { return BackingStore?.Get<long?>("defaultHealthyThreshold"); }
            set { BackingStore?.Set("defaultHealthyThreshold", value); }
        }
        /// <summary>The default threshold for being unhealthy</summary>
        public long? DefaultUnhealthyThreshold {
            get { return BackingStore?.Get<long?>("defaultUnhealthyThreshold"); }
            set { BackingStore?.Set("defaultUnhealthyThreshold", value); }
        }
        /// <summary>The threshold for being healthy</summary>
        public long? HealthyThreshold {
            get { return BackingStore?.Get<long?>("healthyThreshold"); }
            set { BackingStore?.Set("healthyThreshold", value); }
        }
        /// <summary>The threshold for being unhealthy</summary>
        public long? UnhealthyThreshold {
            get { return BackingStore?.Get<long?>("unhealthyThreshold"); }
            set { BackingStore?.Set("unhealthyThreshold", value); }
        }
        /// <summary>
        /// Instantiates a new MicrosoftTunnelHealthThreshold and sets the default values.
        /// </summary>
        public MicrosoftTunnelHealthThreshold() : base() {
            OdataType = "#microsoft.graph.microsoftTunnelHealthThreshold";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftTunnelHealthThreshold CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelHealthThreshold();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultHealthyThreshold", n => { DefaultHealthyThreshold = n.GetLongValue(); } },
                {"defaultUnhealthyThreshold", n => { DefaultUnhealthyThreshold = n.GetLongValue(); } },
                {"healthyThreshold", n => { HealthyThreshold = n.GetLongValue(); } },
                {"unhealthyThreshold", n => { UnhealthyThreshold = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("defaultHealthyThreshold", DefaultHealthyThreshold);
            writer.WriteLongValue("defaultUnhealthyThreshold", DefaultUnhealthyThreshold);
            writer.WriteLongValue("healthyThreshold", HealthyThreshold);
            writer.WriteLongValue("unhealthyThreshold", UnhealthyThreshold);
        }
    }
}
