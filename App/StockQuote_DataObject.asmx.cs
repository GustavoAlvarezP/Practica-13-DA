using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace App
{
    /// <summary>
    /// Descripción breve de StockQuote_DataObject
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class StockQuote_DataObject : System.Web.Services.WebService
    {
        [WebMethod (Description = "Get a price for a stock")]
        public StockInfo GetStockQuote (String ticker)
        {
            StockInfo quote = new StockInfo();
            quote.Symbol = ticker;
            quote = FillQuoteFromDB(quote);
            return quote;
        }
        private StockInfo FillQuoteFromDB (StockInfo Lookup)
        {
            Lookup.CompanyName = "Trapezoide";
            Lookup.price = 400;
            Lookup.High_52week = 410;
            Lookup.Low_52Week = 20;
            return Lookup;
        }
        public class StockInfo
        {
            public decimal price;
            public string Symbol;
            public decimal High_52week;
            public decimal Low_52Week;
            public string CompanyName;
        }
    }
}
