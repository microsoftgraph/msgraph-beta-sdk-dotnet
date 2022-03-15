using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class Quota : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total space consumed by files in the recycle bin, in bytes. Read-only.</summary>
        public int? Deleted { get; set; }
        /// <summary>Total space remaining before reaching the quota limit, in bytes. Read-only.</summary>
        public int? Remaining { get; set; }
        /// <summary>Enumeration value that indicates the state of the storage space. Read-only.</summary>
        public string State { get; set; }
        /// <summary>Information about the drive's storage quota plans. Only in Personal OneDrive.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.StoragePlanInformation StoragePlanInformation { get; set; }
        /// <summary>Total allowed storage space, in bytes. Read-only.</summary>
        public int? Total { get; set; }
        /// <summary>Total space used, in bytes. Read-only.</summary>
        public int? Used { get; set; }
        /// <summary>
        /// Instantiates a new quota and sets the default values.
        /// </summary>
        public Quota() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Quota CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Quota();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deleted", (o,n) => { (o as Quota).Deleted = n.GetIntValue(); } },
                {"remaining", (o,n) => { (o as Quota).Remaining = n.GetIntValue(); } },
                {"state", (o,n) => { (o as Quota).State = n.GetStringValue(); } },
                {"storagePlanInformation", (o,n) => { (o as Quota).StoragePlanInformation = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.StoragePlanInformation>(MicrosoftGraphSdk.Models.Microsoft.Graph.StoragePlanInformation.CreateFromDiscriminatorValue); } },
                {"total", (o,n) => { (o as Quota).Total = n.GetIntValue(); } },
                {"used", (o,n) => { (o as Quota).Used = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deleted", Deleted);
            writer.WriteIntValue("remaining", Remaining);
            writer.WriteStringValue("state", State);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.StoragePlanInformation>("storagePlanInformation", StoragePlanInformation);
            writer.WriteIntValue("total", Total);
            writer.WriteIntValue("used", Used);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
