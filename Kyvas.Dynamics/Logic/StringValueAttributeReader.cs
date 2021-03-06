﻿using System.Linq;
using System.Reflection;
using Kyvas.Dynamics.Attributes;

namespace Kyvas.Dynamics.Logic
{
    public static class StringValueAttributeReader
    {
        public static string GetFirstValueOrName(PropertyInfo property)
        {
            var attributes = property.GetCustomAttributes(typeof(StringValueAttribute)).OfType<StringValueAttribute>();
            return attributes.FirstOrDefault()?.Value ?? property.Name;
        }

        public static string GetFirstValueOrName(FieldInfo property)
        {
            var attributes = property.GetCustomAttributes(typeof(StringValueAttribute)).OfType<StringValueAttribute>();
            return attributes.FirstOrDefault()?.Value ?? property.Name;
        }
    }
}
