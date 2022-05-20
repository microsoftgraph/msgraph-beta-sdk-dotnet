using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public class ApplicationSignInDetailedSummary : Entity, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AggregatedEventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(AggregatedEventDateTime)); }
            set { BackingStore?.Set(nameof(AggregatedEventDateTime), value); }
        }
        /// <summary>Name of the application that the user signed in to.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>(nameof(AppDisplayName)); }
            set { BackingStore?.Set(nameof(AppDisplayName), value); }
        }
        /// <summary>ID of the application that the user signed in to.</summary>
        public string AppId {
            get { return BackingStore?.Get<string>(nameof(AppId)); }
            set { BackingStore?.Set(nameof(AppId), value); }
        }
        /// <summary>Count of sign-ins made by the application.</summary>
        public long? SignInCount {
            get { return BackingStore?.Get<long?>(nameof(SignInCount)); }
            set { BackingStore?.Set(nameof(SignInCount), value); }
        }
        /// <summary>Details of the sign-in status.</summary>
        public SignInStatus Status {
            get { return BackingStore?.Get<SignInStatus>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aggregatedEventDateTime", n => { AggregatedEventDateTime = n.GetDateTimeOffsetValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"signInCount", n => { SignInCount = n.GetLongValue(); } },
                {"status", n => { Status = n.GetObjectValue<SignInStatus>(SignInStatus.CreateFromDiscriminatorValue); } },
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
