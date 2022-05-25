using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Permissions.Domain;
using Permissions.Service.EventHandlers.Command;
using Permissions.Service.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Permissions.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class PermisoController : ControllerBase
    {
        private readonly ILogger<PermisoController> _logger;
        private readonly IPermissionQueryService _permissionQueryService;
        private IMediator _mediator;


        public PermisoController(ILogger<PermisoController> logger, IPermissionQueryService permissionQueryService, IMediator mediator)
        {
            _logger = logger;
            _permissionQueryService = permissionQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public IEnumerable<Permiso> GetAll()
        {
            return _permissionQueryService.GetAll();
        }

        [HttpGet("{id}")]
        public Permiso GetById(int id)
        {
            return _permissionQueryService.GetBYId(id);
        }

        [HttpPost]
        public async Task<IActionResult> Update(PermisoUpdateCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }
    }
}
