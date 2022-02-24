using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AppManagementPolicy : PolicyBase, IParsable {
        /// <summary>Collection of application and service principals to which a policy is applied.</summary>
        public List<DirectoryObject> AppliesTo { get; set; }
        /// <summary>Denotes whether the policy is enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Restrictions that apply to an application or service principal object.</summary>
        public AppManagementConfiguration Restrictions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appliesTo", (o,n) => { (o as AppManagementPolicy).AppliesTo = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"isEnabled", (o,n) => { (o as AppManagementPolicy).IsEnabled = n.GetBoolValue(); } },
                {"restrictions", (o,n) => { (o as AppManagementPolicy).Restrictions = n.GetObjectValue<AppManagementConfiguration>(); } },
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
