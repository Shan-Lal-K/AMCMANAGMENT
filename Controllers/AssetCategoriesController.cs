using AMCMANAGMENT.DataContext;
using AMCMANAGMENT.Model;
using AMCMANAGMENT.Service.AssetCategories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AMCMANAGMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetCategoriesController : ControllerBase
    {
        private readonly AMCContext _context;
        private readonly IAssetCategoryService _assetCategoryService;

        public AssetCategoriesController(AMCContext context, IAssetCategoryService assetCategoryService)
        {
            _context = context;
            _assetCategoryService = assetCategoryService;
        }

        // GET: api/AssetCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetCategory>>> GetAssetCategory()
        {
            if (_context.AssetCategory == null)
            {
                return NotFound();
            }
            return await _context.AssetCategory.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CREATEASSET(AssetCategory assetCategory)
        {
            var r = _assetCategoryService.Save(assetCategory);
            return Ok(r);
        }

        [HttpGet("GETSP")]
        public async Task<IActionResult> GetAssetCategory(int Id)
        {
            var r1 = await _assetCategoryService.Get(Id);
            if (r1 == null)
            {
                return NotFound();
            }
            return Ok(r1);
        }
        [HttpPut]
        public async Task<IActionResult> DELETETYPE(int Id)
        {
            var r2 = await _assetCategoryService.Delete(Id);
            return Ok(r2);
        }

        //// GET: api/AssetCategories/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<AssetCategory>> GetAssetCategory(int id)
        //{
        //    if (_context.AssetCategory == null)
        //    {
        //        return NotFound();
        //    }
        //    var assetCategory = await _context.AssetCategory.FindAsync(id);

        //    if (assetCategory == null)
        //    {
        //        return NotFound();
        //    }

        //    return assetCategory;
        //}

        //// PUT: api/AssetCategories/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAssetCategory(int id, AssetCategory assetCategory)
        //{
        //    if (id != assetCategory.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(assetCategory).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AssetCategoryExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/AssetCategories
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<AssetCategory>> PostAssetCategory(AssetCategory assetCategory)
        //{
        //    if (_context.AssetCategory == null)
        //    {
        //        return Problem("Entity set 'AMCMANAGMENTContext.AssetCategory'  is null.");
        //    }
        //    _context.AssetCategory.Add(assetCategory);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAssetCategory", new { id = assetCategory.Id }, assetCategory);
        //}

        //// DELETE: api/AssetCategories/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAssetCategory(int id)
        //{
        //    if (_context.AssetCategory == null)
        //    {
        //        return NotFound();
        //    }
        //    var assetCategory = await _context.AssetCategory.FindAsync(id);
        //    if (assetCategory == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.AssetCategory.Remove(assetCategory);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AssetCategoryExists(int id)
        //{
        //    return (_context.AssetCategory?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
