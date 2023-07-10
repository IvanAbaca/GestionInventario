using System;
using System.Collections.Generic;

public interface DAO<T>
{
    public int lastId();
    public void Agregar(T entity);
    public void Eliminar(T entity);
    public void Modificar(T entity);
    public T Leer(int id);
    public List<T> LeerTodos();
}
