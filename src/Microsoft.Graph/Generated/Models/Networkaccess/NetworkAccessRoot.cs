using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class NetworkAccessRoot : Entity, IParsable {
        /// <summary>The connectivity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Connectivity? Connectivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Connectivity?>("connectivity"); }
            set { BackingStore?.Set("connectivity", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Connectivity Connectivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Connectivity>("connectivity"); }
            set { BackingStore?.Set("connectivity", value); }
        }
#endif
        /// <summary>The forwardingPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ForwardingPolicy>? ForwardingPolicies {
            get { return BackingStore?.Get<List<ForwardingPolicy>?>("forwardingPolicies"); }
            set { BackingStore?.Set("forwardingPolicies", value); }
        }
#nullable restore
#else
        public List<ForwardingPolicy> ForwardingPolicies {
            get { return BackingStore?.Get<List<ForwardingPolicy>>("forwardingPolicies"); }
            set { BackingStore?.Set("forwardingPolicies", value); }
        }
#endif
        /// <summary>The forwardingProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ForwardingProfile>? ForwardingProfiles {
            get { return BackingStore?.Get<List<ForwardingProfile>?>("forwardingProfiles"); }
            set { BackingStore?.Set("forwardingProfiles", value); }
        }
#nullable restore
#else
        public List<ForwardingProfile> ForwardingProfiles {
            get { return BackingStore?.Get<List<ForwardingProfile>>("forwardingProfiles"); }
            set { BackingStore?.Set("forwardingProfiles", value); }
        }
#endif
        /// <summary>The logs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Logs? Logs {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Logs?>("logs"); }
            set { BackingStore?.Set("logs", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Logs Logs {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Logs>("logs"); }
            set { BackingStore?.Set("logs", value); }
        }
#endif
        /// <summary>The reports property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Reports? Reports {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Reports?>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Reports Reports {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Reports>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Settings? Settings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Settings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Settings Settings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Settings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>The tenantStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus? TenantStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus?>("tenantStatus"); }
            set { BackingStore?.Set("tenantStatus", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus TenantStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus>("tenantStatus"); }
            set { BackingStore?.Set("tenantStatus", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new NetworkAccessRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkAccessRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectivity", n => { Connectivity = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Connectivity>(Microsoft.Graph.Beta.Models.Networkaccess.Connectivity.CreateFromDiscriminatorValue); } },
                {"forwardingPolicies", n => { ForwardingPolicies = n.GetCollectionOfObjectValues<ForwardingPolicy>(ForwardingPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"forwardingProfiles", n => { ForwardingProfiles = n.GetCollectionOfObjectValues<ForwardingProfile>(ForwardingProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"logs", n => { Logs = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Logs>(Microsoft.Graph.Beta.Models.Networkaccess.Logs.CreateFromDiscriminatorValue); } },
                {"reports", n => { Reports = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Reports>(Microsoft.Graph.Beta.Models.Networkaccess.Reports.CreateFromDiscriminatorValue); } },
                {"settings", n => { Settings = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Settings>(Microsoft.Graph.Beta.Models.Networkaccess.Settings.CreateFromDiscriminatorValue); } },
                {"tenantStatus", n => { TenantStatus = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus>(Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Connectivity>("connectivity", Connectivity);
            writer.WriteCollectionOfObjectValues<ForwardingPolicy>("forwardingPolicies", ForwardingPolicies);
            writer.WriteCollectionOfObjectValues<ForwardingProfile>("forwardingProfiles", ForwardingProfiles);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Logs>("logs", Logs);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Reports>("reports", Reports);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Settings>("settings", Settings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus>("tenantStatus", TenantStatus);
        }
    }
}
