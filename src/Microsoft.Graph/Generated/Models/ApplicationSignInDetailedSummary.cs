using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ApplicationSignInDetailedSummary : Entity, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AggregatedEventDateTime { get; set; }
        /// <summary>Name of the application that the user signed in to.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>ID of the application that the user signed in to.</summary>
        public string AppId { get; set; }
        /// <summary>Count of sign-ins made by the application.</summary>
        public long? SignInCount { get; set; }
        /// <summary>Details of the sign-in status.</summary>
        public SignInStatus Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApplicationSignInDetailedSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationSignInDetailedSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"aggregatedEventDateTime", (o,n) => { (o as ApplicationSignInDetailedSummary).AggregatedEventDateTime = n.GetDateTimeOffsetValue(); } },
                {"appDisplayName", (o,n) => { (o as ApplicationSignInDetailedSummary).AppDisplayName = n.GetStringValue(); } },
                {"appId", (o,n) => { (o as ApplicationSignInDetailedSummary).AppId = n.GetStringValue(); } },
                {"signInCount", (o,n) => { (o as ApplicationSignInDetailedSummary).SignInCount = n.GetLongValue(); } },
                {"status", (o,n) => { (o as ApplicationSignInDetailedSummary).Status = n.GetObjectValue<SignInStatus>(SignInStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("aggregatedEventDateTime", AggregatedEventDateTime);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteLongValue("signInCount", SignInCount);
            writer.WriteObjectValue<SignInStatus>("status", Status);
        }
    }
}
