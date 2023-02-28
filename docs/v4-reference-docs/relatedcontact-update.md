---
title: "Update relatedContacts"
description: "Update the relatedContact collection of an educationUser object."
author: "mmast-msft"
ms.localizationpriority: medium
ms.prod: "education"
doc_type: apiPageType
---

# Update relatedContacts

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the [relatedContact](../resources/relatedContact.md) collection of an [educationUser](../resources/educationuser.md) object.

> [!NOTE]
> Updating **relatedContacts** replaces the entire collection. It is not possible to add, remove, or update a single contact.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Not supported.                              |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | EduRoster.ReadWrite.All                     |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

```http
PATCH /education/users/{id}
```

## Request headers

| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation of the [relatedContact](../resources/relatedcontact.md) collection.

The following table shows the properties that are required when you update the [educationUser](../resources/educationuser.md).

| Property        | Type                                                        | Description                                    |
| :-------------- | :---------------------------------------------------------- | :--------------------------------------------- |
| relatedContacts | [relatedContact](../resources/relatedcontact.md) collection | The complete set of related contact for a user |

> [!IMPORTANT]
> This update must be a distinct operation. It cannot be combined with updates to other [educationUser](../resources/educationuser.md) properties.
> For example, updating both **relatedContacts** and **displayName** requires two distinct requests.

## Response

If successful, this method returns a `200 OK` response code and an updated [educationUser](../resources/educationuser.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_educationuser_foruserID"
}
-->

```http
PATCH https://graph.microsoft.com/beta/education/users/{educationUserId}
Content-Type: application/json

{
  "relatedContacts": [
    {
      "displayName": "Father Time",
      "emailAddress": "father@time.com",
      "mobilePhone": "4251231234",
      "relationship": "guardian",
      "accessConsent": true
    },
    {
      "displayName": "Mother Nature",
      "emailAddress": "mother@nature.co.uk",
      "mobilePhone": "3251231234",
      "relationship": "parent",
      "accessConsent": true
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var educationUser = new EducationUser
{
	RelatedContacts = new List<RelatedContact>()
	{
		new RelatedContact
		{
			DisplayName = "Father Time",
			EmailAddress = "father@time.com",
			MobilePhone = "4251231234",
			Relationship = ContactRelationship.Guardian,
			AccessConsent = true
		},
		new RelatedContact
		{
			DisplayName = "Mother Nature",
			EmailAddress = "mother@nature.co.uk",
			MobilePhone = "3251231234",
			Relationship = ContactRelationship.Parent,
			AccessConsent = true
		}
	}
};

await graphClient.Education.Users["{educationUser-id}"]
	.Request()
	.UpdateAsync(educationUser);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.educationUser"
} -->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "4b712dc5-2dc5-4b71-c52d-714bc52d714b",
  "relatedContacts": [
      {
          "displayName": "Father Time",
          "emailAddress": "father@time.com",
          "mobilePhone": "4251231234",
          "relationship": "guardian",
          "accessConsent": true
      },
      {
          "displayName": "Mother Nature",
          "emailAddress": "mother@nature.co.uk",
          "mobilePhone": "3251231234",
          "relationship": "parent",
          "accessConsent": true
      }
  ]
}
```
