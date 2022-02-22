using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class LogonUser : IParsable {
        /// <summary>Domain of user account used to logon.</summary>
        public string AccountDomain { get; set; }
        /// <summary>Account name of user account used to logon.</summary>
        public string AccountName { get; set; }
        /// <summary>User Account type, per Windows definition. Possible values are: unknown, standard, power, administrator.</summary>
        public UserAccountSecurityType? AccountType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>DateTime at which the earliest logon by this user account occurred (provider-determined period). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>DateTime at which the latest logon by this user account occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>User logon ID.</summary>
        public string LogonId { get; set; }
        /// <summary>Collection of the logon types observed for the logged on user from when first to last seen. Possible values are: unknown, interactive, remoteInteractive, network, batch, service.</summary>
        public List<LogonType?> LogonTypes { get; set; }
        /// <summary>
        /// Instantiates a new logonUser and sets the default values.
        /// </summary>
        public LogonUser() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accountDomain", (o,n) => { (o as LogonUser).AccountDomain = n.GetStringValue(); } },
                {"accountName", (o,n) => { (o as LogonUser).AccountName = n.GetStringValue(); } },
                {"accountType", (o,n) => { (o as LogonUser).AccountType = n.GetEnumValue<UserAccountSecurityType>(); } },
                {"firstSeenDateTime", (o,n) => { (o as LogonUser).FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSeenDateTime", (o,n) => { (o as LogonUser).LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"logonId", (o,n) => { (o as LogonUser).LogonId = n.GetStringValue(); } },
                {"logonTypes", (o,n) => { (o as LogonUser).LogonTypes = n.GetCollectionOfEnumValues<LogonType>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountDomain", AccountDomain);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteEnumValue<UserAccountSecurityType>("accountType", AccountType);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("logonId", LogonId);
            writer.WriteCollectionOfEnumValues<LogonType>("logonTypes", LogonTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
