﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerService.Exceptions
{
    public class NotFounException:Exception
    {
        public NotFounException(string message):base(message)
        {
            
        }
    }
}
