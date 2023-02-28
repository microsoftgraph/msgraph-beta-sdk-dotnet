---
title: "Create group"
description: "Create a new Microsoft 365 group or security group."
author: "psaffaie"
ms.localizationpriority: high
ms.prod: "groups"
doc_type: apiPageType
---

# Create group

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [group](../resources/group.md) as specified in the request body. You can create one of the following groups:

- Microsoft 365 group (unified group)
- Security group

This operation returns by default only a subset of the properties for each group. These default properties are noted in the [Properties](../resources/group.md#properties) section. To get properties that are _not_ returned by default, do a [GET operation](group-get.md) and specify the properties in a `$select` OData query option.

**Note**: To create a [team](../resources/team.md), first create a group then add a team to it, see [create team](../api/team-put-teams.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                |
| :------------------------------------- | :--------------------------------------------------------- |
| Delegated (work or school account)     | Group.ReadWrite.All, Directory.ReadWrite.All               |
| Delegated (personal Microsoft account) | Not supported.                                             |
| Application                            | Group.Create, Group.ReadWrite.All, Directory.ReadWrite.All |

For an app create a group with owners or members while it has the *Group.Create* permission, the app must have the privileges to read the object type that it wants to assign as the group owner or member. Therefore:
+ The app can assign itself as the group's owner or member.
+ To create the group with users as owners or members, the app must have at least the *User.Read.All* permission.
+ To create the group with other service principals as owners or members, the app must have at least the *Application.Read.All* permission.
+ To create the group with either users or service principals as owners or members, the app must have at least the *Directory.Read.All* permission.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /groups
```

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

In the request body, supply a JSON representation of the [group](../resources/group.md) object.

The following table shows the properties that are required when you create the [group](../resources/group.md). Specify other writable properties as necessary for your group.

| Property        | Type    | Description                                                                                                                                                                                                                                                                                                                                |
| :-------------- | :------ | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| displayName     | string  | The name to display in the address book for the group. Maximum length is 256 characters. Required.                                                                                                                                                                                                                                         |
| mailEnabled     | boolean | Set to `true` for mail-enabled groups. Required.                                                                                                                                                                                                                                                                                           |
| mailNickname    | string  | The mail alias for the group, unique for Microsoft 365 groups in the organization. Maximum length is 64 characters. This property can contain only characters in the [ASCII character set 0 - 127](/office/vba/language/reference/user-interface-help/character-set-0127) except the following: ` @ () \ [] " ; : . <> , SPACE`. Required. |
| securityEnabled | boolean | Set to `true` for security-enabled groups, including Microsoft 365 groups. Required. **Note:** Groups created using the Microsoft Azure portal always have **securityEnabled** initially set to `true`.                                                                                                                                    |

> [!IMPORTANT]
>
> - Creating a group using the **Group.Create** application permission without specifying owners will create the group anonymously and the group will not be modifiable. Add owners to the group while creating it to specify owners who can modify the group.
>
> - Creating a Microsoft 365 group programmatically with an app-only context and without specifying owners will create the group anonymously. Doing so can result in the associated SharePoint Online site not being created automatically until further manual action is taken.
>
> - To following properties can't be set in the initial POST request and must be set in a subsequent PATCH request: **allowExternalSenders**, **autoSubscribeNewMembers**, **hideFromAddressLists**, **hideFromOutlookClients**, **isSubscribedByMail**, **unseenCount**.

Because the **group** resource supports [extensions](/graph/extensibility-overview), you can add custom properties with your own data to the group while creating it.

### groupTypes options

Use the **groupTypes** property to control the type of group and its membership, as shown.

| Type of group                     | Assigned membership | Dynamic membership                |
| :-------------------------------- | :------------------ | :-------------------------------- |
| Microsoft 365 (aka unified group) | `["Unified"]`       | `["Unified","DynamicMembership"]` |
| Dynamic                           | `[]` (_null_)       | `["DynamicMembership"]`           |

## Response

If successful, this method returns a `201 Created` response code and a [group](../resources/group.md) object in the response body. The response includes only the default properties of the group.

## Examples

### Example 1: Create a Microsoft 365 group

The following example creates a Microsoft 365 group. Because the owners have not been specified, the calling user is automatically added as the owner of the group.

#### Request

The following is an example of the request.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "create_group"
}-->

```http
POST https://graph.microsoft.com/beta/groups
Content-type: application/json

{
  "description": "Self help community for golf",
  "displayName": "Golf Assist",
  "groupTypes": [
    "Unified"
  ],
  "mailEnabled": true,
  "mailNickname": "golfassist",
  "securityEnabled": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var group = new Group
{
	Description = "Self help community for golf",
	DisplayName = "Golf Assist",
	GroupTypes = new List<String>()
	{
		"Unified"
	},
	MailEnabled = true,
	MailNickname = "golfassist",
	SecurityEnabled = false
};

await graphClient.Groups
	.Request()
	.AddAsync(group);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response. The value of the **preferredDataLocation** property is inherited from the group creator's preferred data location.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.group",
  "name": "create_group"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
   "@odata.context": "https://graph.microsoft.com/beta/$metadata#groups/$entity",
	 "id": "45b7d2e7-b882-4a80-ba97-10b7a63b8fa4",
	 "deletedDateTime": null,
	 "classification": null,
	 "createdDateTime": "2018-12-22T02:21:05Z",
	 "description": "Self help community for golf",
	 "displayName": "Golf Assist",
	 "expirationDateTime": null,
	 "groupTypes": [
	     "Unified"
	 ],
   "isAssignableToRole": null,
	 "mail": "golfassist@contoso.com",
	 "mailEnabled": true,
	 "mailNickname": "golfassist",
	 "membershipRule": null,
	 "membershipRuleProcessingState": null,
	 "onPremisesLastSyncDateTime": null,
	 "onPremisesSecurityIdentifier": null,
	 "onPremisesSyncEnabled": null,
	 "preferredDataLocation": "CAN",
	 "preferredLanguage": null,
	 "proxyAddresses": [
	     "SMTP:golfassist@contoso.onmicrosoft.com"
	 ],
	 "renewedDateTime": "2018-12-22T02:21:05Z",
	 "resourceBehaviorOptions": [],
	 "resourceProvisioningOptions": [],
	 "securityEnabled": false,
   "securityIdentifier": "S-1-12-1-1753967289-1089268234-832641959-555555555",
	 "theme": null,
	 "visibility": "Public",
	 "onPremisesProvisioningErrors": []
}
```

### Example 2: Create a security group with an owner and members

The following example creates a security group with an owner and members specified. Note that a maximum of 20 relationships, such as owners and members, can be added as part of group creation. You can subsequently add more members by using the [add member](/graph/api/group-post-members?view=graph-rest-beta&preserve-view=true) API or JSON batching.

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_prepopulated_group"
}-->

