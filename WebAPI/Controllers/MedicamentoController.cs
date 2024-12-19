using Microsoft.AspNetCore.Mvc;
using Shared.Service;
using Shared.Model;
using Shared.Model.DTO;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentoController : ControllerBase
    {
        string sqlconnection = "Data Source=68.168.208.58;" +
            "Initial Catalog=Progra5; Persist Security Info=True;" +
            "TrustServerCertificate=True; User ID=PrograV;" +
            "Password=Aqi90h7@9";
        [HttpGet]
        [Route("getMedicamento")]
        public async Task<ActionResult<List<cMedicamento>>> getService()
        {
            try
            {
                dsMedicamento mdsMed = new dsMedicamento(sqlconnection);
                List<cMedicamento> mCmed = await mdsMed.getServicelist();
                return Ok(mCmed);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("getMedicamento/{idMedicamento}")]
        public async Task<ActionResult<cMedicamento>> getServiceByid(string idMedicamento)
        {
            try
            {
                dsMedicamento mdsMed = new dsMedicamento(sqlconnection);
                cMedicamento mCmed = await mdsMed.getServiceById(Convert.ToInt32(idMedicamento));
                if (mCmed == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(mCmed);
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("agregarMedicamento")]

        public async Task<ActionResult<string>> addServcie(dtoMedicamento clienteMed)
        {
            try
            {
                dsMedicamento mdsMed = new dsMedicamento(sqlconnection);
                if (await mdsMed.addService(clienteMed) == 1)
                {
                    return Ok("OK");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("actualizarMedicamento")]
        public async Task<ActionResult<string>> updateService(cMedicamento clienteMed)
        {
            try
            {
                dsMedicamento mdsMed = new dsMedicamento(sqlconnection);
                if (await mdsMed.updateService(clienteMed) == 1)
                {
                    return Ok("OK");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("borrarMedicamento")]
        public async Task<ActionResult<string>> deleteServcie(cMedicamento clienteMed)
        {
            try
            {
                dsMedicamento mdsMed = new dsMedicamento(sqlconnection);
                if (await mdsMed.deleteService(clienteMed) == 1)
                {
                    return Ok("OK");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
