---
title: "Unarchive team"
description: "Restore an archived team. This restores users' ability to send messages and edit the team, abiding by tenant and team settings. Teams are archived using the archive API."
ms.localizationpriority: medium
author: "nkramer"
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Unarchive team

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Restore an archived [team](../resources/team.md). This restores users' ability to send messages and edit the team, abiding by tenant and team settings. Teams are archived using the [archive](team-archive.md) API.

Unarchiving is an async operation. A team is unarchived once the async operation completes successfully, which may occur subsequent to a response from this API.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | TeamSettings.ReadWrite.All, Group.ReadWrite.All**, Directory.ReadWrite.All** |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | TeamSettings.ReadWrite.Group*, TeamSettings.ReadWrite.All, Group.ReadWrite.All**, Directory.ReadWrite.All** |


<!-- markdownlint-disable MD041-->


> **Note**:
> - Permissions marked with * use [resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent).
> - Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.
> **Note**: This API supports admin permissions. Global admins and Microsoft Teams service admins can access teams that they are not a member of.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /teams/{id}/unarchive
```

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body
Do not supply a request body for this method.

## Response

If unarchiving is started successfully, this method returns a `202 Accepted` response code. The response will also contain a `Location` header, which contains the location of the [teamsAsyncOperation](../resources/teamsasyncoperation.md) that was created to handle unarchiving of the team. Check the status of the unarchiving operation by making a GET request to this location.

## Example
#### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "unarchive_team"
}-->
```http
POST https://graph.microsoft.com/beta/teams/{id}/unarchive
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Teams["{team-id}"]
	.Unarchive()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of a response.
<!-- {
  "blockType": "response",
  "name": "unarchive_team"
}-->
```http
HTTP/1.1 202 Accepted
Location: /teams({id})/operations({opId})
Content-Type: text/plain
Content-Length: 0
```

<!-- uuid: 9a9bb83f-6f35-4426-bb04-73ca43ad6cc8
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Unarchive team",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->
