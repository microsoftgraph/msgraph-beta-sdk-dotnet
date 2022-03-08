using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class UserAnalytics : Entity, IParsable {
        /// <summary>The collection of work activities that a user spent time on during and outside of working hours. Read-only. Nullable.</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.ActivityStatistics> ActivityStatistics { get; set; }
        /// <summary>The current settings for a user to use the analytics API.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Settings Settings { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserAnalytics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAnalytics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityStatistics", (o,n) => { (o as UserAnalytics).ActivityStatistics = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.ActivityStatistics>(MicrosoftGraphSdk.Models.Microsoft.Graph.ActivityStatistics.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", (o,n) => { (o as UserAnalytics).Settings = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Settings>(MicrosoftGraphSdk.Models.Microsoft.Graph.Settings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.ActivityStatistics>("activityStatistics", ActivityStatistics);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Settings>("settings", Settings);
        }
    }
}
