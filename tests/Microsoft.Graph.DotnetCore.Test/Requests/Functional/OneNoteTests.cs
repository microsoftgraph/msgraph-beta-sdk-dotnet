using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Async = System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    public class OneNoteTests : GraphTestBase
    {
        private OnenotePage testPage;
        private Notebook testNotebook;
        private static string firstSectionID;

        public OneNoteTests() : base() {
            // Get a page of OneNote sections.
            IOnenoteSectionsCollectionPage sectionPage = graphClient.Me
                                                                    .Onenote
                                                                    .Sections
                                                                    .Request()
                                                                    .GetAsync()
                                                                    .Result;

            // Get a handle to the first section.
            firstSectionID = sectionPage[0].Id;
        }
        
        public async void TestPageCleanUp()
        {
            await graphClient.Me.Onenote.Pages[testPage.Id].Request().DeleteAsync();
        }

        /// <summary>
        /// Get the OneNote notebooks.
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/api/notebook_get
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteGetNotebooks()
        { 
            try 
            {
                IOnenoteNotebooksCollectionPage notebooksPage = await graphClient.Me
                                                                                 .Onenote
                                                                                 .Notebooks
                                                                                 .Request()
                                                                                 .GetAsync();

                Assert.True(notebooksPage.Count > 0, $"Expected at least one Notebook; Actual {notebooksPage.Count}");
                Assert.NotNull(notebooksPage[0].Id);
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// List a user's OneNote pages. You can also do this for groups.
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/api/onenote_list_pages
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteListPages()
        {
            try
            {
                IOnenotePagesCollectionPage pageCollection = await graphClient.Me
                                                                              .Onenote
                                                                              .Pages
                                                                              .Request()
                                                                              .GetAsync();

                Assert.True(pageCollection.Count > 0, $"Expected at least one Page; Actual {pageCollection.Count}");
                Assert.NotNull(pageCollection[0].Id); // Expected an ID value; ID value is missing.
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// List a user's OneNote sections. You can also do this for groups.
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/api/onenote_list_sections
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteListSections()
        {
            try
            {
                IOnenoteSectionsCollectionPage sectionsCollection = await graphClient.Me
                                                                                     .Onenote
                                                                                     .Sections
                                                                                     .Request()
                                                                                     .GetAsync();

                Assert.True(sectionsCollection.Count > 0, $"Expected at least one Section; Actual {sectionsCollection.Count}");
                Assert.NotNull(sectionsCollection[0].Id); //Expected an ID value; ID value is missing.
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// List a user's OneNote section groups. You can also do this for groups.
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/api/onenote_list_sectiongroups
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteGetSectionGroups()
        {
            try
            {
                IOnenoteSectionGroupsCollectionPage sectionGroupCollection = await graphClient.Me
                                                                                              .Onenote
                                                                                              .SectionGroups
                                                                                              .Request()
                                                                                              .GetAsync();

                Assert.True(sectionGroupCollection.Count > 0, $"Expected at least one SectionGroup; Actual {sectionGroupCollection.Count}");
                Assert.NotNull(sectionGroupCollection[0].Id); // Expected an ID value; ID value is missing.
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// Lists a user's notebooks with the section object expanded.
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/api/onenote_list_notebooks
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteGetNotebooksExpandSection()
        {
            try
            {
                IOnenoteNotebooksCollectionPage notebooksPage = await graphClient.Me
                                                                                 .Onenote
                                                                                 .Notebooks
                                                                                 .Request()
                                                                                 .Expand("sections")
                                                                                 .GetAsync();

                Assert.True(notebooksPage.Count > 0, $"Expected at least one Notebook; Actual {notebooksPage.Count}");
                Assert.NotNull(notebooksPage[0].Id); // Expected an ID value; ID value is missing.
                Assert.NotNull(notebooksPage[0].Sections); // Expected that the sections property was expanded; Actual: null.
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// Lists the notebooks that the usr recetly used.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteGetRecentNotebooks()
        {
            try
            {
                INotebookGetRecentNotebooksCollectionPage recentNotebooksPage = await graphClient.Me
                                                                                                 .Onenote
                                                                                                 .Notebooks
                                                                                                 .GetRecentNotebooks(true)
                                                                                                 .Request()
                                                                                                 .GetAsync();

                Assert.True(recentNotebooksPage.Count > 0, $"Expected at least one recent Notebook; Actual {recentNotebooksPage.Count}");
                Assert.NotNull(recentNotebooksPage[0].DisplayName); // Expected an display name; name value is missing.
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// Preview the contents of a OneNote page.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNotePagePreview()
        {
            try
            {
                // Get a page of OneNote pages
                IOnenoteSectionPagesCollectionPage pageCollection = await graphClient.Me
                                                                                     .Onenote
                                                                                     .Sections[firstSectionID]
                                                                                     .Pages
                                                                                     .Request()
                                                                                     .GetAsync();

                // Get a handle to the first section.
                string pageId = pageCollection[0].Id;

                // URL to update a page. https://graph.microsoft.com/v1.0/me/onenote/sections/{id}/pages/{id}/preview
                OnenotePagePreview pagePreview = await graphClient.Me
                                                                  .Onenote
                                                                  .Pages[pageId]
                                                                  .Preview()
                                                                  .Request()
                                                                  .GetAsync();

                Assert.NotNull(pagePreview); // OnenotePagePreview object is null. This shouldn't be null. Check your request.
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// Get a resource from an existing page.
        /// </summary>
        /// <returns>Task</returns>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteGetResource()
        {
            try
            {

                //graphClient.Sites[""].

                // This resource is from a page created with OneNoteAddPageMultipart.
                // Page Id: 1-c57153f8dc2245b291b83015961fdccd!114-4ad43aa2-8e35-42e6-b9ca-8be860a8af11
                string resourceId = "1-03dd7ea8053b488f9c3ce14c09e1b833!1-4ad43aa2-8e35-42e6-b9ca-8be860a8af11";
                Stream resource = await graphClient.Me.Onenote.Resources[resourceId].Content.Request().GetAsync();

                Assert.NotNull(resource); //Expected a resource stream of an image of Hamilton. Actual: null
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// Try and fail to create a notebook with invalid chars.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteTryCreateNotebookWithInvalidChars()
        {
            try
            {
                var newNotebook = new Notebook()
                {
                    DisplayName = $"Notebook created from test, ?*\\/:<>|'"
                };

                Notebook notebook = await graphClient.Me.Onenote.Notebooks.Request().AddAsync(newNotebook);
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Contains(e.Error.Message, "The notebook name value contains invalid characters");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// Create a notebook.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteCreateNotebook()
        {
            try
            {
                testNotebook = new Notebook()
                {
                    DisplayName = $"Notebook created from test, {DateTime.Now.ToString("yyyy.mm.dd.hh.mm.ss")}"
                };

                Notebook notebook = await graphClient.Me.Onenote.Notebooks.Request().AddAsync(testNotebook);
                Assert.NotNull(notebook); // Expected: A Notebook object, Actual: null. Check the request.
                Assert.Equal(testNotebook.DisplayName, notebook.DisplayName); // Expected: Input notebook display name is the same as the notebook created on the service. Actual: they are different");
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.Contains(e.Error.Message, "The notebook name value contains invalid characters");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// OneNoteAddPageHtmlWorkaround is a workaround test. We've since added functionality to address this in the client library.
        /// See OneNoteCreatePageWithHtml() for how this is done.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteAddPageHtmlWorkaround()
        {
            try
            {
                // Get the request URL for adding a page.
                string requestUrl = graphClient.Me.Onenote.Sections[firstSectionID].Pages.Request().RequestUrl;

                string title = "OneNoteAddPageHtml test created this";
                string htmlBody = $"<!DOCTYPE html><html><head><title>{title}</title></head>" +
                                    "<body>Generated from the test</body></html> ";

                // Create the request message and add the content.
                HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                hrm.Content = new StringContent(htmlBody, System.Text.Encoding.UTF8, "text/html");

                // Send the request and get the response.
                HttpResponseMessage response = await graphClient.HttpProvider.SendAsync(hrm);

                // Get the OneNote page that we created.
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize into OneNotePage object.
                    var content = await response.Content.ReadAsStringAsync();
                    testPage = graphClient.HttpProvider.Serializer.DeserializeObject<OnenotePage>(content);

                    Assert.NotNull(testPage); // We didn't deserialize the OnenotePage object.
                    Assert.Contains(testPage.Title, title); // Expected: title from the posted body matches the title in the OneNotePage object. That didn't happen
                    Assert.Null(testPage.Content); // Expected: content property does not contain anything. Actual: there's an unexpected object in the content property.

                    TestPageCleanUp(); 
                }
                else
                    throw new ServiceException(
                        new Error
                        {
                            Code = response.StatusCode.ToString(),
                            Message = await response.Content.ReadAsStringAsync()
                        });
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// OneNoteAddPageHtmlWithStreamWorkaround is a workaround test. We've since added functionality to address this in the client library.
        /// See OneNoteCreatePageWithHtml() for how this is done.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteAddPageHtmlWithStreamWorkaround()
        {
            try
            {
                // Get the request URL for adding a page. You don't have to use the request builder to 
                // get the URL. We use it here for convenience.
                string requestUrl = graphClient.Me.Onenote.Sections[firstSectionID].Pages.Request().RequestUrl;

                // Create the request body.
                string title = "OneNoteAddPageHtmlWithStream test created this";
                string htmlBody = $"<!DOCTYPE html><html><head><title>{title}</title></head><body>Generated from the test</body></html> ";
                byte[] byteArray = Encoding.ASCII.GetBytes(htmlBody);

                StreamContent body;
                HttpResponseMessage response;

                using (MemoryStream stream = new MemoryStream(byteArray))
                {
                    // Create the stream body.
                    body = new StreamContent(stream);
                    body.Headers.ContentType = new MediaTypeHeaderValue("text/html");

                    // Create the request message and add the content.
                    HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                    hrm.Content = body;

                    // Send the request and get the response.
                    response = await graphClient.HttpProvider.SendAsync(hrm);
                }
                
                // Get the OneNote page that we created.
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize into OneNotePage object.
                    var content = await response.Content.ReadAsStringAsync();
                    testPage = graphClient.HttpProvider.Serializer.DeserializeObject<OnenotePage>(content);

                    Assert.NotNull(testPage); // We didn't deserialize the OnenotePage object.
                    Assert.Contains(testPage.Title, title); // Expected: title matches, Actual: they don't match.

                    TestPageCleanUp();
                }
                else
                    throw new ServiceException(
                        new Error
                        {
                            Code = response.StatusCode.ToString(),
                            Message = await response.Content.ReadAsStringAsync()
                        });
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// OneNoteAddPageMultipartWorkaround is a workaround test. We've since added functionality to address this in the client library.
        /// See OneNoteCreatePageWithMultipart() for how this is done.
        /// Need to replace ImageConverter.
        /// </summary>
        //[Fact(Skip = "No CI set up for functional tests")]
        //public async Async.Task OneNoteAddPageMultipartWorkaround()
        //{
        //    try
        //    {
        //        // Get the request URL for adding a page.
        //        string requestUrl = graphClient.Me.Onenote.Sections[firstSectionID].Pages.Request().RequestUrl;
        //        string title = "OneNoteAddPageMultipart test created this";
        //        string htmlBody = $@"<!DOCTYPE html><html><head><title>{title}</title></head>
        //                            <body>Generated from the test
        //                                <p>
        //                                    <img src=""name:imageBlock1"" alt=""an image on the page"" width=""300"" />
        //                                </p>
        //                            </body></html>";

        //        string boundary = "MultiPartBoundary32541";
        //        string contentType = "multipart/form-data; boundary=" + boundary;

        //        HttpResponseMessage response;

        //        // Create the presentation part. 
        //        StringContent presentation = new StringContent(htmlBody);
        //        presentation.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
        //        presentation.Headers.ContentDisposition.Name = "Presentation";
        //        presentation.Headers.ContentType = new MediaTypeHeaderValue("text/html");

        //        StreamContent image;

        //        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
        //        var buff = (byte[])converter.ConvertTo(Microsoft.Graph.Test.Properties.Resources.hamilton, typeof(byte[]));
        //        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
        //        {
        //            // Create the image part.
        //            image = new StreamContent(ms);
        //            image.Headers.ContentDisposition = new ContentDispositionHeaderValue(@"form-data");
        //            image.Headers.ContentDisposition.Name = "imageBlock1";
        //            image.Headers.ContentType = new MediaTypeHeaderValue("image/png");

        //            // Put the multiparts togeter
        //            MultipartContent multiPartContent = new MultipartContent("form-data", boundary);
        //            multiPartContent.Add(presentation);
        //            multiPartContent.Add(image);
                    
        //            // Create the request message and add the content.
        //            HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Post, requestUrl);
        //            hrm.Content = multiPartContent;

        //            // Send the request and get the response.
        //            response = await graphClient.HttpProvider.SendAsync(hrm);
        //        }

        //        // Get the OneNote page that we created.
        //        if (response.IsSuccessStatusCode)
        //        {
        //            // Deserialize into OneNotePage object.
        //            var content = await response.Content.ReadAsStringAsync();
        //            testPage = graphClient.HttpProvider.Serializer.DeserializeObject<OnenotePage>(content);

        //            Assert.NotNull(testPage); // We didn't deserialize the OnenotePage object.
        //            Assert.True(testPage.GetType() == typeof(OnenotePage), $"Expected a OnenotePage object. Actual type is {testPage.GetType().ToString()} ");
        //            Assert.Contains(testPage.Title, title); // "Expected: title matches, Actual: they don't match.

        //            TestPageCleanUp();
        //        }
        //        else
        //            throw new ServiceException(
        //                new Error
        //                {
        //                    Code = response.StatusCode.ToString(),
        //                    Message = await response.Content.ReadAsStringAsync()
        //                });
        //    }
        //    catch (Microsoft.Graph.ServiceException e)
        //    {
        //        Assert.True(false, $"Error code: {e.Error.Code}");
        //    }

        //    catch (Exception e)
        //    {
        //        Assert.True(false, $"Error code: {e.Message}");
        //    }
        //}

        /// <summary>
        /// This is a workaround for updating a page.
        /// We can't support generation for the update scenario.
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/api/page_update
        /// The service expects PATCH https://graph.microsoft.com/v1.0/me/onenote/pages/{id}/content with a
        /// body that includes a JSON object that describes the PATCH. We generate a dummy object that is
        /// supposed to be set with the properties PATCH. 
        /// Issue: metadata describes a onenotePatchContent action. This scenario would probably generate correctly.
        /// This conflicts with the documentation.
        /// Issue: The documented form we cannot generate from our metadata. Docs say that we PATCH to the content structural property
        /// It is supposed to PATCH a OnenotePatchContentCommand. The content property is actually a stream. Metadata and service don't match.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteUpdatePage()
        {
            try
            {
                // Get a page of OneNote pages
                IOnenoteSectionPagesCollectionPage pageCollection = await graphClient.Me.Onenote.Sections[firstSectionID].Pages.Request().GetAsync();

                // Get a handle to the first section.
                string pageId = pageCollection[0].Id;

                // URL to update a page. https://graph.microsoft.com/v1.0/me/onenote/sections/{id}/pages/{id}/content
                var requestUrl = graphClient.Me.Onenote.Pages[pageId].Content.Request().RequestUrl;

                // Create the patch command to update thebody of the OneNote page.
                OnenotePatchContentCommand updateBodyCommand = new OnenotePatchContentCommand() {
                    Action = OnenotePatchActionType.Append,
                    Target = "body",
                    Content = @"<table><tr><td><p><b>Brazil</b></p></td><td><p>Germany</p></td></tr>
                                       <tr><td><p>France</p></td><td><p><b>Italy</b></p></td></tr>
                                       <tr><td><p>Netherlands</p></td><td><p><b>Spain</b></p></td></tr>
                                       <tr><td><p>Argentina</p></td><td><p><b>Germany</b></p></td></tr>
                                </table>",
                    Position = OnenotePatchInsertPosition.After
                };

                List<OnenotePatchContentCommand> commands = new List<OnenotePatchContentCommand>();
                commands.Add(updateBodyCommand);

                // Create the request message.
                HttpRequestMessage hrm = new HttpRequestMessage(new HttpMethod("PATCH"), requestUrl);

                // Serialize the OnenotePatchContentCommand object and add to the request.
                string updateBodyCommandString = graphClient.HttpProvider.Serializer.SerializeObject(commands);
                hrm.Content = new StringContent(updateBodyCommandString);
                hrm.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // Send the request and get the response.
                HttpResponseMessage response = await graphClient.HttpProvider.SendAsync(hrm);

                // We get a 204 No Content.
                if (response.IsSuccessStatusCode)
                {
                    Assert.Equal(System.Net.HttpStatusCode.NoContent, response.StatusCode); // Expected: 204 No Content, Actual: {response.StatusCode}
                }
                else
                    throw new ServiceException(
                        new Error
                        {
                            Code = response.StatusCode.ToString(),
                            Message = await response.Content.ReadAsStringAsync()
                        });
            }
            catch (Microsoft.Graph.ServiceException e)
            {
                Assert.True(false, $"Error code: {e.Error.Code}");
            }

            catch (Exception e)
            {
                Assert.True(false, $"Error code: {e.Message}");
            }
        }

        /// <summary>
        /// Add a page by using HTML passed in a stream.
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteCreatePageWithHtmlStream()
        {
            string testString = ". Choose positive.";

            // Create the request body.
            string htmlBody = $"<!DOCTYPE html><html><head><title>OneNoteAddPageHtmlWithStream test created this{testString}</title></head>" + 
                                    "<body>Generated from the test with the partial</body></html> ";
            byte[] byteArray = Encoding.ASCII.GetBytes(htmlBody);

            using (MemoryStream stream = new MemoryStream(byteArray))
            {
                // Create a OneNote page.
                testPage = await graphClient.Me.Onenote.Sections[firstSectionID].Pages.Request().AddAsync(stream, "text/html");
            }

            Assert.NotNull(testPage); // EXPECTED: A OneNote page, ACTUAL: null
            Assert.Contains(testPage.Title, testString); // EXPECTED: Test string from the create action in the title.

            TestPageCleanUp();
        }

        /// <summary>
        /// Add a page from HTML
        /// </summary>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task OneNoteAddPageWithHtml()
        {
            string testString = ". Choose positive.";

            // Create the request body.
            string htmlBody = $"<!DOCTYPE html><html><head><title>OneNoteAddPageHtmlWithStream test created this{testString}</title></head>" +
                                    "<body>Generated from the test with the partial</body></html> ";

            testPage = await graphClient.Me.Onenote.Sections[firstSectionID].Pages.Request().AddAsync(htmlBody, "text/html");

            Assert.NotNull(testPage); // EXPECTED: A OneNote page, ACTUAL: null
            Assert.Contains(testPage.Title, testString); // EXPECTED: Test string from the create action in the title.

            TestPageCleanUp();
        }

        /// <summary>
        /// Add a multi-part page.
        /// Needs ImageConverter to replace System.Drawing
        /// </summary>
//        [Fact(Skip = "No CI set up for functional tests")]
//        public async Async.Task OneNoteAddPageWithMultipart()
//        {
//            try
//            {
//                string title = "OneNoteAddPageMultipart test created this";
//                string htmlBody = $@"<!DOCTYPE html><html><head><title>{title}</title></head>
//                                    <body>Generated from the test
//                                        <p>
//                                            <img src=""name:imageBlock1"" alt=""an image on the page"" width=""300"" />
//                                        </p>
//                                    </body></html>
//";

//                string boundary = "MultiPartBoundary32541";
//                string contentType = "multipart/form-data; boundary=" + boundary;

//                // Create the presentation part. 
//                StringContent presentation = new StringContent(htmlBody);
//                presentation.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
//                presentation.Headers.ContentDisposition.Name = "Presentation";
//                presentation.Headers.ContentType = new MediaTypeHeaderValue("text/html");

//                StreamContent image;

//                // Get an image stream.
//                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
//                var buff = (byte[])converter.ConvertTo(Microsoft.Graph.Test.Properties.Resources.hamilton, typeof(byte[]));
//                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buff))
//                {
//                    // Create the image part.
//                    image = new StreamContent(ms);
//                    image.Headers.ContentDisposition = new ContentDispositionHeaderValue(@"form-data");
//                    image.Headers.ContentDisposition.Name = "imageBlock1";
//                    image.Headers.ContentType = new MediaTypeHeaderValue("image/png");

//                    // Put the multiparts together
//                    MultipartContent multiPartContent = new MultipartContent("form-data", boundary);
//                    multiPartContent.Add(presentation);
//                    multiPartContent.Add(image);

//                    // Get the multiPart stream and then send the request to add a page using the stream.
//                    testPage = await graphClient.Me.Onenote.Sections[firstSectionID].Pages.Request().AddAsync(multiPartContent);
//                }

//                Assert.NotNull(testPage); // We didn't deserialize the OnenotePage object.
//                Assert.True(testPage.GetType() == typeof(OnenotePage), $"Expected a OnenotePage object. Actual type is {testPage.GetType().ToString()} ");
//                Assert.Contains(htmlBody, testPage.Title); // Expected: title returned in the OneNotePage object is found in the source HTML. Actual: not found.

//                TestPageCleanUp();
//            }
//            catch (Microsoft.Graph.ServiceException e)
//            {
//                Assert.True(false, $"Error code: {e.Error.Code}");
//            }

//            catch (Exception e)
//            {
//                Assert.True(false, $"Error code: {e.Message}");
//            }
//        }

        /// <summary>
        /// Test the custom 'Root' partial request builder and accessing Onenote notebook collection.
        /// </summary>
        /// <returns></returns>
        [Fact(Skip = "No CI set up for functional tests")]
        public async Async.Task It_accesses_a_sites_OneNote_notebooks()
        {
            try
            {
                Site site = await graphClient.Sites.Root.Request().GetAsync();
                Assert.NotNull(site);

                IOnenoteNotebooksCollectionPage notebooks = await graphClient.Sites[site.Id].Onenote.Notebooks.Request().GetAsync();
                Assert.NotNull(notebooks);
            }
            catch (Exception)
            {
                Assert.True(false, "An unexpected exception was thrown. This test case failed.");
            }
        }
    }
}
