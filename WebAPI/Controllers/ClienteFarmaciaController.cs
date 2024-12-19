using Microsoft.AspNetCore.Mvc;
using Shared.Service;
using Shared.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteFarmaciaController : ControllerBase
    {
        string sqlconnection = "Data Source=68.168.208.58;" +
            "Initial Catalog=Progra5; Persist Security Info=True;" +
            "TrustServerCertificate=True; User ID=PrograV;" +
            "Password=Aqi90h7@9";
        [HttpGet]
        [Route("getCliente")]
        public async Task<ActionResult<List<cClienteFarmacia>>> getService()
        {
            try
            {
                dsClienteFarmacia mdsCli = new dsClienteFarmacia(sqlconnection);
                List<cClienteFarmacia> mCliente = await mdsCli.getServicelist();
                return Ok(mCliente);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("getCliente/{idCliente}")]
        public async Task<ActionResult<cClienteFarmacia>> getServiceByid(int idCliente)
        {
            try
            {
                dsClienteFarmacia mdsCli = new dsClienteFarmacia(sqlconnection);
                cClienteFarmacia mCliente = await mdsCli.getServiceById(Convert.ToInt32(idCliente));
                if (mCliente == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(mCliente);
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("agregarCliente")]

        public async Task<ActionResult<string>> addServcie(cClienteFarmacia cliente)
        {
            try
            {
                dsClienteFarmacia mdsCli = new dsClienteFarmacia(sqlconnection);
                if (await mdsCli.addService(cliente) == 1)
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
        [Route("actualizarCliente")]
        public async Task<ActionResult<string>> updateService(cClienteFarmacia cliente)
        {
            try
            {
                dsClienteFarmacia mdsCli = new dsClienteFarmacia(sqlconnection);
                if (await mdsCli.updateService(cliente) == 1)
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
        [Route("borrarCliente")]
        public async Task<ActionResult<string>> deleteServcie(cClienteFarmacia cliente)
        {
            try
            {
                dsClienteFarmacia mdsCli = new dsClienteFarmacia(sqlconnection);
                if (await mdsCli.deleteService(cliente) == 1)
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
