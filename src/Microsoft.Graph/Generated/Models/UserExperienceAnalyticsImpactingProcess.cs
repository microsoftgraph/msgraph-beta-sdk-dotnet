using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsImpactingProcess : Entity, IParsable {
        /// <summary>The category of impacting process.</summary>
        public string Category { get; set; }
        /// <summary>The description of process.</summary>
        public string Description { get; set; }
        /// <summary>The unique identifier of the impacted device.</summary>
        public string DeviceId { get; set; }
        /// <summary>The impact value of the process. Valid values 0 to 1.79769313486232E+308</summary>
        public double? ImpactValue { get; set; }
        /// <summary>The process name.</summary>
        public string ProcessName { get; set; }
        /// <summary>The publisher of the process.</summary>
        public string Publisher { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsImpactingProcess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsImpactingProcess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"impactValue", n => { ImpactValue = n.GetDoubleValue(); } },
                {"processName", n => { ProcessName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDoubleValue("impactValue", ImpactValue);
            writer.WriteStringValue("processName", ProcessName);
            writer.WriteStringValue("publisher", Publisher);
        }
    }
}
