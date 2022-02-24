using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AccessPackageResourceAttribute : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information about how to set the attribute, currently a accessPackageUserDirectoryAttributeStore object type.</summary>
        public AccessPackageResourceAttributeDestination AttributeDestination { get; set; }
        /// <summary>The name of the attribute in the end system. If the destination is accessPackageUserDirectoryAttributeStore, then a user property such as jobTitle or a directory schema extension for the user object type, such as extension_2b676109c7c74ae2b41549205f1947ed_personalTitle.</summary>
        public string AttributeName { get; set; }
        /// <summary>Information about how to populate the attribute value when an accessPackageAssignmentRequest is being fulfilled, currently a accessPackageResourceAttributeQuestion object type.</summary>
        public AccessPackageResourceAttributeSource AttributeSource { get; set; }
        /// <summary>Unique identifier for the attribute on the access package resource. Read-only.</summary>
        public string Id { get; set; }
        /// <summary>Specifies whether or not an existing attribute value can be edited by the requester.</summary>
        public bool? IsEditable { get; set; }
        /// <summary>Specifies whether the attribute will remain in the end system after an assignment ends.</summary>
        public bool? IsPersistedOnAssignmentRemoval { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageResourceAttribute and sets the default values.
        /// </summary>
        public AccessPackageResourceAttribute() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attributeDestination", (o,n) => { (o as AccessPackageResourceAttribute).AttributeDestination = n.GetObjectValue<AccessPackageResourceAttributeDestination>(); } },
                {"attributeName", (o,n) => { (o as AccessPackageResourceAttribute).AttributeName = n.GetStringValue(); } },
                {"attributeSource", (o,n) => { (o as AccessPackageResourceAttribute).AttributeSource = n.GetObjectValue<AccessPackageResourceAttributeSource>(); } },
                {"id", (o,n) => { (o as AccessPackageResourceAttribute).Id = n.GetStringValue(); } },
                {"isEditable", (o,n) => { (o as AccessPackageResourceAttribute).IsEditable = n.GetBoolValue(); } },
                {"isPersistedOnAssignmentRemoval", (o,n) => { (o as AccessPackageResourceAttribute).IsPersistedOnAssignmentRemoval = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AccessPackageResourceAttributeDestination>("attributeDestination", AttributeDestination);
            writer.WriteStringValue("attributeName", AttributeName);
            writer.WriteObjectValue<AccessPackageResourceAttributeSource>("attributeSource", AttributeSource);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEditable", IsEditable);
            writer.WriteBoolValue("isPersistedOnAssignmentRemoval", IsPersistedOnAssignmentRemoval);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
