using System.Net.Http.Headers;

namespace Cotizacion.api.Services
{
    public class CotizacionService
    {
        private readonly HttpClient _httpClient;

        public CotizacionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> ObtenerCotizacionAsync(string tipoCambio)
        {
            string apiUrl = tipoCambio switch
            {
                "Bolsa" => "https://dolarapi.com/v1/dolares/bolsa",
                "Blue" => "https://dolarapi.com/v1/dolares/blue",
                "Cripto" => "https://dolarapi.com/v1/dolares/cripto",
                _ => throw new ArgumentException("Código de moneda no válido")
            };

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}

