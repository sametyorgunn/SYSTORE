using BusinessLayer.Abstract;
using BusinessLayer.Manager;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public static class ServiceRoutes
	{
		public static void AddServiceRegistiration(this IServiceCollection services)
		{
			services.AddScoped<IFavoriService, FavoriManager>();
			services.AddScoped<IFavoriDal, EfFavoriRepository>();

			services.AddScoped<IKategoriService, KategoriManager>();
			services.AddScoped<IKategoriDal, EfKategoriRepository>();

			services.AddScoped<IMenuService, MenuManager>();
			services.AddScoped<IMenuDal, EfMenuRepository>();

			services.AddScoped<IRolService, RolManager>();
			services.AddScoped<IRolDal, EfRolRepository>();

			services.AddScoped<ISepetService, SepetManager>();
			services.AddScoped<ISepetDal, EfSepetRepository>();

			services.AddScoped<ISepetUyeMapService, SepetUyeMapManager>();
			services.AddScoped<ISepetUyeMapDal, EfSepetUyeMapRepository>();

			services.AddScoped<ISiparisService, SiparisManager>();
			services.AddScoped<ISiparisDal, EfSiparisRepository>();

			services.AddScoped<IUrunService, UrunManager>();
			services.AddScoped<IUrunDal, EfUrunRepository>();

			services.AddScoped<IUyeService, UyeManager>();
			services.AddScoped<IUyeDal, EfUyeRepository>();

			services.AddScoped<IVaryantService, VaryantManager>();
			services.AddScoped<IVaryantDal, EfVaryantRepository>();


            services.AddScoped<IMarkaService, MarkaManager>();
            services.AddScoped<IMarkaDal, EfMarkaRepository>();

            services.AddScoped<IUrunCokluResimService, UrunCokluResimManager>();
            services.AddScoped<IUrunCokluResimDal, EfUrunCokluResim>();

            services.AddScoped<IVaryantDegerService, VaryantDegerManager>();
            services.AddScoped<IVaryantDegerDal, EfVaryantDegerRepository>();


            services.AddScoped<IVaryantDegerMapService, VaryantDegerMapManager>();
            services.AddScoped<IVaryantDegerMapDal, EfVaryantDegerMapRepository>();

            services.AddScoped<IUrunVaryantDegerService, UrunVaryantDegerManager>();
            services.AddScoped<IUrunVaryantDegerDal, EfUrunVaryantDegerRepository>();








        }
    }
}
