﻿using Business.Repositories;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public static class ServiceRegistration
	{
	  public static void AddDataAccessLayerServices (this IServiceCollection services)
		{
			services.AddDbContext<DataContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString));
			services.AddScoped<ISliderRepository, SliderRepository>();
			services.AddScoped<IServiceRepository, ServiceRepository>();
			services.AddScoped<ISettingService, SettingService>();
			services.AddScoped<IWorkProcessRepository,WorkProcessRepository>();
			services.AddScoped<IFeatureRepository, FeatureRepository>();
			services.AddScoped<ICompanyImageRepository, CompanyImageRepository>();
		}
	}
}
