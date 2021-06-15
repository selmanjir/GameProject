using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IPersonCheckService
    {
         bool CheckIfRealPerson(Gamer gamer);
    }
}
