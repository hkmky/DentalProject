using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Interface;

namespace Dental.Entities.Tables.Base
{
    public class EntityBase : IEntity
    {
        //Guid 16 byte area 
        public Guid Id { get; set; }

        public DateTime RecordDate { get; set; }
      
        public DateTime? EditDate { get; set; }//? Eklenme tarihi boş geçilebilir
       
    }
}
