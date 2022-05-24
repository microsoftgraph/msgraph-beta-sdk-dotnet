using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class UserActivity : Entity, IParsable {
        /// <summary>Required. URL used to launch the activity in the best native experience represented by the appId. Might launch a web-based app if no native app exists.</summary>
        public string ActivationUrl {
            get { return BackingStore?.Get<string>(nameof(ActivationUrl)); }
            set { BackingStore?.Set(nameof(ActivationUrl), value); }
        }
        /// <summary>Required. URL for the domain representing the cross-platform identity mapping for the app. Mapping is stored either as a JSON file hosted on the domain or configurable via Windows Dev Center. The JSON file is named cross-platform-app-identifiers and is hosted at root of your HTTPS domain, either at the top level domain or include a sub domain. For example: https://contoso.com or https://myapp.contoso.com but NOT https://myapp.contoso.com/somepath. You must have a unique file and domain (or sub domain) per cross-platform app identity. For example, a separate file and domain is needed for Word vs. PowerPoint.</summary>
        public string ActivitySourceHost {
            get { return BackingStore?.Get<string>(nameof(ActivitySourceHost)); }
            set { BackingStore?.Set(nameof(ActivitySourceHost), value); }
        }
        /// <summary>Required. The unique activity ID in the context of the app - supplied by caller and immutable thereafter.</summary>
        public string AppActivityId {
            get { return BackingStore?.Get<string>(nameof(AppActivityId)); }
            set { BackingStore?.Set(nameof(AppActivityId), value); }
        }
        /// <summary>Optional. Short text description of the app used to generate the activity for use in cases when the app is not installed on the user’s local device.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>(nameof(AppDisplayName)); }
            set { BackingStore?.Set(nameof(AppDisplayName), value); }
        }
        /// <summary>Optional. A custom piece of data - JSON-LD extensible description of content according to schema.org syntax.</summary>
        public Json ContentInfo {
            get { return BackingStore?.Get<Json>(nameof(ContentInfo)); }
            set { BackingStore?.Set(nameof(ContentInfo), value); }
        }
        /// <summary>Optional. Used in the event the content can be rendered outside of a native or web-based app experience (for example, a pointer to an item in an RSS feed).</summary>
        public string ContentUrl {
            get { return BackingStore?.Get<string>(nameof(ContentUrl)); }
            set { BackingStore?.Set(nameof(ContentUrl), value); }
        }
        /// <summary>Set by the server. DateTime in UTC when the object was created on the server.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Set by the server. DateTime in UTC when the object expired on the server.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ExpirationDateTime), value); }
        }
        /// <summary>Optional. URL used to launch the activity in a web-based app, if available.</summary>
        public string FallbackUrl {
            get { return BackingStore?.Get<string>(nameof(FallbackUrl)); }
            set { BackingStore?.Set(nameof(FallbackUrl), value); }
        }
        /// <summary>Optional. NavigationProperty/Containment; navigation property to the activity&apos;s historyItems.</summary>
        public List<ActivityHistoryItem> HistoryItems {
            get { return BackingStore?.Get<List<ActivityHistoryItem>>(nameof(HistoryItems)); }
            set { BackingStore?.Set(nameof(HistoryItems), value); }
        }
        /// <summary>Set by the server. DateTime in UTC when the object was modified on the server.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Set by the server. A status code used to identify valid objects. Values: active, updated, deleted, ignored.</summary>
        public Microsoft.Graph.Beta.Models.Status? Status {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Status?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>Optional. The timezone in which the user&apos;s device used to generate the activity was located at activity creation time; values supplied as Olson IDs in order to support cross-platform representation.</summary>
        public string UserTimezone {
            get { return BackingStore?.Get<string>(nameof(UserTimezone)); }
            set { BackingStore?.Set(nameof(UserTimezone), value); }
        }
        /// <summary>The visualElements property</summary>
        public VisualInfo VisualElements {
            get { return BackingStore?.Get<VisualInfo>(nameof(VisualElements)); }
            set { BackingStore?.Set(nameof(VisualElements), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"historyItems", n => { HistoryItems = n.GetCollectionOfObjectValues<ActivityHistoryItem>(ActivityHistoryItem.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<Status>(); } },
                {"userTimezone", n => { UserTimezone = n.GetStringValue(); } },
                {"visualElements", n => { VisualElements = n.GetObjectValue<VisualInfo>(VisualInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
