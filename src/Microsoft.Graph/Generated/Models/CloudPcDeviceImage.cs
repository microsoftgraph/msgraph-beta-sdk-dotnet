using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcDeviceImage : Entity, IParsable {
        /// <summary>The display name of the image.</summary>
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
        /// <summary>The date the image became unavailable.</summary>
        public Date? ExpirationDate {
            get { return BackingStore?.Get<Date?>("expirationDate"); }
            set { BackingStore?.Set("expirationDate", value); }
        }
        /// <summary>The data and time that the image was last modified. The time is shown in ISO 8601 format and  Coordinated Universal Time (UTC) time. For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The operating system of the image. For example, Windows 10 Enterprise.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>The OS build version of the image. For example, 1909.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsBuildNumber {
            get { return BackingStore?.Get<string?>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
#nullable restore
#else
        public string OsBuildNumber {
            get { return BackingStore?.Get<string>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
#endif
        /// <summary>The OS status of this image. Possible values are: supported, supportedWithWarning, unknownFutureValue.</summary>
        public CloudPcDeviceImageOsStatus? OsStatus {
            get { return BackingStore?.Get<CloudPcDeviceImageOsStatus?>("osStatus"); }
            set { BackingStore?.Set("osStatus", value); }
        }
        /// <summary>The ID of the source image resource on Azure. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceImageResourceId {
            get { return BackingStore?.Get<string?>("sourceImageResourceId"); }
            set { BackingStore?.Set("sourceImageResourceId", value); }
        }
#nullable restore
#else
        public string SourceImageResourceId {
            get { return BackingStore?.Get<string>("sourceImageResourceId"); }
            set { BackingStore?.Set("sourceImageResourceId", value); }
        }
#endif
        /// <summary>The status of the image on Cloud PC. Possible values are: pending, ready, failed.</summary>
        public CloudPcDeviceImageStatus? Status {
            get { return BackingStore?.Get<CloudPcDeviceImageStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The details of the status of the image that indicates why the upload failed, if applicable. Possible values are: internalServerError, sourceImageNotFound, osVersionNotSupported, sourceImageInvalid, and sourceImageNotGeneralized.</summary>
        public CloudPcDeviceImageStatusDetails? StatusDetails {
            get { return BackingStore?.Get<CloudPcDeviceImageStatusDetails?>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
        /// <summary>The image version. For example, 0.0.1 and 1.5.13.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcDeviceImage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcDeviceImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                {"osStatus", n => { OsStatus = n.GetEnumValue<CloudPcDeviceImageOsStatus>(); } },
                {"sourceImageResourceId", n => { SourceImageResourceId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcDeviceImageStatus>(); } },
                {"statusDetails", n => { StatusDetails = n.GetEnumValue<CloudPcDeviceImageStatusDetails>(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteEnumValue<CloudPcDeviceImageOsStatus>("osStatus", OsStatus);
            writer.WriteStringValue("sourceImageResourceId", SourceImageResourceId);
            writer.WriteEnumValue<CloudPcDeviceImageStatus>("status", Status);
            writer.WriteEnumValue<CloudPcDeviceImageStatusDetails>("statusDetails", StatusDetails);
            writer.WriteStringValue("version", Version);
        }
    }
}
