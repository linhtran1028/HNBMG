using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace HNBMG.Models.Pages
{
    [ContentType(DisplayName = "AirJordan", GUID = "9cc44f36-8ab2-4aa0-b2c2-1b501eeef9d2", Description = "")]
    public class AirJordan : PageData
    {
            [CultureSpecific]
            [Display(
              Name = "Heading",
              Description = "The page heading",
              GroupName = SystemTabNames.Content,
              Order = 0)]
            public virtual String Heading { get; set; }

        [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
        [CultureSpecific]
        [Display(
                  Name = "Main body 1",
                  Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                  GroupName = SystemTabNames.Content,
                  Order = 1)]
        public virtual XhtmlString MainBody1 { get; set; }
        [CultureSpecific]
        [Display(
                    Name = "Main body 2",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual XhtmlString MainBody2 { get; set; }
        [CultureSpecific]
        [Display(
                   Name = "Main body 3",
                   Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                   GroupName = SystemTabNames.Content,
                   Order = 1)]
        public virtual XhtmlString MainBody3 { get; set; }
        [CultureSpecific]
        [Display(
                   Name = "Main body 4",
                   Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                   GroupName = SystemTabNames.Content,
                   Order = 1)]
        public virtual XhtmlString MainBody4 { get; set; }
        [CultureSpecific]
        [Display(
                    Name = "Main body 5",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual XhtmlString MainBody5 { get; set; }
        [CultureSpecific]
        [Display(
                   Name = "Main body 6",
                   Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                   GroupName = SystemTabNames.Content,
                   Order = 2)]
        public virtual XhtmlString MainBody6 { get; set; }
    }
}