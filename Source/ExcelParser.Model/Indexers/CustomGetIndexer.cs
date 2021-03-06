﻿using System;

namespace ExcelParser.Model.Indexers
{
    public abstract class CustomGetIndexer<TIn, TOut> : CustomIndexer<TIn, TOut>
    {
        protected override Action<TIn, TOut> Setter
        {
            get
            {
                throw new InvalidOperationException("This indexer has no Setter");
            }
        }
    }
}