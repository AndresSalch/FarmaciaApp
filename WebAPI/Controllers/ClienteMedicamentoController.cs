using Microsoft.AspNetCore.Mvc;
using Shared.Service;
using Shared.Model;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteMedicamentoController : ControllerBase
    {
        string sqlconnection = "Data Source=68.168.208.58;" +
            "Initial Catalog=Progra5; Persist Security Info=True;" +
            "TrustServerCertificate=True; User ID=PrograV;" +
            "Password=Aqi90h7@9";
        [HttpGet]
        [Route("getClienteMedicamento")]
        public async Task<ActionResult<List<cClienteMedicamento>>> getService()
        {
            try
            {
                dsClienteMedicamento mdsCliM = new dsClienteMedicamento(sqlconnection);
                List<cClienteMedicamento> mClienteMed = await mdsCliM.getServicelist();
                return Ok(mClienteMed);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("getClienteMedicamento/{idCliente}")]
        public async Task<ActionResult<cClienteMedicamento>> getServiceByid(string idCliente)
        {
            try
            {
                dsClienteMedicamento mdsCliM = new dsClienteMedicamento(sqlconnection);
                cClienteMedicamento mClienteMed = await mdsCliM.getServiceById(Convert.ToInt32(idCliente));
                if (mClienteMed == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(mClienteMed);
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("agregarClienteMedicamento")]

        public async Task<ActionResult<string>> addServcie(cClienteMedicamento clienteMed)
        {
            try
            {
                dsClienteMedicamento mdsCliM = new dsClienteMedicamento(sqlconnection);
                if (await mdsCliM.addService(clienteMed) == 1)
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
        [Route("actualizarClienteMedicamento")]
        public async Task<ActionResult<string>> updateService(cClienteMedicamento clienteMed)
        {
            try
            {
                dsClienteMedicamento mdsCliM = new dsClienteMedicamento(sqlconnection);
                if (await mdsCliM.updateService(clienteMed) == 1)
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
        [Route("borrarClienteMedicamento")]
        public async Task<ActionResult<string>> deleteServcie(cClienteMedicamento clienteMed)
        {
            try
            {
                dsClienteMedicamento mdsCliM = new dsClienteMedicamento(sqlconnection);
                if (await mdsCliM.deleteService(clienteMed) == 1)
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
