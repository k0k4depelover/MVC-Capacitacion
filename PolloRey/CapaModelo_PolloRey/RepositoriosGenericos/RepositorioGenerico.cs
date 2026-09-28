using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_PolloRey
{
    public interface RepositorioGenerico<Entity> where Entity : class
    {

        int Create(Entity entity); // Cuando creamos un usuario, la base de datos nos devuelve el ID

        List<Entity> Read();  // Devuelve una lista de empleados.
        int Update(Entity entity); // Cuando actualizamos un usuario, la base de datos nos devuelve el ID actualizado
        int Delete(Entity entity); // Cuando eliminamos un usuario, la base de datos nos devuelve el ID eliminado
    }
}
