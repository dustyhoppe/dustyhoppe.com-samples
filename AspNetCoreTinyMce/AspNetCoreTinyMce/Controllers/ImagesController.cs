﻿using AspNetCoreTinyMce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace AspNetCoreTinyMce.Controllers
{
    [Route("api/images")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(FileUploadModel model)
        {
            if (new FileExtensionContentTypeProvider().TryGetContentType(model.FileName, out var contentType))
            {
                // This is the point where we should persist the image bytes to a persistent store.
                // This could be anything from storing the image in a database (MySql, SqlServer), disk,
                // or object store (Amazon S3, Azure Blog Storage, Digital Ocean Spaces)

                // Once the image is stored, we'll want to return the url of where the image is stored
                // in the response. For the time being, this image url will be hardcoded so that the
                // TinyMCE editor functions.
                string imageUrl = "https://dustyhoppe-blog-images-prod.sfo2.cdn.digitaloceanspaces.com/cat-image-qf76g35k.jpg";
                return Ok(new { imageUrl });
            }

            return UnprocessableEntity(new { Message = $"Cannot determine content type for file '{model.FileName}'." });
        }
    }
}