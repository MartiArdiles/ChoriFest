using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;


namespace mvc_project.Filter
{
    public class ExceptionManegerFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IModelMetadataProvider _modelMetadataProvider;

        public ExceptionManegerFilter(IWebHostEnvironment hostEnvironment, IModelMetadataProvider modelMetadataProvider)
        {
            this._hostEnvironment = hostEnvironment;
            this._modelMetadataProvider = modelMetadataProvider;
                
        }
        public void OnException(ExceptionContext context)
        {
            //context.HttpContext.Response.StatusCode = 400;
            var number = context.Exception.HResult.ToString();
            context.Result = new JsonResult("Fallo algo en la Aplicacion " +
                            _hostEnvironment.ApplicationName +
                            " del tipo: " + context.Exception.GetType() +
                            " con el numero de status: " +
                            context.HttpContext.Response.StatusCode +
                            ". El mensaje: " +
                            context.Exception.Message);

        }
    }
}
