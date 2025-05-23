﻿using System.Collections.Specialized;

namespace YPermitin.SQLCLR.ClickHouseClient.Utility
{
    public static class NameValueCollectionExtensions
    {
        public static void SetOrRemove(this NameValueCollection collection, string name, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                collection.Set(name, value);
            }
            else
            {
                collection.Remove(name);
            }
        }
    }
}