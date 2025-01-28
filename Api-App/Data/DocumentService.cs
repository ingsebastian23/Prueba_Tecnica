using System.Net.Http.Json;
using System.Reflection.Metadata;

namespace Api_App.Data{
    public class DocumentService {
        private readonly HttpClient _httpClient;

        public DocumentService(HttpClient httpClient){
            _httpClient = httpClient;
        }

        public async Task<List<Document>?> GetDocumentsAsync(){ //Metodo Para Obtener datos de la API
            return await _httpClient.GetFromJsonAsync<List<Document>>("DocumentosFillsCombos") ?? new List<Document>();
        }

    }

    public class Document{
        public int Codigo {get; set;}
        public string? Descripcion {get; set;}
        public bool VActiva {get; set;}
    }
}