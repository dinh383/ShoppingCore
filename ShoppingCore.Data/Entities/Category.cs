using ShoppingCore.Data.Interfaces;
using ShoppingCore.Infrastructure.SharedKernel;
using System;

namespace ShoppingCore.Data.Entities
{
    public class Category : DomainEntity<int>, IDateTracking, IHasOwner<string>, IMultiLanguage<string>,IHasSeoMetaData
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public virtual AppUser Owner { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string OwnerId { set; get; }
        public string LanguageId { set; get; }
        public virtual Language Language { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
    }
}