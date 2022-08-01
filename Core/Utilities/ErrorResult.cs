﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message):base(false,message)  //hem mesaj verip hem hata olduğunu göstermek için bunu uygularız 
        {

        }

        public ErrorResult():base(false)  //mesaj vemek istemeyip hata olduğunu göstermek istiyorsak bunu uygularız
        {

        }
    }
}