```http
POST https://graph.microsoft.com/beta/groups
Content-Type: application/json

{
  "description": "Group with designated owner and members",
  "displayName": "Operations group",
  "groupTypes": [
  ],
  "mailEnabled": false,
  "mailNickname": "operations2019",
  "securityEnabled": true,
  "owners@odata.bind": [
    "https://graph.microsoft.com/beta/users/26be1845-4119-4801-a799-aea79d09f1a2"
  ],
  "members@odata.bind": [
    "https://graph.microsoft.com/beta/users/ff7cb387-6688-423c-8188-3da9532a73cc",
    "https://graph.microsoft.com/beta/users/69456242-0067-49d3-ba96-9de6f2728e14"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var group = new Group
{
	Description = "Group with designated owner and members",
	DisplayName = "Operations group",
	GroupTypes = new List<String>()
	{
	},
	MailEnabled = false,
	MailNickname = "operations2019",
	SecurityEnabled = true,
	AdditionalData = new Dictionary<string, object>()
	{
		{"owners@odata.bind", "[\"https://graph.microsoft.com/beta/users/26be1845-4119-4801-a799-aea79d09f1a2\"]"},
		{"members@odata.bind", "[\"https://graph.microsoft.com/beta/users/ff7cb387-6688-423c-8188-3da9532a73cc\",\"https://graph.microsoft.com/beta/users/69456242-0067-49d3-ba96-9de6f2728e14\"]"}
	}
};

await graphClient.Groups
	.Request()
	.AddAsync(group);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of a successful response. It includes only default properties. You can subsequently get the **owners** or **members** navigation properties of the group to verify the owner or members. The value of the **preferredDataLocation** property is inherited from the group creator's preferred data location.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.group",
  "name": "create_prepopulated_group"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#groups/$entity",
    "@odata.id": "https://graph.microsoft.com/v2/84841066-274d-4ec0-a5c1-276be684bdd3/directoryObjects/1226170d-83d5-49b8-99ab-d1ab3d91333e/Microsoft.DirectoryServices.Group",
    "id": "1226170d-83d5-49b8-99ab-d1ab3d91333e",
    "deletedDateTime": null,
    "classification": null,
    "createdDateTime": "2021-09-21T07:14:44Z",
    "createdByAppId": "de8bc8b5-d9f9-48b1-a8ad-b748da725064",
    "organizationId": "84841066-274d-4ec0-a5c1-276be684bdd3",
    "description": "Group with designated owner and members",
    "displayName": "Operations group",
    "expirationDateTime": null,
    "groupTypes": [],
    "infoCatalogs": [],
    "isAssignableToRole": null,
    "isManagementRestricted": null,
    "mail": null,
    "mailEnabled": false,
    "mailNickname": "operations2019",
    "membershipRule": null,
    "membershipRuleProcessingState": null,
    "onPremisesDomainName": null,
    "onPremisesLastSyncDateTime": null,
    "onPremisesNetBiosName": null,
    "onPremisesSamAccountName": null,
    "onPremisesSecurityIdentifier": null,
    "onPremisesSyncEnabled": null,
    "preferredDataLocation": null,
    "preferredLanguage": null,
    "proxyAddresses": [],
    "renewedDateTime": "2021-09-21T07:14:44Z",
    "resourceBehaviorOptions": [],
    "resourceProvisioningOptions": [],
    "securityEnabled": true,
    "securityIdentifier": "S-1-12-1-304486157-1236829141-2882644889-1043566909",
    "theme": null,
    "visibility": null,
    "writebackConfiguration": {
        "isEnabled": null,
        "onPremisesGroupType": null
    },
    "onPremisesProvisioningErrors": []
}
```

