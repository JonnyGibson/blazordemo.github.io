﻿using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class FiltersController : Controller
    {
        [Route("filters")]
        public  IEnumerable<FilterLookupItem> Filters(FilterType filterType)
        {

            switch (filterType)
            {
                case FilterType.Company:
                    return SampleData.Companies.Select(x => new FilterLookupItem(x.Key, x.Value));
                    break;
                case FilterType.Sector:
                    return SampleData.Sectors.Select(x => new FilterLookupItem(x.Key, x.Value));
                    break;
                case FilterType.Rating:
                    return SampleData.Ratings.Select(x => new FilterLookupItem(x.Key, x.Value));
                    break;
                case FilterType.Type:
                    return SampleData.FundTypes.Select(x => new FilterLookupItem(x.Key, x.Value));
                    break;
                default:
                    return null;
                    break;
            };
        }
    }
}
