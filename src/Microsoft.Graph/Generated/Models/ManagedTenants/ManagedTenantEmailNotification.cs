using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagedTenantEmailNotification : Entity, IParsable {
        /// <summary>The alert property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedTenantAlert? Alert {
            get { return BackingStore?.Get<ManagedTenantAlert?>("alert"); }
            set { BackingStore?.Set("alert", value); }
        }
#nullable restore
#else
        public ManagedTenantAlert Alert {
            get { return BackingStore?.Get<ManagedTenantAlert>("alert"); }
            set { BackingStore?.Set("alert", value); }
        }
#endif
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId {
            get { return BackingStore?.Get<string?>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#nullable restore
#else
        public string CreatedByUserId {
            get { return BackingStore?.Get<string>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The emailAddresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Email>? EmailAddresses {
            get { return BackingStore?.Get<List<Email>?>("emailAddresses"); }
            set { BackingStore?.Set("emailAddresses", value); }
        }
#nullable restore
#else
        public List<Email> EmailAddresses {
            get { return BackingStore?.Get<List<Email>>("emailAddresses"); }
            set { BackingStore?.Set("emailAddresses", value); }
        }
#endif
        /// <summary>The emailBody property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailBody {
            get { return BackingStore?.Get<string?>("emailBody"); }
            set { BackingStore?.Set("emailBody", value); }
        }
#nullable restore
#else
        public string EmailBody {
            get { return BackingStore?.Get<string>("emailBody"); }
            set { BackingStore?.Set("emailBody", value); }
        }
#endif
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId {
            get { return BackingStore?.Get<string?>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#nullable restore
#else
        public string LastActionByUserId {
            get { return BackingStore?.Get<string>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedTenantEmailNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedTenantEmailNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alert", n => { Alert = n.GetObjectValue<ManagedTenantAlert>(ManagedTenantAlert.CreateFromDiscriminatorValue); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"emailAddresses", n => { EmailAddresses = n.GetCollectionOfObjectValues<Email>(Email.CreateFromDiscriminatorValue)?.ToList(); } },
                {"emailBody", n => { EmailBody = n.GetStringValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ManagedTenantAlert>("alert", Alert);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<Email>("emailAddresses", EmailAddresses);
            writer.WriteStringValue("emailBody", EmailBody);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
