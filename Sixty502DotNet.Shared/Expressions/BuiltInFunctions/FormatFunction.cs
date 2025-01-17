﻿//-----------------------------------------------------------------------------
// Copyright (c) 2017-2023 informedcitizenry <informedcitizenry@gmail.com>
//
// Licensed under the MIT license. See LICENSE for full license information.
// 
//-----------------------------------------------------------------------------

namespace Sixty502DotNet.Shared;

/// <summary>
/// Implements a string formatter function.
/// </summary>
public sealed class FormatFunction : BuiltInFunctionObject
{
    /// <summary>
    /// Construct a new instance of the <see cref="FormatFunction"/> class.
    /// </summary>
	public FormatFunction()
        : base("format", -1)
    {
    }

    protected override ValueBase OnInvoke(SyntaxParser.ExpressionCallContext callSite, ArrayValue? parameters)
    {
        if (parameters?.Count < 1)
        {
            throw new Error(callSite.expr(), "Too few parameters to function");
        }
        if (parameters![0] is not StringValue format)
        {
            throw new Error(callSite.exprList().expr()[0], "Format parameter must be a string");
        }
        if (parameters.Count == 1)
        {
            return format;
        }
        object[] formatParams = new object[parameters.Count - 1];
        for (int i = 0; i < parameters.Count - 1; i++)
        {
            formatParams[i] = parameters[i + 1].ToObject()
                ?? parameters[i + 1].ToString()
                ?? "undefined";
        }
        return new StringValue($"\"{string.Format(format.AsString(), formatParams)}\"");
    }

    protected override bool OnEqualTo(ValueBase other)
    {
        return other is FormatFunction;
    }

    protected override void OnSetAs(ValueBase other)
    {
        if (other is not FormatFunction)
        {
            throw new TypeMismatchError();
        }
    }
}

