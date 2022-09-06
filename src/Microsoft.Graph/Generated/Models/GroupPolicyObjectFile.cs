using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Group Policy Object file uploaded by admin.</summary>
    public class GroupPolicyObjectFile : Entity, IParsable {
        /// <summary>The Group Policy Object file content.</summary>
        public string Content {
            get { return BackingStore?.Get<string>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>The date and time at which the GroupPolicy was first uploaded.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The Group Policy Object GUID from GPO Xml content</summary>
        public string GroupPolicyObjectId {
            get { return BackingStore?.Get<string>("groupPolicyObjectId"); }
            set { BackingStore?.Set("groupPolicyObjectId", value); }
        }
        /// <summary>The date and time at which the GroupPolicyObjectFile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The distinguished name of the OU.</summary>
        public string OuDistinguishedName {
            get { return BackingStore?.Get<string>("ouDistinguishedName"); }
            set { BackingStore?.Set("ouDistinguishedName", value); }
        }
        /// <summary>
        /// Instantiates a new groupPolicyObjectFile and sets the default values.
        /// </summary>
        public GroupPolicyObjectFile() : base() {
            OdataType = "#microsoft.graph.groupPolicyObjectFile";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupPolicyObjectId", n => { GroupPolicyObjectId = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"ouDistinguishedName", n => { OuDistinguishedName = n.GetStringValue(); } },
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
