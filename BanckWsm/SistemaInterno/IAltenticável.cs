using BankCleudADM  .Colaboradores;

namespace BankCleudADM.SistemaInterno
{
    public interface IAltenticável
    {
        public string senha { get; set; }

        public bool Autenticar(string senha);
    }
}
