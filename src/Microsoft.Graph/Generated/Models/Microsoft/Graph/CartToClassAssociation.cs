using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CartToClassAssociation : Entity, IParsable {
        /// <summary>Identifiers of classrooms to be associated with device carts.</summary>
        public List<string> ClassroomIds { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the CartToClassAssociation.</summary>
        public string Description { get; set; }
        /// <summary>Identifiers of device carts to be associated with classes.</summary>
        public List<string> DeviceCartIds { get; set; }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Version of the CartToClassAssociation.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CartToClassAssociation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CartToClassAssociation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"classroomIds", (o,n) => { (o as CartToClassAssociation).ClassroomIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as CartToClassAssociation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as CartToClassAssociation).Description = n.GetStringValue(); } },
                {"deviceCartIds", (o,n) => { (o as CartToClassAssociation).DeviceCartIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"displayName", (o,n) => { (o as CartToClassAssociation).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as CartToClassAssociation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"version", (o,n) => { (o as CartToClassAssociation).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("classroomIds", ClassroomIds);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("deviceCartIds", DeviceCartIds);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("version", Version);
        }
    }
}
