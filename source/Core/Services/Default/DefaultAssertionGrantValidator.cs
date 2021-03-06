﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Security.Claims;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Validation;

namespace Thinktecture.IdentityServer.Core.Services.Default
{
    /// <summary>
    /// Default custom grant validator
    /// </summary>
    public class DefaultCustomGrantValidator : ICustomGrantValidator
    {
        /// <summary>
        /// Validates the custom grant request.
        /// </summary>
        /// <param name="request">The validated token request.</param>
        /// <returns>
        /// A principal
        /// </returns>
        public Task<ClaimsPrincipal> ValidateAsync(ValidatedTokenRequest request)
        {
            return Task.FromResult<ClaimsPrincipal>(null);
        }
    }
}