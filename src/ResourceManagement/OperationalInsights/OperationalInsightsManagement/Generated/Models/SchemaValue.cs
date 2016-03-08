// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    /// <summary>
    /// Value object for schema results.
    /// </summary>
    public partial class SchemaValue
    {
        private string _displayName;
        
        /// <summary>
        /// Optional. Gets or sets the display name.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private bool _facet;
        
        /// <summary>
        /// Optional. Gets or sets the boolean that indicates whether or not
        /// the field is a facet.
        /// </summary>
        public bool Facet
        {
            get { return this._facet; }
            set { this._facet = value; }
        }
        
        private bool _indexed;
        
        /// <summary>
        /// Optional. Gets or sets the boolean that indicates the field is
        /// searchable as free text.
        /// </summary>
        public bool Indexed
        {
            get { return this._indexed; }
            set { this._indexed = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private IList<string> _ownerType;
        
        /// <summary>
        /// Optional. Gets or sets the array of workflows containing the field.
        /// </summary>
        public IList<string> OwnerType
        {
            get { return this._ownerType; }
            set { this._ownerType = value; }
        }
        
        private bool _stored;
        
        /// <summary>
        /// Optional. Gets or sets the boolean that indicates whether or not
        /// the field is stored.
        /// </summary>
        public bool Stored
        {
            get { return this._stored; }
            set { this._stored = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Gets or sets the type.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SchemaValue class.
        /// </summary>
        public SchemaValue()
        {
            this.OwnerType = new LazyList<string>();
        }
    }
}
