using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics metric for work from anywhere report</summary>
    public class UserExperienceAnalyticsWorkFromAnywhereMetric : Entity, IParsable {
        /// <summary>The work from anywhere metric devices.</summary>
        public List<UserExperienceAnalyticsWorkFromAnywhereDevice> MetricDevices {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsWorkFromAnywhereDevice>>("metricDevices"); }
            set { BackingStore?.Set("metricDevices", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsWorkFromAnywhereMetric and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsWorkFromAnywhereMetric() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsWorkFromAnywhereMetric";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsWorkFromAnywhereMetric CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"metricDevices", n => { MetricDevices = n.GetCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereDevice>(UserExperienceAnalyticsWorkFromAnywhereDevice.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereDevice>("metricDevices", MetricDevices);
        }
    }
}
