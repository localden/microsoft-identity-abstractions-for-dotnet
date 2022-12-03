﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Net.Http;

namespace Microsoft.Identity.Abstractions
{
    /// <summary>
    /// Specialization of <see cref="DownstreamRestApiOptions"/> where the <see cref="AuthorizationHeaderProviderOptions.HttpMethod"/>
    /// is not settable beyond it's construction.
    /// </summary>
    /// <remarks>This class is useful to provide a better developer experience on the specialized methods
    /// of <see cref="IDownstreamRestApi"/> where the HTTP method is provided already by the name of the 
    /// method, and should not be overriden by the options.</remarks>
    public class DownstreamRestApiOptionsNoHttpMethod : DownstreamRestApiOptions
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DownstreamRestApiOptionsNoHttpMethod()
        {

        }

        /// <summary>
        /// Copy constructor for <see cref="DownstreamRestApiOptionsNoHttpMethod"/>.
        /// </summary>
        /// <param name="other">other instance to copy from.</param>
        public DownstreamRestApiOptionsNoHttpMethod(DownstreamRestApiOptionsNoHttpMethod other) : base(other)
        {

        }

        /// <summary>
        /// Constructor fro a <see cref="DownstreamRestApiOptions"/> and an HTTP method.
        /// </summary>
        /// <param name="options">Options</param>
        /// <param name="httpMethod">HTTP method.</param>
        public DownstreamRestApiOptionsNoHttpMethod(DownstreamRestApiOptions options, HttpMethod httpMethod) : base(options)
        {
            HttpMethod = httpMethod;
        }

        /// <summary>
        /// Http method only readable publicly.
        /// </summary>
        public new HttpMethod HttpMethod { get { return base.HttpMethod; } private set { base.HttpMethod = value; } }

        /// <inheritdoc/>
        public override AuthorizationHeaderProviderOptions Clone()
        {
            return new DownstreamRestApiOptionsNoHttpMethod(this);
        }
    }
}
