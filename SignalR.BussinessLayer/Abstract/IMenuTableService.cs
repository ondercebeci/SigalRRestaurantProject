﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Abstract
{
    public interface IMenuTableService:IGenericService<MenuTable>
    {
        int TMenuTableCount();
        int TActiveMenuTableCount();
        void TChangeMenuTableStatusToFalse(int id);
        void TChangeMenuTableStatusToTrue(int id);
    }
}
