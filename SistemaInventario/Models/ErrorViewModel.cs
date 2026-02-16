namespace SistemaInventario.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string VariablePrueba { get; set; } = "Valor de prueba";
    }
}
