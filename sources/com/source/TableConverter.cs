using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace fxcore2.com
{
    [ComVisible(false)]
    [Guid("2376908F-64B0-41b6-A045-3E174383F473")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    public class TableConverter
    {
        public IAccountTable AsAccountTable([MarshalAs(UnmanagedType.IDispatch)]ITable table)
        {
            if (table is IAccountTable)
                return (IAccountTable)table;
            else
                return null;
        }

        public IClosedTradeTable AsClosedTradeTable([MarshalAs(UnmanagedType.IDispatch)]ITable table)
        {
            if (table is IClosedTradeTable)
                return (IClosedTradeTable)table;
            else
                return null;
        }

        public IMessageTable AsMessageTable([MarshalAs(UnmanagedType.IDispatch)]ITable table)
        {
            if (table is IMessageTable)
                return (IMessageTable)table;
            else
                return null;
        }

        public IOfferTable AsOfferTable([MarshalAs(UnmanagedType.IDispatch)]ITable table)
        {
            if (table is IOfferTable)
                return (IOfferTable)table;
            else
                return null;
        }

        public IOrderTable AsOrderTable([MarshalAs(UnmanagedType.IDispatch)]ITable table)
        {
            if (table is IOrderTable)
                return (IOrderTable)table;
            else
                return null;
        }

        public ISummariesTable AsSummariesTable([MarshalAs(UnmanagedType.IDispatch)]ITable table)
        {
            if (table is ISummariesTable)
                return (ISummariesTable)table;
            else
                return null;
        }

        public ITradeTable AsTradeTable([MarshalAs(UnmanagedType.IDispatch)]ITable table)
        {
            if (table is ITradeTable)
                return (ITradeTable)table;
            else
                return null;
        }
        
        internal static ITable WrapAsTable(fxcore2.O2GTable table, ISession session)
        {
            if (table == null)
                return null;
            switch (table.Type)
            {
                case O2GTableType.Accounts:
                    return new AccountTable((fxcore2.O2GAccountsTable)table, (Session)session);
                case O2GTableType.ClosedTrades:
                    return new ClosedTradeTable((fxcore2.O2GClosedTradesTable)table, (Session)session);
                case O2GTableType.Messages:
                    return new MessageTable((fxcore2.O2GMessagesTable)table, (Session)session);
                case O2GTableType.Offers:
                    return new OfferTable((fxcore2.O2GOffersTable)table, (Session)session);
                case O2GTableType.Orders:
                    return new OrderTable((fxcore2.O2GOrdersTable)table, (Session)session);
                case O2GTableType.Summary:
                    return new SummariesTable((fxcore2.O2GSummaryTable)table, (Session)session);
                case O2GTableType.TableUnknown:
                    return new Table(table, (Session)session);
                case O2GTableType.Trades:
                    return new TradeTable((fxcore2.O2GTradesTable)table, (Session)session);
                default:
                    Debug.Fail("Table type is not supported");
                    return null;
            }
        }
    
    }
}
