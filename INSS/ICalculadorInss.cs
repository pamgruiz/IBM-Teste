﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
	public interface ICalculadorInss
	{
		/// <summary>
		/// Deve retornar o deconto do INSS aplicado ao salário, na determinada data.

		DateTime data { get; set; }
		decimal salario { get; set; }


	}
}
