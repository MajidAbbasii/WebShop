﻿using Application.Services.Categories.Commands.AddNewCategory;
using Application.Services.Categories.Queries.GetAllCategory;
using Application.Services.Categories.Queries.GetCategories;
using Application.Services.Products.Commands;
using Application.Services.Products.Commands.EditProduct;
using Application.Services.Products.Queries.GetAllProductForSite;
using Application.Services.Products.Queries.GetProductAdmin;
using Application.Services.Products.Queries.GetProductDetailAdmin;
using Application.Services.Products.Queries.GetProductForSite;
using Application.Services.Products.Queries.GetProductSiteById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.FacadPattern
{
    public interface IFacadPattern
    {
        AddNewCategory AddNewCategory { get; }
        AddNewProduct AddNewProduct { get; }
        IGetCategories GetCategories { get; }
        IGetAllCategory GetAllCategory { get; }
        IGetProductDetailAdmin GetProductDetailAdmin { get; }
        IGetProductAdmin GetProductAdmin { get; }
        IGetProductSiteById GetProductSiteById { get; }
        IGetAllProductForSite GetAllProductForSite { get; }
        IGetProductForSite GetProductForSite { get; }
        RemoveProduct RemoveProduct { get; }
        IEditProduct EditProduct { get; }


    }
}
