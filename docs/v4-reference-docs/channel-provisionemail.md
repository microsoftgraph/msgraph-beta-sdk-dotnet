---
title: "channel: provisionEmail"
description: "Provision an email address for a channel."
author: "anandab-msft"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# channel: provisionEmail

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Provision an email address for a [channel](../resources/channel.md).

Microsoft Teams doesn't automatically provision an email address for a **channel** by default. To have Teams provision an email address, you can call **provisionEmail**, or through the Teams user interface, select **Get email address**, which triggers Teams to generate an email address if it has not already provisioned one.

To remove the email address of a **channel**, use the [removeEmail](channel-removeemail.md) method.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | ChannelSettings.ReadWrite.All               |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Not supported.                              |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /teams/{team-id}/channels/{channel-id}/provisionEmail
```
## Request headers
| Header        | Value                     |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [provisionChannelEmailResult](../resources/provisionChannelEmailResult.md) object in the response body. The provisioned email address is in the `email` property.

## Example
### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["893075dd-2487-4122-925f-022c42e20265", "19:561fbdbbfca848a484f0a6f00ce9dbbd@thread.tacv2"],
  "name": "channel_provisionemail"
}
-->
```http
POST https://graph.microsoft.com/beta/teams/893075dd-2487-4122-925f-022c42e20265/channels/19:561fbdbbfca848a484f0a6f00ce9dbbd@thread.tacv2/provisionEmail
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Teams["{team-id}"].Channels["{channel-id}"]
	.ProvisionEmail()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of a response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.provisionChannelEmailResult"
}
-->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.type": "#microsoft.graph.provisionChannelEmailResult",
    "email": "1df8f174.teamsgraph.onmicrosoft.com@amer.teams.ms"
}
```
<!-- uuid: e848414b-4669-4484-ac36-1504c58a3fb8
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Provision channel email",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->


