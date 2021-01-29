using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Files
{
    public class Add
    {
        public class Command : IRequest<Domain.File>
        {
            public IFormFile File { get; set; }
        }

        public class Handler : IRequestHandler<Command, File>
        {
            private readonly DataContext _context;
            private readonly IUserAccessor _userAccessor;
            private readonly IPhotoAccessor _photoAccessor;
            public Handler(DataContext context, IUserAccessor userAccessor, IPhotoAccessor photoAccessor)
            {
                _photoAccessor = photoAccessor;
                _userAccessor = userAccessor;
                _context = context;
            }

            public async Task<File> Handle(Command request, CancellationToken cancellationToken)
            {
                var fileUploadResult = _photoAccessor.AddPhoto(request.File);

                var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == _userAccessor.GetCurrentUsername());

                var file = new File
                {
                    Url = fileUploadResult.Url,
                    Id =  fileUploadResult.PublicId
                };

                user.Files.Add(file);           

                var success = await _context.SaveChangesAsync() > 0;

                if (success) return file;

                throw new Exception("Problem saving file");
            }
        }
    }
}