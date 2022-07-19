using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics metric contains the score and units of a metric of a user experience anlaytics category.</summary>
    public class UserExperienceAnalyticsMetric : Entity, IParsable {
        /// <summary>The unit of the user experience analytics metric.</summary>
        public string Unit {
            get { return BackingStore?.Get<string>("unit"); }
            set { BackingStore?.Set("unit", value); }
        }
        /// <summary>The value of the user experience analytics metric.</summary>
        public double? Value {
            get { return BackingStore?.Get<double?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsMetric and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsMetric() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsMetric";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsMetric CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"unit", n => { Unit = n.GetStringValue(); } },
                {"value", n => { Value = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("unit", Unit);
            writer.WriteDoubleValue("value", Value);
        }
    }
}
