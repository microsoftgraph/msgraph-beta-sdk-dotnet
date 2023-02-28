---
title: "Create team"
description: "Create a new team."
author: "anandjo"
ms.localizationpriority: high
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Create team

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [team](../resources/team.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Team.Create, Group.ReadWrite.All**, Directory.ReadWrite.All** |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Team.Create, Teamwork.Migrate.All, Group.ReadWrite.All**, Directory.ReadWrite.All** |

> **Note**: The Teamwork.Migrate.All permission is *only* supported for [migration](/microsoftteams/platform/graph-api/import-messages/import-external-messages-to-teams).
In the future, Microsoft may require you or your customers to pay additional fees based on the amount of data imported.

> **Note**: Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /teams
```

## Request headers

| Header        | Value                     |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation of a [team](../resources/team.md) object.

## Response

If successful, this API returns a `202 Accepted` response that contains a link to the [teamsAsyncOperation](../resources/teamsasyncoperation.md).

## Examples

### Example 1: Delegated permissions

The following is an example of a minimal request. By omitting other properties, the client is implicitly taking defaults from the pre-defined template represented by `template`.

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_team_post"
}-->
```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
  "template@odata.bind": "https://graph.microsoft.com/beta/teamsTemplates('standard')",
  "displayName": "My Sample Team",
  "description": "My Sample Teamâ€™s Description"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var team = new Team
{
	DisplayName = "My Sample Team",
	Description = "My Sample Team’s Description",
	AdditionalData = new Dictionary<string, object>()
	{
		{"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('standard')"}
	}
};

await graphClient.Teams
	.Request()
	.AddAsync(team);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "name": "create_team_post"
}-->

```http
HTTP/1.1 202 Accepted
Content-Type: application/json
Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')/operations('3a6fdce1-c261-48bc-89de-1cfef658c0d5')
Content-Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')
Content-Length: 0
```

### Example 2: Application permissions

The following is an example of a minimal request using application permissions. By omitting other properties, the client is implicitly taking defaults from the predefined template represented by `template`. When issuing a request with application permissions, a [user](../resources/user.md) must be specified in the `members` collection.

#### Request
<!-- markdownlint-disable MD025 -->

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_team_post_minimal"
}-->

