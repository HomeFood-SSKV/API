using System;
using Jwt;
using Microsoft.AspNetCore.Mvc;
using DotnetCore.Business.Interfaces;
using DotnetCore.Web.Models;

namespace WebApi.Common.Helper
{

    public class BaseModel 
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
                    return null;
                return _businessSupervisor;
            }
            set
            {
                _businessSupervisor = value;
            }
        }

    }
}