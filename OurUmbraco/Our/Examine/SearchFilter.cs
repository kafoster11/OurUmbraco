﻿using Lucene.Net.Search;

namespace OurUmbraco.Our.Examine
{
    public class SearchFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public SearchFilter(string fieldName, object value)
        {
            FieldName = fieldName;
            Value = value;
        }

        public string FieldName { get; private set; }
        public object Value { get; private set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return string.Format("{0}:{1}", FieldName, Value);
        }

        /// <summary>
        /// Can be used to return a true LUcene query object if the string format is not good enough
        /// </summary>
        /// <returns></returns>
        public virtual Query GetLuceneQuery()
        {
            return null;
        }
    }
}