```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
   "template@odata.bind":"https://graph.microsoft.com/beta/teamsTemplates('standard')",
   "displayName":"My Sample Team",
   "description":"My Sample Teamâ€™s Description",
   "members":[
      {
         "@odata.type":"#microsoft.graph.aadUserConversationMember",
         "roles":[
            "owner"
         ],
         "user@odata.bind":"https://graph.microsoft.com/beta/users('0040b377-61d8-43db-94f5-81374122dc7e')"
      }
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var team = new Team
{
	DisplayName = "My Sample Team",
	Description = "My Sample Team’s Description",
	Members = new TeamMembersCollectionPage()
	{
		new AadUserConversationMember
		{
			Roles = new List<String>()
			{
				"owner"
			},
			AdditionalData = new Dictionary<string, object>()
			{
				{"user@odata.bind", "https://graph.microsoft.com/beta/users('0040b377-61d8-43db-94f5-81374122dc7e')"}
			}
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('standard')"}
	}
};

await graphClient.Teams
	.Request()
	.AddAsync(team);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "name": "create_team_post_minimal"
}-->

```http
HTTP/1.1 202 Accepted
Content-Type: application/json
Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')/operations('3a6fdce1-c261-48bc-89de-1cfef658c0d5')
Content-Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')
Content-Length: 0
```

### Example 3: Create a team with multiple channels, installed apps, and pinned tabs using delegated permissions

The following is a request with a full payload. The client can override values in the base template and add to array-valued items to the extent allowed by validation rules for the `specialization`.

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_team_post_full_payload"
}-->

```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
    "template@odata.bind": "https://graph.microsoft.com/beta/teamsTemplates('standard')",
    "visibility": "Private",
    "displayName": "Sample Engineering Team",
    "description": "This is a sample engineering team, used to showcase the range of properties supported by this API",
    "channels": [
        {
            "displayName": "Announcements ðŸ“¢",
            "isFavoriteByDefault": true,
            "description": "This is a sample announcements channel that is favorited by default. Use this channel to make important team, product, and service announcements."
        },
        {
            "displayName": "Training ðŸ‹ï¸",
            "isFavoriteByDefault": true,
            "description": "This is a sample training channel, that is favorited by default, and contains an example of pinned website and YouTube tabs.",
            "tabs": [
                {
                    "teamsApp@odata.bind": "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.web')",
                    "displayName": "A Pinned Website",
                    "configuration": {
                        "contentUrl": "https://learn.microsoft.com/microsoftteams/microsoft-teams"
                    }
                },
                {
                    "teamsApp@odata.bind": "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.youtube')",
                    "displayName": "A Pinned YouTube Video",
                    "configuration": {
                        "contentUrl": "https://tabs.teams.microsoft.com/Youtube/Home/YoutubeTab?videoId=X8krAMdGvCQ",
                        "websiteUrl": "https://www.youtube.com/watch?v=X8krAMdGvCQ"
                    }
                }
            ]
        },
        {
            "displayName": "Planning ðŸ“… ",
            "description": "This is a sample of a channel that is not favorited by default, these channels will appear in the more channels overflow menu.",
            "isFavoriteByDefault": false
        },
        {
            "displayName": "Issues and Feedback ðŸž",
            "description": "This is a sample of a channel that is not favorited by default, these channels will appear in the more channels overflow menu."
        }
    ],
    "memberSettings": {
        "allowCreateUpdateChannels": true,
        "allowDeleteChannels": true,
        "allowAddRemoveApps": true,
        "allowCreateUpdateRemoveTabs": true,
        "allowCreateUpdateRemoveConnectors": true
    },
    "guestSettings": {
        "allowCreateUpdateChannels": false,
        "allowDeleteChannels": false
    },
    "funSettings": {
        "allowGiphy": true,
        "giphyContentRating": "Moderate",
        "allowStickersAndMemes": true,
        "allowCustomMemes": true
    },
    "messagingSettings": {
        "allowUserEditMessages": true,
        "allowUserDeleteMessages": true,
        "allowOwnerDeleteMessages": true,
        "allowTeamMentions": true,
        "allowChannelMentions": true
    },
    "discoverySettings": {
        "showInTeamsSearchAndSuggestions": true
    },
    "installedApps": [
        {
            "teamsApp@odata.bind": "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
        },
        {
            "teamsApp@odata.bind": "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
        }
    ]
}
```

# [C#](#tab/csharp)
```
Snippet not available
```

 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "name": "create_team_post_full_payload"
}-->

```http
HTTP/1.1 202 Accepted
Content-Type: application/json
Location: /teams('958e8cf8-169a-42aa-8599-5c1c5479c0ca')/operations('00000000-0000-0000-0000-000000000000')
Content-Location: /teams('958e8cf8-169a-42aa-8599-5c1c5479c0ca')
Content-Length: 0
```

### Example 4: Create a team from group

The following example shows how you can create a new [team](../resources/team.md) from a [group](../resources/group.md), given a **groupId**.

A few things to note about this call:

* In order to create a team, the group you're creating it from must have a least one owner.
* The team that's created will always inherit from the group's display name, visibility, specialization, and members. Therefore, when making this call with the **group@odata.bind** property, the inclusion of team **displayName**, **visibility**, **specialization**, or **members@odata.bind** properties will return an error.
* If the group was created less than 15 minutes ago, it's possible for the Create team call to fail with a 404 error code due to replication delays. We recommend that you retry the Create team call three times, with a 10 second delay between calls.

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_team_from_group"
}-->

```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
  "template@odata.bind": "https://graph.microsoft.com/beta/teamsTemplates('standard')",
  "group@odata.bind": "https://graph.microsoft.com/beta/groups('71392b2f-1765-406e-86af-5907d9bdb2ab')"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var team = new Team
{
	AdditionalData = new Dictionary<string, object>()
	{
		{"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('standard')"},
		{"group@odata.bind", "https://graph.microsoft.com/beta/groups('71392b2f-1765-406e-86af-5907d9bdb2ab')"}
	}
};

await graphClient.Teams
	.Request()
	.AddAsync(team);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "name": "create_team_from_group"
}-->

```http
HTTP/1.1 202 Accepted
Content-Type: application/json
Location: /teams('71392b2f-1765-406e-86af-5907d9bdb2ab')/operations('9698b2b8-9636-4f49-b7a8-10dadfa7062a')
Content-Location: /teams('71392b2f-1765-406e-86af-5907d9bdb2ab')
Content-Length: 0
```

### Example 5: Create a team from a group with multiple channels, installed apps, and pinned tabs

The following is a request that converts an existing group with extended properties which will create the team with multiple channels, installed apps, and pinned tabs.

To learn more about supported base template types and supported properties, see [Get started with Teams templates](/MicrosoftTeams/get-started-with-teams-templates).

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "convert_team_from_group"
}-->

