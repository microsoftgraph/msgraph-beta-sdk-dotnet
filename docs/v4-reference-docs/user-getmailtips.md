---
title: "user: getMailTips"
description: "Get the MailTips of one or more recipients as available to the signed-in user."
author: "abheek-das"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# user: getMailTips

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the MailTips of one or more recipients as available to the signed-in [user](../resources/user.md).

Note that by making a `POST` call to the `getMailTips` action, you can request specific types of MailTips to 
be returned for more than one recipient at one time. The requested MailTips are returned in a [mailTips](../resources/mailtips.md) collection.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Mail.Read, Mail.Read.Shared    |
|Delegated (personal Microsoft account) | Mail.Read    |
|Application | Mail.Read |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /me/getMailTips
POST /users/{id|userPrincipalName}/getMailTips
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.
## Request headers
| Header       | Value|
|:-----------  |:------|
| Authorization | Bearer {token}. Required. |
| Content-Type  | application/json  |

## Request body
In the request body, provide a JSON object with the following parameters.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|EmailAddresses|String collection|A collection of SMTP addresses of recipients to get MailTips for.|
|MailTipsOptions|String|A enumeration of flags that represents the requested mailtips. Possible values are: `automaticReplies`, `customMailTip`, `deliveryRestriction`, `externalMemberCount`, `mailboxFullStatus`, `maxMessageSize`, `moderationStatus`, `recipientScope`, `recipientSuggestions`, and `totalMemberCount`.|

## Response

If successful, this method returns a `200 OK` response code and a collection of [mailTips](../resources/mailtips.md) objects in the response body.
## Example
##### Request
The following example gets MailTips for the specified recipients, for any automatic reply settings and the mailbox full status.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_getmailtips"
}-->
```http
POST https://graph.microsoft.com/beta/me/getMailTips
Content-Type: application/json

{
    "EmailAddresses": [
        "danas@contoso.onmicrosoft.com", 
        "fannyd@contoso.onmicrosoft.com"
    ],
    "MailTipsOptions": "automaticReplies, mailboxFullStatus"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var emailAddresses = new List<String>()
{
	"danas@contoso.onmicrosoft.com",
	"fannyd@contoso.onmicrosoft.com"
};

var mailTipsOptions = MailTipsType.AutomaticReplies | MailTipsType.MailboxFullStatus;

await graphClient.Me
	.GetMailTips(emailAddresses,mailTipsOptions)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

