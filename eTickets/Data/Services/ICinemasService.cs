﻿using System.Linq;
using System.Text;
using System;
using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface ICinemasService: IEntityBaseRepository<Cinema>
    {
    }
}
