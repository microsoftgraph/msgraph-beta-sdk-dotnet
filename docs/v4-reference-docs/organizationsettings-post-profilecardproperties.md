---
title: "Create profileCardProperty"
description: "Use this API to create a new profileCardProperty."
ms.localizationpriority: medium
author: "kevinbellinger"
ms.prod: "people"
doc_type: "apiPageType"
---

# Create profileCardProperty

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [profileCardProperty](../resources/profilecardproperty.md) for an organization. The new property is identified by its **directoryPropertyName** property.

For more information on adding properties to the profile card for an organization, see [customize the profile card](/graph/add-properties-profilecard).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | User.ReadWrite, User.ReadWrite.All          |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Not supported.                              |

>**Note:** Using delegated permissions for this operation requires the signed-in user to have a tenant administrator or global administrator role.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST https://graph.microsoft.com/beta/organization/{organizationId}/settings/profileCardProperties
```

## Request headers

| Name          |Description                  |
|:--------------|:----------------------------|
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation of a [profileCardProperty](../resources/profilecardproperty.md) object.

## Response

If successful, this method returns `201 Created` response code and a new [profileCardProperty](../resources/profilecardproperty.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_profilecardproperty_from_organizationsettings"
}-->

```http
POST https://graph.microsoft.com/beta/organization/{organizationId}/settings/profileCardProperties
Content-type: application/json

{
  "directoryPropertyName": "CustomAttribute1",
  "annotations": [
    {
      "displayName": "Cost Center",
      "localizations": [
        {
          "languageTag": "ru-RU",
          "displayName": "центр затрат"
        }
      ]
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var profileCardProperty = new ProfileCardProperty
{
	DirectoryPropertyName = "CustomAttribute1",
	Annotations = new List<ProfileCardAnnotation>()
	{
		new ProfileCardAnnotation
		{
			DisplayName = "Cost Center",
			Localizations = new List<DisplayNameLocalization>()
			{
				new DisplayNameLocalization
				{
					LanguageTag = "ru-RU",
					DisplayName = " "
				}
			}
		}
	}
};

await graphClient.Organization["{organization-id}"].Settings.ProfileCardProperties
	.Request()
	.AddAsync(profileCardProperty);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.profileCardProperty"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "directoryPropertyName": "CustomAttribute1",
  "annotations": [
    {
      "displayName": "Cost Center",
      "localizations": [
        {
          "languageTag": "ru-RU",
          "displayName": "центр затрат"
        }
      ]
    }
  ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create profileCardProperty",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


