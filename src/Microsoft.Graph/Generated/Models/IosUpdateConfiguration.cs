// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// IOS Update Configuration, allows you to configure time window within week to install iOS updates
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosUpdateConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Active Hours End (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursEnd
        {
            get { return BackingStore?.Get<Time?>("activeHoursEnd"); }
            set { BackingStore?.Set("activeHoursEnd", value); }
        }
        /// <summary>Active Hours Start (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursStart
        {
            get { return BackingStore?.Get<Time?>("activeHoursStart"); }
            set { BackingStore?.Set("activeHoursStart", value); }
        }
        /// <summary>If update schedule type is set to use time window scheduling, custom time windows when updates will be scheduled. This collection can contain a maximum of 20 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CustomUpdateTimeWindow>? CustomUpdateTimeWindows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomUpdateTimeWindow>?>("customUpdateTimeWindows"); }
            set { BackingStore?.Set("customUpdateTimeWindows", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CustomUpdateTimeWindow> CustomUpdateTimeWindows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomUpdateTimeWindow>>("customUpdateTimeWindows"); }
            set { BackingStore?.Set("customUpdateTimeWindows", value); }
        }
#endif
        /// <summary>If left unspecified, devices will update to the latest version of the OS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DesiredOsVersion
        {
            get { return BackingStore?.Get<string?>("desiredOsVersion"); }
            set { BackingStore?.Set("desiredOsVersion", value); }
        }
#nullable restore
#else
        public string DesiredOsVersion
        {
            get { return BackingStore?.Get<string>("desiredOsVersion"); }
            set { BackingStore?.Set("desiredOsVersion", value); }
        }
#endif
        /// <summary>Days before software updates are visible to iOS devices ranging from 0 to 90 inclusive</summary>
        public int? EnforcedSoftwareUpdateDelayInDays
        {
            get { return BackingStore?.Get<int?>("enforcedSoftwareUpdateDelayInDays"); }
            set { BackingStore?.Set("enforcedSoftwareUpdateDelayInDays", value); }
        }
        /// <summary>Is setting enabled in UI</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Days in week for which active hours are configured. This collection can contain a maximum of 7 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DayOfWeekObject?>? ScheduledInstallDays
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DayOfWeekObject?>?>("scheduledInstallDays"); }
            set { BackingStore?.Set("scheduledInstallDays", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DayOfWeekObject?> ScheduledInstallDays
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DayOfWeekObject?>>("scheduledInstallDays"); }
            set { BackingStore?.Set("scheduledInstallDays", value); }
        }
#endif
        /// <summary>Update schedule type for iOS software updates.</summary>
        public global::Microsoft.Graph.Beta.Models.IosSoftwareUpdateScheduleType? UpdateScheduleType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IosSoftwareUpdateScheduleType?>("updateScheduleType"); }
            set { BackingStore?.Set("updateScheduleType", value); }
        }
        /// <summary>UTC Time Offset indicated in minutes</summary>
        public int? UtcTimeOffsetInMinutes
        {
            get { return BackingStore?.Get<int?>("utcTimeOffsetInMinutes"); }
            set { BackingStore?.Set("utcTimeOffsetInMinutes", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IosUpdateConfiguration"/> and sets the default values.
        /// </summary>
        public IosUpdateConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosUpdateConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IosUpdateConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IosUpdateConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IosUpdateConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeHoursEnd", n => { ActiveHoursEnd = n.GetTimeValue(); } },
                { "activeHoursStart", n => { ActiveHoursStart = n.GetTimeValue(); } },
                { "customUpdateTimeWindows", n => { CustomUpdateTimeWindows = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomUpdateTimeWindow>(global::Microsoft.Graph.Beta.Models.CustomUpdateTimeWindow.CreateFromDiscriminatorValue)?.AsList(); } },
                { "desiredOsVersion", n => { DesiredOsVersion = n.GetStringValue(); } },
                { "enforcedSoftwareUpdateDelayInDays", n => { EnforcedSoftwareUpdateDelayInDays = n.GetIntValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "scheduledInstallDays", n => { ScheduledInstallDays = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.DayOfWeekObject>()?.AsList(); } },
                { "updateScheduleType", n => { UpdateScheduleType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.IosSoftwareUpdateScheduleType>(); } },
                { "utcTimeOffsetInMinutes", n => { UtcTimeOffsetInMinutes = n.GetIntValue(); } },
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
            writer.WriteTimeValue("activeHoursEnd", ActiveHoursEnd);
            writer.WriteTimeValue("activeHoursStart", ActiveHoursStart);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomUpdateTimeWindow>("customUpdateTimeWindows", CustomUpdateTimeWindows);
            writer.WriteStringValue("desiredOsVersion", DesiredOsVersion);
            writer.WriteIntValue("enforcedSoftwareUpdateDelayInDays", EnforcedSoftwareUpdateDelayInDays);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.DayOfWeekObject>("scheduledInstallDays", ScheduledInstallDays);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.IosSoftwareUpdateScheduleType>("updateScheduleType", UpdateScheduleType);
            writer.WriteIntValue("utcTimeOffsetInMinutes", UtcTimeOffsetInMinutes);
        }
    }
}
#pragma warning restore CS0618
