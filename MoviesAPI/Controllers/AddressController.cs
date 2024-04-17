using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Data.Dtos;

[ApiController]
[Route("api/[controller]")]
public class AddressController : ControllerBase
{
    private MovieContext _context;
    private IMapper _mapper;
    public AddressController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Add an address to the database
    /// </summary>
    /// <param name="addressDto">The address to add</param>
    /// <returns>The address that was added</returns>
    /// <response code="201">Returns the newly created address</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AddAddress([FromBody] CreateAddressDto addressDto)
    {
        Address address = _mapper.Map<Address>(addressDto);
        _context.Addresses.Add(address);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetAddress), new { id = address.Id }, address);
    }
    /// <summary>
    /// Get a list of addresses
    /// </summary>
    /// <param name="skip">The number of addresses to skip</param>
    /// <param name="take">The number of addresses to take</param>
    /// <returns>A list of addresses</returns>
    /// <response code="200">Returns the list of addresses</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<ReadAddressDto> GetAddresses([FromQuery] int skip = 0, int take = 2)
    {
        return _mapper.Map<List<ReadAddressDto>>(_context.Addresses.Skip(skip).Take(take));
    }
    /// <summary>
    /// Get an address by its ID
    /// </summary>
    /// <param name="id">The ID of the address</param>
    /// <returns>The address with the given ID</returns>
    /// <response code="200">Returns the address</response>
    /// <response code="404">If the address is not found</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetAddress(int id)
    {
        var address = _context.Addresses.FirstOrDefault(a => a.Id == id);
        if (address == null) return NotFound();
        var addressDto = _mapper.Map<ReadAddressDto>(address);
        return Ok(addressDto);

    }

    /// <summary>
    /// Update an address
    /// </summary>
    /// <param name="id">The ID of the address to update</param>
    /// <param name="addressDto">The updated address</param>
    /// <returns>The updated address</returns>
    /// <response code="200">Returns the updated address</response>
    /// <response code="404">If the address is not found</response>
    [HttpPut("{id}")]
    public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDto addressDto)
    {
        var address = _context.Addresses.FirstOrDefault(a => a.Id == id);
        if (address == null) return NotFound();
        _mapper.Map(addressDto, address);
        _context.SaveChanges();
        return NoContent();
    }
    /// <summary>
    /// Delete an address
    /// </summary>
    /// <param name="id">The ID of the address to delete</param>
    /// <returns>No content</returns>
    /// <response code="204">No content</response>
    /// <response code="404">If the address is not found</response>
    [HttpDelete("{id}")]
    public IActionResult DeleteAddress(int id)
    {
        var address = _context.Addresses.FirstOrDefault(a => a.Id == id);
        if (address == null) return NotFound();
        _context.Addresses.Remove(address);
        _context.SaveChanges();
        return NoContent();
    }
}