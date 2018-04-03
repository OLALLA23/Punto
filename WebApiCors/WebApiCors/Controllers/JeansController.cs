using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCors.Models;

namespace WebApiCors.Controllers
{
    public class JeansController : ApiController
    {
        List<Jeans> listajeans;
        //AÑADIMOS ALGUNOS COCHES EN EL CONTRUCTOR
        public JeansController()
        {
            listajeans = new List<Jeans>();
            Jeans vaquero = new Jeans
            {
                IdJeans = 01
                ,
                Marca = "Pepe Jeans"
                ,
                Modelo = "Pantalón 40 Aniverario Pepe Jeans London"
                ,
                Imagen = "http://www.jses.es/image/cache/data/caballero/2013%20o.i/Pepe_Jeans_London%20PM2009694%20ANNIVERSARY%20MENS%203-900x900.jpg"
            };
            listajeans.Add(vaquero); 
             vaquero = new Jeans
            {
                IdJeans = 02
                ,
                Marca = "Levis"
                ,
                Modelo = "501"
                ,
                Imagen = "https://i.blogs.es/855451/levis_501-/450_1000.jpg"
             };
            listajeans.Add(vaquero);
            vaquero = new Jeans
            {
                IdJeans = 03
                ,
                Marca = "Jack and Jones"
                ,
                Modelo = "JJglenn"
                ,
                Imagen = "https://es.privalia.com/front/get/photo/263310_-_images_-_products_-_12114613_-_templ1.jpg"
            };
            listajeans.Add(vaquero);
            vaquero = new Jeans
            {
                IdJeans = 04
                ,
                Marca = "Salsa Jeans"
                ,
                Modelo = "Push up"
                ,
                Imagen = "https://static2.salsajeans.com/images/3d/27462/xbig01.jpg?random=Mon%20Mar%2012%202018%2019:18:24%20GMT+0100%20(Romance%20Standard%20Time)"
            };
            listajeans.Add(vaquero);
            vaquero = new Jeans
            {
                IdJeans = 05
                ,
                Marca = "G-Star"
                ,
                Modelo = "Radar Loose Jeans"
                ,
                Imagen = "https://img1.g-star.com/image/private/c_fill,f_auto,h_620,q_80/v1507101559/51007-4639-89-Z01W.jpg"
            };
            listajeans.Add(vaquero);
        }
        //METODO PARA DEVOLVER TODOS LOS JEANS 
        public List<Jeans> GetJeans()
        {
            return this.listajeans;
        }

        //METODO PARA BUSCAR UN JEAN
        public Jeans GetJean(int idjeans)
        {
            Jeans vaquero = 
                listajeans.Where(z => z.IdJeans == idjeans).FirstOrDefault();
            return vaquero;
        }
    }
}
