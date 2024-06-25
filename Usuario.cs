using Microsoft.AspNetCore.Identity;

namespace servico.models
{
    public class Usuario : IdentityUser
    {
        // Propriedades adicionais, se necessário
        public string Nome { get; set; } // Exemplo de propriedade adicional

        // Você não precisa definir propriedades para Email e Senha,
        // pois essas são herdadas da classe IdentityUser
    }
}
