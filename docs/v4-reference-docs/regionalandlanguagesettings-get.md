---
title: "Get regionalAndLanguageSettings resource"
description: "Retrieve the properties of a user's regionalAndLanguageSettings"
author: "jasonbro"
ms.localizationpriority: medium
ms.prod: "users"
doc_type: apiPageType
---

# Get regionalAndLanguageSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the properties of a [regionalAndLanguageSettings](../resources/regionalAndLanguageSettings.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission Type                   |Permission (from least to most privileged)     |
|----------------------------------|---------------------------------------------- |
|Delegated (work or school account)|User.Read, User.Read.All                        |
|Delegated (personal account)      |User.Read, User.Read.All              |
|Application                       |User.Read, User.Read.All              |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /settings/regionalAndLanguageSettings
```
## Optional query parameters
You can use `$select` to get specific regionalAndLanguageSettings properties, including those that are not returned by default.

For more information on OData query options, see [OData Query Parameters](/graph/query-parameters).

## Request headers
| Header       | Value|
|:-----------|:------|
| Authorization  | Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and [regionalAndLanguageSettings](../resources/regionalandlanguagesettings.md) object in the response body.

## Example

The following example gets the properties of the signed-in user.

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_regionalAndLanguageSettings"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/settings/regionalAndLanguageSettings
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var regionalAndLanguageSettings = await graphClient.Me.Settings.RegionalAndLanguageSettings
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.regionalAndLanguageSettings",
  "name": "get_regionalAndLanguageSettings"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "defaultDisplayLanguage": {
        "locale": "en-US",
        "displayName": "English (United States)"
    },
    "authoringLanguages": [
        {
            "locale": "fr-FR",
            "displayName": "French (France)"
        },
        {
            "locale": "de-DE",
            "displayName": "German (Germany)"
        },
    ],
    "defaultTranslationLanguage": {
        "locale": "en-US",
        "displayName": "English (United States)"
    },
    "defaultSpeechInputLanguage": {
        "locale": "en-US",
        "displayName": "English (United States)"
    },
    "defaultRegionalFormat": {
        "locale": "en-GB",
        "displayName": "English (United Kingdom)"
    },
    "regionalFormatOverrides": {
        "calendar": "Gregorian Calendar",
        "firstDayOfWeek": "Sunday",
        "shortDateFormat": "yyyy-MM-dd",
        "longDateFormat": "dddd, MMMM d, yyyy",
        "shortTimeFormat": "HH:mm",
        "longTimeFormat": "h:mm:ss tt",
        "timeZone": "Pacific Standard Time"
    },
    "translationPreferences": {
        "translationBehavior": "Yes",
        "languageOverrides": [
            {
                "languageTag": "fr",
                "translationBehavior": "Yes" 
            }
        ],
        "untranslatedLanguages": ["de"]
     }
}
```

<!--
{
  "type": "#page.annotation",
  "description": "Get regionalAndLanguageSettings",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


