---
title: "Get channel"
description: "Retrieve the properties and relationships of a channel."
author: "nkramer"
doc_type: apiPageType
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
---

# Get channel

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of a [channel](../resources/channel.md).

This method supports federation. Only a user who is a member of the shared channel can retrieve channel information.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Channel.ReadBasic.All, ChannelSettings.Read.All, ChannelSettings.ReadWrite.All, Group.Read.All**, Group.ReadWrite.All**, Directory.Read.All**, Directory.ReadWrite.All** |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | ChannelSettings.Read.Group*, ChannelSettings.ReadWrite.Group*, Channel.ReadBasic.All, ChannelSettings.Read.All, ChannelSettings.ReadWrite.All, Group.Read.All**, Group.ReadWrite.All**, Directory.Read.All**, Directory.ReadWrite.All** |


<!-- markdownlint-disable MD041-->


> **Note**:
> - Permissions marked with * use [resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent).
> - Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.
> **Note**: This API supports admin permissions. Global admins and Microsoft Teams service admins can access teams that they are not a member of.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /teams/{team-id}/channels/{channel-id}
```

## Optional query parameters

This method supports the `$filter` and `$select` [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers

| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [channel](../resources/channel.md) object in the response body.

## Example

### Request

Here is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_channel",
  "sampleKeys": ["893075dd-2487-4122-925f-022c42e20265", "19:561fbdbbfca848a484f0a6f00ce9dbbd@thread.tacv2"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/teams/893075dd-2487-4122-925f-022c42e20265/channels/19:561fbdbbfca848a484f0a6f00ce9dbbd@thread.tacv2
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var channel = await graphClient.Teams["{team-id}"].Channels["{channel-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

Here is an example of the response.

>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.channel"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "id": "19:561fbdbbfca848a484f0a6f00ce9dbbd@thread.tacv2",
    "createdDateTime": "2020-05-27T19:22:25.692Z",
    "displayName": "General",
    "description": "AutoTestTeam_20210311_150740.2550_fim3udfdjen9",
    "membershipType": "standard"
}

```

Here is an example of the response for a standard channel with channel moderation off.

```http
HTTP/1.1 200 OK

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#teams('8bb12236-b929-42e0-94a0-1c417466ebf8')/channels/$entity",
    "id": "19:d468258bc90f4a358361b5d73b89d39b@thread.skype",
    "displayName": "TestChannelModeration",
    "description": "Test channel moderation.",
    "isFavoriteByDefault": null,
    "email": "",
    "webUrl": "https://teams.microsoft.com/l/channel/19%3Ad468258bc90f4a358361b5d73b89d39b%40thread.skype/General?groupId=8bb12236-b929-42e0-94a0-1c417466ebf8&tenantId=139d16b4-7223-43ad-b9a8-674ba63c7924",
    "membershipType": "standard",
    "moderationSettings": {
        "userNewMessageRestriction": "everyone",
        "replyRestriction": "everyone",
        "allowNewMessageFromBots": true,
        "allowNewMessageFromConnectors": true
    }
}
```

Here is an example of the response for a standard channel with channel moderation on.

>**Note:** The response object shown here might be shortened for readability.

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#teams('8bb12236-b929-42e0-94a0-1c417466ebf8')/channels/$entity",
    "id": "19:d468258bc90f4a358361b5d73b89d39b@thread.skype",
    "displayName": "TestChannelModeration",
    "description": "Test channel moderation.",
    "isFavoriteByDefault": null,
    "email": "",
    "webUrl": "https://teams.microsoft.com/l/channel/19%3Ad468258bc90f4a358361b5d73b89d39b%40thread.skype/General?groupId=8bb12236-b929-42e0-94a0-1c417466ebf8&tenantId=139d16b4-7223-43ad-b9a8-674ba63c7924",
    "membershipType": "standard",
    "moderationSettings": {
        "userNewMessageRestriction": "moderators",
        "replyRestriction": "everyone",
        "allowNewMessageFromBots": true,
        "allowNewMessageFromConnectors": true
    }
}
```

Here is an example of the response for a private channel.

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#teams('8bb12236-b929-42e0-94a0-1c417466ebf8')/channels/$entity",
    "id": "19:d468258bc90f4a358361b5d73b89d39b@thread.skype",
    "displayName": "TestChannelModeration",
    "description": "Test channel moderation.",
    "isFavoriteByDefault": null,
    "email": "",
    "webUrl": "https://teams.microsoft.com/l/channel/19%3Ad468258bc90f4a358361b5d73b89d39b%40thread.skype/General?groupId=8bb12236-b929-42e0-94a0-1c417466ebf8&tenantId=139d16b4-7223-43ad-b9a8-674ba63c7924",
    "membershipType": "private",
    "moderationSettings": null
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Get channel",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


