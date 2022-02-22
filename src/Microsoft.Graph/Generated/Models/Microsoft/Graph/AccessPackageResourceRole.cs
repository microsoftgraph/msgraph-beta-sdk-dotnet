using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackageResourceRole : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource AccessPackageResource { get; set; }
        /// <summary>A description for the resource role.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the resource role such as the role defined by the application.</summary>
        public string DisplayName { get; set; }
        /// <summary>The unique identifier of the resource role in the origin system. For a SharePoint Online site, the originId will be the sequence number of the role in the site.</summary>
        public string OriginId { get; set; }
        /// <summary>The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.</summary>
        public string OriginSystem { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageResource", (o,n) => { (o as AccessPackageResourceRole).AccessPackageResource = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource>(); } },
                {"description", (o,n) => { (o as AccessPackageResourceRole).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageResourceRole).DisplayName = n.GetStringValue(); } },
                {"originId", (o,n) => { (o as AccessPackageResourceRole).OriginId = n.GetStringValue(); } },
                {"originSystem", (o,n) => { (o as AccessPackageResourceRole).OriginSystem = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource>("accessPackageResource", AccessPackageResource);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
        }
    }
}
