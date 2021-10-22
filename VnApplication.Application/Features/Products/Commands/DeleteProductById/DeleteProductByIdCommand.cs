using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VnApplication.Application.Exceptions;
using VnApplication.Application.Interfaces.Repositories;
using VnApplication.Application.Wrappers;

namespace VnApplication.Application.Features.Products.Commands.DeleteProductById
{
    public class DeleteProductByIdCommand : IRequest<Response<Guid>>
    {
        public Guid Id { get; set; }
        public class DeleteProductByIdCommandHandler : IRequestHandler<DeleteProductByIdCommand, Response<Guid>>
        {
            private readonly IProductRepositoryAsync _productRepository;
            public DeleteProductByIdCommandHandler(IProductRepositoryAsync productRepository)
            {
                _productRepository = productRepository;
            }
            public async Task<Response<Guid>> Handle(DeleteProductByIdCommand command, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(command.Id);
                if (product == null) throw new ApiException($"Product Not Found.");
                await _productRepository.DeleteAsync(product);
                return new Response<Guid>(product.Id);
            }
        }
    }
}
