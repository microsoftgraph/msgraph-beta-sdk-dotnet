using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DefaultUserRolePermissions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the default user role can create applications.</summary>
        public bool? AllowedToCreateApps { get; set; }
        /// <summary>Indicates whether the default user role can create security groups.</summary>
        public bool? AllowedToCreateSecurityGroups { get; set; }
        /// <summary>Indicates whether the default user role can read other users.</summary>
        public bool? AllowedToReadOtherUsers { get; set; }
        /// <summary>
        /// Instantiates a new defaultUserRolePermissions and sets the default values.
        /// </summary>
        public DefaultUserRolePermissions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DefaultUserRolePermissions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DefaultUserRolePermissions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowedToCreateApps", (o,n) => { (o as DefaultUserRolePermissions).AllowedToCreateApps = n.GetBoolValue(); } },
                {"allowedToCreateSecurityGroups", (o,n) => { (o as DefaultUserRolePermissions).AllowedToCreateSecurityGroups = n.GetBoolValue(); } },
                {"allowedToReadOtherUsers", (o,n) => { (o as DefaultUserRolePermissions).AllowedToReadOtherUsers = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowedToCreateApps", AllowedToCreateApps);
            writer.WriteBoolValue("allowedToCreateSecurityGroups", AllowedToCreateSecurityGroups);
            writer.WriteBoolValue("allowedToReadOtherUsers", AllowedToReadOtherUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
