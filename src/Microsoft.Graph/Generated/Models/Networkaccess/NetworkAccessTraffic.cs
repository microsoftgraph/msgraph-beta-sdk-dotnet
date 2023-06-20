using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class NetworkAccessTraffic : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The agentVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgentVersion {
            get { return BackingStore?.Get<string?>("agentVersion"); }
            set { BackingStore?.Set("agentVersion", value); }
        }
#nullable restore
#else
        public string AgentVersion {
            get { return BackingStore?.Get<string>("agentVersion"); }
            set { BackingStore?.Set("agentVersion", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The connectionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionId {
            get { return BackingStore?.Get<string?>("connectionId"); }
            set { BackingStore?.Set("connectionId", value); }
        }
#nullable restore
#else
        public string ConnectionId {
            get { return BackingStore?.Get<string>("connectionId"); }
            set { BackingStore?.Set("connectionId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The destinationFQDN property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationFQDN {
            get { return BackingStore?.Get<string?>("destinationFQDN"); }
            set { BackingStore?.Set("destinationFQDN", value); }
        }
#nullable restore
#else
        public string DestinationFQDN {
            get { return BackingStore?.Get<string>("destinationFQDN"); }
            set { BackingStore?.Set("destinationFQDN", value); }
        }
#endif
        /// <summary>The destinationIp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationIp {
            get { return BackingStore?.Get<string?>("destinationIp"); }
            set { BackingStore?.Set("destinationIp", value); }
        }
#nullable restore
#else
        public string DestinationIp {
            get { return BackingStore?.Get<string>("destinationIp"); }
            set { BackingStore?.Set("destinationIp", value); }
        }
#endif
        /// <summary>The destinationPort property</summary>
        public int? DestinationPort {
            get { return BackingStore?.Get<int?>("destinationPort"); }
            set { BackingStore?.Set("destinationPort", value); }
        }
        /// <summary>The deviceCategory property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.DeviceCategory? DeviceCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.DeviceCategory?>("deviceCategory"); }
            set { BackingStore?.Set("deviceCategory", value); }
        }
        /// <summary>The deviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The deviceOperatingSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceOperatingSystem {
            get { return BackingStore?.Get<string?>("deviceOperatingSystem"); }
            set { BackingStore?.Set("deviceOperatingSystem", value); }
        }
#nullable restore
#else
        public string DeviceOperatingSystem {
            get { return BackingStore?.Get<string>("deviceOperatingSystem"); }
            set { BackingStore?.Set("deviceOperatingSystem", value); }
        }
#endif
        /// <summary>The deviceOperatingSystemVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceOperatingSystemVersion {
            get { return BackingStore?.Get<string?>("deviceOperatingSystemVersion"); }
            set { BackingStore?.Set("deviceOperatingSystemVersion", value); }
        }
#nullable restore
#else
        public string DeviceOperatingSystemVersion {
            get { return BackingStore?.Get<string>("deviceOperatingSystemVersion"); }
            set { BackingStore?.Set("deviceOperatingSystemVersion", value); }
        }
#endif
        /// <summary>The headers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Headers? Headers {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Headers?>("headers"); }
            set { BackingStore?.Set("headers", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Headers Headers {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Headers>("headers"); }
            set { BackingStore?.Set("headers", value); }
        }
#endif
        /// <summary>The networkProtocol property</summary>
        public NetworkingProtocol? NetworkProtocol {
            get { return BackingStore?.Get<NetworkingProtocol?>("networkProtocol"); }
            set { BackingStore?.Set("networkProtocol", value); }
        }
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
        /// <summary>The policyId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId {
            get { return BackingStore?.Get<string?>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#nullable restore
#else
        public string PolicyId {
            get { return BackingStore?.Get<string>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#endif
        /// <summary>The policyRuleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyRuleId {
            get { return BackingStore?.Get<string?>("policyRuleId"); }
            set { BackingStore?.Set("policyRuleId", value); }
        }
#nullable restore
#else
        public string PolicyRuleId {
            get { return BackingStore?.Get<string>("policyRuleId"); }
            set { BackingStore?.Set("policyRuleId", value); }
        }
#endif
        /// <summary>The receivedBytes property</summary>
        public long? ReceivedBytes {
            get { return BackingStore?.Get<long?>("receivedBytes"); }
            set { BackingStore?.Set("receivedBytes", value); }
        }
        /// <summary>The sentBytes property</summary>
        public long? SentBytes {
            get { return BackingStore?.Get<long?>("sentBytes"); }
            set { BackingStore?.Set("sentBytes", value); }
        }
        /// <summary>The sessionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionId {
            get { return BackingStore?.Get<string?>("sessionId"); }
            set { BackingStore?.Set("sessionId", value); }
        }
#nullable restore
#else
        public string SessionId {
            get { return BackingStore?.Get<string>("sessionId"); }
            set { BackingStore?.Set("sessionId", value); }
        }
#endif
        /// <summary>The sourceIp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceIp {
            get { return BackingStore?.Get<string?>("sourceIp"); }
            set { BackingStore?.Set("sourceIp", value); }
        }
#nullable restore
#else
        public string SourceIp {
            get { return BackingStore?.Get<string>("sourceIp"); }
            set { BackingStore?.Set("sourceIp", value); }
        }
#endif
        /// <summary>The sourcePort property</summary>
        public int? SourcePort {
            get { return BackingStore?.Get<int?>("sourcePort"); }
            set { BackingStore?.Set("sourcePort", value); }
        }
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The trafficType property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.TrafficType? TrafficType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TrafficType?>("trafficType"); }
            set { BackingStore?.Set("trafficType", value); }
        }
        /// <summary>The transactionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionId {
            get { return BackingStore?.Get<string?>("transactionId"); }
            set { BackingStore?.Set("transactionId", value); }
        }
