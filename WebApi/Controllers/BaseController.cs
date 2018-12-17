using System;
using Jwt;
using Microsoft.AspNetCore.Mvc;
using DotnetCore.Business.Interfaces;
using DotnetCore.Web.Models;

namespace DotnetCore.Web.Controllers
{

    public class BaseController : Controller
    {

        private WebToken _sessionUserData { get; set; }

        protected virtual WebToken SessionUserData
        {
            get
            {
                return this._sessionUserData;
            }
            set
            {
                this._sessionUserData = value;
            }
        }



        private static BusinessSupervisor _businessSupervisor;
        public static BusinessSupervisor businessSupervisor
        {
            get
            {
                if (_businessSupervisor == null)
                    return new BusinessSupervisor();
                return _businessSupervisor;
            }
            set
            {
                _businessSupervisor = value;
            }
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}