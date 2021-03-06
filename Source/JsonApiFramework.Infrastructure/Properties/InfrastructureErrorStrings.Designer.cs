﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JsonApiFramework {
    using System;
    using System.Reflection;
    
    
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
    internal class InfrastructureErrorStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal InfrastructureErrorStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JsonApiFramework.Properties.InfrastructureErrorStrings", typeof(InfrastructureErrorStrings).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Unable to build &apos;{0}&apos; for a collection [count={1}] of CLR resources or CLR resource identifiers [type={2}] with a collection [count={3}] of &apos;{0}&apos; objects, collection counts mismatch. Make sure the collection counts are the same..
        /// </summary>
        internal static string DocumentBuildExceptionDetailBuildResourceCollectionCountMismatch {
            get {
                return ResourceManager.GetString("DocumentBuildExceptionDetailBuildResourceCollectionCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to build &apos;{0}&apos; for a collection of CLR resources or CLR resource identifiers [type={1}] with a single &apos;{0}&apos; object..
        /// </summary>
        internal static string DocumentBuildExceptionDetailBuildResourceCollectionWithSingleObject {
            get {
                return ResourceManager.GetString("DocumentBuildExceptionDetailBuildResourceCollectionWithSingleObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to build &apos;{0}&apos; for a single CLR resource or CLR resource identifier [type={1}] with a collection of &apos;{0}&apos; objects..
        /// </summary>
        internal static string DocumentBuildExceptionDetailBuildResourceWithCollectionOfObjects {
            get {
                return ResourceManager.GetString("DocumentBuildExceptionDetailBuildResourceWithCollectionOfObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Document Build Error.
        /// </summary>
        internal static string DocumentBuildExceptionTitle {
            get {
                return ResourceManager.GetString("DocumentBuildExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} was not configured for this document context..
        /// </summary>
        internal static string DocumentContextExtensionValidationConfigurationError {
            get {
                return ResourceManager.GetString("DocumentContextExtensionValidationConfigurationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get the single CLR resource [type={0} id={1}] in the json:api document, json:api document has multiple resources with the same resource identity..
        /// </summary>
        internal static string DocumentReadExceptionGetMultipleResourcesExistWithSameIdentity {
            get {
                return ResourceManager.GetString("DocumentReadExceptionGetMultipleResourcesExistWithSameIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get the single CLR resource or resource identifier [type={0}] in the json:api document, json:api document has multiple resources or resource identifiers with the same resource type..
        /// </summary>
        internal static string DocumentReadExceptionGetMultipleResourcesExistWithSameType {
            get {
                return ResourceManager.GetString("DocumentReadExceptionGetMultipleResourcesExistWithSameType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get the &apos;to-many&apos; related CLR resource collection [type={0}] with a &apos;to-one&apos; CLR relationship object. Call the get &apos;to-many&apos; related CLR resource collection method with a &apos;to-many&apos; CLR relationship object..
        /// </summary>
        internal static string DocumentReadExceptionGetToManyRelatedResourceCollectionWithToOneRelationship {
            get {
                return ResourceManager.GetString("DocumentReadExceptionGetToManyRelatedResourceCollectionWithToOneRelationship", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get the &apos;to-one&apos; related CLR resource [type={0}] with a &apos;to-many&apos; CLR relationship object. Call the get &apos;to-one&apos; related CLR resource method with a &apos;to-one&apos; CLR relationship object..
        /// </summary>
        internal static string DocumentReadExceptionGetToOneRelatedResourceWithToManyRelationship {
            get {
                return ResourceManager.GetString("DocumentReadExceptionGetToOneRelatedResourceWithToManyRelationship", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Document Read Error.
        /// </summary>
        internal static string DocumentReadExceptionTitle {
            get {
                return ResourceManager.GetString("DocumentReadExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Document Write Error.
        /// </summary>
        internal static string DocumentWriteExceptionTitle {
            get {
                return ResourceManager.GetString("DocumentWriteExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DOM node [type={0}] already contains DOM child node [type={1}]. Only add the DOM child node [type={1}] once..
        /// </summary>
        internal static string DomExceptionDetailNodeAlreadyContainsChildNode {
            get {
                return ResourceManager.GetString("DomExceptionDetailNodeAlreadyContainsChildNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DOM node [type={0}] already contains DOM child node [rel={1} type={2}]. Only add the DOM child node [rel={1} type={2}] once..
        /// </summary>
        internal static string DomExceptionDetailNodeAlreadyContainsRelBasedChildNode {
            get {
                return ResourceManager.GetString("DomExceptionDetailNodeAlreadyContainsRelBasedChildNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DOM node [type={0}] attribute [name={1}] is missing. Can only get existing attributes..
        /// </summary>
        internal static string DomExceptionDetailNodeGetMissingAttribute {
            get {
                return ResourceManager.GetString("DomExceptionDetailNodeGetMissingAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DOM node [type={0}] already contains DOM child node [type={1}], can not add DOM child node [type={2}] because these two DOM child nodes can not coexist as sibling DOM nodes. Would violate the JSON API specification..
        /// </summary>
        internal static string DomExceptionDetailNodeHasChildNodesThatMustNotCoexist {
            get {
                return ResourceManager.GetString("DomExceptionDetailNodeHasChildNodesThatMustNotCoexist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DOM node [type={0}] contains incompatible DOM child node [type={1}] and DOM child node [type={2}]..
        /// </summary>
        internal static string DomExceptionDetailNodeHasIncompatibleChildNodes {
            get {
                return ResourceManager.GetString("DomExceptionDetailNodeHasIncompatibleChildNodes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DOM node  [type={0}] has no access to a service model..
        /// </summary>
        internal static string DomExceptionDetailNodeHasNoServiceModel {
            get {
                return ResourceManager.GetString("DomExceptionDetailNodeHasNoServiceModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DOM node [type={0}] contains an unexpected DOM child node [type={1}]..
        /// </summary>
        internal static string DomExceptionDetailNodeHasUnexpectedChildNode {
            get {
                return ResourceManager.GetString("DomExceptionDetailNodeHasUnexpectedChildNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DOM node [type={0}] attribute [name={1}] already exists. Can only set an attribute one-time..
        /// </summary>
        internal static string DomExceptionDetailNodeSetExistingAttribute {
            get {
                return ResourceManager.GetString("DomExceptionDetailNodeSetExistingAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal DOM Error.
        /// </summary>
        internal static string DomExceptionTitle {
            get {
                return ResourceManager.GetString("DomExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has missing &apos;{1}&apos; extension. Ensure extension is configured and added correctly to the {0} object..
        /// </summary>
        internal static string InternalErrorExceptionDetailMissingExtension {
            get {
                return ResourceManager.GetString("InternalErrorExceptionDetailMissingExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown or unexpected {0} enumeration value of &apos;{1}&apos;..
        /// </summary>
        internal static string InternalErrorExceptionDetailUnknownEnumerationValue {
            get {
                return ResourceManager.GetString("InternalErrorExceptionDetailUnknownEnumerationValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal Error.
        /// </summary>
        internal static string InternalErrorExceptionTitle {
            get {
                return ResourceManager.GetString("InternalErrorExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has missing {1} metadata. Ensure metadata is configured correctly for the respective domain/schema..
        /// </summary>
        internal static string MetadataExceptionDetailMissingMetadata {
            get {
                return ResourceManager.GetString("MetadataExceptionDetailMissingMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metadata Error.
        /// </summary>
        internal static string MetadataExceptionTitle {
            get {
                return ResourceManager.GetString("MetadataExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access a disposed object. A common cause of this error is disposing a document context that was resolved from dependency injection and then later trying to use the same document context instance elsewhere in your application. This may occur is you are calling Dispose() on the document context, or wrapping the document context in a using statement. If you are using dependency injection, you should let the dependency injection container take care of disposing document context instances..
        /// </summary>
        internal static string ObjectDisposedExceptionDetailDocumentContext {
            get {
                return ResourceManager.GetString("ObjectDisposedExceptionDetailDocumentContext", resourceCulture);
            }
        }
    }
}
