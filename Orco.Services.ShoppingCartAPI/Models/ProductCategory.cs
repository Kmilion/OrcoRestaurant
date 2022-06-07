using System.ComponentModel;

namespace Orco.Services.ShoppingCartAPI.Models
{
    public enum ProductCategory
    {
        [Description("Televisores")]
        Televisor = 1,
        [Description("Celulares")]
        Celular,
        [Description("Climatización")]
        Climatizacion,
        [Description("Colchones y Sommiers")]
        ColchonSommier,
        [Description("Lavarropas y Lavavajillas")]
        LavarropasLavavajillas,
        [Description("Notebooks")]
        Notebook,
        [Description("Heladeras, Freezers y Cavas")]
        HeladeraFreezerCava,
        [Description("Herramientas Eléctricas")]
        HerramientaElectrica,
        [Description("Agua Caliente")]
        AguaCaliente,
        [Description("Cocinas y Hornos")]
        CocinaHorno,
        [Description("Cuidado Personal")]
        CuidadoPersonal
    }
}
