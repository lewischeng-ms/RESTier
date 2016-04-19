﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Restier.Core
{
    /// <summary>
    /// Specifies a set of methods that can participate in the
    /// configuration, initialization and disposal of an API.
    /// </summary>
    [Serializable]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public abstract class ApiConfiguratorAttribute : Attribute
    {
        /// <summary>
        /// Configures an API services.
        /// </summary>
        /// <param name="services">
        /// The API services registration.
        /// </param>
        /// <param name="type">
        /// The API type on which this attribute was placed.
        /// </param>
        [CLSCompliant(false)]
        public virtual void AddApiServices(
            IServiceCollection services,
            Type type)
        {
        }

        /// <summary>
        /// Configures an API configuration.
        /// </summary>
        /// <param name="configuration">
        /// An API configuration.
        /// </param>
        /// <param name="type">
        /// The API type on which this attribute was placed.
        /// </param>
        public virtual void Configure(
            ApiConfiguration configuration,
            Type type)
        {
        }

        /// <summary>
        /// Initializes an API context.
        /// </summary>
        /// <param name="context">
        /// An API context.
        /// </param>
        /// <param name="type">
        /// The API type on which this attribute was placed.
        /// </param>
        /// <param name="instance">
        /// An API instance, if applicable.
        /// </param>
        public virtual void Initialize(
            ApiContext context,
            Type type,
            object instance)
        {
        }

        /// <summary>
        /// Disposes an API context.
        /// </summary>
        /// <param name="context">
        /// An API context.
        /// </param>
        /// <param name="type">
        /// The API type on which this attribute was placed.
        /// </param>
        /// <param name="instance">
        /// An API instance, if applicable.
        /// </param>
        public virtual void Dispose(
            ApiContext context,
            Type type,
            object instance)
        {
        }
    }
}
