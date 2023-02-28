---
title: "Create teamworkTag"
description: "Create a new teamworkTag object."
author: "RamjotSingh"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Create teamworkTag
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a standard [tag](../resources/teamworktag.md) for members in the team. 

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from most to least privileged)|
|:---|:---|
|Delegated (work or school account)|TeamworkTag.ReadWrite|
|Delegated (personal Microsoft account)|Not supported.|
|Application|TeamworkTag.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /teams/{team-Id}/tags
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [teamworkTag](../resources/teamworktag.md) object.

The following table shows the properties that are required when you create the [teamworkTag](../resources/teamworktag.md).

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|Name of the tag. The value can't be more than 40 characters.|
|members| [teamworkTagMember](../resources/teamworktagmember.md) collection | The unique identifier for the members of the team to add to the tag. The members count shouldn't be more than 25.|



## Response

If successful, this method returns a `201 Created` response code and a [teamworkTag](../resources/teamworktag.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_teamworktag_from"
}
-->
``` http
POST https://graph.microsoft.com/beta/teams/53c53217-fe77-4383-bc5a-ed4937a1aecd/tags
Content-Type: application/json

{
  "displayName": "Finance",
  "members":[
	{
		"userId":"92f6952f-61ca-4a94-8910-508a240bc167"
	},
	{
		"userId":"085d800c-b86b-4bfc-a857-9371ad1caf29"
	}
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamworkTag = new TeamworkTag
{
	DisplayName = "Finance",
	Members = new TeamworkTagMembersCollectionPage()
	{
		new TeamworkTagMember
		{
			UserId = "92f6952f-61ca-4a94-8910-508a240bc167"
		},
		new TeamworkTagMember
		{
			UserId = "085d800c-b86b-4bfc-a857-9371ad1caf29"
		}
	}
};

await graphClient.Teams["{team-id}"].Tags
	.Request()
	.AddAsync(teamworkTag);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.teamworkTag"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.teamworkTag",
  "id": "MjQzMmI1N2ItMGFiZC00M2RiLWFhN2ItMTZlYWRkMTE1ZDM0IyM3ZDg4M2Q4Yi1hMTc5LTRkZDctOTNiMy1hOGQzZGUxYTIxMmUjI3RhY29VSjN2RGk==",
  "teamId": "53c53217-fe77-4383-bc5a-ed4937a1aecd",
  "displayName": "Finance",
  "memberCount": 2,
  "tagType": "standard"
}
```

