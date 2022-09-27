using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ZebraFotaConnector : Entity, IParsable {
        /// <summary>Complete account enrollment authorization URL. This corresponds to verification_uri_complete in the Zebra API documentations.</summary>
        public string EnrollmentAuthorizationUrl {
            get { return BackingStore?.Get<string>("enrollmentAuthorizationUrl"); }
            set { BackingStore?.Set("enrollmentAuthorizationUrl", value); }
        }
        /// <summary>Tenant enrollment token from Zebra. The token is used to enroll Zebra devices in the FOTA Service via app config.</summary>
        public string EnrollmentToken {
            get { return BackingStore?.Get<string>("enrollmentToken"); }
            set { BackingStore?.Set("enrollmentToken", value); }
        }
        /// <summary>Flag indicating if required Firmware Over-the-Air (FOTA) Apps have been approved.</summary>
        public bool? FotaAppsApproved {
            get { return BackingStore?.Get<bool?>("fotaAppsApproved"); }
            set { BackingStore?.Set("fotaAppsApproved", value); }
        }
        /// <summary>Date and time when the account was last synched with Zebra</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>Represents various states for Zebra FOTA connector.</summary>
        public ZebraFotaConnectorState? State {
            get { return BackingStore?.Get<ZebraFotaConnectorState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new ZebraFotaConnector and sets the default values.
        /// </summary>
        public ZebraFotaConnector() : base() {
            OdataType = "#microsoft.graph.zebraFotaConnector";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ZebraFotaConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ZebraFotaConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enrollmentAuthorizationUrl", n => { EnrollmentAuthorizationUrl = n.GetStringValue(); } },
                {"enrollmentToken", n => { EnrollmentToken = n.GetStringValue(); } },
                {"fotaAppsApproved", n => { FotaAppsApproved = n.GetBoolValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", n => { State = n.GetEnumValue<ZebraFotaConnectorState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("enrollmentAuthorizationUrl", EnrollmentAuthorizationUrl);
            writer.WriteStringValue("enrollmentToken", EnrollmentToken);
            writer.WriteBoolValue("fotaAppsApproved", FotaAppsApproved);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<ZebraFotaConnectorState>("state", State);
        }
    }
}
