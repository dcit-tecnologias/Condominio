﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain.Model;
using Domain.Util;

namespace Web.Pages
{
    public partial class VisualizarAta : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null && Utilities.IsNumber(Request.QueryString["id"]))
            {
                int id = int.Parse(Request.QueryString["id"]);
                Comunicado comunicado = Comunicado.FindByPrimaryKey(id);

                if (comunicado != null)
                {
                    lblTituloAta.Text = comunicado.Titulo;
                    lblIndetificacao.Text = string.Format("Criado por {0}  {1}", comunicado.Usuario.ToString(), comunicado.DataCriacao.ToString("dd/MM/yyyy HH:mm"));
                    conteudo.InnerHtml = comunicado.Texto;
                }
            }
        }
    }
}