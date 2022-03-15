using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the fileSecurityProfiles property of the microsoft.graph.security entity.</summary>
    public class FileSecurityProfile : Entity, IParsable {
        public List<string> ActivityGroupNames { get; set; }
        public string AzureSubscriptionId { get; set; }
        public string AzureTenantId { get; set; }
        public string CertificateThumbprint { get; set; }
        public List<string> Extensions { get; set; }
        public string FileType { get; set; }
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        public List<FileHash> Hashes { get; set; }
        public DateTimeOffset? LastSeenDateTime { get; set; }
        public List<MalwareState> MalwareStates { get; set; }
        public List<string> Names { get; set; }
        public string RiskScore { get; set; }
        public int? Size { get; set; }
        public List<string> Tags { get; set; }
        public SecurityVendorInformation VendorInformation { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityGroupNames", (o,n) => { (o as FileSecurityProfile).ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"azureSubscriptionId", (o,n) => { (o as FileSecurityProfile).AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as FileSecurityProfile).AzureTenantId = n.GetStringValue(); } },
                {"certificateThumbprint", (o,n) => { (o as FileSecurityProfile).CertificateThumbprint = n.GetStringValue(); } },
                {"extensions", (o,n) => { (o as FileSecurityProfile).Extensions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fileType", (o,n) => { (o as FileSecurityProfile).FileType = n.GetStringValue(); } },
                {"firstSeenDateTime", (o,n) => { (o as FileSecurityProfile).FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"hashes", (o,n) => { (o as FileSecurityProfile).Hashes = n.GetCollectionOfObjectValues<FileHash>(FileHash.CreateFromDiscriminatorValue).ToList(); } },
                {"lastSeenDateTime", (o,n) => { (o as FileSecurityProfile).LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareStates", (o,n) => { (o as FileSecurityProfile).MalwareStates = n.GetCollectionOfObjectValues<MalwareState>(MalwareState.CreateFromDiscriminatorValue).ToList(); } },
                {"names", (o,n) => { (o as FileSecurityProfile).Names = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"riskScore", (o,n) => { (o as FileSecurityProfile).RiskScore = n.GetStringValue(); } },
                {"size", (o,n) => { (o as FileSecurityProfile).Size = n.GetIntValue(); } },
                {"tags", (o,n) => { (o as FileSecurityProfile).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"vendorInformation", (o,n) => { (o as FileSecurityProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
                {"vulnerabilityStates", (o,n) => { (o as FileSecurityProfile).VulnerabilityStates = n.GetCollectionOfObjectValues<VulnerabilityState>(VulnerabilityState.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteIntValue("size", Size);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
            writer.WriteCollectionOfObjectValues<VulnerabilityState>("vulnerabilityStates", VulnerabilityStates);
        }
    }
}
