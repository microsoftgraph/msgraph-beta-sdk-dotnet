// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedAppRegistration : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The app package Identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MobileAppIdentifier? AppIdentifier
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppIdentifier?>("appIdentifier"); }
            set { BackingStore?.Set("appIdentifier", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MobileAppIdentifier AppIdentifier
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppIdentifier>("appIdentifier"); }
            set { BackingStore?.Set("appIdentifier", value); }
        }
#endif
        /// <summary>App version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationVersion
        {
            get { return BackingStore?.Get<string?>("applicationVersion"); }
            set { BackingStore?.Set("applicationVersion", value); }
        }
#nullable restore
#else
        public string ApplicationVersion
        {
            get { return BackingStore?.Get<string>("applicationVersion"); }
            set { BackingStore?.Set("applicationVersion", value); }
        }
#endif
        /// <summary>Zero or more policys already applied on the registered app when it last synchronized with managment service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>? AppliedPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>?>("appliedPolicies"); }
            set { BackingStore?.Set("appliedPolicies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy> AppliedPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>>("appliedPolicies"); }
            set { BackingStore?.Set("appliedPolicies", value); }
        }
#endif
        /// <summary>The Azure Active Directory Device identifier of the host device. Value could be empty even when the host device is Azure Active Directory registered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureADDeviceId
        {
            get { return BackingStore?.Get<string?>("azureADDeviceId"); }
            set { BackingStore?.Set("azureADDeviceId", value); }
        }
#nullable restore
#else
        public string AzureADDeviceId
        {
            get { return BackingStore?.Get<string>("azureADDeviceId"); }
            set { BackingStore?.Set("azureADDeviceId", value); }
        }
#endif
        /// <summary>Date and time of creation</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The device manufacturer for the current app registration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceManufacturer
        {
            get { return BackingStore?.Get<string?>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
#nullable restore
#else
        public string DeviceManufacturer
        {
            get { return BackingStore?.Get<string>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
#endif
        /// <summary>The device model for the current app registration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel
        {
            get { return BackingStore?.Get<string?>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#nullable restore
#else
        public string DeviceModel
        {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#endif
        /// <summary>Host device name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName
        {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName
        {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceTag
        {
            get { return BackingStore?.Get<string?>("deviceTag"); }
            set { BackingStore?.Set("deviceTag", value); }
        }
#nullable restore
#else
        public string DeviceTag
        {
            get { return BackingStore?.Get<string>("deviceTag"); }
            set { BackingStore?.Set("deviceTag", value); }
        }
#endif
        /// <summary>Host device type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceType
        {
            get { return BackingStore?.Get<string?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#nullable restore
#else
        public string DeviceType
        {
            get { return BackingStore?.Get<string>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#endif
        /// <summary>Zero or more reasons an app registration is flagged. E.g. app running on rooted device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppFlaggedReason?>? FlaggedReasons
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppFlaggedReason?>?>("flaggedReasons"); }
            set { BackingStore?.Set("flaggedReasons", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppFlaggedReason?> FlaggedReasons
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppFlaggedReason?>>("flaggedReasons"); }
            set { BackingStore?.Set("flaggedReasons", value); }
        }
#endif
        /// <summary>Zero or more policies admin intended for the app as of now.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>? IntendedPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>?>("intendedPolicies"); }
            set { BackingStore?.Set("intendedPolicies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy> IntendedPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>>("intendedPolicies"); }
            set { BackingStore?.Set("intendedPolicies", value); }
        }
#endif
        /// <summary>Date and time of last the app synced with management service.</summary>
        public DateTimeOffset? LastSyncDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>Zero or more log collection requests triggered for the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest>? ManagedAppLogCollectionRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest>?>("managedAppLogCollectionRequests"); }
            set { BackingStore?.Set("managedAppLogCollectionRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest> ManagedAppLogCollectionRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest>>("managedAppLogCollectionRequests"); }
            set { BackingStore?.Set("managedAppLogCollectionRequests", value); }
        }
#endif
        /// <summary>The Managed Device identifier of the host device. Value could be empty even when the host device is managed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId
        {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId
        {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
        /// <summary>App management SDK version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementSdkVersion
        {
            get { return BackingStore?.Get<string?>("managementSdkVersion"); }
            set { BackingStore?.Set("managementSdkVersion", value); }
        }
#nullable restore
#else
        public string ManagementSdkVersion
        {
            get { return BackingStore?.Get<string>("managementSdkVersion"); }
            set { BackingStore?.Set("managementSdkVersion", value); }
        }
#endif
        /// <summary>Zero or more long running operations triggered on the app registration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppOperation>? Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppOperation> Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>Operating System version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlatformVersion
        {
            get { return BackingStore?.Get<string?>("platformVersion"); }
            set { BackingStore?.Set("platformVersion", value); }
        }
#nullable restore
#else
        public string PlatformVersion
        {
            get { return BackingStore?.Get<string>("platformVersion"); }
            set { BackingStore?.Set("platformVersion", value); }
        }
#endif
        /// <summary>The user Id to who this app registration belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>Version of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ManagedAppRegistration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ManagedAppRegistration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedAppRegistration" => new global::Microsoft.Graph.Beta.Models.AndroidManagedAppRegistration(),
                "#microsoft.graph.iosManagedAppRegistration" => new global::Microsoft.Graph.Beta.Models.IosManagedAppRegistration(),
                "#microsoft.graph.windowsManagedAppRegistration" => new global::Microsoft.Graph.Beta.Models.WindowsManagedAppRegistration(),
                _ => new global::Microsoft.Graph.Beta.Models.ManagedAppRegistration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appIdentifier", n => { AppIdentifier = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MobileAppIdentifier>(global::Microsoft.Graph.Beta.Models.MobileAppIdentifier.CreateFromDiscriminatorValue); } },
                { "applicationVersion", n => { ApplicationVersion = n.GetStringValue(); } },
                { "appliedPolicies", n => { AppliedPolicies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>(global::Microsoft.Graph.Beta.Models.ManagedAppPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "azureADDeviceId", n => { AzureADDeviceId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                { "deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "deviceTag", n => { DeviceTag = n.GetStringValue(); } },
                { "deviceType", n => { DeviceType = n.GetStringValue(); } },
                { "flaggedReasons", n => { FlaggedReasons = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.ManagedAppFlaggedReason>()?.AsList(); } },
                { "intendedPolicies", n => { IntendedPolicies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>(global::Microsoft.Graph.Beta.Models.ManagedAppPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "managedAppLogCollectionRequests", n => { ManagedAppLogCollectionRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest>(global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                { "managementSdkVersion", n => { ManagementSdkVersion = n.GetStringValue(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppOperation>(global::Microsoft.Graph.Beta.Models.ManagedAppOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "platformVersion", n => { PlatformVersion = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MobileAppIdentifier>("appIdentifier", AppIdentifier);
            writer.WriteStringValue("applicationVersion", ApplicationVersion);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>("appliedPolicies", AppliedPolicies);
            writer.WriteStringValue("azureADDeviceId", AzureADDeviceId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.ManagedAppFlaggedReason>("flaggedReasons", FlaggedReasons);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppPolicy>("intendedPolicies", IntendedPolicies);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest>("managedAppLogCollectionRequests", ManagedAppLogCollectionRequests);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managementSdkVersion", ManagementSdkVersion);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppOperation>("operations", Operations);
            writer.WriteStringValue("platformVersion", PlatformVersion);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
