---
title: "Create learningProvider"
description: "Create a new learningProvider object."
author: "malabikaroy"
ms.localizationpriority: medium
ms.prod: "employee-learning"
doc_type: apiPageType
---

# Create learningProvider
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [learningProvider](../resources/learningprovider.md) object and register it with Viva Learning using the specified display name and logos for different themes.

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
POST /employeeExperience/learningProviders
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [learningProvider](../resources/learningprovider.md) object.

You can specify the following properties when you create a **learningProvider**.

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

If successful, this method returns a `201 Created` response code and a [learningProvider](../resources/learningprovider.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_learningprovider_from_"
}
-->
``` http
POST /employeeExperience/learningProviders 
Content-Type: application/json

{
    "displayName": "Microsoft",
    "squareLogoWebUrlForDarkTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "longLogoWebUrlForDarkTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "squareLogoWebUrlForLightTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "longLogoWebUrlForLightTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "isEnabled": true,
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
	IsEnabled = true,
	LoginWebUrl = "https://www.linkedin.com/learning-login/teams"
};

await graphClient.EmployeeExperience.LearningProviders
	.Request()
	.AddAsync(learningProvider);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.learningProvider"
}
-->
``` http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#learningProviders/$entity",
    "id": "ba9790ef-21d5-4c17-808c-acda55230253",
    "displayName": "Microsoft",
    "squareLogoWebUrlForDarkTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "longLogoWebUrlForDarkTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "squareLogoWebUrlForLightTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "longLogoWebUrlForLightTheme": "https://support.content.office.net/en-us/media/4c531d12-4c13-4782-a6e4-4b8f991801a3.png",
    "isEnabled": true,
    "loginWebUrl": "https://www.linkedin.com/learning-login/teams"
}
```

