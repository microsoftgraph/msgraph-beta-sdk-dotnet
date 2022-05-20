using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the getAzureADLicenseUsage method.</summary>
    public class AzureADLicenseUsage : Entity, IParsable {
        /// <summary>The licenseInfoDetails property</summary>
        public List<LicenseInfoDetail> LicenseInfoDetails {
            get { return BackingStore?.Get<List<LicenseInfoDetail>>(nameof(LicenseInfoDetails)); }
            set { BackingStore?.Set(nameof(LicenseInfoDetails), value); }
        }
        /// <summary>The snapshotDateTime property</summary>
        public DateTimeOffset? SnapshotDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(SnapshotDateTime)); }
            set { BackingStore?.Set(nameof(SnapshotDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AzureADLicenseUsage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureADLicenseUsage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"licenseInfoDetails", n => { LicenseInfoDetails = n.GetCollectionOfObjectValues<LicenseInfoDetail>(LicenseInfoDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"snapshotDateTime", n => { SnapshotDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<LicenseInfoDetail>("licenseInfoDetails", LicenseInfoDetails);
            writer.WriteDateTimeOffsetValue("snapshotDateTime", SnapshotDateTime);
        }
    }
}
