namespace entidades
{
    public class Guerrero
    {
        public Arma armaActual;
        public Item itemEquipado;

        public string AtacarConArma()
        {
            return armaActual.Atacar();
        }

        public void CambiarArma(Arma armaNueva)
        {
            this.armaActual = armaNueva;
        }

        public string UsarItem()
        {
            return this.itemEquipado.Usar();
        }

        public void CambiarItem(Item itemNuevo)
        {
            this.itemEquipado = itemNuevo;
        }
    }
}