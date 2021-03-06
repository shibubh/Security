// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Http;
using Microsoft.AspNet.HttpFeature.Security;
using Microsoft.AspNet.PipelineCore.Security;

namespace Microsoft.AspNet.Security.Infrastructure
{
    internal static class HttpContextExtensions
    {
        internal static IHttpAuthenticationFeature GetAuthentication(this HttpContext context)
        {
            var auth = context.GetFeature<IHttpAuthenticationFeature>();
            if (auth == null)
            {
                auth = new HttpAuthenticationFeature();
                context.SetFeature<IHttpAuthenticationFeature>(auth);
            }
            return auth;
        }
    }
}
