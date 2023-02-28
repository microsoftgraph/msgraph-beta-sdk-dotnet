---
title: "Update regionalAndLanguageSettings"
description: "Update the regional and language settings of a user."
author: "jasonbro"
ms.localizationpriority: medium
ms.prod: "users"
doc_type: apiPageType
---

# Update regionalAndLanguageSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update some or all of the properties of a [regionalAndLanguageSettings](../resources/regionalAndLanguageSettings.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission Type                   |Permission (from least to most privileged)     |
|----------------------------------|---------------------------------------------- |
|Delegated (work or school account)|User.ReadWrite, User.ReadWrite.All             |
|Delegated (personal account)      |User.ReadWrite, User.ReadWrite.All             |
|Application                       |User.ReadWrite, User.ReadWrite.All             |

## HTTP request

To update all of a user's regional and language settings:
<!-- { "blockType": "ignored" } -->
```http
PUT /settings/regionalAndLanguageSettings
```

To update a subset of the properties of a user's regional and language settings:
<!-- { "blockType": "ignored" } -->
```http
PATCH /settings/regionalAndLanguageSettings
```

## Request headers
| Header       | Value|
|:-----------|:------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.  |

## Request body
 **PUT**: In the request body, supply a [regionalAndLanguageSettings](../resources/regionalAndLanguageSettings.md) object.
 
 **PATCH**: Only supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.
 
## Response

If successful, this method returns a 200 response code and the updated **regionalAndLanguageSettings** object.

## Example

### Example 1: Update the entire regionalAndLanguageSettings object of the signed-in user

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "put_regionalAndLanguageSettings"
}-->
```http
PUT https://graph.microsoft.com/beta/me/settings/regionalandlanguagesettings
Content-type: application/json

{
    "defaultDisplayLanguage": {
        "locale": "en-US"
    },
    "authoringLanguages": [
        {
            "locale": "fr-FR"
        },
        {
            "locale": "de-DE"
        }
    ],
    "defaultTranslationLanguage": {
        "locale": "en-US"
    },
    "defaultSpeechInputLanguage": {
        "locale": "en-US"
    },
    "defaultRegionalFormat": {
        "locale": "en-GB"
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
        ]
     }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var regionalAndLanguageSettings = new RegionalAndLanguageSettings
{
	DefaultDisplayLanguage = new LocaleInfo
	{
		Locale = "en-US"
	},
	AuthoringLanguages = new List<LocaleInfo>()
	{
		new LocaleInfo
		{
			Locale = "fr-FR"
		},
		new LocaleInfo
		{
			Locale = "de-DE"
		}
	},
	DefaultTranslationLanguage = new LocaleInfo
	{
		Locale = "en-US"
	},
	DefaultSpeechInputLanguage = new LocaleInfo
	{
		Locale = "en-US"
	},
	DefaultRegionalFormat = new LocaleInfo
	{
		Locale = "en-GB"
	},
	RegionalFormatOverrides = new RegionalFormatOverrides
	{
		Calendar = "Gregorian Calendar",
		FirstDayOfWeek = "Sunday",
		ShortDateFormat = "yyyy-MM-dd",
		LongDateFormat = "dddd, MMMM d, yyyy",
		ShortTimeFormat = "HH:mm",
		LongTimeFormat = "h:mm:ss tt",
		TimeZone = "Pacific Standard Time"
	},
	TranslationPreferences = new TranslationPreferences
	{
		TranslationBehavior = TranslationBehavior.Yes,
		LanguageOverrides = new List<TranslationLanguageOverride>()
		{
			new TranslationLanguageOverride
			{
				LanguageTag = "fr",
				TranslationBehavior = TranslationBehavior.Yes
			}
		}
	}
};

await graphClient.Me.Settings.RegionalAndLanguageSettings
	.Request()
	.PutAsync(regionalAndLanguageSettings);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.
<!-- {
  "blockType": "response",
  "name": "put_regionalAndLanguageSettings"
} -->
```http
HTTP/1.1 204 No Content
```

### Example 2: Update selected properties of the signed-in user

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "patch_regionalAndLanguageSettings"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/settings/regionalandlanguagesettings
Content-type: application/json

{
  "authoringLanguages": [
    {
     "locale": "en-US" },
    {
     "locale": "es-MX" }
  ],
  "defaultRegionalFormat": {
     "locale": "en-US"
   }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var regionalAndLanguageSettings = new RegionalAndLanguageSettings
{
	AuthoringLanguages = new List<LocaleInfo>()
	{
		new LocaleInfo
		{
			Locale = "en-US"
		},
		new LocaleInfo
		{
			Locale = "es-MX"
		}
	},
	DefaultRegionalFormat = new LocaleInfo
	{
		Locale = "en-US"
	}
};

await graphClient.Me.Settings.RegionalAndLanguageSettings
	.Request()
	.UpdateAsync(regionalAndLanguageSettings);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.
<!-- {
  "blockType": "response",
  "name": "patch_regionalAndLanguageSettings"
} -->
```http
HTTP/1.1 204 No Content
```

<!--
{
  "type": "#page.annotation",
  "description": "Update regionalAndLanguageSettings",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


