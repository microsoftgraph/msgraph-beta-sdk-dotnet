using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public class PstnOnlineMeetingDialoutReport : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency {
            get { return BackingStore?.Get<string?>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#nullable restore
#else
        public string Currency {
            get { return BackingStore?.Get<string>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#endif
        /// <summary>The destinationContext property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationContext {
            get { return BackingStore?.Get<string?>("destinationContext"); }
            set { BackingStore?.Set("destinationContext", value); }
        }
#nullable restore
#else
        public string DestinationContext {
            get { return BackingStore?.Get<string>("destinationContext"); }
            set { BackingStore?.Set("destinationContext", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The totalCallCharge property</summary>
        public decimal? TotalCallCharge {
            get { return BackingStore?.Get<decimal?>("totalCallCharge"); }
            set { BackingStore?.Set("totalCallCharge", value); }
        }
        /// <summary>The totalCalls property</summary>
        public int? TotalCalls {
            get { return BackingStore?.Get<int?>("totalCalls"); }
            set { BackingStore?.Set("totalCalls", value); }
        }
        /// <summary>The totalCallSeconds property</summary>
        public int? TotalCallSeconds {
            get { return BackingStore?.Get<int?>("totalCallSeconds"); }
            set { BackingStore?.Set("totalCallSeconds", value); }
        }
        /// <summary>The usageLocation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UsageLocation {
            get { return BackingStore?.Get<string?>("usageLocation"); }
            set { BackingStore?.Set("usageLocation", value); }
        }
#nullable restore
#else
        public string UsageLocation {
            get { return BackingStore?.Get<string>("usageLocation"); }
            set { BackingStore?.Set("usageLocation", value); }
        }
#endif
        /// <summary>The userDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>The userId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>The userPrincipalName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new pstnOnlineMeetingDialoutReport and sets the default values.
        /// </summary>
        public PstnOnlineMeetingDialoutReport() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PstnOnlineMeetingDialoutReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PstnOnlineMeetingDialoutReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"currency", n => { Currency = n.GetStringValue(); } },
                {"destinationContext", n => { DestinationContext = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"totalCallCharge", n => { TotalCallCharge = n.GetDecimalValue(); } },
                {"totalCalls", n => { TotalCalls = n.GetIntValue(); } },
                {"totalCallSeconds", n => { TotalCallSeconds = n.GetIntValue(); } },
                {"usageLocation", n => { UsageLocation = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("destinationContext", DestinationContext);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDecimalValue("totalCallCharge", TotalCallCharge);
            writer.WriteIntValue("totalCalls", TotalCalls);
            writer.WriteIntValue("totalCallSeconds", TotalCallSeconds);
            writer.WriteStringValue("usageLocation", UsageLocation);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
