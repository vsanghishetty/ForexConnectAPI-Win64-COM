using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace fxcore2.com
{
    class Utils
    {
        /// <summary>
        /// When native object of wrapper id null return null, otherwise return wrapper object
        /// </summary>
        /// <param name="nativeObj"></param>
        /// <returns></returns>
        public static IWrapperBase CheckWrapperForNativeNull(IWrapperBase wrapperObj)
        {
            if (wrapperObj.NativeObj == null)
                return null;
            else
                return wrapperObj;
        }

        public static object FixColumnValueType(object columnValue)
        {
            if (columnValue.GetType() == typeof(short) || columnValue.GetType() == typeof(int) || columnValue.GetType() == typeof(uint))
                return (int)(short)columnValue;
            else if (columnValue.GetType() == typeof(ushort))
                return (int)(ushort)columnValue;
            else if (columnValue.GetType() == typeof(ulong))
                return (int)(ulong)columnValue;
            else if (columnValue.GetType() == typeof(long))
                return (int)(long)columnValue;
            else if (columnValue.GetType() == typeof(byte))
                return (int)(byte)columnValue;
            else if (columnValue.GetType() == typeof(sbyte))
                return (int)(sbyte)columnValue;
            else if (columnValue.GetType() == typeof(uint))
                return (int)(uint)columnValue;
            else if (columnValue.GetType() == typeof(float))
                return (double)columnValue;
            else if (columnValue.GetType() == typeof(decimal))
                return (int)(decimal)columnValue;
            else if (columnValue.GetType() == typeof(char))
                return ((char)columnValue).ToString();
            else if (columnValue.GetType() == typeof(bool) || columnValue.GetType() == typeof(string) || columnValue.GetType() == typeof(DateTime) || columnValue.GetType() == typeof(int) || columnValue.GetType() == typeof(double))
                return columnValue; //as is
            else
                throw new Exception("Type is not supported");
        }

        public static IRow CastToParticularRowType(fxcore2.O2GRow row, Session session)
        {
            switch (row.TableType)
            {
                case O2GTableType.Accounts:
                    if(row is fxcore2.O2GAccountTableRow)
                        return new AccountTableRow((fxcore2.O2GAccountTableRow)row, session);
                    else
                        return new AccountRow((fxcore2.O2GAccountRow)row, session);
                case O2GTableType.ClosedTrades:
                    if(row is fxcore2.O2GClosedTradeTableRow)
                        return new ClosedTradeTableRow((fxcore2.O2GClosedTradeTableRow)row, session);
                    else
                        return new ClosedTradeRow((fxcore2.O2GClosedTradeRow)row, session);
                case O2GTableType.Messages:
                    if (row is fxcore2.O2GMessageTableRow)
                        return new MessageTableRow((fxcore2.O2GMessageTableRow)row, session);
                    else
                        return new MessageRow((fxcore2.O2GMessageRow)row, session);
                case O2GTableType.Offers:
                    if(row is fxcore2.O2GOfferTableRow)
                        return (IRow)new OfferTableRow((fxcore2.O2GOfferTableRow)row, session);
                    else
                        return (IRow)new OfferRow((fxcore2.O2GOfferRow)row, session);
                case O2GTableType.Orders:
                    if (row is fxcore2.O2GOrderTableRow)
                        return new OrderTableRow((fxcore2.O2GOrderTableRow)row, session);
                    else
                        return new OrderRow((fxcore2.O2GOrderRow)row, session);
                case O2GTableType.Summary:
                    if (row is fxcore2.O2GSummaryTableRow)
                        return new SummariesTableRow((fxcore2.O2GSummaryTableRow)row, session);
                    else
                        return new SummariesRow((fxcore2.O2GSummaryRow)row, session);
                case O2GTableType.Trades:
                    if (row is fxcore2.O2GTradeTableRow)
                        return new TradeTableRow((fxcore2.O2GTradeTableRow)row, session);
                    else
                        return new TradeRow((fxcore2.O2GTradeRow)row, session);
                default:
                    return new Row(row, session);
            }
        }

        public static string[] LoadComObjectIntoStringArray(object comObject)
        {
            Type thisType = comObject.GetType();
            Type strType = Type.GetType("System.String[*]");
            string[] stringArray = new string[1];
            if (thisType.Equals(strType))
            {
                object[] args = new object[1];
                int numEntries = (int)thisType.InvokeMember("Length",
                                BindingFlags.GetProperty,
                                null, comObject, null);
                stringArray = new string[numEntries];
                for (int j = 0; j < numEntries; j++)
                {
                    args[0] = j + 1; // VB arrays index from 1
                    stringArray[j] = (string)thisType.InvokeMember("GetValue",
                                    BindingFlags.InvokeMethod,
                                    null, comObject, args);
                }
            }
            return stringArray;
        }

        public static object[] LoadComObjectIntoObjectArray(object comObject)
        {
            Type thisType = comObject.GetType();
            Type objType = Type.GetType("System.Object[*]");
            object[] objectArray = new object[1];
            if (thisType.Equals(objType))
            {
                object[] args = new object[1];
                int numEntries = (int)thisType.InvokeMember("Length",
                                BindingFlags.GetProperty,
                                null, comObject, null);
                objectArray = new object[numEntries];
                for (int j = 0; j < numEntries; j++)
                {
                    args[0] = j + 1; // VB arrays index from 1
                    objectArray[j] = (object)thisType.InvokeMember("GetValue",
                                    BindingFlags.InvokeMethod,
                                    null, comObject, args);
                }
            }
            return objectArray;
        }

        public static int[] LoadComObjectIntoIntegerArray(object comObject)
        {
            Type thisType = comObject.GetType();
            Type intType = Type.GetType("System.Int32[*]");
            int[] intArray = new int[1];
            if (thisType.Equals(intType))
            {
                object[] args = new object[1];
                int numEntries = (int)thisType.InvokeMember("Length",
                                BindingFlags.GetProperty,
                                null, comObject, null);
                intArray = new int[numEntries];
                for (int j = 0; j < numEntries; j++)
                {
                    args[0] = j + 1; // VB arrays index from 1
                    intArray[j] = (int)thisType.InvokeMember("GetValue",
                                    BindingFlags.InvokeMethod,
                                    null, comObject, args);
                }
            }
            return intArray;
        }        

    }
}
