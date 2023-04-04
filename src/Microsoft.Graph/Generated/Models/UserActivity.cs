using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UserActivity : Entity, IParsable {
        /// <summary>The activationUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivationUrl {
            get { return BackingStore?.Get<string?>("activationUrl"); }
            set { BackingStore?.Set("activationUrl", value); }
        }
#nullable restore
#else
        public string ActivationUrl {
            get { return BackingStore?.Get<string>("activationUrl"); }
            set { BackingStore?.Set("activationUrl", value); }
        }
#endif
        /// <summary>The activitySourceHost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivitySourceHost {
            get { return BackingStore?.Get<string?>("activitySourceHost"); }
            set { BackingStore?.Set("activitySourceHost", value); }
        }
#nullable restore
#else
        public string ActivitySourceHost {
            get { return BackingStore?.Get<string>("activitySourceHost"); }
            set { BackingStore?.Set("activitySourceHost", value); }
        }
#endif
        /// <summary>The appActivityId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppActivityId {
            get { return BackingStore?.Get<string?>("appActivityId"); }
            set { BackingStore?.Set("appActivityId", value); }
        }
#nullable restore
#else
        public string AppActivityId {
            get { return BackingStore?.Get<string>("appActivityId"); }
            set { BackingStore?.Set("appActivityId", value); }
        }
#endif
        /// <summary>The appDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName {
            get { return BackingStore?.Get<string?>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#nullable restore
#else
        public string AppDisplayName {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#endif
        /// <summary>The contentInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ContentInfo {
            get { return BackingStore?.Get<Json?>("contentInfo"); }
            set { BackingStore?.Set("contentInfo", value); }
        }
#nullable restore
#else
        public Json ContentInfo {
            get { return BackingStore?.Get<Json>("contentInfo"); }
            set { BackingStore?.Set("contentInfo", value); }
        }
#endif
        /// <summary>The contentUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentUrl {
            get { return BackingStore?.Get<string?>("contentUrl"); }
            set { BackingStore?.Set("contentUrl", value); }
        }
#nullable restore
#else
        public string ContentUrl {
            get { return BackingStore?.Get<string>("contentUrl"); }
            set { BackingStore?.Set("contentUrl", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The fallbackUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FallbackUrl {
            get { return BackingStore?.Get<string?>("fallbackUrl"); }
            set { BackingStore?.Set("fallbackUrl", value); }
        }
#nullable restore
#else
        public string FallbackUrl {
            get { return BackingStore?.Get<string>("fallbackUrl"); }
            set { BackingStore?.Set("fallbackUrl", value); }
        }
#endif
        /// <summary>The historyItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ActivityHistoryItem>? HistoryItems {
            get { return BackingStore?.Get<List<ActivityHistoryItem>?>("historyItems"); }
            set { BackingStore?.Set("historyItems", value); }
        }
#nullable restore
#else
        public List<ActivityHistoryItem> HistoryItems {
            get { return BackingStore?.Get<List<ActivityHistoryItem>>("historyItems"); }
            set { BackingStore?.Set("historyItems", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The status property</summary>
        public Microsoft.Graph.Beta.Models.Status? Status {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Status?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The userTimezone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserTimezone {
            get { return BackingStore?.Get<string?>("userTimezone"); }
            set { BackingStore?.Set("userTimezone", value); }
        }
#nullable restore
#else
        public string UserTimezone {
            get { return BackingStore?.Get<string>("userTimezone"); }
            set { BackingStore?.Set("userTimezone", value); }
        }
#endif
        /// <summary>The visualElements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VisualInfo? VisualElements {
            get { return BackingStore?.Get<VisualInfo?>("visualElements"); }
            set { BackingStore?.Set("visualElements", value); }
        }
#nullable restore
#else
        public VisualInfo VisualElements {
            get { return BackingStore?.Get<VisualInfo>("visualElements"); }
            set { BackingStore?.Set("visualElements", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activationUrl", n => { ActivationUrl = n.GetStringValue(); } },
                {"activitySourceHost", n => { ActivitySourceHost = n.GetStringValue(); } },
                {"appActivityId", n => { AppActivityId = n.GetStringValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"contentInfo", n => { ContentInfo = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"contentUrl", n => { ContentUrl = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"fallbackUrl", n => { FallbackUrl = n.GetStringValue(); } },
                {"historyItems", n => { HistoryItems = n.GetCollectionOfObjectValues<ActivityHistoryItem>(ActivityHistoryItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<Status>(); } },
                {"userTimezone", n => { UserTimezone = n.GetStringValue(); } },
                {"visualElements", n => { VisualElements = n.GetObjectValue<VisualInfo>(VisualInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activationUrl", ActivationUrl);
            writer.WriteStringValue("activitySourceHost", ActivitySourceHost);
            writer.WriteStringValue("appActivityId", AppActivityId);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteObjectValue<Json>("contentInfo", ContentInfo);
            writer.WriteStringValue("contentUrl", ContentUrl);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("fallbackUrl", FallbackUrl);
            writer.WriteCollectionOfObjectValues<ActivityHistoryItem>("historyItems", HistoryItems);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<Status>("status", Status);
            writer.WriteStringValue("userTimezone", UserTimezone);
            writer.WriteObjectValue<VisualInfo>("visualElements", VisualElements);
        }
    }
}
