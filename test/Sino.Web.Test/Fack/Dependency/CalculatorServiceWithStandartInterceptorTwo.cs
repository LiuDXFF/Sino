﻿using Sino.Web.Dependency.Aop;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Web.Test
{
	[SinoInterceptor("fooInterceptor")]
	[SinoInterceptor(typeof(SinoInterceptor))]
	public class CalculatorServiceWithStandartInterceptorTwo : CalculatorService
	{

	}
}