### Example 3: Create a Microsoft 365 group that can be assigned to an Azure AD role

#### Request

The following is an example of the request. The calling user must be assigned the _RoleManagement.ReadWrite.Directory_ permission to set the **isAssignableToRole** property or update the membership of such groups.

A group with **isAssignableToRole** property set to `true` cannot be of dynamic membership type, its **securityEnabled** must be set to `true`, and **visibility** can only be `Private`.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "create_role_enabled_group"
}-->

```http
POST https://graph.microsoft.com/beta/groups
Content-Type: application/json

{
    "description": "Group assignable to a role",
    "displayName": "Role assignable group",
    "groupTypes": [
        "Unified"
    ],
    "isAssignableToRole": true,
    "mailEnabled": true,
    "securityEnabled": true,
    "mailNickname": "contosohelpdeskadministrators",
    "owners@odata.bind": [
        "https://graph.microsoft.com/beta/users/99e44b05-c10b-4e95-a523-e2732bbaba1e"
    ],
    "members@odata.bind": [
        "https://graph.microsoft.com/beta/users/6ea91a8d-e32e-41a1-b7bd-d2d185eed0e0",
        "https://graph.microsoft.com/beta/users/4562bcc8-c436-4f95-b7c0-4f8ce89dca5e"
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var group = new Group
{
	Description = "Group assignable to a role",
	DisplayName = "Role assignable group",
	GroupTypes = new List<String>()
	{
		"Unified"
	},
	IsAssignableToRole = true,
	MailEnabled = true,
	SecurityEnabled = true,
	MailNickname = "contosohelpdeskadministrators",
	AdditionalData = new Dictionary<string, object>()
	{
		{"owners@odata.bind", "[\"https://graph.microsoft.com/beta/users/99e44b05-c10b-4e95-a523-e2732bbaba1e\"]"},
		{"members@odata.bind", "[\"https://graph.microsoft.com/beta/users/6ea91a8d-e32e-41a1-b7bd-d2d185eed0e0\",\"https://graph.microsoft.com/beta/users/4562bcc8-c436-4f95-b7c0-4f8ce89dca5e\"]"}
	}
};

await graphClient.Groups
	.Request()
	.AddAsync(group);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response. The value of the **preferredDataLocation** property is inherited from the group creator's preferred data location.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.group",
  "name": "create_role_enabled_group"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#groups/$entity",
    "@odata.id": "https://graph.microsoft.com/v2/84841066-274d-4ec0-a5c1-276be684bdd3/directoryObjects/1afc3ca3-b14d-43af-9c70-8ae3a5065454/Microsoft.DirectoryServices.Group",
    "id": "1afc3ca3-b14d-43af-9c70-8ae3a5065454",
    "deletedDateTime": null,
    "classification": null,
    "createdDateTime": "2021-09-21T07:16:21Z",
    "createdByAppId": "de8bc8b5-d9f9-48b1-a8ad-b748da725064",
    "organizationId": "84841066-274d-4ec0-a5c1-276be684bdd3",
    "description": "Group assignable to a role",
    "displayName": "Role assignable group",
    "expirationDateTime": null,
    "groupTypes": [
        "Unified"
    ],
    "infoCatalogs": [],
    "isAssignableToRole": true,
    "isManagementRestricted": null,
    "mail": "contosohelpdeskadministrators@Contoso.com",
    "mailEnabled": true,
    "mailNickname": "contosohelpdeskadministrators",
    "membershipRule": null,
    "membershipRuleProcessingState": null,
    "onPremisesDomainName": null,
    "onPremisesLastSyncDateTime": null,
    "onPremisesNetBiosName": null,
    "onPremisesSamAccountName": null,
    "onPremisesSecurityIdentifier": null,
    "onPremisesSyncEnabled": null,
    "preferredDataLocation": "EU",
    "preferredLanguage": null,
    "proxyAddresses": [
        "SMTP:contosohelpdeskadministrators@Contoso.com"
    ],
    "renewedDateTime": "2021-09-21T07:16:21Z",
    "resourceBehaviorOptions": [],
    "resourceProvisioningOptions": [],
    "securityEnabled": true,
    "securityIdentifier": "S-1-12-1-452738211-1135587661-3817500828-1414792869",
    "theme": null,
    "visibility": "Private",
    "writebackConfiguration": {
        "isEnabled": null,
        "onPremisesGroupType": null
    },
    "onPremisesProvisioningErrors": []
}
```

## See also

- [Add custom data to resources using extensions](/graph/extensibility-overview)
- [Add custom data to users using open extensions (preview)](/graph/extensibility-open-users)
- [Add custom data to groups using schema extensions (preview)](/graph/extensibility-schema-groups)

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create group",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
