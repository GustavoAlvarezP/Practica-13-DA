using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmpresaProveedor
{
    /// <summary>
    /// Descripción breve de WSCategorias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

        public class WSCategorias : System.Web.Services.WebService
        {
            private string connectionString; public WSCategorias()
            {
                //Eliminar la marca de comentario de la línea siguiente si utiliza los
                // componentes diseñados //InitializeComponent();
                connectionString = "Data Source=dLAPTOP-LO8K6NU9\\SQLEXPRESS;Initial Catalog = Northwind; Integrated Security = True";
            }

            [WebMethod]
            public DataSet GetCategorias()
            {
            string selectSQL = "SELECT CategoryID,CategoryName, Description, Picture FROM Categories";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            //SqlDataReader reader;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dsCategorias = new DataSet();
            return dsCategorias;
            }
            [WebMethod]
            public DataSet GetProductos()
            {
            string selectSQL = "SELECT ProductID, ProductName,CategoryID,UnitPrice,UnitsInStock FROM Products";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            //SqlDataReader reader;
            SqlDataAdapter daProductos = new SqlDataAdapter(cmd);
            DataSet dsProductos = new DataSet();
            // Fill the same table. daProductos.Fill(dsProductos, "Productos");
            return dsProductos;
        }
    }
}
    
