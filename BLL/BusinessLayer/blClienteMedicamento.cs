using System.Text.Json;
using BLL.DataLayer;
using Shared.Model;

namespace BLL.BusinessLayer
{
    public class blClienteMedicamento
    {

        DataAccess _data = new DataAccess();
        string url = "https://farmaciaapi-e3hffsf0eqc4b2ab.centralus-01.azurewebsites.net/api";

        public async Task<List<cClienteMedicamento>?> getModel()
        {
            try
            {
                var response = await _data.getRequest($"{url}/ClienteMedicamento/getClienteMedicamento");

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Empty response.");
                    return null;
                }

                return JsonSerializer.Deserialize<List<cClienteMedicamento>>(response);

            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON error: {ex.Message}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return null;
        }

        public async Task<cClienteMedicamento?> getModelId(int id)
        {
            try
            {
                var response = await _data.getRequest($"{url}/ClienteMedicamento/getClienteMedicamento/{id}");

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Empty response.");
                    return null;
                }

                return JsonSerializer.Deserialize<cClienteMedicamento>(response);

            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON error: {ex.Message}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return null;
        }

        public async Task<string> postModel(cClienteMedicamento model)
        {
            try
            {
                var response = await _data.postRequest<cClienteMedicamento>($"{url}/ClienteMedicamento/agregarClienteMedicamento", model);
                return response;

            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return string.Empty;
        }

        public async Task<string> putModel(cClienteMedicamento model)
        {
            try
            {
                var response = await _data.putRequest<cClienteMedicamento>($"{url}/ClienteMedicamento/actualizarClienteMedicamento", model);
                return response;

            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return string.Empty;
        }

        public async Task<string> deleteModel(cClienteMedicamento model)
        {
            try
            {
                var response = await _data.deleteRequest<cClienteMedicamento>($"{url}/ClienteMedicamento/borrarClienteMedicamento", model);
                return response;

            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return string.Empty;
        }
    }
}
