﻿using System.Collections.Generic;
using System.Web.Mvc;
using Ilaro.Admin.Core;
using Ilaro.Admin.Extensions;

namespace Ilaro.Admin.Filters
{
    public class ForeignEntityFilter : BaseFilter
    {
        public override Property Property { get; protected set; }
        public override sealed SelectList Options { get; protected set; }
        public override sealed string Value { get; protected set; }
        public override bool DisplayInUI { get { return false; } }

        public ForeignEntityFilter(Property property, string value = "")
            : base(property, value)
        {
        }

        public override string GetSqlCondition(string alias, ref List<object> args)
        {
            var sql = "{0}{1} = @{2}".Fill(alias, Property.ColumnName, args.Count);
            args.Add(Value);
            return sql;
        }
    }
}