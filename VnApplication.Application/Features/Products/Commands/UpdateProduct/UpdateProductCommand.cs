using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VnApplication.Application.Exceptions;
using VnApplication.Application.Interfaces.Repositories;
using VnApplication.Application.Wrappers;

namespace VnApplication.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<Response<Guid>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Response<Guid>>
        {
            private readonly IProductRepositoryAsync _productRepository;
            public UpdateProductCommandHandler(IProductRepositoryAsync productRepository)
            {
                _productRepository = productRepository;
            }
            public async Task<Response<Guid>> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(command.Id);

                if (product == null)
                {
                    throw new ApiException($"Product Not Found.");
                }
                else
                {
                    product.Name = command.Name;
                    product.Rate = command.Rate;
                    product.Description = command.Description;
                    await _productRepository.UpdateAsync(product);
                    return new Response<Guid>(product.Id);
                }
            }
        }
    }
}
