﻿/*
' Copyright (c) 2014 Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using System.Web.Caching;
using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;

namespace Satrabel.Modules.OpenBlocks.Components
{
    [TableName("OpenBlocks_Blocks")]
    //setup the primary key for table
    [PrimaryKey("BlockId", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("Blocks", CacheItemPriority.Default, 20)]
    //scope the objects to the PortalId of a module on a page (or copy of a module on a page)
    [Scope("PortalId")]
    public class Block
    {
        ///<summary>
        /// The ID of your object with the name of the Block
        ///</summary>
        public int BlockId { get; set; }

        public int BlockType { get; set; }
        ///<summary>
        /// A string with the name of the Block
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// A string with the content of the object
        ///</summary>
        public string Content { get; set; }

        ///<summary>
        /// An integer with the user id of the assigned user for the object
        ///</summary>
        public int AssignedUserId { get; set; }

        public string CultureCode { get; set; }

        ///<summary>
        /// The ModuleId of where the object was created and gets displayed
        ///</summary>
        public int PortalId { get; set; }

        ///<summary>
        /// An integer for the user id of the user who created the object
        ///</summary>
        public int CreatedByUserId { get; set; }

        ///<summary>
        /// An integer for the user id of the user who last updated the object
        ///</summary>
        public int LastModifiedByUserId { get; set; }

        ///<summary>
        /// The date the object was created
        ///</summary>
        public DateTime CreatedOnDate { get; set; }

        ///<summary>
        /// The date the object was updated
        ///</summary>
        public DateTime LastModifiedOnDate { get; set; }
    }
}


