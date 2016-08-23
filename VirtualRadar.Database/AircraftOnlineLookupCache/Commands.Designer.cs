﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualRadar.Database.AircraftOnlineLookupCache {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Commands {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Commands() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VirtualRadar.Database.AircraftOnlineLookupCache.Commands", typeof(Commands).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [AircraftDetail] (
        ///    [Icao]
        ///   ,[Registration]
        ///   ,[Country]
        ///   ,[Manufacturer]
        ///   ,[Model]
        ///   ,[ModelIcao]
        ///   ,[Operator]
        ///   ,[OperatorIcao]
        ///   ,[Serial]
        ///   ,[YearBuilt]
        ///   ,[CreatedUtc]
        ///   ,[UpdatedUtc]
        ///) VALUES (
        ///    @icao
        ///   ,@registration
        ///   ,@country
        ///   ,@manufacturer
        ///   ,@model
        ///   ,@modelIcao
        ///   ,@operator
        ///   ,@operatorIcao
        ///   ,@serial
        ///   ,@yearBuilt
        ///   ,@createdUtc
        ///   ,@updatedUtc
        ///);
        ///SELECT [AircraftDetailID] FROM [AircraftDetail] WHERE _ROWID_ = last_insert_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AircraftDetail_Insert {
            get {
                return ResourceManager.GetString("AircraftDetail_Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [AircraftDetail] (
        ///    [Icao]
        ///   ,[CreatedUtc]
        ///   ,[UpdatedUtc]
        ///) VALUES (
        ///    @icao
        ///   ,@createdUtc
        ///   ,@updatedUtc
        ///);
        ///.
        /// </summary>
        internal static string AircraftDetail_InsertMissing {
            get {
                return ResourceManager.GetString("AircraftDetail_InsertMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [AircraftDetail]
        ///   SET [Icao]          = @icao
        ///      ,[Registration]  = @registration
        ///      ,[Country]       = @country
        ///      ,[Manufacturer]  = @manufacturer
        ///      ,[Model]         = @model
        ///      ,[ModelIcao]     = @modelIcao
        ///      ,[Operator]      = @operator
        ///      ,[OperatorIcao]  = @operatorIcao
        ///      ,[Serial]        = @serial
        ///      ,[YearBuilt]     = @yearBuilt
        ///      ,[UpdatedUtc]    = @updatedUtc
        /// WHERE [AircraftDetailID] = @aircraftDetailId;
        ///.
        /// </summary>
        internal static string AircraftDetail_Update {
            get {
                return ResourceManager.GetString("AircraftDetail_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [AircraftDetail]
        ///   SET [UpdatedUtc] = @updatedUtc
        /// WHERE [AircraftDetailID] = @aircraftDetailId;
        ///.
        /// </summary>
        internal static string AircraftDetail_UpdateMissing {
            get {
                return ResourceManager.GetString("AircraftDetail_UpdateMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --
        ///-- DatabaseVersion
        ///--
        ///CREATE TABLE IF NOT EXISTS [DatabaseVersion]
        ///(
        ///    [Version]   INTEGER NOT NULL
        ///);
        ///
        ///
        ///--
        ///-- AircraftDetail
        ///--
        ///CREATE TABLE IF NOT EXISTS [AircraftDetail]
        ///(
        ///    [AircraftDetailID]   INTEGER PRIMARY KEY AUTOINCREMENT
        ///   ,[Icao]               VARCHAR(6) NOT NULL COLLATE NOCASE
        ///   ,[Registration]       VARCHAR(20) NULL COLLATE NOCASE
        ///   ,[Country]            NVARCHAR(200) NULL
        ///   ,[Manufacturer]       NVARCHAR(200) NULL
        ///   ,[Model]              NVARCHAR(200) NULL
        ///   , [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateSchema {
            get {
                return ResourceManager.GetString("UpdateSchema", resourceCulture);
            }
        }
    }
}
