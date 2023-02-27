---
title: "Update emailThreatSubmissionPolicy"
description: "Update the properties of an emailThreatSubmissionPolicy object."
author: "caigen"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# Update emailThreatSubmissionPolicy
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [emailThreatSubmissionPolicy](../resources/security-emailthreatsubmissionpolicy.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ThreatSubmissionPolicies.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|ThreatSubmissionPolicy.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH security/threatSubmission/emailThreatSubmissionPolicies/{emailThreatSubmissionPoliciesId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

These properties are related to the **user reported message settings**. For details, see [User reported message settings](/microsoft-365/security/office-365-security/user-submission.md).

| Property                                 | Type    | Description                                                                                |
|:-----------------------------------------|:--------|:-------------------------------------------------------------------------------------------|
| customizedNotificationSenderEmailAddress | String  | Specifies the email address of the sender from which email notifications will be sent to end users to inform them whether an email is spam, phish or clean. The default value is `null`. Optional for creation.                   |
| customizedReportRecipientEmailAddress    | String  | Specifies the destination where the reported messages from end users will land whenever they report something as phish, junk or not junk. The default value is `null`. Optional for creation. |
| isAlwaysReportEnabledForUsers            | Boolean | Indicates whether end users can report a message as spam, phish or junk directly without a confirmation(popup). The default value is `true`.  Optional for creation.          |
| isAskMeEnabledForUsers                   | Boolean | Indicates whether end users can confirm using a popup before reporting messages as spam, phish or not junk. The default value is `true`.  Optional for creation. |
| isCustomizedMessageEnabled               | Boolean | Indicates whether the email notifications sent to end users to inform them if an email is phish, spam or junk is customized or not. The default value is `false`. Optional for creation.                  |
| isCustomizedMessageEnabledForPhishing    | Boolean | If enabled, customized message only shows when email is reported as phishing. The default value is `false`. Optional for creation. |
| isCustomizedNotificationSenderEnabled    | Boolean | Indicates whether to use the sender email address set using customizedNotificationSenderEmailAddress for sending email notifications to end users. The default value is `false`. Optional for creation.               |
| isNeverReportEnabledForUsers             | Boolean | Indicates whether end users can simply move the message from one folder to another based on the action of spam, phish or not junk without actually reporting it. The default value is `true`. Optional for creation.         |
| isOrganizationBrandingEnabled            | Boolean | Indicates whether the branding logo should be used in the email notifications sent to end users. The default value is `false`. Optional for creation.        |
| isReportFromQuarantineEnabled            | Boolean | Indicates whether end users can submit from the quarantine page. The default value is `true`. Optional for creation.              |
| isReportToCustomizedEmailAddressEnabled  | Boolean | Indicates whether emails reported by end users should be send to the custom mailbox configured using customizedReportRecipientEmailAddress.  The default value is `false`. Optional for creation.              |
| isReportToMicrosoftEnabled               | Boolean | If enabled, the email will be sent to Microsoft for analysis. The default value is `false`. Requried for creation.  |
| isReviewEmailNotificationEnabled         | Boolean | Indicates whether an email notification is sent to the end user who reported the email when it has been reviewed by the admin. The default value is `false`. Optional for creation.  |



## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_emailthreatsubmissionpolicy"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/security/threatSubmission/emailthreatSubmissionPolicies/DefaultReportSubmissionPolicy
Content-type: application/json

{
  "isReportToMicrosoftEnabled": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var emailThreatSubmissionPolicy = new Microsoft.Graph.Security.EmailThreatSubmissionPolicy
{
	IsReportToMicrosoftEnabled = false
};

await graphClient.Security.ThreatSubmission.EmailThreatSubmissionPolicies["{security.emailThreatSubmissionPolicy-id}"]
	.Request()
	.UpdateAsync(emailThreatSubmissionPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

