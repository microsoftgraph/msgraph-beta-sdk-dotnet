using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class Mention : Entity, IParsable {
        /// <summary>The name of the application where the mention is created. Optional. Not used and defaulted as null for message.</summary>
        public string Application { get; set; }
        /// <summary>A unique identifier that represents a parent of the resource instance. Optional. Not used and defaulted as null for message.</summary>
        public string ClientReference { get; set; }
        /// <summary>The email information of the user who made the mention.</summary>
        public EmailAddress CreatedBy { get; set; }
        /// <summary>The date and time that the mention is created on the client.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A deep web link to the context of the mention in the resource instance. Optional. Not used and defaulted as null for message.</summary>
        public string DeepLink { get; set; }
        public EmailAddress Mentioned { get; set; }
        /// <summary>Optional. Not used and defaulted as null for message. To get the mentions in a message, see the bodyPreview property of the message instead.</summary>
        public string MentionText { get; set; }
        /// <summary>The date and time that the mention is created on the server. Optional. Not used and defaulted as null for message.</summary>
        public DateTimeOffset? ServerCreatedDateTime { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"application", (o,n) => { (o as Mention).Application = n.GetStringValue(); } },
                {"clientReference", (o,n) => { (o as Mention).ClientReference = n.GetStringValue(); } },
                {"createdBy", (o,n) => { (o as Mention).CreatedBy = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as Mention).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deepLink", (o,n) => { (o as Mention).DeepLink = n.GetStringValue(); } },
                {"mentioned", (o,n) => { (o as Mention).Mentioned = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                {"mentionText", (o,n) => { (o as Mention).MentionText = n.GetStringValue(); } },
                {"serverCreatedDateTime", (o,n) => { (o as Mention).ServerCreatedDateTime = n.GetDateTimeOffsetValue(); } },
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
