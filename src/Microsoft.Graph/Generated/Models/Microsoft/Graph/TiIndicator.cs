using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the tiIndicators property of the microsoft.graph.security entity.</summary>
    public class TiIndicator : Entity, IParsable {
        /// <summary>The action to apply if the indicator is matched from within the targetProduct security tool. Possible values are: unknown, allow, block, alert. Required.</summary>
        public TiAction? Action { get; set; }
        /// <summary>The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.</summary>
        public List<string> ActivityGroupNames { get; set; }
        /// <summary>A catchall area into which extra data from the indicator not covered by the other tiIndicator properties may be placed. Data placed into additionalInformation will typically not be utilized by the targetProduct security tool.</summary>
        public string AdditionalInformation { get; set; }
        /// <summary>Stamped by the system when the indicator is ingested. The Azure Active Directory tenant id of submitting client. Required.</summary>
        public string AzureTenantId { get; set; }
        /// <summary>An integer representing the confidence the data within the indicator accurately identifies malicious behavior. Acceptable values are 0 – 100 with 100 being the highest.</summary>
        public int? Confidence { get; set; }
        /// <summary>Brief description (100 characters or less) of the threat represented by the indicator. Required.</summary>
        public string Description { get; set; }
        /// <summary>The area of the Diamond Model in which this indicator exists. Possible values are: unknown, adversary, capability, infrastructure, victim.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DiamondModel? DiamondModel { get; set; }
        public string DomainName { get; set; }
        public string EmailEncoding { get; set; }
        public string EmailLanguage { get; set; }
        public string EmailRecipient { get; set; }
        public string EmailSenderAddress { get; set; }
        public string EmailSenderName { get; set; }
        public string EmailSourceDomain { get; set; }
        public string EmailSourceIpAddress { get; set; }
        public string EmailSubject { get; set; }
        public string EmailXMailer { get; set; }
        /// <summary>DateTime string indicating when the Indicator expires. All indicators must have an expiration date to avoid stale indicators persisting in the system. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>An identification number that ties the indicator back to the indicator provider’s system (e.g. a foreign key).</summary>
        public string ExternalId { get; set; }
        public DateTimeOffset? FileCompileDateTime { get; set; }
        public DateTimeOffset? FileCreatedDateTime { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.FileHashType? FileHashType { get; set; }
        public string FileHashValue { get; set; }
        public string FileMutexName { get; set; }
        public string FileName { get; set; }
        public string FilePacker { get; set; }
        public string FilePath { get; set; }
        public int? FileSize { get; set; }
        public string FileType { get; set; }
        /// <summary>Stamped by the system when the indicator is ingested. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? IngestedDateTime { get; set; }
        /// <summary>Used to deactivate indicators within system. By default, any indicator submitted is set as active. However, providers may submit existing indicators with this set to ‘False’ to deactivate indicators in the system.</summary>
        public bool? IsActive { get; set; }
        /// <summary>A JSON array of strings that describes which point or points on the Kill Chain this indicator targets. See ‘killChain values’ below for exact values.</summary>
        public List<string> KillChain { get; set; }
        /// <summary>Scenarios in which the indicator may cause false positives. This should be human-readable text.</summary>
        public string KnownFalsePositives { get; set; }
        /// <summary>The last time the indicator was seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible which can be found via the Windows Defender Security Intelligence threat encyclopedia.</summary>
        public List<string> MalwareFamilyNames { get; set; }
        public string NetworkCidrBlock { get; set; }
        public int? NetworkDestinationAsn { get; set; }
        public string NetworkDestinationCidrBlock { get; set; }
        public string NetworkDestinationIPv4 { get; set; }
        public string NetworkDestinationIPv6 { get; set; }
        public int? NetworkDestinationPort { get; set; }
        public string NetworkIPv4 { get; set; }
        public string NetworkIPv6 { get; set; }
        public int? NetworkPort { get; set; }
        public int? NetworkProtocol { get; set; }
        public int? NetworkSourceAsn { get; set; }
        public string NetworkSourceCidrBlock { get; set; }
        public string NetworkSourceIPv4 { get; set; }
        public string NetworkSourceIPv6 { get; set; }
        public int? NetworkSourcePort { get; set; }
        /// <summary>Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools will not notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they will simply log that a match occurred but will not perform the action. Default value is false.</summary>
        public bool? PassiveOnly { get; set; }
        /// <summary>An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero is not severe at all. Default value is 3.</summary>
        public int? Severity { get; set; }
        /// <summary>A JSON array of strings that stores arbitrary tags/keywords.</summary>
        public List<string> Tags { get; set; }
        /// <summary>A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required</summary>
        public string TargetProduct { get; set; }
        /// <summary>Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.</summary>
        public string ThreatType { get; set; }
        /// <summary>Traffic Light Protocol value for the indicator. Possible values are: unknown, white, green, amber, red. Required.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TlpLevel? TlpLevel { get; set; }
        public string Url { get; set; }
        public string UserAgent { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TiIndicator CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TiIndicator();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"action", (o,n) => { (o as TiIndicator).Action = n.GetEnumValue<TiAction>(); } },
                {"activityGroupNames", (o,n) => { (o as TiIndicator).ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"additionalInformation", (o,n) => { (o as TiIndicator).AdditionalInformation = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as TiIndicator).AzureTenantId = n.GetStringValue(); } },
                {"confidence", (o,n) => { (o as TiIndicator).Confidence = n.GetIntValue(); } },
                {"description", (o,n) => { (o as TiIndicator).Description = n.GetStringValue(); } },
                {"diamondModel", (o,n) => { (o as TiIndicator).DiamondModel = n.GetEnumValue<DiamondModel>(); } },
                {"domainName", (o,n) => { (o as TiIndicator).DomainName = n.GetStringValue(); } },
                {"emailEncoding", (o,n) => { (o as TiIndicator).EmailEncoding = n.GetStringValue(); } },
                {"emailLanguage", (o,n) => { (o as TiIndicator).EmailLanguage = n.GetStringValue(); } },
                {"emailRecipient", (o,n) => { (o as TiIndicator).EmailRecipient = n.GetStringValue(); } },
                {"emailSenderAddress", (o,n) => { (o as TiIndicator).EmailSenderAddress = n.GetStringValue(); } },
                {"emailSenderName", (o,n) => { (o as TiIndicator).EmailSenderName = n.GetStringValue(); } },
                {"emailSourceDomain", (o,n) => { (o as TiIndicator).EmailSourceDomain = n.GetStringValue(); } },
                {"emailSourceIpAddress", (o,n) => { (o as TiIndicator).EmailSourceIpAddress = n.GetStringValue(); } },
                {"emailSubject", (o,n) => { (o as TiIndicator).EmailSubject = n.GetStringValue(); } },
                {"emailXMailer", (o,n) => { (o as TiIndicator).EmailXMailer = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as TiIndicator).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", (o,n) => { (o as TiIndicator).ExternalId = n.GetStringValue(); } },
                {"fileCompileDateTime", (o,n) => { (o as TiIndicator).FileCompileDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileCreatedDateTime", (o,n) => { (o as TiIndicator).FileCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileHashType", (o,n) => { (o as TiIndicator).FileHashType = n.GetEnumValue<FileHashType>(); } },
                {"fileHashValue", (o,n) => { (o as TiIndicator).FileHashValue = n.GetStringValue(); } },
                {"fileMutexName", (o,n) => { (o as TiIndicator).FileMutexName = n.GetStringValue(); } },
                {"fileName", (o,n) => { (o as TiIndicator).FileName = n.GetStringValue(); } },
                {"filePacker", (o,n) => { (o as TiIndicator).FilePacker = n.GetStringValue(); } },
                {"filePath", (o,n) => { (o as TiIndicator).FilePath = n.GetStringValue(); } },
                {"fileSize", (o,n) => { (o as TiIndicator).FileSize = n.GetIntValue(); } },
                {"fileType", (o,n) => { (o as TiIndicator).FileType = n.GetStringValue(); } },
                {"ingestedDateTime", (o,n) => { (o as TiIndicator).IngestedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isActive", (o,n) => { (o as TiIndicator).IsActive = n.GetBoolValue(); } },
                {"killChain", (o,n) => { (o as TiIndicator).KillChain = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"knownFalsePositives", (o,n) => { (o as TiIndicator).KnownFalsePositives = n.GetStringValue(); } },
                {"lastReportedDateTime", (o,n) => { (o as TiIndicator).LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareFamilyNames", (o,n) => { (o as TiIndicator).MalwareFamilyNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"networkCidrBlock", (o,n) => { (o as TiIndicator).NetworkCidrBlock = n.GetStringValue(); } },
                {"networkDestinationAsn", (o,n) => { (o as TiIndicator).NetworkDestinationAsn = n.GetIntValue(); } },
                {"networkDestinationCidrBlock", (o,n) => { (o as TiIndicator).NetworkDestinationCidrBlock = n.GetStringValue(); } },
                {"networkDestinationIPv4", (o,n) => { (o as TiIndicator).NetworkDestinationIPv4 = n.GetStringValue(); } },
                {"networkDestinationIPv6", (o,n) => { (o as TiIndicator).NetworkDestinationIPv6 = n.GetStringValue(); } },
                {"networkDestinationPort", (o,n) => { (o as TiIndicator).NetworkDestinationPort = n.GetIntValue(); } },
                {"networkIPv4", (o,n) => { (o as TiIndicator).NetworkIPv4 = n.GetStringValue(); } },
                {"networkIPv6", (o,n) => { (o as TiIndicator).NetworkIPv6 = n.GetStringValue(); } },
                {"networkPort", (o,n) => { (o as TiIndicator).NetworkPort = n.GetIntValue(); } },
                {"networkProtocol", (o,n) => { (o as TiIndicator).NetworkProtocol = n.GetIntValue(); } },
                {"networkSourceAsn", (o,n) => { (o as TiIndicator).NetworkSourceAsn = n.GetIntValue(); } },
                {"networkSourceCidrBlock", (o,n) => { (o as TiIndicator).NetworkSourceCidrBlock = n.GetStringValue(); } },
                {"networkSourceIPv4", (o,n) => { (o as TiIndicator).NetworkSourceIPv4 = n.GetStringValue(); } },
                {"networkSourceIPv6", (o,n) => { (o as TiIndicator).NetworkSourceIPv6 = n.GetStringValue(); } },
                {"networkSourcePort", (o,n) => { (o as TiIndicator).NetworkSourcePort = n.GetIntValue(); } },
                {"passiveOnly", (o,n) => { (o as TiIndicator).PassiveOnly = n.GetBoolValue(); } },
                {"severity", (o,n) => { (o as TiIndicator).Severity = n.GetIntValue(); } },
                {"tags", (o,n) => { (o as TiIndicator).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"targetProduct", (o,n) => { (o as TiIndicator).TargetProduct = n.GetStringValue(); } },
                {"threatType", (o,n) => { (o as TiIndicator).ThreatType = n.GetStringValue(); } },
                {"tlpLevel", (o,n) => { (o as TiIndicator).TlpLevel = n.GetEnumValue<TlpLevel>(); } },
                {"url", (o,n) => { (o as TiIndicator).Url = n.GetStringValue(); } },
                {"userAgent", (o,n) => { (o as TiIndicator).UserAgent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TiAction>("action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("activityGroupNames", ActivityGroupNames);
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DiamondModel>("diamondModel", DiamondModel);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("emailEncoding", EmailEncoding);
            writer.WriteStringValue("emailLanguage", EmailLanguage);
            writer.WriteStringValue("emailRecipient", EmailRecipient);
            writer.WriteStringValue("emailSenderAddress", EmailSenderAddress);
            writer.WriteStringValue("emailSenderName", EmailSenderName);
            writer.WriteStringValue("emailSourceDomain", EmailSourceDomain);
            writer.WriteStringValue("emailSourceIpAddress", EmailSourceIpAddress);
            writer.WriteStringValue("emailSubject", EmailSubject);
            writer.WriteStringValue("emailXMailer", EmailXMailer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteDateTimeOffsetValue("fileCompileDateTime", FileCompileDateTime);
            writer.WriteDateTimeOffsetValue("fileCreatedDateTime", FileCreatedDateTime);
            writer.WriteEnumValue<FileHashType>("fileHashType", FileHashType);
            writer.WriteStringValue("fileHashValue", FileHashValue);
            writer.WriteStringValue("fileMutexName", FileMutexName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("filePacker", FilePacker);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteIntValue("fileSize", FileSize);
            writer.WriteStringValue("fileType", FileType);
            writer.WriteDateTimeOffsetValue("ingestedDateTime", IngestedDateTime);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteCollectionOfPrimitiveValues<string>("killChain", KillChain);
            writer.WriteStringValue("knownFalsePositives", KnownFalsePositives);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("malwareFamilyNames", MalwareFamilyNames);
            writer.WriteStringValue("networkCidrBlock", NetworkCidrBlock);
            writer.WriteIntValue("networkDestinationAsn", NetworkDestinationAsn);
            writer.WriteStringValue("networkDestinationCidrBlock", NetworkDestinationCidrBlock);
            writer.WriteStringValue("networkDestinationIPv4", NetworkDestinationIPv4);
            writer.WriteStringValue("networkDestinationIPv6", NetworkDestinationIPv6);
            writer.WriteIntValue("networkDestinationPort", NetworkDestinationPort);
            writer.WriteStringValue("networkIPv4", NetworkIPv4);
            writer.WriteStringValue("networkIPv6", NetworkIPv6);
            writer.WriteIntValue("networkPort", NetworkPort);
            writer.WriteIntValue("networkProtocol", NetworkProtocol);
            writer.WriteIntValue("networkSourceAsn", NetworkSourceAsn);
            writer.WriteStringValue("networkSourceCidrBlock", NetworkSourceCidrBlock);
            writer.WriteStringValue("networkSourceIPv4", NetworkSourceIPv4);
            writer.WriteStringValue("networkSourceIPv6", NetworkSourceIPv6);
            writer.WriteIntValue("networkSourcePort", NetworkSourcePort);
            writer.WriteBoolValue("passiveOnly", PassiveOnly);
            writer.WriteIntValue("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("targetProduct", TargetProduct);
            writer.WriteStringValue("threatType", ThreatType);
            writer.WriteEnumValue<TlpLevel>("tlpLevel", TlpLevel);
            writer.WriteStringValue("url", Url);
            writer.WriteStringValue("userAgent", UserAgent);
        }
    }
}
