using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PersonCertification : ItemFacet, IParsable {
        /// <summary>The referenceable identifier for the certification.</summary>
        public string CertificationId { get; set; }
        /// <summary>Description of the certification.</summary>
        public string Description { get; set; }
        /// <summary>Title of the certification.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date that the certification expires.</summary>
        public Date? EndDate { get; set; }
        /// <summary>The date that the certification was issued.</summary>
        public Date? IssuedDate { get; set; }
        /// <summary>Authority which granted the certification.</summary>
        public string IssuingAuthority { get; set; }
        /// <summary>Company which granted the certification.</summary>
        public string IssuingCompany { get; set; }
        /// <summary>The date that the certification became valid.</summary>
        public Date? StartDate { get; set; }
        /// <summary>URL referencing a thumbnail of the certification.</summary>
        public string ThumbnailUrl { get; set; }
        /// <summary>URL referencing the certification.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"certificationId", (o,n) => { (o as PersonCertification).CertificationId = n.GetStringValue(); } },
                {"description", (o,n) => { (o as PersonCertification).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PersonCertification).DisplayName = n.GetStringValue(); } },
                {"endDate", (o,n) => { (o as PersonCertification).EndDate = n.GetDateValue(); } },
                {"issuedDate", (o,n) => { (o as PersonCertification).IssuedDate = n.GetDateValue(); } },
                {"issuingAuthority", (o,n) => { (o as PersonCertification).IssuingAuthority = n.GetStringValue(); } },
                {"issuingCompany", (o,n) => { (o as PersonCertification).IssuingCompany = n.GetStringValue(); } },
                {"startDate", (o,n) => { (o as PersonCertification).StartDate = n.GetDateValue(); } },
                {"thumbnailUrl", (o,n) => { (o as PersonCertification).ThumbnailUrl = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as PersonCertification).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("certificationId", CertificationId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteDateValue("issuedDate", IssuedDate);
            writer.WriteStringValue("issuingAuthority", IssuingAuthority);
            writer.WriteStringValue("issuingCompany", IssuingCompany);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
