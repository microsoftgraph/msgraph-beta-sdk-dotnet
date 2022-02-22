using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ItemPatent : ItemFacet, IParsable {
        /// <summary>Descpription of the patent or filing.</summary>
        public string Description { get; set; }
        /// <summary>Title of the patent or filing.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates the patent is pending.</summary>
        public bool? IsPending { get; set; }
        /// <summary>The date that the patent was granted.</summary>
        public Date? IssuedDate { get; set; }
        /// <summary>Authority which granted the patent.</summary>
        public string IssuingAuthority { get; set; }
        /// <summary>The patent number.</summary>
        public string Number { get; set; }
        /// <summary>URL referencing the patent or filing.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as ItemPatent).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ItemPatent).DisplayName = n.GetStringValue(); } },
                {"isPending", (o,n) => { (o as ItemPatent).IsPending = n.GetBoolValue(); } },
                {"issuedDate", (o,n) => { (o as ItemPatent).IssuedDate = n.GetDateValue(); } },
                {"issuingAuthority", (o,n) => { (o as ItemPatent).IssuingAuthority = n.GetStringValue(); } },
                {"number", (o,n) => { (o as ItemPatent).Number = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as ItemPatent).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isPending", IsPending);
            writer.WriteDateValue("issuedDate", IssuedDate);
            writer.WriteStringValue("issuingAuthority", IssuingAuthority);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
