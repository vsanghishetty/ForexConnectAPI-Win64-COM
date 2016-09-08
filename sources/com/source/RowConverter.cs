using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace fxcore2.com
{
    [ComVisible(false)]
    [Guid("EDD94FEC-A999-4b4a-A6F0-EC443AE26511")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    public class RowConverter
    {
        public IAccountTableRow AsAccountTableRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IAccountTableRow)
                return (IAccountTableRow)row;
            else
                return null;
        }
                
        public IAccountRow AsAccountRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IAccountRow)
                return (IAccountRow)row;
            else
                return null;
        }
        
        public IClosedTradeTableRow AsClosedTradeTableRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IClosedTradeTableRow)
                return (IClosedTradeTableRow)row;
            else
                return null;
        }
        
        public IClosedTradeRow AsClosedTradeRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IClosedTradeRow)
                return (IClosedTradeRow)row;
            else
                return null;
        }
        
        public IMessageTableRow AsMessageTableRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IMessageTableRow)
                return (IMessageTableRow)row;
            else
                return null;
        }
        
        public IMessageRow AsMessageRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IMessageRow)
                return (IMessageRow)row;
            else
                return null;
        }
        
        public IOfferTableRow AsOfferTableRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IOfferTableRow)
                return (IOfferTableRow)row;
            else
                return null;
        }

        public IOfferRow AsOfferRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IOfferRow)
                return (IOfferRow)row;
            else
                return null;
        }

        public IOrderTableRow AsOrderTableRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IOrderTableRow)
                return (IOrderTableRow)row;
            else
                return null;
        }
        
        public IOrderRow AsOrderRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is IOrderRow)
                return (IOrderRow)row;
            else
                return null;
        }

        public ISummariesTableRow AsSummariesTableRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is ISummariesTableRow)
                return (ISummariesTableRow)row;
            else
                return null;
        }

        public ISummariesRow AsSummariesRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is ISummariesRow)
                return (ISummariesRow)row;
            else
                return null;
        }

        public ITradeTableRow AsTradeTableRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is ITradeTableRow)
                return (ITradeTableRow)row;
            else
                return null;
        }

        public ITradeRow AsTradeRow([MarshalAs(UnmanagedType.IDispatch)]IRow row)
        {
            if (row is ITradeRow)
                return (ITradeRow)row;
            else
                return null;
        }
        
        internal static IRow WrapAsRow(fxcore2.O2GRow row, ISession session)
        {
            if (row == null)
                return null;
            switch (row.TableType)
            { 
                case O2GTableType.Accounts:
                    if(row is O2GAccountTableRow)
                        return new AccountTableRow((fxcore2.O2GAccountTableRow)row, (Session)session);
                    else
                        return new AccountRow((fxcore2.O2GAccountRow)row, (Session)session);
                case O2GTableType.ClosedTrades:
                    if (row is O2GClosedTradeTableRow)
                        return new ClosedTradeTableRow((fxcore2.O2GClosedTradeTableRow)row, (Session)session);
                    else
                        return new ClosedTradeRow((fxcore2.O2GClosedTradeRow)row, (Session)session);
                case O2GTableType.Messages:
                    if (row is O2GMessageTableRow)
                        return new MessageTableRow((fxcore2.O2GMessageTableRow)row, (Session)session);
                    else
                        return new MessageRow((fxcore2.O2GMessageRow)row, (Session)session);
                case O2GTableType.Offers:
                    if (row is O2GOfferTableRow)
                        return new OfferTableRow((fxcore2.O2GOfferTableRow)row, (Session)session);
                    else
                        return new OfferRow((fxcore2.O2GOfferRow)row, (Session)session);
                case O2GTableType.Orders:
                    if (row is O2GOrderTableRow)
                        return new OrderTableRow((fxcore2.O2GOrderTableRow)row, (Session)session);
                    else
                        return new OrderRow((fxcore2.O2GOrderRow)row, (Session)session);
                case O2GTableType.Summary:
                    if (row is O2GSummaryTableRow)
                        return new SummariesTableRow((fxcore2.O2GSummaryTableRow)row, (Session)session);
                    else
                        return new SummariesRow((fxcore2.O2GSummaryRow)row, (Session)session);
                case O2GTableType.TableUnknown:
                    return new Row(row, (Session)session);
                case O2GTableType.Trades:
                    if (row is O2GTradeTableRow)
                        return new TradeTableRow((fxcore2.O2GTradeTableRow)row, (Session)session);
                    else
                        return new TradeRow((fxcore2.O2GTradeRow)row, (Session)session);
                default:
                    Debug.Fail("Row type is not supported");
                    return null;
            }
        }
    }
}
