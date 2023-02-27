---
title: "Remove channel"
description: "Remove an incoming channel."
author: "devjha-ms"
doc_type: "apiPageType"
ms.localizationpriority: high
ms.prod: "microsoft-teams"
---

# Remove channel
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Remove an incoming [channel](../resources/channel.md) (a **channel** shared with a **team**) from a [team](../resources/team.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account) | Channel.Delete.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Channel.Delete.All |


> **Note**: This API supports admin permissions. Global admins and Microsoft Teams service admins can access teams that they are not a member of.

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
DELETE /teams/{team-id}/incomingChannels/{incoming-channel-id}/$ref
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_incoming_channel_from_team",
  "sampleKeys": ["ece6f0a1-7ca4-498b-be79-edf6c8fc4d82", "19%3A56eb04e133944cf69e603c5dac2d292e%40thread.skype"]
}
-->
``` http
DELETE https://graph.microsoft.com/beta/teams/ece6f0a1-7ca4-498b-be79-edf6c8fc4d82/incomingChannels/19%3A56eb04e133944cf69e603c5dac2d292e%40thread.skype/$ref
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Teams["{team-id}"].IncomingChannels["{channel-id}"].Reference
	.Request()
	.DeleteAsync();

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

## See also

- [Remove member from channel](channel-delete-members.md)
- [Remove member from team](team-delete-members.md)
