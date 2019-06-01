using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using eCommerce.Application;

namespace eCommerce.WebService.Extensions
{
    public class MappingConfig
    {
        public static void RegisterMapping()
        {
            Mapper.AddProfile(new Map());
        }
    }
}