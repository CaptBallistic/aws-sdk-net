﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ServiceInterface : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.Collections.Generic;\r\n\r\nusing Amazon.Runtime;\r\nus" +
                    "ing ");
            
            #line 15 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\n\r\nnamespace ");
            
            #line 17 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
    this.FormatServiceInterfaceDocumentation(this.Config.ServiceModel.Documentation); 
            
            #line default
            #line hidden
            this.Write("\tpublic partial interface IAmazon");
            
            #line 20 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" : IAmazonService, IDisposable\r\n\t{\r\n\r\n\r\n");
            
            #line 24 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

    // Creates paginators for service if available
    if (this.Config.ServiceModel.HasPaginators)
    {

            
            #line default
            #line hidden
            this.Write("#if BCL45 || AWS_ASYNC_ENUMERABLES_API\r\n        /// <summary>\r\n        /// Pagina" +
                    "tors for the service\r\n        /// </summary>\r\n        I");
            
            #line 33 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceNameRoot));
            
            #line default
            #line hidden
            this.Write("PaginatorFactory Paginators { get; }\r\n#endif\r\n");
            
            #line 35 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n\r\n\t\t");
            
            #line 40 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

		foreach(var operation in this.Config.ServiceModel.Operations)
		{
            if(operation.IsInternal)
                continue;
		
            
            #line default
            #line hidden
            this.Write("\r\n\t\t#region  ");
            
            #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 49 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        // Creates a method for the operation that takes no parameters if the operation has a request that requires no members to be set
        if (this.Config.ServiceModel.Customizations.CreateNoArgOverload(operation.Name))
        {

            
            #line default
            #line hidden
            
            #line 54 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        this.FormatOperationDocumentationSync(operation, false);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 59 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 60 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 63 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 63 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        }

        AddSimpleClientMethodInterfaces(operation, true);

            
            #line default
            #line hidden
            
            #line 69 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        this.FormatOperationDocumentationSync(operation, true);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 74 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 75 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 78 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 78 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 78 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request);\r\n\r\n");
            
            #line 80 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
AddBeginAsyncDocumentation(operation);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 84 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 85 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        IAsyncResult Begin");
            
            #line 88 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 88 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request, AsyncCallback callback, object state);\r\n\r\n\r\n\r\n");
            
            #line 92 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
AddEndAsyncDocumentation(operation);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 96 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 100 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response End");
            
            #line 100 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(IAsyncResult asyncResult);\r\n\r\n\t\t#endregion\r\n\t\t");
            
            #line 103 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

		}
		
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
