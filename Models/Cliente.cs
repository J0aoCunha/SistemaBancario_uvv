namespace SistemaBancario_uvv.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public List<Conta> Contas { get; set; } = new List<Conta>();
    }
}