```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
   "template@odata.bind":"https://graph.microsoft.com/beta/teamsTemplates('standard')",
   "group@odata.bind":"https://graph.microsoft.com/beta/groups('dbd8de4f-5d47-48da-87f1-594bed003375')",
   "channels":[
      {
         "displayName":"Class Announcements ðŸ“¢",
         "isFavoriteByDefault":true
      },
      {
         "displayName":"Homework ðŸ‹ï¸",
         "isFavoriteByDefault":true
      }
   ],
   "memberSettings":{
      "allowCreateUpdateChannels":false,
      "allowDeleteChannels":false,
      "allowAddRemoveApps":false,
      "allowCreateUpdateRemoveTabs":false,
      "allowCreateUpdateRemoveConnectors":false
   },
   "installedApps":[
      {
         "teamsApp@odata.bind":"https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
      },
      {
         "teamsApp@odata.bind":"https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
      }
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var team = new Team
{
	Channels = new TeamChannelsCollectionPage()
	{
		new Channel
		{
			DisplayName = "Class Announcements ",
			IsFavoriteByDefault = true
		},
		new Channel
		{
			DisplayName = "Homework ",
			IsFavoriteByDefault = true
		}
	},
	MemberSettings = new TeamMemberSettings
	{
		AllowCreateUpdateChannels = false,
		AllowDeleteChannels = false,
		AllowAddRemoveApps = false,
		AllowCreateUpdateRemoveTabs = false,
		AllowCreateUpdateRemoveConnectors = false
	},
	InstalledApps = new TeamInstalledAppsCollectionPage()
	{
		new TeamsAppInstallation
		{
			AdditionalData = new Dictionary<string, object>()
			{
				{"teamsApp@odata.bind", "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"}
			}
		},
		new TeamsAppInstallation
		{
			AdditionalData = new Dictionary<string, object>()
			{
				{"teamsApp@odata.bind", "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"}
			}
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('standard')"},
		{"group@odata.bind", "https://graph.microsoft.com/beta/groups('dbd8de4f-5d47-48da-87f1-594bed003375')"}
	}
};

await graphClient.Teams
	.Request()
	.AddAsync(team);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "name": "convert_team_from_group"
}-->

```http
HTTP/1.1 202 Accepted
Content-Type: application/json
Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')/operations('3a6fdce1-c261-48bc-89de-1cfef658c0d5')
Content-Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')
Content-Length: 0
```

### Example 6: Create a team with a non-standard base template type

Base template types are special templates that Microsoft created for specific industries. These base templates often contain proprietary apps that aren't available in the store and team properties that are not yet supported individually in Microsoft Teams templates.

To create a team from a non-standard base template, youâ€™ll want to change the `template@odata.bind` property in the request body from `standard` to point to the specific base template youâ€™d like to create.

To learn more about supported base template types, see [Get started with Teams templates](/MicrosoftTeams/get-started-with-teams-templates).

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "convert_team_from_non_standard"
}-->

```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
  "template@odata.bind": "https://graph.microsoft.com/beta/teamsTemplates('educationClass')",
  "displayName": "My Class Team",
  "description": "My Class Teamâ€™s Description"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var team = new Team
{
	DisplayName = "My Class Team",
	Description = "My Class Team’s Description",
	AdditionalData = new Dictionary<string, object>()
	{
		{"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('educationClass')"}
	}
};

await graphClient.Teams
	.Request()
	.AddAsync(team);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "name": "convert_team_from_non_standard"
}-->
```http
HTTP/1.1 202 Accepted
Content-Type: application/json
Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')/operations('3a6fdce1-c261-48bc-89de-1cfef658c0d5')
Content-Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')
Content-Length: 0
```

### Example 7: Create a team with a non-standard base template type with extended properties

Base template types can be extended with additional properties, enabling you to build on an existing base template with additional team settings, channels, apps, or tabs.

