using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcDeviceImage : Entity, IParsable {
        /// <summary>The image&apos;s display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date the image became unavailable.</summary>
        public Date? ExpirationDate { get; set; }
        /// <summary>The data and time that the image was last modified. The time is shown in ISO 8601 format and  Coordinated Universal Time (UTC) time. For example, midnight UTC on Jan 1, 2014 appears as &apos;2014-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The image&apos;s operating system. For example: Windows 10 Enterprise.</summary>
        public string OperatingSystem { get; set; }
        /// <summary>The image&apos;s OS build version. For example: 1909.</summary>
        public string OsBuildNumber { get; set; }
        /// <summary>The OS status of this image. Possible values are: supported, supportedWithWarning, unknownFutureValue.</summary>
        public CloudPcDeviceImageOsStatus? OsStatus { get; set; }
        /// <summary>The ID of the source image resource on Azure. Required format: &apos;/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}&apos;.</summary>
        public string SourceImageResourceId { get; set; }
        /// <summary>The status of the image on Cloud PC. Possible values are: pending, ready, failed.</summary>
        public CloudPcDeviceImageStatus? Status { get; set; }
        /// <summary>The details of the image&apos;s status, which indicates why the upload failed, if applicable. Possible values are: internalServerError, sourceImageNotFound, osVersionNotSupported, sourceImageInvalid, and sourceImageNotGeneralized.</summary>
        public CloudPcDeviceImageStatusDetails? StatusDetails { get; set; }
        /// <summary>The image version. For example: 0.0.1, 1.5.13.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
