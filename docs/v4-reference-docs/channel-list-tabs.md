---
title: "List tabs in channel"
description: "Retrieve the list of tabs in the specified channel within a team. "
author: "nkramer"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# List tabs in channel

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the list of [tabs](../resources/teamstab.md) in the specified [channel](../resources/channel.md) within a [team](../resources/team.md). 

> **Note**: The Files tab is native to a channel or chat and is not returned by this API.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | TeamsTab.Read.All, TeamsTab.ReadWriteSelfForTeam, TeamsTab.ReadWriteForTeam, TeamsTab.ReadWrite.All, Group.Read.All**, Group.ReadWrite.All**, Directory.Read.All**, Directory.ReadWrite.All** |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | TeamsTab.Read.Group*, TeamsTab.ReadWrite.Group*, TeamsTab.Read.All, TeamsTab.ReadWriteSelfForTeam.All, TeamsTab.ReadWriteForTeam.All, TeamsTab.ReadWrite.All, Group.Read.All**, Group.ReadWrite.All**, Directory.Read.All**, Directory.ReadWrite.All** |


<!-- markdownlint-disable MD041-->


> **Note**:
> - Permissions marked with * use [resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent).
> - Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.
> **Note**: This API supports admin permissions. Global admins and Microsoft Teams service admins can access teams that they are not a member of.

## HTTP request

```http
GET /teams/{team-id}/channels/{channel-id}/tabs
```

## Optional query parameters

This method supports the $filter, $select, and $expand [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `200 OK` response code and collection of [tabs](../resources/teamstab.md) objects in the response body.

## Examples

### Example 1: List all the tabs in the channel along with associated Teams app
#### Request
The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_tabs_in_channel",
  "sampleKeys": ["6903fa93-605b-43ef-920e-77c4729f8258", "19:33b76eea88574bd1969dca37e2b7a819@thread.skype"]
}
-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/teams/6903fa93-605b-43ef-920e-77c4729f8258/channels/19:33b76eea88574bd1969dca37e2b7a819@thread.skype/tabs?$expand=teamsApp
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tabs = await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Tabs
	.Request()
	.Expand("teamsApp")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability. 

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.teamsTab)"
}
-->

```http
HTTP/1.1 200 Success
Content-type: application/json

{
  "value": [
    {
      "id": "794f0e4e-4d10-4bb5-9079-3a465a629eff",
      "displayName": "My Contoso Tab - updated",
      "configuration": {
        "entityId": "2DCA2E6C7A10415CAF6B8AB6661B3154",
        "contentUrl": "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154/tabView",
        "websiteUrl": "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154",
        "removeUrl": "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154/uninstallTab"
      },
      "sortOrderIndex": "20",
      "teamsApp": {
        "id": "06805b9e-77e3-4b93-ac81-525eb87513b8",
        "displayName": "Contoso",
        "distributionMethod": "store"
      },
      "webUrl": "https://teams.microsoft.com/l/channel/19%3ac2e36757ee744c569e70b385e6dd79b6%40thread.skype/tab%3a%3afd736d46-51ed-4c0b-9b23-e67ca354bb24?label=my%20%contoso%to%tab"
    },
    {
      "id": "b5d5f001-0471-49a5-aac4-04ef96683be0",
      "displayName": "My Planner Tab",
      "configuration": null,
      "sortOrderIndex": "21",
      "teamsApp": {
        "id": "com.microsoft.teamspace.tab.planner",
        "displayName": "Microsoft Planner",
        "distributionMethod": "store"
      },
      "webUrl": "https://teams.microsoft.com/l/channel/19%3ac2e36757ee744c569e70b385e6dd79b6%40thread.skype/tab%3a%3a3709b35c-a0ba-467c-8001-0f66895fb9d3?label=My%20Planner%Tab"
    }
  ]
}
```

### Example 2: List all the tabs belonging to a specific app in a channel
#### Request
The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_tabs_in_channel_app_filter",
  "sampleKeys": ["6903fa93-605b-43ef-920e-77c4729f8258", "19:33b76eea88574bd1969dca37e2b7a819@thread.skype"]
}
-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/teams/6903fa93-605b-43ef-920e-77c4729f8258/channels/19:33b76eea88574bd1969dca37e2b7a819@thread.skype/tabs?$expand=teamsApp&$filter=teamsApp/id eq 'com.microsoft.teamspace.tab.planner'
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tabs = await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Tabs
	.Request()
	.Filter("teamsApp/id eq 'com.microsoft.teamspace.tab.planner'")
	.Expand("teamsApp")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability. 

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.teamsTab)"
}
-->

```http
HTTP/1.1 200 Success
Content-type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#teams('6903fa93-605b-43ef-920e-77c4729f8258')/channels('19%3A33b76eea88574bd1969dca37e2b7a819%40thread.skype')/tabs(teamsApp())",
  "@odata.count": 1,
  "value": [
    {
      "id": "b5d5f001-0471-49a5-aac4-04ef96683be0",
      "displayName": "My Planner Tab",
      "configuration": null,
      "sortOrderIndex": "21",
      "teamsApp": {
        "id": "com.microsoft.teamspace.tab.planner",
        "displayName": "Microsoft Planner",
        "distributionMethod": "store"
      },
      "webUrl": "https://teams.microsoft.com/l/channel/19%3ac2e36757ee744c569e70b385e6dd79b6%40thread.skype/tab%3a%3a3709b35c-a0ba-467c-8001-0f66895fb9d3?label=My%20Planner%Tab"
    }
  ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List all tabs in channel",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->


