using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppManagementPolicy : PolicyBase, IParsable {
        /// <summary>The appliesTo property</summary>
        public List<DirectoryObject> AppliesTo { get; set; }
        /// <summary>The isEnabled property</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The restrictions property</summary>
        public AppManagementConfiguration Restrictions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AppManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appliesTo", (o,n) => { (o as AppManagementPolicy).AppliesTo = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"isEnabled", (o,n) => { (o as AppManagementPolicy).IsEnabled = n.GetBoolValue(); } },
                {"restrictions", (o,n) => { (o as AppManagementPolicy).Restrictions = n.GetObjectValue<AppManagementConfiguration>(AppManagementConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<AppManagementConfiguration>("restrictions", Restrictions);
        }
    }
}
