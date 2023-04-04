using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualAppointment : Entity, IParsable {
        /// <summary>The join web URL of the virtual appointment for clients with waiting room and browser join. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppointmentClientJoinWebUrl {
            get { return BackingStore?.Get<string?>("appointmentClientJoinWebUrl"); }
            set { BackingStore?.Set("appointmentClientJoinWebUrl", value); }
        }
#nullable restore
#else
        public string AppointmentClientJoinWebUrl {
            get { return BackingStore?.Get<string>("appointmentClientJoinWebUrl"); }
            set { BackingStore?.Set("appointmentClientJoinWebUrl", value); }
        }
#endif
        /// <summary>The client information for the virtual appointment, including name, email, and SMS phone number. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VirtualAppointmentUser>? AppointmentClients {
            get { return BackingStore?.Get<List<VirtualAppointmentUser>?>("appointmentClients"); }
            set { BackingStore?.Set("appointmentClients", value); }
        }
#nullable restore
#else
        public List<VirtualAppointmentUser> AppointmentClients {
            get { return BackingStore?.Get<List<VirtualAppointmentUser>>("appointmentClients"); }
            set { BackingStore?.Set("appointmentClients", value); }
        }
#endif
        /// <summary>The identifier of the appointment from the scheduling system, associated with the current virtual appointment. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalAppointmentId {
            get { return BackingStore?.Get<string?>("externalAppointmentId"); }
            set { BackingStore?.Set("externalAppointmentId", value); }
        }
#nullable restore
#else
        public string ExternalAppointmentId {
            get { return BackingStore?.Get<string>("externalAppointmentId"); }
            set { BackingStore?.Set("externalAppointmentId", value); }
        }
#endif
        /// <summary>The URL of the appointment resource from the scheduling system, associated with the current virtual appointment. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalAppointmentUrl {
            get { return BackingStore?.Get<string?>("externalAppointmentUrl"); }
            set { BackingStore?.Set("externalAppointmentUrl", value); }
        }
#nullable restore
#else
        public string ExternalAppointmentUrl {
            get { return BackingStore?.Get<string>("externalAppointmentUrl"); }
            set { BackingStore?.Set("externalAppointmentUrl", value); }
        }
#endif
        /// <summary>The settings associated with the virtual appointment resource. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VirtualAppointmentSettings? Settings {
            get { return BackingStore?.Get<VirtualAppointmentSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public VirtualAppointmentSettings Settings {
            get { return BackingStore?.Get<VirtualAppointmentSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualAppointment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualAppointment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appointmentClientJoinWebUrl", n => { AppointmentClientJoinWebUrl = n.GetStringValue(); } },
                {"appointmentClients", n => { AppointmentClients = n.GetCollectionOfObjectValues<VirtualAppointmentUser>(VirtualAppointmentUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalAppointmentId", n => { ExternalAppointmentId = n.GetStringValue(); } },
                {"externalAppointmentUrl", n => { ExternalAppointmentUrl = n.GetStringValue(); } },
                {"settings", n => { Settings = n.GetObjectValue<VirtualAppointmentSettings>(VirtualAppointmentSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appointmentClientJoinWebUrl", AppointmentClientJoinWebUrl);
            writer.WriteCollectionOfObjectValues<VirtualAppointmentUser>("appointmentClients", AppointmentClients);
            writer.WriteStringValue("externalAppointmentId", ExternalAppointmentId);
            writer.WriteStringValue("externalAppointmentUrl", ExternalAppointmentUrl);
            writer.WriteObjectValue<VirtualAppointmentSettings>("settings", Settings);
        }
    }
}
