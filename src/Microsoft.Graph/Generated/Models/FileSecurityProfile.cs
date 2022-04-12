using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class FileSecurityProfile : Entity, IParsable {
        /// <summary>The activityGroupNames property</summary>
        public List<string> ActivityGroupNames { get; set; }
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId { get; set; }
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId { get; set; }
        /// <summary>The certificateThumbprint property</summary>
        public string CertificateThumbprint { get; set; }
        /// <summary>The extensions property</summary>
        public List<string> Extensions { get; set; }
        /// <summary>The fileType property</summary>
        public string FileType { get; set; }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>The hashes property</summary>
        public List<FileHash> Hashes { get; set; }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>The malwareStates property</summary>
        public List<MalwareState> MalwareStates { get; set; }
        /// <summary>The names property</summary>
        public List<string> Names { get; set; }
        /// <summary>The riskScore property</summary>
        public string RiskScore { get; set; }
        /// <summary>The size property</summary>
        public long? Size { get; set; }
        /// <summary>The tags property</summary>
        public List<string> Tags { get; set; }
        /// <summary>The vendorInformation property</summary>
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>The vulnerabilityStates property</summary>
        public List<VulnerabilityState> VulnerabilityStates { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new FileSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityGroupNames", n => { ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"certificateThumbprint", n => { CertificateThumbprint = n.GetStringValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fileType", n => { FileType = n.GetStringValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"hashes", n => { Hashes = n.GetCollectionOfObjectValues<FileHash>(FileHash.CreateFromDiscriminatorValue).ToList(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareStates", n => { MalwareStates = n.GetCollectionOfObjectValues<MalwareState>(MalwareState.CreateFromDiscriminatorValue).ToList(); } },
                {"names", n => { Names = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
                {"vulnerabilityStates", n => { VulnerabilityStates = n.GetCollectionOfObjectValues<VulnerabilityState>(VulnerabilityState.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("activityGroupNames", ActivityGroupNames);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteStringValue("certificateThumbprint", CertificateThumbprint);
            writer.WriteCollectionOfPrimitiveValues<string>("extensions", Extensions);
            writer.WriteStringValue("fileType", FileType);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteCollectionOfObjectValues<FileHash>("hashes", Hashes);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteCollectionOfObjectValues<MalwareState>("malwareStates", MalwareStates);
            writer.WriteCollectionOfPrimitiveValues<string>("names", Names);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteLongValue("size", Size);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
            writer.WriteCollectionOfObjectValues<VulnerabilityState>("vulnerabilityStates", VulnerabilityStates);
        }
    }
}
