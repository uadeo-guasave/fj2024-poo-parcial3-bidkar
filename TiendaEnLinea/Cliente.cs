﻿namespace TiendaEnLinea;

public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Domicilio { get; set; }
    public string Telefono { get; set; }

    public Cliente Recuperar(int id)
    {
        var cliente = new Cliente();

        if (id == 1)
        {
            cliente.Id = 1;
            cliente.Nombre = "Joel";
            cliente.Apellidos = "Vega";
            cliente.Domicilio = "Guasave";
            cliente.Telefono = "6870000000";
        }

        return cliente;
    }
}