using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace contactosProyecto.Models.ViewModels
{
    
    /* modelo para el listado de contactos*/
    
    public class ContactViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public bool Favorite { get; set; }
        public bool Emergency { get; set; }
    }
}