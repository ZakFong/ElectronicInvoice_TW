﻿using System;
using System.Linq;

namespace ElectronicInvoice.Produce.Extension
{
    public static class ExtensionAttribute
    {
        public static TValue GetAttributeValue<TAttribute, TValue>(
          this Type attrType,
          Func<TAttribute, TValue> selector) where TAttribute : Attribute
        {
            var attr = attrType.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;
            if (attr != null)
            {
                return selector(attr);
            }
            return default(TValue);
        }
    }
}