To learn more about supported base template types and supported properties, see [Get started with Teams templates](/MicrosoftTeams/get-started-with-teams-templates).

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "convert_team_from_non_standard2"
}-->
```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
   "template@odata.bind":"https://graph.microsoft.com/beta/teamsTemplates('educationClass')",
   "displayName":"My Class Team",
   "description":"My Class Teamâ€™s Description",
   "channels":[
      {
         "displayName":"Class Announcements ðŸ“¢",
         "isFavoriteByDefault":true
      },
      {
         "displayName":"Homework ðŸ‹ï¸",
         "isFavoriteByDefault":true
      }
   ],
   "memberSettings":{
      "allowCreateUpdateChannels":false,
      "allowDeleteChannels":false,
      "allowAddRemoveApps":false,
      "allowCreateUpdateRemoveTabs":false,
      "allowCreateUpdateRemoveConnectors":false
   },
   "installedApps":[
      {
         "teamsApp@odata.bind":"https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
      },
      {
         "teamsApp@odata.bind":"https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
      }
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var team = new Team
{
	DisplayName = "My Class Team",
	Description = "My Class Team’s Description",
	Channels = new TeamChannelsCollectionPage()
	{
		new Channel
		{
			DisplayName = "Class Announcements ",
			IsFavoriteByDefault = true
		},
		new Channel
		{
			DisplayName = "Homework ",
			IsFavoriteByDefault = true
		}
	},
	MemberSettings = new TeamMemberSettings
	{
		AllowCreateUpdateChannels = false,
		AllowDeleteChannels = false,
		AllowAddRemoveApps = false,
		AllowCreateUpdateRemoveTabs = false,
		AllowCreateUpdateRemoveConnectors = false
	},
	InstalledApps = new TeamInstalledAppsCollectionPage()
	{
		new TeamsAppInstallation
		{
			AdditionalData = new Dictionary<string, object>()
			{
				{"teamsApp@odata.bind", "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"}
			}
		},
		new TeamsAppInstallation
		{
			AdditionalData = new Dictionary<string, object>()
			{
				{"teamsApp@odata.bind", "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"}
			}
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('educationClass')"}
	}
};

await graphClient.Teams
	.Request()
	.AddAsync(team);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "name": "convert_team_from_non_standard2",
}-->

```http
HTTP/1.1 202 Accepted
Content-Type: application/json
Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')/operations('3a6fdce1-c261-48bc-89de-1cfef658c0d5')
Content-Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')
Content-Length: 0
```

### Example 8: Create a team in migration mode

#### Request

The following example shows how to create a team for imported messages.

>**Note:** In the future, Microsoft may require you or your customers to pay additional fees based on the amount of data imported.

>**Note:** Teams created in migration mode only support the `standard` template.

```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
  "@microsoft.graph.teamCreationMode": "migration",
  "template@odata.bind": "https://graph.microsoft.com/beta/teamsTemplates('standard')",
  "displayName": "My Sample Team",
  "description": "My Sample Teamâ€™s Description",
  "createdDateTime": "2020-03-14T11:22:17.067Z"
}
```

#### Response

```http
HTTP/1.1 202 Accepted
Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')/operations('3a6fdce1-c261-48bc-89de-1cfef658c0d5')
Content-Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')
```

#### Error response

If the request is unsuccessful, this method returns a `400 Bad Request` response code.

```http
400 Bad Request
```

The following are common reasons for this response:

* **createdDateTime** is set in the future.
* **createdDateTime** is correctly specified but the **teamCreationMode** instance attribute is missing or set to an invalid value.

### Example 9: Application permissions using user principal name

The following is an example of a minimal request using application permissions. By omitting other properties, the client is implicitly taking defaults from the predefined template represented by `template`. When issuing a request with application permissions, a [user](../resources/user.md) must be specified in the `members` collection.

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_team_post_upn"
}-->

```http
POST https://graph.microsoft.com/beta/teams
Content-Type: application/json

{
   "template@odata.bind":"https://graph.microsoft.com/beta/teamsTemplates('standard')",
   "displayName":"My Sample Team",
   "description":"My Sample Teamâ€™s Description",
   "members":[
      {
         "@odata.type":"#microsoft.graph.aadUserConversationMember",
         "roles":[
            "owner"
         ],
         "user@odata.bind":"https://graph.microsoft.com/beta/users('jacob@contoso.com')"
      }
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var team = new Team
{
	DisplayName = "My Sample Team",
	Description = "My Sample Team’s Description",
	Members = new TeamMembersCollectionPage()
	{
		new AadUserConversationMember
		{
			Roles = new List<String>()
			{
				"owner"
			},
			AdditionalData = new Dictionary<string, object>()
			{
				{"user@odata.bind", "https://graph.microsoft.com/beta/users('jacob@contoso.com')"}
			}
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"template@odata.bind", "https://graph.microsoft.com/beta/teamsTemplates('standard')"}
	}
};

await graphClient.Teams
	.Request()
	.AddAsync(team);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "name": "create_team_post_upn"
}-->

```http
HTTP/1.1 202 Accepted
Content-Type: application/json
Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')/operations('3a6fdce1-c261-48bc-89de-1cfef658c0d5')
Content-Location: /teams('dbd8de4f-5d47-48da-87f1-594bed003375')
Content-Length: 0
```


## See also

* [Complete migration for a team](team-completemigration.md)
* [Import third-party platform messages to Teams using Microsoft Graph](/microsoftteams/platform/graph-api/import-messages/import-external-messages-to-teams)
* [Create channel](channel-post.md)
* [Available templates](/MicrosoftTeams/get-started-with-teams-templates)
* [Getting started with Retail Teams templates](/MicrosoftTeams/get-started-with-retail-teams-templates)
* [Getting started with Healthcare Teams templates](/MicrosoftTeams/healthcare/healthcare-templates)
* [Creating a group with a team](/graph/teams-create-group-and-team)
