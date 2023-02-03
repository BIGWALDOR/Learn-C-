HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("http://www.microsoft.com");
WriteLine("Microsoft's home page has {0:N0} bytes.", response.Content.Headers.ContentLength);