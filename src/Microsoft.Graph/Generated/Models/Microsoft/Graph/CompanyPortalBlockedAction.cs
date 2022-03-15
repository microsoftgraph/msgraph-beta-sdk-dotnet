using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class CompanyPortalBlockedAction : IAdditionalDataHolder, IParsable {
        /// <summary>Device Action. Possible values are: unknown, remove, reset.</summary>
        public CompanyPortalAction? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device ownership type. Possible values are: unknown, company, personal.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.OwnerType? OwnerType { get; set; }
        /// <summary>Device OS/Platform. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown.</summary>
        public DevicePlatformType? Platform { get; set; }
        /// <summary>
        /// Instantiates a new companyPortalBlockedAction and sets the default values.
        /// </summary>
        public CompanyPortalBlockedAction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CompanyPortalBlockedAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CompanyPortalBlockedAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"action", (o,n) => { (o as CompanyPortalBlockedAction).Action = n.GetEnumValue<CompanyPortalAction>(); } },
                {"ownerType", (o,n) => { (o as CompanyPortalBlockedAction).OwnerType = n.GetEnumValue<OwnerType>(); } },
                {"platform", (o,n) => { (o as CompanyPortalBlockedAction).Platform = n.GetEnumValue<DevicePlatformType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CompanyPortalAction>("action", Action);
            writer.WriteEnumValue<OwnerType>("ownerType", OwnerType);
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