#nullable restore
#else
        public string TransactionId {
            get { return BackingStore?.Get<string>("transactionId"); }
            set { BackingStore?.Set("transactionId", value); }
        }
#endif
        /// <summary>The transportProtocol property</summary>
        public NetworkingProtocol? TransportProtocol {
            get { return BackingStore?.Get<NetworkingProtocol?>("transportProtocol"); }
            set { BackingStore?.Set("transportProtocol", value); }
        }
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
        /// Instantiates a new NetworkAccessTraffic and sets the default values.
        /// </summary>
        public NetworkAccessTraffic() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NetworkAccessTraffic CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkAccessTraffic();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"agentVersion", n => { AgentVersion = n.GetStringValue(); } },
                {"connectionId", n => { ConnectionId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"destinationFQDN", n => { DestinationFQDN = n.GetStringValue(); } },
                {"destinationIp", n => { DestinationIp = n.GetStringValue(); } },
                {"destinationPort", n => { DestinationPort = n.GetIntValue(); } },
                {"deviceCategory", n => { DeviceCategory = n.GetEnumValue<DeviceCategory>(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceOperatingSystem", n => { DeviceOperatingSystem = n.GetStringValue(); } },
                {"deviceOperatingSystemVersion", n => { DeviceOperatingSystemVersion = n.GetStringValue(); } },
                {"headers", n => { Headers = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Headers>(Microsoft.Graph.Beta.Models.Networkaccess.Headers.CreateFromDiscriminatorValue); } },
                {"networkProtocol", n => { NetworkProtocol = n.GetEnumValue<NetworkingProtocol>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"policyId", n => { PolicyId = n.GetStringValue(); } },
                {"policyRuleId", n => { PolicyRuleId = n.GetStringValue(); } },
                {"receivedBytes", n => { ReceivedBytes = n.GetLongValue(); } },
                {"sentBytes", n => { SentBytes = n.GetLongValue(); } },
                {"sessionId", n => { SessionId = n.GetStringValue(); } },
                {"sourceIp", n => { SourceIp = n.GetStringValue(); } },
                {"sourcePort", n => { SourcePort = n.GetIntValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"trafficType", n => { TrafficType = n.GetEnumValue<TrafficType>(); } },
                {"transactionId", n => { TransactionId = n.GetStringValue(); } },
                {"transportProtocol", n => { TransportProtocol = n.GetEnumValue<NetworkingProtocol>(); } },
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
            writer.WriteStringValue("agentVersion", AgentVersion);
            writer.WriteStringValue("connectionId", ConnectionId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("destinationFQDN", DestinationFQDN);
            writer.WriteStringValue("destinationIp", DestinationIp);
            writer.WriteIntValue("destinationPort", DestinationPort);
            writer.WriteEnumValue<DeviceCategory>("deviceCategory", DeviceCategory);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceOperatingSystem", DeviceOperatingSystem);
            writer.WriteStringValue("deviceOperatingSystemVersion", DeviceOperatingSystemVersion);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Headers>("headers", Headers);
            writer.WriteEnumValue<NetworkingProtocol>("networkProtocol", NetworkProtocol);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyRuleId", PolicyRuleId);
            writer.WriteLongValue("receivedBytes", ReceivedBytes);
            writer.WriteLongValue("sentBytes", SentBytes);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteStringValue("sourceIp", SourceIp);
            writer.WriteIntValue("sourcePort", SourcePort);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteEnumValue<TrafficType>("trafficType", TrafficType);
            writer.WriteStringValue("transactionId", TransactionId);
            writer.WriteEnumValue<NetworkingProtocol>("transportProtocol", TransportProtocol);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
