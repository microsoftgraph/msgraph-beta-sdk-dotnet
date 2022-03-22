using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsRegressionSummary : Entity, IParsable {
        /// <summary>The metric values for the user experience analytics Manufacturer regression.</summary>
        public List<UserExperienceAnalyticsMetric> ManufacturerRegression { get; set; }
        /// <summary>The metric values for the user experience analytics model regression.</summary>
        public List<UserExperienceAnalyticsMetric> ModelRegression { get; set; }
        /// <summary>The metric values for the user experience analytics operating system regression.</summary>
        public List<UserExperienceAnalyticsMetric> OperatingSystemRegression { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"manufacturerRegression", (o,n) => { (o as UserExperienceAnalyticsRegressionSummary).ManufacturerRegression = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetric>(UserExperienceAnalyticsMetric.CreateFromDiscriminatorValue).ToList(); } },
                {"modelRegression", (o,n) => { (o as UserExperienceAnalyticsRegressionSummary).ModelRegression = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetric>(UserExperienceAnalyticsMetric.CreateFromDiscriminatorValue).ToList(); } },
                {"operatingSystemRegression", (o,n) => { (o as UserExperienceAnalyticsRegressionSummary).OperatingSystemRegression = n.GetCollectionOfObjectValues<UserExperienceAnalyticsMetric>(UserExperienceAnalyticsMetric.CreateFromDiscriminatorValue).ToList(); } },
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
