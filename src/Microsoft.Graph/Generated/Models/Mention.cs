using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class Mention : Entity, IParsable {
        /// <summary>The name of the application where the mention is created. Optional. Not used and defaulted as null for message.</summary>
        public string Application {
            get { return BackingStore?.Get<string>(nameof(Application)); }
            set { BackingStore?.Set(nameof(Application), value); }
        }
        /// <summary>A unique identifier that represents a parent of the resource instance. Optional. Not used and defaulted as null for message.</summary>
        public string ClientReference {
            get { return BackingStore?.Get<string>(nameof(ClientReference)); }
            set { BackingStore?.Set(nameof(ClientReference), value); }
        }
        /// <summary>The email information of the user who made the mention.</summary>
        public EmailAddress CreatedBy {
            get { return BackingStore?.Get<EmailAddress>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The date and time that the mention is created on the client.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>A deep web link to the context of the mention in the resource instance. Optional. Not used and defaulted as null for message.</summary>
        public string DeepLink {
            get { return BackingStore?.Get<string>(nameof(DeepLink)); }
            set { BackingStore?.Set(nameof(DeepLink), value); }
        }
        /// <summary>The mentioned property</summary>
        public EmailAddress Mentioned {
            get { return BackingStore?.Get<EmailAddress>(nameof(Mentioned)); }
            set { BackingStore?.Set(nameof(Mentioned), value); }
        }
        /// <summary>Optional. Not used and defaulted as null for message. To get the mentions in a message, see the bodyPreview property of the message instead.</summary>
        public string MentionText {
            get { return BackingStore?.Get<string>(nameof(MentionText)); }
            set { BackingStore?.Set(nameof(MentionText), value); }
        }
        /// <summary>The date and time that the mention is created on the server. Optional. Not used and defaulted as null for message.</summary>
        public DateTimeOffset? ServerCreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ServerCreatedDateTime)); }
            set { BackingStore?.Set(nameof(ServerCreatedDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Mention CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Mention();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"application", n => { Application = n.GetStringValue(); } },
                {"clientReference", n => { ClientReference = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deepLink", n => { DeepLink = n.GetStringValue(); } },
                {"mentioned", n => { Mentioned = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                {"mentionText", n => { MentionText = n.GetStringValue(); } },
                {"serverCreatedDateTime", n => { ServerCreatedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("application", Application);
            writer.WriteStringValue("clientReference", ClientReference);
            writer.WriteObjectValue<EmailAddress>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deepLink", DeepLink);
            writer.WriteObjectValue<EmailAddress>("mentioned", Mentioned);
            writer.WriteStringValue("mentionText", MentionText);
            writer.WriteDateTimeOffsetValue("serverCreatedDateTime", ServerCreatedDateTime);
        }
    }
}
