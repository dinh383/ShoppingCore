using ShoppingCore.Data.Interfaces;
using ShoppingCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.Data.Entities
{
    public class Product : DomainEntity<int>, IDateTracking, IHasOwner<string>, IMultiLanguage<string>, IHasSeoMetaData, ISortable
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnails { get; set; }

        public string MoreImages { get; set; }


        public decimal Price { get; set; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string OwnerId { set; get; }
        public AppUser Owner { set; get; }
        public string LanguageId { set; get; }
        public Language Language { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public int SortOrder { set; get; }
    }
}
