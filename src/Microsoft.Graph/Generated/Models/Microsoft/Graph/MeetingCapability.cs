using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class MeetingCapability : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether anonymous users dialout is allowed in a meeting.</summary>
        public bool? AllowAnonymousUsersToDialOut { get; set; }
        /// <summary>Indicates whether anonymous users are allowed to start a meeting.</summary>
        public bool? AllowAnonymousUsersToStartMeeting { get; set; }
        /// <summary>Possible values are: everyoneInCompany, everyone.</summary>
        public AutoAdmittedUsersType? AutoAdmittedUsers { get; set; }
        /// <summary>
        /// Instantiates a new meetingCapability and sets the default values.
        /// </summary>
        public MeetingCapability() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowAnonymousUsersToDialOut", (o,n) => { (o as MeetingCapability).AllowAnonymousUsersToDialOut = n.GetBoolValue(); } },
                {"allowAnonymousUsersToStartMeeting", (o,n) => { (o as MeetingCapability).AllowAnonymousUsersToStartMeeting = n.GetBoolValue(); } },
                {"autoAdmittedUsers", (o,n) => { (o as MeetingCapability).AutoAdmittedUsers = n.GetEnumValue<AutoAdmittedUsersType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAnonymousUsersToDialOut", AllowAnonymousUsersToDialOut);
            writer.WriteBoolValue("allowAnonymousUsersToStartMeeting", AllowAnonymousUsersToStartMeeting);
            writer.WriteEnumValue<AutoAdmittedUsersType>("autoAdmittedUsers", AutoAdmittedUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
