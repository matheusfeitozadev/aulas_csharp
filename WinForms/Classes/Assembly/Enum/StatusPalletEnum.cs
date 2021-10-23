using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Classes.Assembly.Enum
{
    public enum StatusPalletEnum
    {
        //É utilizado para armazenar constantes e valores com uma descricao
        //Packed
        //On Hold
        //Partial
        //Used

        Packed = 1,
        OnHold = 2,
        Partial = 3,
        Used = 4
    }
}
