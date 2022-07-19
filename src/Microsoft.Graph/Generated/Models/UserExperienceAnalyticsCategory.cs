using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsCategory : Entity, IParsable {
        /// <summary>The insights for the user experience analytics category.</summary>
        public List<UserExperienceAnalyticsInsight> Insights {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsInsight>>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
        /// <summary>The metric values for the user experience analytics category.</summary>
        public List<UserExperienceAnalyticsMetric> MetricValues {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsMetric>>("metricValues"); }
            set { BackingStore?.Set("metricValues", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsCategory and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsCategory() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsCategory";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsCategory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"insights", n => { Insights = n.GetCollectionOfObjectValues<UserExperienceAnalyticsInsight>(UserExperienceAnalyticsInsight.CreateFromDiscriminatorValue).ToList(); } },
                {"metricValues", n => { MetricValues = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetric>(UserExperienceAnalyticsMetric.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsInsight>("insights", Insights);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsMetric>("metricValues", MetricValues);
        }
    }
}
