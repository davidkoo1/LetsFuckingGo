﻿using appTutorial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Domain.Commands
{
    public interface IDeleteUserCommand
    {
        Task Execute(Guid UserID);
    }
}
