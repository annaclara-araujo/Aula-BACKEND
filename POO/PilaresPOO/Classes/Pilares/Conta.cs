

namespace PilaresPOO.Classes.Pilares
{
    public abstract class Conta
    {
        protected float Saldo;
        public string ? Titular;

        public abstract float Sacar (float valor);
        public abstract bool Depositar (float valor);

    public void BotaSaldoAi (float grana)
    {
        Saldo = grana;
    }

    public float getSaldo () 
    {
        return Saldo;
    }





    }
}