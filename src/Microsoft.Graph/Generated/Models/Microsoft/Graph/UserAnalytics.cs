using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserAnalytics : Entity, IParsable {
        /// <summary>The collection of work activities that a user spent time on during and outside of working hours. Read-only. Nullable.</summary>
        public List<ActivityStatistics> ActivityStatistics { get; set; }
        /// <summary>The current settings for a user to use the analytics API.</summary>
        public Settings Settings { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityStatistics", (o,n) => { (o as UserAnalytics).ActivityStatistics = n.GetCollectionOfObjectValues<ActivityStatistics>().ToList(); } },
                {"settings", (o,n) => { (o as UserAnalytics).Settings = n.GetObjectValue<Settings>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ActivityStatistics>("activityStatistics", ActivityStatistics);
            writer.WriteObjectValue<Settings>("settings", Settings);
        }
    }
}
