using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;

/// <summary>
/// Summary description for brandxWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class brandxWebService : System.Web.Services.WebService {

    iClass c = new iClass();
    public brandxWebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod(EnableSession = true)]
    public string AdminLoginUpdate()
    {
        try
        {
            //System.Diagnostics.Debugger.Break();
            return DateTime.Now.ToString();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [WebMethod(EnableSession = true)]
    public int UpdateCartList(int prodIdX, int qty, int optionId)
    {
        try
        {
            int custId = 0;
            if (HttpContext.Current.Session["poppinsCust"] != null)
            {
                custId = Convert.ToInt32(HttpContext.Current.Session["poppinsCust"]);
            }
            else
            {
                //custId = 0;
                return 2; // meaning of return 2 => not logged in, therefore redirect cust to login then add product to cart
            }

            double prodAmount = Convert.ToDouble(c.GetReqData("ProductsData", "PriceFinal", "ProductID=" + prodIdX));
            double ordAmount = 0, finalOrdAmount = 0, incrementPrice = 0;
            int prodOptionId = 0;
            if (optionId > 0)
            {
                prodOptionId = Convert.ToInt32(c.GetReqData("ProductOptions", "ProdOptionID", "FK_ProductID=" + prodIdX + " AND FK_OptionID=" + optionId));
                incrementPrice = Convert.ToDouble(c.GetReqData("ProductOptions", "PriceIncrement", "ProdOptionID=" + prodOptionId));
                ordAmount = prodAmount + incrementPrice;
                finalOrdAmount = ordAmount * qty;
            }
            else
            {
                ordAmount = prodAmount;
                finalOrdAmount = ordAmount * qty;
            }
            
            string prodCode = c.GetReqData("ProductsData", "ProductSKU", "ProductID=" + prodIdX).ToString();

            DateTime cDate = DateTime.Now;
            string currentDate = cDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

            // orderStatus=0 > added to cart, 1 > Order placed (New/pending), 2 > CANCELL ORDER BY CUSTOMER , 3 > Accepted, 4 > Denied, 5 > Processing , 6 > Shipped , 7 > deliverd
            int orderId = 0;
            if (HttpContext.Current.Request.Cookies["ordId"] != null)
            {
                string[] arrOrdId = HttpContext.Current.Request.Cookies["ordId"].Value.Split('#');
                orderId = Convert.ToInt32(arrOrdId[0].ToString());
            }
            else
            {
                orderId = c.NextId("OrdersData", "OrderID");

                c.ExecuteQuery("Insert Into OrdersData (OrderID, FK_OrderMemberID, OrderDate, OrderStatus) Values (" + orderId +
                    ", " + custId + ", '" + currentDate + "', 0)");

                string ordId = orderId.ToString() + "#" + custId.ToString();

                HttpContext.Current.Response.Cookies["ordId"].Value = ordId;
                HttpContext.Current.Response.Cookies["ordId"].Expires = DateTime.Now.AddDays(30);
            }

            int detailsMaxId = 0;
            if (!c.IsRecordExist("Select OrdDetailID From OrderDetails Where FK_DetailOrderID=" + orderId + " AND FK_DetailProductID=" + prodIdX))
            {
                detailsMaxId = c.NextId("OrderDetails", "OrdDetailID");

                c.ExecuteQuery("Insert Into OrderDetails (OrdDetailID, FK_DetailOrderID, FK_DetailProductID, OrdDetailQTY, OrdDetailPrice, " +
                    " OrdDetailAmount, OrdDetailSKU)" +
                    " Values (" + detailsMaxId + ", " + orderId + ", " + prodIdX + ", " + qty + ", " + ordAmount +
                    ", " + finalOrdAmount + ", '" + prodCode + "')");
            }

            if (optionId > 0)
            {
                if (!c.IsRecordExist("Select OrderOptionID From OrderProductOptions Where FK_OrdDetailID=" + detailsMaxId + " AND FK_ProdOptionID=" + prodIdX))
                {
                    int maxOrdOptionId = c.NextId("OrderProductOptions", "OrderOptionID");
                    c.ExecuteQuery("Insert Into OrderProductOptions (OrderOptionID, FK_OrdDetailID, FK_ProdOptionID, PriceProduct, " +
                        " PriceIncrement) Values (" + maxOrdOptionId + ", " + detailsMaxId + ", " + prodOptionId + ", " + prodAmount + "," + incrementPrice + ")");
                }
            }

            return 1;
             
        }
        catch (Exception)
        {
            return 0;
        }
    }


    [WebMethod(EnableSession = true)]
    public int CartListCount()
    {
        try
        {
            HttpCookie reqCookie = HttpContext.Current.Request.Cookies["ordId"];
            if (reqCookie != null)
            {
                string[] arrItems = reqCookie.Value.Split('#');
                int orderId = Convert.ToInt32(arrItems[0].ToString());
                int count = Convert.ToInt32(c.GetReqData("OrderDetails", "Count(FK_DetailProductID)", "FK_DetailOrderID=" + orderId));
                return count;
            }
            else
            {
                return 0;
            }
        }
        catch (Exception)
        {
            return 0;
        }
    }


    [WebMethod(EnableSession = true)]
    public int UpdateAddress(int addrIdX, int orderIdX)
    {
        try
        {
            c.ExecuteQuery("Update OrdersData Set FK_AddressId=" + addrIdX + " Where OrderID=" + orderIdX);
            return 1;
        }
        catch (Exception)
        {
            return 0;
        }
    }
}
