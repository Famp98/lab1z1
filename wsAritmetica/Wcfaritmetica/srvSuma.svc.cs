﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcfaritmetica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class srvSuma : IsrvSuma
    {
        public clsSuma suma(int numero1, int numero2)
        {
            clsSuma obj = new clsSuma();
            obj.numeroA = numero1 ;
            obj.numeroB = numero2;
            obj.resultado = obj.numeroA + obj.numeroB;
        }
    }
}
