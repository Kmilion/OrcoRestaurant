using System.ComponentModel;

namespace Orco.Services.ShoppingCartAPI.Models
{
    public enum ProductCategory
    {
        [Description("Aperitivo")]
        Aperitivo = 1,
        [Description("Entrada")]
        Entrada,
        [Description("Plato principal")]
        PlatoPrincipal,
        [Description("Postre")]
        Postre
    }
}
