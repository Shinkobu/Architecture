using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicService.Controllers
{
    /// <summary>
    /// ДОМАШНЯЯ РАБОТА Добавить контроллеры PetController и ConsultationController по образу и подобию текущего контроллера.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : ControllerBase
    {
        private IConsultationRepository _ConsultationRepository;
        
        public ConsultationController(IConsultationRepository ConsultationRepository)
        {
            _ConsultationRepository = ConsultationRepository;
        }

        [HttpPost("create")]
        public ActionResult<int> Create([FromBody] CreateConsultationRequest createRequest)
        {
            int res = _ConsultationRepository.Create(new Consultation
            {
                ClientId = createRequest.ClientId,
                PetId = createRequest.PetId,
                ConsultationDate = createRequest.ConsultationDate,
                Description = createRequest.Description,
            });
            return Ok(res);
        }

        [HttpPut("update")]
        public ActionResult<int> Update([FromBody] UpdateConsultationRequest updateRequest)
        {
            int res = _ConsultationRepository.Update(new Consultation
            {
                ConsultationId = updateRequest.ConsultationId,
                ClientId = updateRequest.ClientId,
                PetId = updateRequest.PetId,
                ConsultationDate = updateRequest.ConsultationDate,
                Description = updateRequest.Description,
            });
            return Ok(res);
        }


        [HttpDelete("delete")]
        public ActionResult<int> Delete(int ConsultationId)
        {
            int res = _ConsultationRepository.Delete(ConsultationId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public ActionResult<List<Consultation>> GetAll()
        {
            return Ok(_ConsultationRepository.GetAll());
        }

        [HttpGet("get-by-id")]
        public ActionResult<Consultation> GetById(int ConsultationId)
        {
            return Ok(_ConsultationRepository.GetById(ConsultationId));
        }


    }
}
