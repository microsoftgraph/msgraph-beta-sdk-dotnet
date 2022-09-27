using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsDeviceScope : Entity, IParsable {
        /// <summary>Indicates the creation date and time for the custom device scope.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The name of the user experience analytics device Scope configuration.</summary>
        public string DeviceScopeName {
            get { return BackingStore?.Get<string>("deviceScopeName"); }
            set { BackingStore?.Set("deviceScopeName", value); }
        }
        /// <summary>Indicates whether a device scope is enabled or disabled. When TRUE, the device scope is enabled. When FALSE, the device scope is disabled. Default value is FALSE.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>Indicates whether the device scope configuration is built-in or custom. When TRUE, the device scope configuration is built-in. When FALSE, the device scope configuration is custom. Default value is FALSE.</summary>
        public bool? IsBuiltIn {
            get { return BackingStore?.Get<bool?>("isBuiltIn"); }
            set { BackingStore?.Set("isBuiltIn", value); }
        }
        /// <summary>Indicates the last updated date and time for the custom device scope.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Device scope configuration query operator. Possible values are: equals, notEquals, contains, notContains, greaterThan, lessThan. Default value: equals.</summary>
        public DeviceScopeOperator? Operator {
            get { return BackingStore?.Get<DeviceScopeOperator?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
        /// <summary>The unique identifier of the person (admin) who created the device scope configuration.</summary>
        public string OwnerId {
            get { return BackingStore?.Get<string>("ownerId"); }
            set { BackingStore?.Set("ownerId", value); }
        }
        /// <summary>Device scope configuration parameter. It will be expend in future to add more parameter. Eg: device scope parameter can be OS version, Disk Type, Device manufacturer, device model or Scope tag. Default value: scopeTag.</summary>
        public DeviceScopeParameter? Parameter {
            get { return BackingStore?.Get<DeviceScopeParameter?>("parameter"); }
            set { BackingStore?.Set("parameter", value); }
        }
        /// <summary>Indicates the device scope status after the device scope has been enabled. Possible values are: none, computing, insufficientData or completed. Default value is none.</summary>
        public DeviceScopeStatus? Status {
            get { return BackingStore?.Get<DeviceScopeStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The device scope configuration query clause value.</summary>
        public string Value {
            get { return BackingStore?.Get<string>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>The unique identifier for a user device scope tag Id used for the creation of device scope configuration.</summary>
        public string ValueObjectId {
            get { return BackingStore?.Get<string>("valueObjectId"); }
            set { BackingStore?.Set("valueObjectId", value); }
        }
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsDeviceScope and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsDeviceScope() : base() {
            OdataType = "#microsoft.graph.userExperienceAnalyticsDeviceScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsDeviceScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceScopeName", n => { DeviceScopeName = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operator", n => { Operator = n.GetEnumValue<DeviceScopeOperator>(); } },
                {"ownerId", n => { OwnerId = n.GetStringValue(); } },
                {"parameter", n => { Parameter = n.GetEnumValue<DeviceScopeParameter>(); } },
                {"status", n => { Status = n.GetEnumValue<DeviceScopeStatus>(); } },
                {"value", n => { Value = n.GetStringValue(); } },
                {"valueObjectId", n => { ValueObjectId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceScopeName", DeviceScopeName);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DeviceScopeOperator>("operator", Operator);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteEnumValue<DeviceScopeParameter>("parameter", Parameter);
            writer.WriteEnumValue<DeviceScopeStatus>("status", Status);
            writer.WriteStringValue("value", Value);
            writer.WriteStringValue("valueObjectId", ValueObjectId);
        }
    }
}
