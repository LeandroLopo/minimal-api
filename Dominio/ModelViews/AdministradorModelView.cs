using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Dominio.Enums;

namespace minimal_api.Dominio.ModelViews
{
    public struct AdministradorModelView
    {
        public AdministradorModelView()
        {
        }
        public int Id { get; set; } = default!;

        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    }
}