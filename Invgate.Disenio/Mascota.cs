using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invgate.Disenio.Estado;
using Invgate.Disenio.Gruñidos;
using Invgate.Disenio.Movimiento;

namespace Invgate.Disenio
{
    public class Mascota
    {
        #region propiedades
        public string nombre { get; private set; }
        public Especie especie { get; private set; }
        public List<Especie> teme { get; private set; }
        public Gruñido gruñido { get; private set; } //¿es por especie ?
        public IEstadoMascota estadoMascota { get; set; }
        public Gruñido comoGruñir { get; set; }
        public IMovimiento comoMoverse { get; set; }
        #endregion

        #region constructores
        public Mascota(string nombre, Especie especie, List<Especie> teme, Gruñido gruñido )
        {
            this.gruñido = gruñido;
            this.nombre = nombre;
            this.especie = especie;
            this.teme = teme;
            if (this.teme.Contains(especie))
                throw new Exception("Especie propensa a extinguirse por temerse a si misma");
            this.estadoMascota = new EstadoDespierto();
            this.comoMoverse = new MovimientoNormal();
        }
        public Mascota(string nombre, Especie especie, List<Especie> teme, Gruñido gruñido, IEstadoMascota estado): this(nombre, especie, teme, gruñido)
        {
            this.estadoMascota = estadoMascota;
        }
        #endregion
        
        #region cambios de estado
        public void Dormite()
        {
            estadoMascota = new EstadoDormido();
            comoGruñir = new Silencio();
            comoMoverse = new MovimientoNulo();
        }
        public void Despertate()
        {
            estadoMascota = new EstadoDespierto();
            comoGruñir = gruñido;
            comoMoverse = new MovimientoNormal();
        }
        public void Alegrate()
        {
            estadoMascota = new EstadoFeliz();
            comoGruñir = gruñido;
            comoMoverse = new MovimientoNormal();
        }
        public void Entristecete()
        {
            estadoMascota = new EstadoTriste();
            comoGruñir = gruñido;
            comoMoverse = new MovimientoNormal();
        }
        #endregion

        #region metodos publicos
        public void MoverMascota()
        {
            estadoMascota.Moverse(this);
        }
        public void HacerRuido()
        {
            estadoMascota.HacerRuido(this);
        }
        public string Estado()
        {
            return estadoMascota.Estado;
        }
        #endregion

    }
}
