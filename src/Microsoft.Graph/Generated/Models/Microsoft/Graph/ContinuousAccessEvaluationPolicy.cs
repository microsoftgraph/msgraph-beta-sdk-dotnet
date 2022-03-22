using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ContinuousAccessEvaluationPolicy : Entity, IParsable {
        /// <summary>Continuous access evaluation automatically blocks access to resources and applications in near real time when a user's access is removed or a client IP address changes. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The value is always Continuous Access Evaluation. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The collection of group identifiers in scope for evaluation. All groups are in scope when the collection is empty. Read-only.</summary>
        public List<string> Groups { get; set; }
        /// <summary>true to indicate whether continuous access evaluation should be performed; otherwise false. Read-only.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>true to indicate that the continuous access evaluation policy settings should be or has been migrated to the conditional access policy.</summary>
        public bool? Migrate { get; set; }
        /// <summary>The collection of user identifiers in scope for evaluation. All users are in scope when the collection is empty. Read-only.</summary>
        public List<string> Users { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ContinuousAccessEvaluationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContinuousAccessEvaluationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as ContinuousAccessEvaluationPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ContinuousAccessEvaluationPolicy).DisplayName = n.GetStringValue(); } },
                {"groups", (o,n) => { (o as ContinuousAccessEvaluationPolicy).Groups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isEnabled", (o,n) => { (o as ContinuousAccessEvaluationPolicy).IsEnabled = n.GetBoolValue(); } },
                {"migrate", (o,n) => { (o as ContinuousAccessEvaluationPolicy).Migrate = n.GetBoolValue(); } },
                {"users", (o,n) => { (o as ContinuousAccessEvaluationPolicy).Users = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("groups", Groups);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("migrate", Migrate);
            writer.WriteCollectionOfPrimitiveValues<string>("users", Users);
        }
    }
}
