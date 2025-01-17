﻿using System;
using RichardSzalay.MockHttp;
using Newtonsoft.Json;
using Patros.MockHttpExtensions.ContentTypeExtensions;

namespace Patros.MockHttpExtensions.JsonExtensions
{
    public static class JsonExtensions
    {
        public static MockedRequest WithJsonContent(this MockedRequest handler, string json)
        {
            handler.WithContent("application/json", json);
            return handler;
        }

        public static MockedRequest WithJsonSerializedContent(this MockedRequest handler, object obj)
        {
            handler.WithContent("application/json", JsonConvert.SerializeObject(obj));
            return handler;
        }
    }
}
