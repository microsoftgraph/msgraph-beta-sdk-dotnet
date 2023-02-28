---
title: "Update learningProvider"
description: "Update the properties of a learningProvider object."
author: "malabikaroy"
ms.localizationpriority: medium
ms.prod: "employee-learning"
doc_type: apiPageType
---

# Update learningProvider
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [learningProvider](../resources/learningprovider.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|LearningProvider.ReadWrite|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /employeeExperience/learningProviders/{learningProviderId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The display name that appears in Viva Learning. Required.|
|isEnabled|Boolean|The state of the provider. Optional.|
|loginWebUrl|String|Authentication URL to access the courses for the provider. Optional.|
|longLogoWebUrlForDarkTheme|String|The long logo URL for the dark mode, which needs to be a publicly accessible image. This image would be saved to the Blob storage of Viva Learning for rendering within the Viva Learning app. Required.|
|longLogoWebUrlForLightTheme|String|The long logo URL for the light mode, which needs to be a publicly accessible image. This image would be saved to the Blob storage of Viva Learning for rendering  within the Viva Learning app. Required.|
|squareLogoWebUrlForDarkTheme|String|The square logo URL for the dark mode, which needs to be a publicly accessible image. This image would be saved to the Blob storage of Viva Learning for rendering within the Viva Learning app. Required.|
|squareLogoWebUrlForLightTheme|String|The square logo URL for the light mode, which needs to be a publicly accessible image. This image would be saved to the Blob storage of Viva Learning for rendering within the Viva Learning app. Required.|


## Response

If successful, this method returns a `204 No Content` response code in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_learningprovider"
}
-->
``` http
PATCH /employeeExperience/learningProviders/13727311-e7bb-470d-8b20-6a23d9030d70
Content-Type: application/json

{
    "displayName": "Microsoft",
    "squareLogoWebUrlForDarkTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "longLogoWebUrlForDarkTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "squareLogoWebUrlForLightTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "longLogoWebUrlForLightTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "isEnabled": false,
    "loginWebUrl": "https://www.linkedin.com/learning-login/teams"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var learningProvider = new LearningProvider
{
	DisplayName = "Microsoft",
	SquareLogoWebUrlForDarkTheme = "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
	LongLogoWebUrlForDarkTheme = "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
	SquareLogoWebUrlForLightTheme = "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
	LongLogoWebUrlForLightTheme = "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
	IsEnabled = false,
	LoginWebUrl = "https://www.linkedin.com/learning-login/teams"
};

await graphClient.EmployeeExperience.LearningProviders["{learningProvider-id}"]
	.Request()
	.UpdateAsync(learningProvider);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

