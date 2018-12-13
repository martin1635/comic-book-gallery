using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {

        // PROPERTIES
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favourite { get; set; }

        public string DisplayText
        {
            get
            {
                return this.SeriesTitle + " #" + this.IssueNumber;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-"
                    + this.IssueNumber + ".jpg";
            }
        }

    }
}