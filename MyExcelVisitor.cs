﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace MyExcel
{
    class MyExcelVisitor : MyExcelBaseVisitor<double>
    {
        public static Dictionary<string, Cell> tableIdentifier = new Dictionary<string, Cell>();
        public override double VisitCompileUnit(MyExcelParser.CompileUnitContext context)
        {
            return Visit(context.expression());
        }
        
        public override double VisitNumberExpr(MyExcelParser.NumberExprContext context)
        {
            var result = double.Parse(context.GetText());
            Debug.WriteLine(result);
            return result;
        }
        public override double VisitMaxExpr(MyExcelParser.MaxExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            Debug.WriteLine("max({0}, {1})", left, right);
            return Math.Max(left, right);
        }
        public override double VisitMinExpr(MyExcelParser.MinExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            Debug.WriteLine("min({0}, {1})", left, right);
            return Math.Min(left, right);
        }
        public override double VisitIncExpr(MyExcelParser.IncExprContext context)
        {
            var type = context.GetText();
            Debug.WriteLine("inc({0})", type);
            try
            {
                return Visit(context.expression()) + 1;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public override double VisitDecExpr(MyExcelParser.DecExprContext context)
        {
            var type = context.GetText();
            Debug.WriteLine("dec({0})", type);
            return Visit(context.expression()) - 1;
        }
        public override double VisitIdentifierExpr(MyExcelParser.IdentifierExprContext context)
        {

            var result = context.GetText();
            if (tableIdentifier.TryGetValue(result.ToString(), out Cell cell))
            {
                if (Calculator.Registry.TryGetValue(cell.Name, out var value))
                {
                    if (value == false)
                    {
                        Calculator.Registry[cell.Name] = true;
                        return Convert.ToDouble(Calculator.PrvtEvaluate(cell.Value));
                    }
                }
            }
            string errorMsg = "Error at '" + result + "'";
            throw new Exception(errorMsg);
            return 0;
        }
        public override double VisitParenthesizedExpr(MyExcelParser.ParenthesizedExprContext context)
        {
            return Visit(context.expression());
        }
        public override double VisitExponentialExpr(MyExcelParser.ExponentialExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            Debug.WriteLine("{0}^{1}", left, right);
            return Math.Pow(left, right);
        }
        public override double VisitAdditiveExpr(MyExcelParser.AdditiveExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == MyExcelLexer.ADD)
            {
                Debug.WriteLine("{0} + {1}", left, right);
                return left + right;
            }
            else //MyExcelLexer.SUBTRACT
            {
                Debug.WriteLine("{0} - {1}", left, right);
                return left - right;
            }
        }
        public override double VisitMultiplicativeExpr(MyExcelParser.MultiplicativeExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == MyExcelLexer.MULTIPLY)
            {
                Debug.WriteLine("{0} * {1}", left, right);
                return left * right;
            }
            else //MyExcelLexer.DIVIDE
            {
                Debug.WriteLine("{0} / {1}", left, right);
                if (right == 0)
                {
                    throw new ArgumentException("'0'");
                }
                return left / right;
            }
        }
        private double WalkLeft(MyExcelParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<MyExcelParser.ExpressionContext>(0));
        }
        private double WalkRight(MyExcelParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<MyExcelParser.ExpressionContext>(1));
        }
    }
}