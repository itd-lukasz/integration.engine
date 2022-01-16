using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Engine.Message
{
    public interface IMessage
    {
        public enum StatusEnum
        {
            New = 0,
            Processing = 1,
            Success = 2,
            Failed = -99
        }

        public enum TypeEnum
        {
            Xml = 0
        }

        public DateOnly Created { get; init; }

        public StatusEnum Status { get; set; } 

        public TypeEnum Type { get; set; }
        
        public string Content { get; set; }
    }
}
