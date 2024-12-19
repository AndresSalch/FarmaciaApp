using System.Text.Json;
using BLL.DataLayer;
using Shared.Model;
using Shared.Model.DTO;

namespace BLL.BusinessLayer
{
    public class blMedicamento
    {
        DataAccess _data = new DataAccess();
        string url = "https://farmaciaapi-e3hffsf0eqc4b2ab.centralus-01.azurewebsites.net/api";

        public async Task<List<cMedicamento>?> getModel()
        {
            try
            {
                var response = await _data.getRequest($"{url}/Medicamento/getMedicamento");

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Empty response.");
                    return null;
                }

                return JsonSerializer.Deserialize<List<cMedicamento>>(response);

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

        public async Task<cMedicamento?> getModelId(int id)
        {
            try
            {
                var response = await _data.getRequest($"{url}/Medicamento/getMedicamento/{id}");

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Empty response.");
                    return null;
                }

                return JsonSerializer.Deserialize<cMedicamento>(response);

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

        public async Task<string> postModel(cMedicamento model)
        {
            try
            {
                var response = await _data.postRequest<dtoMedicamento>($"{url}/Medicamento/agregarMedicamento", new dtoMedicamento(){descripcion = model.descripcion, presentacion = model.presentacion, marca = model.marca, estado = model.estado});
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

        public async Task<string> putModel(cMedicamento model)
        {
            try
            {
                var response = await _data.putRequest<cMedicamento>($"{url}/Medicamento/actualizarMedicamento", model);
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

        public async Task<string> deleteModel(cMedicamento model)
        {
            try
            {
                var response = await _data.deleteRequest<cMedicamento>($"{url}/Medicamento/borrarMedicamento", model);
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
