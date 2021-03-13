using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) // siz params verdiğiniz zaman Run() içine  istediğiniz kadar parametre gönderebilirisiniz
         {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                { 
                    return logic;

                }
               
            }
            return null;
        }
       
    }
}
