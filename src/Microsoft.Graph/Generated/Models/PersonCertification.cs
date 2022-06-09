using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PersonCertification : ItemFacet, IParsable {
        /// <summary>The referenceable identifier for the certification.</summary>
        public string CertificationId {
            get { return BackingStore?.Get<string>(nameof(CertificationId)); }
            set { BackingStore?.Set(nameof(CertificationId), value); }
        }
        /// <summary>Description of the certification.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Title of the certification.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The date that the certification expires.</summary>
        public Date? EndDate {
            get { return BackingStore?.Get<Date?>(nameof(EndDate)); }
            set { BackingStore?.Set(nameof(EndDate), value); }
        }
        /// <summary>The date that the certification was issued.</summary>
        public Date? IssuedDate {
            get { return BackingStore?.Get<Date?>(nameof(IssuedDate)); }
            set { BackingStore?.Set(nameof(IssuedDate), value); }
        }
        /// <summary>Authority which granted the certification.</summary>
        public string IssuingAuthority {
            get { return BackingStore?.Get<string>(nameof(IssuingAuthority)); }
            set { BackingStore?.Set(nameof(IssuingAuthority), value); }
        }
        /// <summary>Company which granted the certification.</summary>
        public string IssuingCompany {
            get { return BackingStore?.Get<string>(nameof(IssuingCompany)); }
            set { BackingStore?.Set(nameof(IssuingCompany), value); }
        }
        /// <summary>The date that the certification became valid.</summary>
        public Date? StartDate {
            get { return BackingStore?.Get<Date?>(nameof(StartDate)); }
            set { BackingStore?.Set(nameof(StartDate), value); }
        }
        /// <summary>URL referencing a thumbnail of the certification.</summary>
        public string ThumbnailUrl {
            get { return BackingStore?.Get<string>(nameof(ThumbnailUrl)); }
            set { BackingStore?.Set(nameof(ThumbnailUrl), value); }
        }
        /// <summary>URL referencing the certification.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>(nameof(WebUrl)); }
            set { BackingStore?.Set(nameof(WebUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PersonCertification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonCertification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificationId", n => { CertificationId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endDate", n => { EndDate = n.GetDateValue(); } },
                {"issuedDate", n => { IssuedDate = n.GetDateValue(); } },
                {"issuingAuthority", n => { IssuingAuthority = n.GetStringValue(); } },
                {"issuingCompany", n => { IssuingCompany = n.GetStringValue(); } },
                {"startDate", n => { StartDate = n.GetDateValue(); } },
                {"thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
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
