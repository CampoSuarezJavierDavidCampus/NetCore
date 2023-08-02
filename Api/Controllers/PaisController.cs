using Application.Model;
using Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
public class PaisController: BaseApiController{
    private readonly IMediator _mediator;
    public PaisController(IMediator mediator)=>_mediator = mediator;

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<Pais>>> Get(){
        return await _mediator.Send(new Consultas.ListaPais());
    }
}
