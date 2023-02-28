---
title: "Update personAnnotation"
description: "Update the properties of a personAnnotation object."
author: "kevinbellinger"
ms.localizationpriority: medium
ms.prod: "people"
doc_type: apiPageType
---

# Update personAnnotation
Namespace: microsoft.graph

Update the properties of a [personAnnotation](../resources/personannotation.md) object in a user's [profile](../resources/profile.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                                      |
|:---------------------------------------|:---------------------------------------------------------------------------------|
| Delegated (work or school account)     | User.Read, User.ReadWrite, User.ReadBasic.All, User.Read.All, User.ReadWrite.All |
| Delegated (personal Microsoft account) | User.Read, User.ReadWrite, User.ReadBasic.All, User.Read.All, User.ReadWrite.All |
| Application                            | User.ReadBasic.All, User.Read.All, User.ReadWrite.All                            |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /me/profile/notes/{id}
PATCH /users/{id | userPrincipalName}/profile/notes/{id}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

The following table shows the properties that are possible to update within an existing [personAnnotation](../resources/personannotation.md) object in a user's [profile](../resources/profile.md).

|Property|Type|Description|
|:---|:---|:---|
|allowedAudiences|String|The audiences that are able to see the values contained within the entity. Inherited from [itemFacet](../resources/itemfacet.md). Possible values are: `me`, `family`, `contacts`, `groupMembers`, `organization`, `federatedOrganizations`, `everyone`, `unknownFutureValue`.|
|detail|[itemBody](../resources/itembody.md)|Contains the detail of the note itself.|
|displayName|String|Contains a friendly name for the note.|
|inference|[inferenceData](../resources/inferencedata.md)|Contains inference detail if the entity is inferred by the creating or modifying application. Inherited from [itemFacet](../resources/itemfacet.md).|

## Response

If successful, this method returns a `200 OK` response code and an updated [personAnnotation](../resources/personannotation.md) object in the response body.

## Examples

### Request
# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_personannotation"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/users/{userId}/profile/notes/{id}
Content-Type: application/json

{
  "allowedAudiences": "organization"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var personAnnotation = new PersonAnnotation
{
	AllowedAudiences = AllowedAudiences.Organization
};

await graphClient.Users["{user-id}"].Profile.Notes["{personAnnotation-id}"]
	.Request()
	.UpdateAsync(personAnnotation);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
    "@odata.type": "microsoft.graph.personAnnotation"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "0fb4c1e3-c1e3-0fb4-e3c1-b40fe3c1b40f",
  "allowedAudiences": "organization",
  "inference": null,
  "createdDateTime": "2020-07-06T06:34:12.2294868Z",
  "createdBy": {
    "application": null,
    "device": null,
    "user": {
      "displayName": "Innocenty Popov",
      "id": "db789417-4ccb-41d1-a0a9-47b01a09ea49"
    }
  },
  "lastModifiedDateTime": "2020-07-06T06:34:12.2294868Z",
  "lastModifiedBy": {
    "application": null,
    "device": null,
    "user": {
      "displayName": "Innocenty Popov",
      "id": "db789417-4ccb-41d1-a0a9-47b01a09ea49"
    }
  },
  "detail": {
    "contentType": "text",
    "content": "I am originally from Australia, but grew up in Moscow."
  },
  "displayName": "About Me"
}
```



