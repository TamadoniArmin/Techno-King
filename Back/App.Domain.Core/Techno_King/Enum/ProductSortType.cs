using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProductSortType
    {
        Price = 1,
        Rating = 2,
        SalesCount = 3,
        DiscountPercentage = 4,
        CreatedAt = 5
    }
}
