﻿// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using JsonApiFramework.Json;

using Newtonsoft.Json.Linq;

namespace JsonApiFramework.JsonApi
{
    /// <summary>
    /// Represents a json:api compliant meta object.
    /// </summary>
    /// <see cref="http://jsonapi.org"/>
    public class Meta : JsonObject
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Object Overrides
        public override string ToString()
        {
            var metaAsJson = this.JObject.SafeToString();
            return "{0} [{1}]".FormatWith(TypeName, metaAsJson);
        }
        #endregion

        #region Metadata Methods
        public static Meta Create<T>(T data)
        {
            var jObject = JObject.FromObject(data);
            var meta = (Meta)jObject;
            return meta;
        }

        public T GetData<T>()
        {
            if (this.JObject == null)
                return default(T);

            var data = this.JObject.ToObject<T>();
            return data;
        }

        public void SetData<T>(T data)
        {
            var jObject = JObject.FromObject(data);
            this.JObject = jObject;
        }
        #endregion

        // PUBLIC OPERATORS /////////////////////////////////////////////////
        #region Conversion Operators
        public static implicit operator JObject(Meta meta)
        {
            return meta?.JObject;
        }

        public static implicit operator Meta(JObject jObject)
        {
            return jObject != null
                ? new Meta
                    {
                        JObject = jObject
                    }
                : null;
        }
        #endregion

        // PRIVATE PROPERTIES ///////////////////////////////////////////////
        #region Non-JSON Properties
        private JObject JObject { get; set; }
        #endregion

        // PRIVATE FIELDS ///////////////////////////////////////////////////
        #region Fields
        private static readonly string TypeName = typeof(Meta).Name;
        #endregion
    }
}