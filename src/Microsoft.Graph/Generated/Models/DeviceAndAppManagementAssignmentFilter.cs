using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A class containing the properties used for Assignment Filter.
    /// </summary>
    public class DeviceAndAppManagementAssignmentFilter : Entity, IParsable {
        /// <summary>Creation time of the Assignment Filter.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the Assignment Filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>DisplayName of the Assignment Filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Last modified time of the Assignment Filter.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Associated assignments for a specific filter</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayloadByFilter>? Payloads {
            get { return BackingStore?.Get<List<PayloadByFilter>?>("payloads"); }
            set { BackingStore?.Set("payloads", value); }
        }
#nullable restore
#else
        public List<PayloadByFilter> Payloads {
            get { return BackingStore?.Get<List<PayloadByFilter>>("payloads"); }
            set { BackingStore?.Set("payloads", value); }
        }
#endif
        /// <summary>Supported platform types.</summary>
        public DevicePlatformType? Platform {
            get { return BackingStore?.Get<DevicePlatformType?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>RoleScopeTags of the Assignment Filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTags {
            get { return BackingStore?.Get<List<string>?>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTags {
            get { return BackingStore?.Get<List<string>>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
#endif
        /// <summary>Rule definition of the Assignment Filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rule {
            get { return BackingStore?.Get<string?>("rule"); }
            set { BackingStore?.Set("rule", value); }
        }
#nullable restore
#else
        public string Rule {
            get { return BackingStore?.Get<string>("rule"); }
            set { BackingStore?.Set("rule", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceAndAppManagementAssignmentFilter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.payloadCompatibleAssignmentFilter" => new PayloadCompatibleAssignmentFilter(),
                _ => new DeviceAndAppManagementAssignmentFilter(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"payloads", n => { Payloads = n.GetCollectionOfObjectValues<PayloadByFilter>(PayloadByFilter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"platform", n => { Platform = n.GetEnumValue<DevicePlatformType>(); } },
                {"roleScopeTags", n => { RoleScopeTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"rule", n => { Rule = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<PayloadByFilter>("payloads", Payloads);
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTags", RoleScopeTags);
            writer.WriteStringValue("rule", Rule);
        }
    }
}
