using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.ApproveApps {
    /// <summary>Provides operations to call the approveApps method.</summary>
    public class ApproveAppsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The approveAllPermissions property</summary>
        public bool? ApproveAllPermissions { get; set; }
        /// <summary>The packageIds property</summary>
        public List<string> PackageIds { get; set; }
        /// <summary>
        /// Instantiates a new approveAppsRequestBody and sets the default values.
        /// </summary>
        public ApproveAppsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApproveAppsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApproveAppsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"approveAllPermissions", (o,n) => { (o as ApproveAppsRequestBody).ApproveAllPermissions = n.GetBoolValue(); } },
                {"packageIds", (o,n) => { (o as ApproveAppsRequestBody).PackageIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("approveAllPermissions", ApproveAllPermissions);
            writer.WriteCollectionOfPrimitiveValues<string>("packageIds", PackageIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
