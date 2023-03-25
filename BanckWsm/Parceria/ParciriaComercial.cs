using BankCleudADM.SistemaInterno;

namespace BankCleudADM.Parceria
{
    public class ParciriaComercial : IAltenticável
    {
        public string senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}
