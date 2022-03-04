using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GroupPolicyObjectFile : Entity, IParsable {
        /// <summary>The Group Policy Object file content.</summary>
        public string Content { get; set; }
        /// <summary>The date and time at which the GroupPolicy was first uploaded.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The Group Policy Object GUID from GPO Xml content</summary>
        public string GroupPolicyObjectId { get; set; }
        /// <summary>The date and time at which the GroupPolicyObjectFile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The distinguished name of the OU.</summary>
        public string OuDistinguishedName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyObjectFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyObjectFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as GroupPolicyObjectFile).Content = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as GroupPolicyObjectFile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupPolicyObjectId", (o,n) => { (o as GroupPolicyObjectFile).GroupPolicyObjectId = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyObjectFile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"ouDistinguishedName", (o,n) => { (o as GroupPolicyObjectFile).OuDistinguishedName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("content", Content);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("groupPolicyObjectId", GroupPolicyObjectId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("ouDistinguishedName", OuDistinguishedName);
        }
    }
}
