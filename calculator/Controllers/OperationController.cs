using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using calculator.Models;


namespace calculator.Controllers
{
    public class OperationController : ApiController
    {
        public ICalculate _ICal;

        public OperationController(ICalculate ICal)
        {
            this._ICal = ICal;
        }
            
       

        [HttpGet]
        public int add(int i, int j)
        {
            return _ICal.Opera(i, j);
        //    AddModel a = new AddModel(_ICal);
            
        //    return a.Opera(i,j);
        }
        [HttpGet]
        public int Sub(int i, int j)
        {
            return _ICal.Opera(i, j);
            //DifferenceModel o = new DifferenceModel();
            //int s = o.sub(i, j);
            //return  s;
        }
        //[HttpGet]
        //public int Mul(int i, int j)
        //{
        //    ProductModel o = new ProductModel();
        //    int s = o.Mul(i, j);
        //    return s;
        //}
        //[HttpGet]
        //public int Div(int i, int j)
        //{
        //    DivideModel o = new DivideModel();
        //    //string s = o.Quo(i, j);
        //    //return s;

        //    return i;
        //}
    }
}
