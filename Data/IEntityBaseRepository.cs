using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Day4_BookProject.Data;

public interface IEntityBaseRepository<TypeOfEntity,TypeOfID>
{
    void Add(TypeOfEntity TypeOfEntity);
    void Delete(TypeOfID id);

    List<TypeOfEntity> GetAll();

    TypeOfEntity? GetById(TypeOfID id);
}
