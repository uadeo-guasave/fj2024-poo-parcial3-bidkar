namespace TiendaEnLinea;

public interface IABCable<T>
{
    public bool Guardar();
    public bool Validar();
    abstract static T Recuperar(int id);
}
