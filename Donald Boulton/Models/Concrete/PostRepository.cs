using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Donald_Boulton.Models.Repository;

namespace Donald_Boulton.Models.Repository.Concrete
{
    public class InMemoryPostRepository : IPostRepository
    {
        private List<Post> posts = new List<Post> {
            new Post{PostId=1,Title="Tag Helpers in Asp.Net Core",
                Description =" Learn how to build ASP.NET apps that can run anywhere. ",
                URL ="http://www.codedigest.com/posts/21/understanding-tag-helpers-in-aspnet-core-mvc",
                Category ="Asp.Net Core", CategoryImg="/images/banner1.svg" },
             new Post{PostId=2,Title="Creating Custom Tag Helpers in Asp.Net Core MVC",
                Description ="Asp.Net Core MVC also allows developers to write custom tag helpers by extending TagHelper class. ",
                URL ="http://www.codedigest.com/posts/15/creating-custom-tag-helpers-in-aspnet-core-mvc",
                Category ="Asp.Net Core", CategoryImg="/images/banner1.svg" },
               new Post{PostId=3,Title="Live Unit Testing in Visual Studio",
                Description ="Run Unit tests as you write code..",
                URL ="https://blogs.msdn.microsoft.com/visualstudio/2017/03/09/live-unit-testing-in-visual-studio-2017-enterprise/",
                Category ="Visual Studio", CategoryImg="/images/banner2.svg" },
                new Post{PostId=4,Title="A Lap Around Python in Visual Studio 2017",
                Description ="We’re delighted to announce that our rich Python toolchain is fully available in Visual Studio 2017. ",
                URL ="https://blogs.msdn.microsoft.com/visualstudio/2017/05/12/a-lap-around-python-in-visual-studio-2017/",
                Category ="Visual Studio", CategoryImg="/images/banner2.svg" },
                new Post{PostId=5,Title="Whats new in Visual Studio 2017",
                Description ="",
                URL ="https://www.visualstudio.com/vs/whatsnew/",
                Category ="Visual Studio", CategoryImg="/images/banner2.svg" },
                new Post{PostId=6,Title="Using Gulp in Visual Studio 2017",
                Description ="In this quick start article, let’s understand how to use this tool to automate some of the most repetitive tasks using Gulp in Visual Studio 2017.",
                URL ="http://www.codedigest.com/quick-start/14/using-of-gulp-gulpfilejs-in-visual-studio-2017",
                Category ="Packages", CategoryImg="/images/banner3.svg" },
                new Post{PostId=7,Title="Learn Bower Package Manager in 10 Minutes",
                Description ="Bower is an open source client side package manager used when developing web applications that extensively uses client side JavaScript libraries or CSS",
                URL ="http://www.codedigest.com/quick-start/7/learn-bower-package-manager-in-10-minutes",
                Category ="Packages", CategoryImg="/images/banner3.svg" },
                new Post{PostId=8,Title="What is Azure?",
                Description ="Microsoft Azure is a growing collection of integrated cloud services which developers and IT professionals use",
                URL ="https://azure.microsoft.com/en-in/overview/what-is-azure/",
                Category ="Azure", CategoryImg="/images/banner4.svg" },
                new Post{PostId=9,Title="Microsoft Azure Stack",
                Description ="Innovate through hybrid applications with Azure and Azure Stack",
                URL ="https://azure.microsoft.com/en-in/overview/azure-stack/",
                Category ="Azure", CategoryImg="/images/banner4.svg" }
        };

        public IEnumerable<Post> Posts => posts;
    }
}
