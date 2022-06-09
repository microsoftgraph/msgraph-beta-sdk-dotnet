using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosVppEBook : ManagedEBook, IParsable {
        /// <summary>The Apple ID associated with Vpp token.</summary>
        public string AppleId {
            get { return BackingStore?.Get<string>(nameof(AppleId)); }
            set { BackingStore?.Set(nameof(AppleId), value); }
        }
        /// <summary>Genres.</summary>
        public List<string> Genres {
            get { return BackingStore?.Get<List<string>>(nameof(Genres)); }
            set { BackingStore?.Set(nameof(Genres), value); }
        }
        /// <summary>Language.</summary>
        public string Language {
            get { return BackingStore?.Get<string>(nameof(Language)); }
            set { BackingStore?.Set(nameof(Language), value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>Seller.</summary>
        public string Seller {
            get { return BackingStore?.Get<string>(nameof(Seller)); }
            set { BackingStore?.Set(nameof(Seller), value); }
        }
        /// <summary>Total license count.</summary>
        public int? TotalLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(TotalLicenseCount)); }
            set { BackingStore?.Set(nameof(TotalLicenseCount), value); }
        }
        /// <summary>Used license count.</summary>
        public int? UsedLicenseCount {
            get { return BackingStore?.Get<int?>(nameof(UsedLicenseCount)); }
            set { BackingStore?.Set(nameof(UsedLicenseCount), value); }
        }
        /// <summary>The Vpp token&apos;s organization name.</summary>
        public string VppOrganizationName {
            get { return BackingStore?.Get<string>(nameof(VppOrganizationName)); }
            set { BackingStore?.Set(nameof(VppOrganizationName), value); }
        }
        /// <summary>The Vpp token ID.</summary>
        public string VppTokenId {
            get { return BackingStore?.Get<string>(nameof(VppTokenId)); }
            set { BackingStore?.Set(nameof(VppTokenId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosVppEBook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVppEBook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"genres", n => { Genres = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"seller", n => { Seller = n.GetStringValue(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppOrganizationName", n => { VppOrganizationName = n.GetStringValue(); } },
                {"vppTokenId", n => { VppTokenId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteCollectionOfPrimitiveValues<string>("genres", Genres);
            writer.WriteStringValue("language", Language);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteStringValue("seller", Seller);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteStringValue("vppOrganizationName", VppOrganizationName);
            writer.WriteStringValue("vppTokenId", VppTokenId);
        }
    }
}
