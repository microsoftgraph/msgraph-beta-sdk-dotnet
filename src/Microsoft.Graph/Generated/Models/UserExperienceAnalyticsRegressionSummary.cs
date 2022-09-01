using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsRegressionSummary : Entity, IParsable {
        /// <summary>The metric values for the user experience analytics Manufacturer regression.</summary>
        public List<UserExperienceAnalyticsMetric> ManufacturerRegression {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsMetric>>("manufacturerRegression"); }
            set { BackingStore?.Set("manufacturerRegression", value); }
        }
        /// <summary>The metric values for the user experience analytics model regression.</summary>
        public List<UserExperienceAnalyticsMetric> ModelRegression {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsMetric>>("modelRegression"); }
            set { BackingStore?.Set("modelRegression", value); }
        }
        /// <summary>The metric values for the user experience analytics operating system regression.</summary>
        public List<UserExperienceAnalyticsMetric> OperatingSystemRegression {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsMetric>>("operatingSystemRegression"); }
            set { BackingStore?.Set("operatingSystemRegression", value); }
        }
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsRegressionSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsRegressionSummary() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsRegressionSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsRegressionSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsRegressionSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"manufacturerRegression", n => { ManufacturerRegression = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetric>(UserExperienceAnalyticsMetric.CreateFromDiscriminatorValue).ToList(); } },
                {"modelRegression", n => { ModelRegression = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetric>(UserExperienceAnalyticsMetric.CreateFromDiscriminatorValue).ToList(); } },
                {"operatingSystemRegression", n => { OperatingSystemRegression = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetric>(UserExperienceAnalyticsMetric.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsMetric>("manufacturerRegression", ManufacturerRegression);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsMetric>("modelRegression", ModelRegression);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsMetric>("operatingSystemRegression", OperatingSystemRegression);
        }
    }
}
