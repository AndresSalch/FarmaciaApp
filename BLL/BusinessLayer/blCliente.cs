using BLL.DataLayer;
using Shared.Model;
using System.Text.Json;

namespace BLL.BusinessLayer
{
    public class blCLiente
    {

        DataAccess _data = new DataAccess();
        string url = "https://farmaciaapi-e3hffsf0eqc4b2ab.centralus-01.azurewebsites.net/api";

        public async Task<List<cClienteFarmacia>?> getModel()
        {
            try
            {
                var response = await _data.getRequest($"{url}/ClienteFarmacia/getCliente");

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Empty response.");
                    return null;
                }

                return JsonSerializer.Deserialize<List<cClienteFarmacia>>(response);

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

        public async Task<cClienteFarmacia?> getModelId(int id)
        {
            try
            {
                var response = await _data.getRequest($"{url}/ClienteFarmacia/getCliente/{id}");

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Empty response.");
                    return null;
                }

                return JsonSerializer.Deserialize<cClienteFarmacia>(response);

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

        public async Task<string> postModel(cClienteFarmacia model)
        {
            try
            {
                var response = await _data.postRequest<cClienteFarmacia>($"{url}/ClienteFarmacia/agregarCliente", model);
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

        public async Task<string> putModel(cClienteFarmacia model)
        {
            try
            {
                var response = await _data.putRequest<cClienteFarmacia>($"{url}/ClienteFarmacia/actualizarCliente", model);
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

        public async Task<string> deleteModel(cClienteFarmacia model)
        {
            try
            {
                var response = await _data.deleteRequest<cClienteFarmacia>($"{url}/ClienteFarmacia/borrarCliente", model);
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
