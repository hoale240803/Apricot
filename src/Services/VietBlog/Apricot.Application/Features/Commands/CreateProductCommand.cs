using Apricot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apricot.Application.Features.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public  string BarCode { get; set; }
        public decimal Rate { get; set; }


        public class CreateProductCommandHandler
        {
            private readonly IApplicationContext _applicationContext;

            public CreateProductCommandHandler(IApplicationContext applicationContext)
            {
                _applicationContext = applicationContext;
            }
            public async Task Handle(CreateProductCommand command)
            {
                var product = new Product
                {
                    ProductName = command.Name,


                };
            }
        }
    }
}
