﻿using HangFire.Common;

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\QueuesPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Pages\QueuesPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\Pages\QueuesPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class QueuesPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






            
            #line 6 "..\..\Pages\QueuesPage.cshtml"
  
    Layout = new LayoutPage { Title = "Queues" };
    var queues = JobStorage.Queues();


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 11 "..\..\Pages\QueuesPage.cshtml"
 if (queues.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-warning\">\r\n        You have no queues yet. Try to enq" +
"ueue your first job.\r\n    </div>\r\n");


            
            #line 16 "..\..\Pages\QueuesPage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Queue</th>
                <th>Length</th>
                <th>Dequeued</th>
                <th>Next jobs</th>
            </tr>
        </thead>
        <tbody>
");


            
            #line 29 "..\..\Pages\QueuesPage.cshtml"
             foreach (var queue in queues)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a class=" +
"\"label-queue\" href=\"");


            
            #line 33 "..\..\Pages\QueuesPage.cshtml"
                                                Write(Request.LinkTo("/queues/" + queue.Name));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 34 "..\..\Pages\QueuesPage.cshtml"
                       Write(queue.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <t" +
"d>");


            
            #line 37 "..\..\Pages\QueuesPage.cshtml"
                   Write(queue.Length);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>\r\n                        <a href=\"");


            
            #line 39 "..\..\Pages\QueuesPage.cshtml"
                            Write(Request.LinkTo("/queues/dequeued/" + queue.Name));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 40 "..\..\Pages\QueuesPage.cshtml"
                       Write(queue.Dequeued);

            
            #line default
            #line hidden

            
            #line 40 "..\..\Pages\QueuesPage.cshtml"
                                           WriteLiteral("    \r\n                        </a>\r\n                    </td>\r\n                  " +
"  <td>");

            
            #line default
            #line hidden
            
            #line 43 "..\..\Pages\QueuesPage.cshtml"
                         if (queue.FirstJobs.Count == 0)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <em>No jobs queued.</em>\r\n");


            
            #line 46 "..\..\Pages\QueuesPage.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral(@"                        <table class=""table table-condensed table-bordered table-inner"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Job type</th>
                                    <th>Enqueued</th>
                                </tr>
                            </thead>
                            <tbody>
");


            
            #line 58 "..\..\Pages\QueuesPage.cshtml"
                                 foreach (var job in queue.FirstJobs)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <tr class=\"");


            
            #line 60 "..\..\Pages\QueuesPage.cshtml"
                                           Write(!job.Value.InEnqueuedState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        <td>\r\n                               " +
"             <a href=\"");


            
            #line 62 "..\..\Pages\QueuesPage.cshtml"
                                                Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 62 "..\..\Pages\QueuesPage.cshtml"
                                                                                    Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");


            
            #line 63 "..\..\Pages\QueuesPage.cshtml"
                                             if (!job.Value.InEnqueuedState)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <span title=\"Job\'s state has been" +
" changed while fetching data.\" class=\"glyphicon glyphicon-question-sign\"></span>" +
"\r\n");


            
            #line 66 "..\..\Pages\QueuesPage.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </td>\r\n                                  " +
"      <td>");


            
            #line 68 "..\..\Pages\QueuesPage.cshtml"
                                       Write(HtmlHelper.JobType(job.Value.Type));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                        <td>\r\n");


            
            #line 70 "..\..\Pages\QueuesPage.cshtml"
                                             if (job.Value.EnqueuedAt.HasValue)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <span data-moment=\"");


            
            #line 72 "..\..\Pages\QueuesPage.cshtml"
                                                              Write(JobHelper.ToStringTimestamp(job.Value.EnqueuedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                    ");


            
            #line 73 "..\..\Pages\QueuesPage.cshtml"
                                               Write(job.Value.EnqueuedAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </span>\r\n");


            
            #line 75 "..\..\Pages\QueuesPage.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </td>\r\n                                  " +
"  </tr>\r\n");


            
            #line 78 "..\..\Pages\QueuesPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </tbody>\r\n                        </table>\r\n");


            
            #line 81 "..\..\Pages\QueuesPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                </tr>\r\n");


            
            #line 84 "..\..\Pages\QueuesPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 87 "..\..\Pages\QueuesPage.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
