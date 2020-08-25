using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace HNBMG.Models.Pages
{
    [ContentType(GUID = "EE3BD195-7CB0-4756-AB5F-E5E223CD9820")]
    public class GenericMedia : MediaData
    {
        public virtual string Description { get; set; }
    }

    [ContentType(GUID = "0A89E464-56D4-449F-AEA8-2BF774AB8730")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        public virtual string Description { get; set; }
        public virtual string Copyright { get; set; }
    }

    [ContentType(DisplayName = "HnbmgPage", GUID = "45f8ac90-e2d8-492f-8035-a347aa557a34", Description = "")]
    public class HnbmgPage : PageData
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
                    Order = 2)]
        public virtual XhtmlString MainBody1 { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Main body 2",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 2)]
        public virtual XhtmlString MainBody2 { get; set; }

        [CultureSpecific]
        [Display(
                   Name = "Main body 3",
                   Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                   GroupName = SystemTabNames.Content,
                   Order = 2)]
        public virtual XhtmlString MainBody3 { get; set; }

        [CultureSpecific]
        [Display(
                   Name = "Main body 4",
                   Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                   GroupName = SystemTabNames.Content,
                   Order = 2)]
        public virtual XhtmlString MainBody4 { get; set; }

        [CultureSpecific]
        [Display(
                  Name = "Main body 5",
                  Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                  GroupName = SystemTabNames.Content,
                  Order = 2)]
        public virtual XhtmlString MainBody5 { get; set; }

        [CultureSpecific]
        [Display(
                 Name = "Main body 6",
                 Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                 GroupName = SystemTabNames.Content,
                 Order = 2)]
        public virtual XhtmlString MainBody6 { get; set; }

        [CultureSpecific]
        [Display(
                 Name = "Main body 7",
                 Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                 GroupName = SystemTabNames.Content,
                 Order = 2)]
        public virtual XhtmlString MainBody7 { get; set; }

         [CultureSpecific]
        [Display(
                 Name = "Main body 8",
                 Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                 GroupName = SystemTabNames.Content,
                 Order = 2)]
        public virtual XhtmlString MainBody8 { get; set; }


        [CultureSpecific]
        [Display(
                Name = "Main body 9",
                Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                GroupName = SystemTabNames.Content,
                Order = 2)]
        public virtual XhtmlString MainBody9 { get; set; }

        [CultureSpecific]
        [Display(
               Name = "Main body 10",
               Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
               GroupName = SystemTabNames.Content,
               Order = 2)]
        public virtual XhtmlString MainBody10 { get; set; }
    }
}